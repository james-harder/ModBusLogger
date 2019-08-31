
Public Class SimpleTest

    Private _device As EasyModbus.ModbusClient = New EasyModbus.ModbusClient()
    Private _readingTime As Integer = 0
    Private _readingInterval As Integer

    Private Sub ReadTimer_Tick(source As Object, e As EventArgs) Handles tmrReadTimer.Tick

        _readingTime += 1
        lblSeconds.Text = _readingTime.ToString() + "s"

        If _readingTime Mod _readingInterval = 0 Then

            WriteRecord(ReadRegisters())

        End If

    End Sub

    Private Sub Connect()

        Dim ipAddress As String = txtIpAddress.Text
        Dim port As Integer
        Integer.TryParse(txtPort.Text, port)
        Dim deviceName As String = txtDeviceName.Text
        Integer.TryParse(txtInterval.Text, _readingInterval)
        Dim comError = 0

        _device.IPAddress = ipAddress
        _device.Port = port

        Try

            _device.Connect()

        Catch ex As EasyModbus.Exceptions.ConnectionException

            lblStatus.Text = "Unable to connect to " + ipAddress + ":" + port.ToString()
            comError = 1

        Catch ex As System.Net.Sockets.SocketException

            lblStatus.Text = "An error occured with the network..."
            comError = 2

        End Try

        If comError = 0 Then

            lblDeviceInfo.Text = ipAddress + " : " + port.ToString()
            lblDeviceName.Text = deviceName

            lblStatus.Text = "Connected."

        End If

    End Sub

    Private Sub Disconnect()

        'if timer is running, stop it
        ' for future me: Should this throw an exception instead of handling someone elses business?
        If tmrReadTimer.Enabled = True Then

            tmrReadTimer.Stop()

        End If

        _device.Disconnect()

        lblStatus.Text = "Disconnected."
        lblDeviceName.Text = "None Connected..."
        lblDeviceInfo.Text = "N/A"

    End Sub

    Private Sub BtnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click

        Dim theButton As Button = sender

        Dim device As EasyModbus.ModbusClient = New EasyModbus.ModbusClient()

        If theButton.Text = "Connect" Then

            Connect()
            theButton.Text = "Disconnect"

        Else

            Disconnect()
            theButton.Text = "Connect"

        End If

    End Sub

    Private Function ReadRegisters() As Integer()

        Dim registers = {0, 0, 0}

        Try

            registers = _device.ReadHoldingRegisters(0, 3)

        Catch ex As Exception

            lblReadStatus.Text = "Unable to read registers"

        End Try

        Return registers

    End Function

    Private Sub WriteRecord(ByRef registers As Integer())

        txtRegister1.Text = registers(0).ToString()
        txtRegister2.Text = registers(1).ToString()
        txtRegister3.Text = registers(2).ToString()

    End Sub

    Private Sub BtnReadRegisters_Click(sender As Object, e As EventArgs) Handles btnReadRegisters.Click

        Dim btnRead As Button = sender

        If btnRead.Text = "Read Registers" Then

            btnRead.Text = "Stop Reading"

            tmrReadTimer.Start()

        Else

            btnRead.Text = "Read Registers"

            tmrReadTimer.Stop()

        End If

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' Same as above, should this throw an exception?
        If _device.Connected = True Then

            Disconnect()

        End If

        Me.Close()

    End Sub

End Class