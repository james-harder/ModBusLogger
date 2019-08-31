<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblIpAddress = New System.Windows.Forms.Label()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblDeviceName = New System.Windows.Forms.Label()
        Me.txtRegister1 = New System.Windows.Forms.TextBox()
        Me.lblCurrent = New System.Windows.Forms.Label()
        Me.txtRegister2 = New System.Windows.Forms.TextBox()
        Me.lblPeak = New System.Windows.Forms.Label()
        Me.txtRegister3 = New System.Windows.Forms.TextBox()
        Me.lblValley = New System.Windows.Forms.Label()
        Me.ReadTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Plc_2DataSet = New ModBus_1.plc_2DataSet()
        Me.ACC_LogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ACC_LogTableAdapter = New ModBus_1.plc_2DataSetTableAdapters.ACC_LogTableAdapter()
        Me.TableAdapterManager = New ModBus_1.plc_2DataSetTableAdapters.TableAdapterManager()
        Me.ACC_LogBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ACC_LogBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txtIpAddress = New System.Windows.Forms.TextBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.lblTimer = New System.Windows.Forms.Label()
        CType(Me.Plc_2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ACC_LogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ACC_LogBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ACC_LogBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(153, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(236, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'lblIpAddress
        '
        Me.lblIpAddress.AutoSize = True
        Me.lblIpAddress.Location = New System.Drawing.Point(156, 43)
        Me.lblIpAddress.Name = "lblIpAddress"
        Me.lblIpAddress.Size = New System.Drawing.Size(64, 13)
        Me.lblIpAddress.TabIndex = 2
        Me.lblIpAddress.Text = "I.P. Address"
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.Location = New System.Drawing.Point(194, 72)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(26, 13)
        Me.lblPort.TabIndex = 4
        Me.lblPort.Text = "Port"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(236, 347)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Get Reading"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblDeviceName
        '
        Me.lblDeviceName.AutoSize = True
        Me.lblDeviceName.Location = New System.Drawing.Point(196, 155)
        Me.lblDeviceName.Name = "lblDeviceName"
        Me.lblDeviceName.Size = New System.Drawing.Size(89, 13)
        Me.lblDeviceName.TabIndex = 7
        Me.lblDeviceName.Text = "Small Bake Oven"
        '
        'txtRegister1
        '
        Me.txtRegister1.Location = New System.Drawing.Point(236, 197)
        Me.txtRegister1.Name = "txtRegister1"
        Me.txtRegister1.Size = New System.Drawing.Size(100, 20)
        Me.txtRegister1.TabIndex = 9
        '
        'lblCurrent
        '
        Me.lblCurrent.AutoSize = True
        Me.lblCurrent.Location = New System.Drawing.Point(126, 197)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(104, 13)
        Me.lblCurrent.TabIndex = 8
        Me.lblCurrent.Text = "Current Temperature"
        '
        'txtRegister2
        '
        Me.txtRegister2.Location = New System.Drawing.Point(236, 239)
        Me.txtRegister2.Name = "txtRegister2"
        Me.txtRegister2.Size = New System.Drawing.Size(100, 20)
        Me.txtRegister2.TabIndex = 11
        '
        'lblPeak
        '
        Me.lblPeak.AutoSize = True
        Me.lblPeak.Location = New System.Drawing.Point(135, 239)
        Me.lblPeak.Name = "lblPeak"
        Me.lblPeak.Size = New System.Drawing.Size(95, 13)
        Me.lblPeak.TabIndex = 10
        Me.lblPeak.Text = "Peak Temperature"
        '
        'txtRegister3
        '
        Me.txtRegister3.Location = New System.Drawing.Point(236, 285)
        Me.txtRegister3.Name = "txtRegister3"
        Me.txtRegister3.Size = New System.Drawing.Size(100, 20)
        Me.txtRegister3.TabIndex = 13
        '
        'lblValley
        '
        Me.lblValley.AutoSize = True
        Me.lblValley.Location = New System.Drawing.Point(132, 285)
        Me.lblValley.Name = "lblValley"
        Me.lblValley.Size = New System.Drawing.Size(98, 13)
        Me.lblValley.TabIndex = 12
        Me.lblValley.Text = "Valley Temperature"
        '
        'ReadTimer
        '
        '
        'Plc_2DataSet
        '
        Me.Plc_2DataSet.DataSetName = "plc_2DataSet"
        Me.Plc_2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ACC_LogBindingSource
        '
        Me.ACC_LogBindingSource.DataMember = "ACC_Log"
        Me.ACC_LogBindingSource.DataSource = Me.Plc_2DataSet
        '
        'ACC_LogTableAdapter
        '
        Me.ACC_LogTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ACC_LogTableAdapter = Me.ACC_LogTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = ModBus_1.plc_2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ACC_LogBindingNavigator
        '
        Me.ACC_LogBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ACC_LogBindingNavigator.BindingSource = Me.ACC_LogBindingSource
        Me.ACC_LogBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ACC_LogBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ACC_LogBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ACC_LogBindingNavigatorSaveItem})
        Me.ACC_LogBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ACC_LogBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ACC_LogBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ACC_LogBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ACC_LogBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ACC_LogBindingNavigator.Name = "ACC_LogBindingNavigator"
        Me.ACC_LogBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ACC_LogBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.ACC_LogBindingNavigator.TabIndex = 14
        Me.ACC_LogBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ACC_LogBindingNavigatorSaveItem
        '
        Me.ACC_LogBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ACC_LogBindingNavigatorSaveItem.Image = CType(resources.GetObject("ACC_LogBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ACC_LogBindingNavigatorSaveItem.Name = "ACC_LogBindingNavigatorSaveItem"
        Me.ACC_LogBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ACC_LogBindingNavigatorSaveItem.Text = "Save Data"
        '
        'txtIpAddress
        '
        Me.txtIpAddress.Location = New System.Drawing.Point(236, 40)
        Me.txtIpAddress.Name = "txtIpAddress"
        Me.txtIpAddress.Size = New System.Drawing.Size(100, 20)
        Me.txtIpAddress.TabIndex = 15
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(236, 95)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(100, 20)
        Me.txtStatus.TabIndex = 17
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(180, 98)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(40, 13)
        Me.lblStatus.TabIndex = 16
        Me.lblStatus.Text = "Status:"
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(236, 69)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(100, 20)
        Me.txtPort.TabIndex = 18
        Me.txtPort.Text = "502"
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Location = New System.Drawing.Point(558, 203)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(39, 13)
        Me.lblTimer.TabIndex = 19
        Me.lblTimer.Text = "Label2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 640)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.txtIpAddress)
        Me.Controls.Add(Me.ACC_LogBindingNavigator)
        Me.Controls.Add(Me.txtRegister3)
        Me.Controls.Add(Me.lblValley)
        Me.Controls.Add(Me.txtRegister2)
        Me.Controls.Add(Me.lblPeak)
        Me.Controls.Add(Me.txtRegister1)
        Me.Controls.Add(Me.lblCurrent)
        Me.Controls.Add(Me.lblDeviceName)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblPort)
        Me.Controls.Add(Me.lblIpAddress)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Plc_2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ACC_LogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ACC_LogBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ACC_LogBindingNavigator.ResumeLayout(False)
        Me.ACC_LogBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblIpAddress As Label
    Friend WithEvents lblPort As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblDeviceName As Label
    Friend WithEvents txtRegister1 As TextBox
    Friend WithEvents lblCurrent As Label
    Friend WithEvents txtRegister2 As TextBox
    Friend WithEvents lblPeak As Label
    Friend WithEvents txtRegister3 As TextBox
    Friend WithEvents lblValley As Label
    Friend WithEvents ReadTimer As Timer
    Friend WithEvents Plc_2DataSet As plc_2DataSet
    Friend WithEvents ACC_LogBindingSource As BindingSource
    Friend WithEvents ACC_LogTableAdapter As plc_2DataSetTableAdapters.ACC_LogTableAdapter
    Friend WithEvents TableAdapterManager As plc_2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ACC_LogBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ACC_LogBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents txtIpAddress As TextBox
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents txtPort As TextBox
    Friend WithEvents lblTimer As Label
End Class
