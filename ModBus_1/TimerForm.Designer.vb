<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimerForm
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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.txtStart = New System.Windows.Forms.TextBox()
        Me.txtInterval = New System.Windows.Forms.TextBox()
        Me.lblInterval = New System.Windows.Forms.Label()
        Me.txtEnd = New System.Windows.Forms.TextBox()
        Me.lblStop = New System.Windows.Forms.Label()
        Me.tmrTestTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(78, 67)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start Timer"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblDisplay
        '
        Me.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplay.Location = New System.Drawing.Point(191, 67)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(100, 23)
        Me.lblDisplay.TabIndex = 1
        Me.lblDisplay.Text = "0"
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Location = New System.Drawing.Point(78, 157)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(59, 13)
        Me.lblStart.TabIndex = 2
        Me.lblStart.Text = "Start Value"
        '
        'txtStart
        '
        Me.txtStart.Location = New System.Drawing.Point(138, 154)
        Me.txtStart.Name = "txtStart"
        Me.txtStart.Size = New System.Drawing.Size(100, 20)
        Me.txtStart.TabIndex = 3
        Me.txtStart.Text = "0"
        '
        'txtInterval
        '
        Me.txtInterval.Location = New System.Drawing.Point(138, 192)
        Me.txtInterval.Name = "txtInterval"
        Me.txtInterval.Size = New System.Drawing.Size(100, 20)
        Me.txtInterval.TabIndex = 5
        Me.txtInterval.Text = "1"
        '
        'lblInterval
        '
        Me.lblInterval.AutoSize = True
        Me.lblInterval.Location = New System.Drawing.Point(78, 195)
        Me.lblInterval.Name = "lblInterval"
        Me.lblInterval.Size = New System.Drawing.Size(42, 13)
        Me.lblInterval.TabIndex = 4
        Me.lblInterval.Text = "Interval"
        '
        'txtEnd
        '
        Me.txtEnd.Location = New System.Drawing.Point(138, 230)
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.Size = New System.Drawing.Size(100, 20)
        Me.txtEnd.TabIndex = 7
        Me.txtEnd.Text = "100"
        '
        'lblStop
        '
        Me.lblStop.AutoSize = True
        Me.lblStop.Location = New System.Drawing.Point(78, 233)
        Me.lblStop.Name = "lblStop"
        Me.lblStop.Size = New System.Drawing.Size(56, 13)
        Me.lblStop.TabIndex = 6
        Me.lblStop.Text = "End Value"
        '
        'TimerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtEnd)
        Me.Controls.Add(Me.lblStop)
        Me.Controls.Add(Me.txtInterval)
        Me.Controls.Add(Me.lblInterval)
        Me.Controls.Add(Me.txtStart)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "TimerForm"
        Me.Text = "TimerForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents lblDisplay As Label
    Friend WithEvents lblStart As Label
    Friend WithEvents txtStart As TextBox
    Friend WithEvents txtInterval As TextBox
    Friend WithEvents lblInterval As Label
    Friend WithEvents txtEnd As TextBox
    Friend WithEvents lblStop As Label
    Friend WithEvents tmrTestTimer As Timer
End Class
