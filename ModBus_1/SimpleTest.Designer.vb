<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SimpleTest
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnReadRegisters = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRegister1 = New System.Windows.Forms.TextBox()
        Me.txtRegister2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRegister3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblReadStatus = New System.Windows.Forms.Label()
        Me.lblDeviceInfo = New System.Windows.Forms.Label()
        Me.lblDeviceName = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtDeviceName = New System.Windows.Forms.TextBox()
        Me.txtIpAddress = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tmrReadTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblSeconds = New System.Windows.Forms.Label()
        Me.txtInterval = New System.Windows.Forms.TextBox()
        Me.lblInterval = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnReadRegisters
        '
        Me.btnReadRegisters.Location = New System.Drawing.Point(181, 197)
        Me.btnReadRegisters.Name = "btnReadRegisters"
        Me.btnReadRegisters.Size = New System.Drawing.Size(104, 23)
        Me.btnReadRegisters.TabIndex = 0
        Me.btnReadRegisters.Text = "Read Registers"
        Me.btnReadRegisters.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(124, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Register 1"
        '
        'txtRegister1
        '
        Me.txtRegister1.Location = New System.Drawing.Point(181, 63)
        Me.txtRegister1.Name = "txtRegister1"
        Me.txtRegister1.Size = New System.Drawing.Size(100, 20)
        Me.txtRegister1.TabIndex = 2
        '
        'txtRegister2
        '
        Me.txtRegister2.Location = New System.Drawing.Point(181, 105)
        Me.txtRegister2.Name = "txtRegister2"
        Me.txtRegister2.Size = New System.Drawing.Size(100, 20)
        Me.txtRegister2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(124, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Register 2"
        '
        'txtRegister3
        '
        Me.txtRegister3.Location = New System.Drawing.Point(181, 150)
        Me.txtRegister3.Name = "txtRegister3"
        Me.txtRegister3.Size = New System.Drawing.Size(100, 20)
        Me.txtRegister3.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(124, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Register 3"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblSeconds)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblReadStatus)
        Me.GroupBox1.Controls.Add(Me.lblDeviceInfo)
        Me.GroupBox1.Controls.Add(Me.lblDeviceName)
        Me.GroupBox1.Controls.Add(Me.txtRegister1)
        Me.GroupBox1.Controls.Add(Me.btnReadRegisters)
        Me.GroupBox1.Controls.Add(Me.txtRegister3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtRegister2)
        Me.GroupBox1.Location = New System.Drawing.Point(395, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(351, 323)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data"
        '
        'lblReadStatus
        '
        Me.lblReadStatus.AutoSize = True
        Me.lblReadStatus.Location = New System.Drawing.Point(194, 223)
        Me.lblReadStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblReadStatus.Name = "lblReadStatus"
        Me.lblReadStatus.Size = New System.Drawing.Size(66, 13)
        Me.lblReadStatus.TabIndex = 17
        Me.lblReadStatus.Text = "Read Status"
        '
        'lblDeviceInfo
        '
        Me.lblDeviceInfo.AutoSize = True
        Me.lblDeviceInfo.Location = New System.Drawing.Point(139, 26)
        Me.lblDeviceInfo.Name = "lblDeviceInfo"
        Me.lblDeviceInfo.Size = New System.Drawing.Size(69, 13)
        Me.lblDeviceInfo.TabIndex = 8
        Me.lblDeviceInfo.Text = "lblDeviceInfo"
        '
        'lblDeviceName
        '
        Me.lblDeviceName.AutoSize = True
        Me.lblDeviceName.Location = New System.Drawing.Point(53, 26)
        Me.lblDeviceName.Name = "lblDeviceName"
        Me.lblDeviceName.Size = New System.Drawing.Size(79, 13)
        Me.lblDeviceName.TabIndex = 7
        Me.lblDeviceName.Text = "lblDeviceName"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtInterval)
        Me.GroupBox2.Controls.Add(Me.lblInterval)
        Me.GroupBox2.Controls.Add(Me.lblStatus)
        Me.GroupBox2.Controls.Add(Me.txtDeviceName)
        Me.GroupBox2.Controls.Add(Me.txtIpAddress)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.btnConnect)
        Me.GroupBox2.Controls.Add(Me.txtPort)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(318, 323)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Configure"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(118, 223)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(74, 13)
        Me.lblStatus.TabIndex = 16
        Me.lblStatus.Text = "Device Status"
        '
        'txtDeviceName
        '
        Me.txtDeviceName.Location = New System.Drawing.Point(118, 106)
        Me.txtDeviceName.Name = "txtDeviceName"
        Me.txtDeviceName.Size = New System.Drawing.Size(100, 20)
        Me.txtDeviceName.TabIndex = 15
        Me.txtDeviceName.Text = "Default Device"
        '
        'txtIpAddress
        '
        Me.txtIpAddress.Location = New System.Drawing.Point(118, 19)
        Me.txtIpAddress.Name = "txtIpAddress"
        Me.txtIpAddress.Size = New System.Drawing.Size(100, 20)
        Me.txtIpAddress.TabIndex = 11
        Me.txtIpAddress.Text = "127.0.0.1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(77, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Name"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(114, 197)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(104, 23)
        Me.btnConnect.TabIndex = 9
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(118, 61)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(100, 20)
        Me.txtPort.TabIndex = 13
        Me.txtPort.Text = "502"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(48, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "I.P. Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(86, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Port"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(665, 399)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'tmrReadTimer
        '
        Me.tmrReadTimer.Interval = 1000
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(219, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Read Time:"
        '
        'lblSeconds
        '
        Me.lblSeconds.AutoSize = True
        Me.lblSeconds.Location = New System.Drawing.Point(287, 26)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(18, 13)
        Me.lblSeconds.TabIndex = 19
        Me.lblSeconds.Text = "0s"
        '
        'txtInterval
        '
        Me.txtInterval.Location = New System.Drawing.Point(118, 147)
        Me.txtInterval.Name = "txtInterval"
        Me.txtInterval.Size = New System.Drawing.Size(100, 20)
        Me.txtInterval.TabIndex = 18
        Me.txtInterval.Text = "5"
        '
        'lblInterval
        '
        Me.lblInterval.AutoSize = True
        Me.lblInterval.Location = New System.Drawing.Point(27, 150)
        Me.lblInterval.Name = "lblInterval"
        Me.lblInterval.Size = New System.Drawing.Size(85, 13)
        Me.lblInterval.TabIndex = 17
        Me.lblInterval.Text = "Reading Interval"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(224, 150)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Seconds"
        '
        'SimpleTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "SimpleTest"
        Me.Text = "SimpleTest"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnReadRegisters As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRegister1 As TextBox
    Friend WithEvents txtRegister2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRegister3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblDeviceInfo As Label
    Friend WithEvents lblDeviceName As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtDeviceName As TextBox
    Friend WithEvents txtIpAddress As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnConnect As Button
    Friend WithEvents txtPort As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblReadStatus As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents tmrReadTimer As Timer
    Friend WithEvents lblSeconds As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtInterval As TextBox
    Friend WithEvents lblInterval As Label
End Class
