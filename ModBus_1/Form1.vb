Imports EasyModbus

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Plc_2DataSet.ACC_Log' table. You can move, or remove it, as needed.
        'Me.ACC_LogTableAdapter.Fill(Me.Plc_2DataSet.ACC_Log)

    End Sub

    Private Sub Button1_Click() Handles Button1.Click

        Dim reading As Integer()

        'lblDeviceName.Text = txtIpAddress.Text

        reading = ReadPlc()

        DisplayReading(reading)

        WriteRecord(reading)

    End Sub

    Private Sub ReadTimer_Tick(sender As Object, e As EventArgs) Handles ReadTimer.Tick

        lblTimer.Text = Now
        ReadTimer.Interval = 60000
        ReadTimer.Enabled = True

        Call Sub() Button1_Click()

    End Sub

    Private Sub ACC_LogBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ACC_LogBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Plc_2DataSet)

    End Sub

    Private Sub ACC_LogBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles ACC_LogBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ACC_LogBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Plc_2DataSet)

    End Sub

    Private Function ReadPlc() As Integer()

        Dim ipAddress As String = txtIpAddress.Text
        Dim port As Integer
        Integer.TryParse(txtPort.Text, port)

        Dim Registers As Integer() = {0, 0, 0}

        Dim ComError = 0

        Dim ModBusClient As EasyModbus.ModbusClient = New EasyModbus.ModbusClient(ipAddress, port)

        Try
            'ModBusClient.IPAddress = "127.1.1.1"
            txtStatus.Text = "Connecting to: " + txtIpAddress.Text
            'ModBusClient.Connect("127.1.1.1", txtPort.Text)
            ModBusClient.Connect()
            lblDeviceName.Text = ModBusClient.IPAddress.ToString() + " : " + ModBusClient.Port.ToString()

        Catch ex As Exception

            txtStatus.ForeColor = Color.Red
            txtStatus.Text = "Communication Error!"

            ComError = 1

        End Try

        If ComError = 0 Then

            txtStatus.ForeColor = Color.Black
            txtStatus.Text = "Logging..."

            Registers = ModBusClient.ReadHoldingRegisters(0, 3)

            ModBusClient.Disconnect()

        End If

        Return Registers

    End Function

    Private Sub WriteRecord(readings As Integer())

        Try

            ACC_LogTableAdapter.Insert(Now.ToLongDateString, Now.ToLongTimeString, readings(0), readings(1), readings(2))

        Catch ex As Exception

            txtStatus.ForeColor = Color.Red
            txtStatus.Text = "Database Error!"

        End Try

    End Sub

    Private Sub DisplayReading(readings As Integer())

        txtRegister1.Text = readings(0)
        txtRegister2.Text = readings(1)
        txtRegister3.Text = readings(2)

    End Sub

End Class
