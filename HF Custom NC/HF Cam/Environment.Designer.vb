<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnvironment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEnvironment))
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnEnvironmentBrowse = New System.Windows.Forms.Button()
        Me.btnEnvironmentCancel = New System.Windows.Forms.Button()
        Me.btnEnvironmentOk = New System.Windows.Forms.Button()
        Me.lblCad = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEnvironmentAdd = New System.Windows.Forms.Button()
        Me.txtBoxCustomMenu = New System.Windows.Forms.TextBox()
        Me.GroupBoxCustomMenu = New System.Windows.Forms.GroupBox()
        Me.chkSubmenu = New System.Windows.Forms.CheckBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.lstCustomMenu = New System.Windows.Forms.ListBox()
        Me.btnRename = New System.Windows.Forms.Button()
        Me.lstBoxAddRemoveEmailAddresses = New System.Windows.Forms.ListBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnEnvironmentRemove = New System.Windows.Forms.Button()
        Me.txtBoxSetCadFilePath = New System.Windows.Forms.TextBox()
        Me.txtBoxEmailAddress = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBoxCustomMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEnvironmentBrowse
        '
        Me.btnEnvironmentBrowse.Location = New System.Drawing.Point(420, 33)
        Me.btnEnvironmentBrowse.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEnvironmentBrowse.Name = "btnEnvironmentBrowse"
        Me.btnEnvironmentBrowse.Size = New System.Drawing.Size(134, 34)
        Me.btnEnvironmentBrowse.TabIndex = 0
        Me.btnEnvironmentBrowse.Text = "Browse"
        Me.btnEnvironmentBrowse.UseVisualStyleBackColor = True
        '
        'btnEnvironmentCancel
        '
        Me.btnEnvironmentCancel.Location = New System.Drawing.Point(420, 507)
        Me.btnEnvironmentCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEnvironmentCancel.Name = "btnEnvironmentCancel"
        Me.btnEnvironmentCancel.Size = New System.Drawing.Size(134, 34)
        Me.btnEnvironmentCancel.TabIndex = 1
        Me.btnEnvironmentCancel.Text = "Cancel"
        Me.btnEnvironmentCancel.UseVisualStyleBackColor = True
        '
        'btnEnvironmentOk
        '
        Me.btnEnvironmentOk.Location = New System.Drawing.Point(420, 463)
        Me.btnEnvironmentOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEnvironmentOk.Name = "btnEnvironmentOk"
        Me.btnEnvironmentOk.Size = New System.Drawing.Size(134, 34)
        Me.btnEnvironmentOk.TabIndex = 2
        Me.btnEnvironmentOk.Text = "OK"
        Me.btnEnvironmentOk.UseVisualStyleBackColor = True
        '
        'lblCad
        '
        Me.lblCad.AutoSize = True
        Me.lblCad.Location = New System.Drawing.Point(8, 13)
        Me.lblCad.Name = "lblCad"
        Me.lblCad.Size = New System.Drawing.Size(133, 20)
        Me.lblCad.TabIndex = 4
        Me.lblCad.Text = "Set Cad File Path"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Recipients of Sign Off Sheet"
        '
        'btnEnvironmentAdd
        '
        Me.btnEnvironmentAdd.Enabled = False
        Me.btnEnvironmentAdd.Location = New System.Drawing.Point(420, 159)
        Me.btnEnvironmentAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEnvironmentAdd.Name = "btnEnvironmentAdd"
        Me.btnEnvironmentAdd.Size = New System.Drawing.Size(134, 30)
        Me.btnEnvironmentAdd.TabIndex = 8
        Me.btnEnvironmentAdd.Text = "Add"
        Me.btnEnvironmentAdd.UseVisualStyleBackColor = True
        '
        'txtBoxCustomMenu
        '
        Me.txtBoxCustomMenu.Location = New System.Drawing.Point(17, 25)
        Me.txtBoxCustomMenu.MaxLength = 32
        Me.txtBoxCustomMenu.Name = "txtBoxCustomMenu"
        Me.txtBoxCustomMenu.Size = New System.Drawing.Size(231, 26)
        Me.txtBoxCustomMenu.TabIndex = 9
        '
        'GroupBoxCustomMenu
        '
        Me.GroupBoxCustomMenu.Controls.Add(Me.chkSubmenu)
        Me.GroupBoxCustomMenu.Controls.Add(Me.btnDelete)
        Me.GroupBoxCustomMenu.Controls.Add(Me.btnEdit)
        Me.GroupBoxCustomMenu.Controls.Add(Me.btnUp)
        Me.GroupBoxCustomMenu.Controls.Add(Me.btnDown)
        Me.GroupBoxCustomMenu.Controls.Add(Me.lstCustomMenu)
        Me.GroupBoxCustomMenu.Controls.Add(Me.btnRename)
        Me.GroupBoxCustomMenu.Controls.Add(Me.txtBoxCustomMenu)
        Me.GroupBoxCustomMenu.Enabled = False
        Me.GroupBoxCustomMenu.Location = New System.Drawing.Point(12, 247)
        Me.GroupBoxCustomMenu.Name = "GroupBoxCustomMenu"
        Me.GroupBoxCustomMenu.Size = New System.Drawing.Size(401, 293)
        Me.GroupBoxCustomMenu.TabIndex = 10
        Me.GroupBoxCustomMenu.TabStop = False
        Me.GroupBoxCustomMenu.Text = "Custom Menu List"
        '
        'chkSubmenu
        '
        Me.chkSubmenu.AutoSize = True
        Me.chkSubmenu.Location = New System.Drawing.Point(254, 197)
        Me.chkSubmenu.Name = "chkSubmenu"
        Me.chkSubmenu.Size = New System.Drawing.Size(130, 24)
        Me.chkSubmenu.TabIndex = 17
        Me.chkSubmenu.Text = "Has Submenu"
        Me.chkSubmenu.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(254, 165)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(130, 26)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(254, 133)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(130, 26)
        Me.btnEdit.TabIndex = 15
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnUp
        '
        Me.btnUp.Location = New System.Drawing.Point(254, 69)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(130, 26)
        Me.btnUp.TabIndex = 15
        Me.btnUp.Text = "Up"
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.Location = New System.Drawing.Point(254, 101)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(130, 26)
        Me.btnDown.TabIndex = 13
        Me.btnDown.Text = "Down"
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'lstCustomMenu
        '
        Me.lstCustomMenu.FormattingEnabled = True
        Me.lstCustomMenu.ItemHeight = 20
        Me.lstCustomMenu.Location = New System.Drawing.Point(17, 77)
        Me.lstCustomMenu.Name = "lstCustomMenu"
        Me.lstCustomMenu.ScrollAlwaysVisible = True
        Me.lstCustomMenu.Size = New System.Drawing.Size(231, 204)
        Me.lstCustomMenu.TabIndex = 11
        '
        'btnRename
        '
        Me.btnRename.Location = New System.Drawing.Point(254, 25)
        Me.btnRename.Name = "btnRename"
        Me.btnRename.Size = New System.Drawing.Size(130, 26)
        Me.btnRename.TabIndex = 10
        Me.btnRename.Text = "Rename"
        Me.btnRename.UseVisualStyleBackColor = True
        '
        'lstBoxAddRemoveEmailAddresses
        '
        Me.lstBoxAddRemoveEmailAddresses.Enabled = False
        Me.lstBoxAddRemoveEmailAddresses.FormattingEnabled = True
        Me.lstBoxAddRemoveEmailAddresses.ItemHeight = 20
        Me.lstBoxAddRemoveEmailAddresses.Location = New System.Drawing.Point(12, 158)
        Me.lstBoxAddRemoveEmailAddresses.Name = "lstBoxAddRemoveEmailAddresses"
        Me.lstBoxAddRemoveEmailAddresses.ScrollAlwaysVisible = True
        Me.lstBoxAddRemoveEmailAddresses.Size = New System.Drawing.Size(401, 64)
        Me.lstBoxAddRemoveEmailAddresses.TabIndex = 11
        '
        'btnEnvironmentRemove
        '
        Me.btnEnvironmentRemove.Enabled = False
        Me.btnEnvironmentRemove.Location = New System.Drawing.Point(420, 193)
        Me.btnEnvironmentRemove.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEnvironmentRemove.Name = "btnEnvironmentRemove"
        Me.btnEnvironmentRemove.Size = New System.Drawing.Size(134, 30)
        Me.btnEnvironmentRemove.TabIndex = 12
        Me.btnEnvironmentRemove.Text = "Remove"
        Me.btnEnvironmentRemove.UseVisualStyleBackColor = True
        '
        'txtBoxSetCadFilePath
        '
        Me.txtBoxSetCadFilePath.Location = New System.Drawing.Point(12, 36)
        Me.txtBoxSetCadFilePath.Name = "txtBoxSetCadFilePath"
        Me.txtBoxSetCadFilePath.Size = New System.Drawing.Size(401, 26)
        Me.txtBoxSetCadFilePath.TabIndex = 3
        '
        'txtBoxEmailAddress
        '
        Me.txtBoxEmailAddress.Enabled = False
        Me.txtBoxEmailAddress.Location = New System.Drawing.Point(12, 103)
        Me.txtBoxEmailAddress.Name = "txtBoxEmailAddress"
        Me.txtBoxEmailAddress.Size = New System.Drawing.Size(401, 26)
        Me.txtBoxEmailAddress.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Enter Email Address"
        '
        'frmEnvironment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(563, 556)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBoxEmailAddress)
        Me.Controls.Add(Me.btnEnvironmentRemove)
        Me.Controls.Add(Me.lstBoxAddRemoveEmailAddresses)
        Me.Controls.Add(Me.GroupBoxCustomMenu)
        Me.Controls.Add(Me.btnEnvironmentAdd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCad)
        Me.Controls.Add(Me.txtBoxSetCadFilePath)
        Me.Controls.Add(Me.btnEnvironmentOk)
        Me.Controls.Add(Me.btnEnvironmentCancel)
        Me.Controls.Add(Me.btnEnvironmentBrowse)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmEnvironment"
        Me.Text = "Environment"
        Me.GroupBoxCustomMenu.ResumeLayout(False)
        Me.GroupBoxCustomMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnEnvironmentBrowse As System.Windows.Forms.Button
    Friend WithEvents btnEnvironmentCancel As System.Windows.Forms.Button
    Friend WithEvents btnEnvironmentOk As System.Windows.Forms.Button
    Friend WithEvents lblCad As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnEnvironmentAdd As System.Windows.Forms.Button
    Friend WithEvents txtBoxCustomMenu As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxCustomMenu As System.Windows.Forms.GroupBox
    Friend WithEvents chkSubmenu As System.Windows.Forms.CheckBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents lstCustomMenu As System.Windows.Forms.ListBox
    Friend WithEvents btnRename As System.Windows.Forms.Button
    Friend WithEvents lstBoxAddRemoveEmailAddresses As System.Windows.Forms.ListBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnEnvironmentRemove As System.Windows.Forms.Button
    Friend WithEvents txtBoxSetCadFilePath As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
