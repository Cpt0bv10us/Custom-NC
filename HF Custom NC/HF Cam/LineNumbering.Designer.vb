<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLineNumbering
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLineNumbering))
        Me.lblStartNumb = New System.Windows.Forms.Label()
        Me.lblNumbIncrement = New System.Windows.Forms.Label()
        Me.lblStartTxt = New System.Windows.Forms.Label()
        Me.txtLNStartNumb = New System.Windows.Forms.TextBox()
        Me.txtLNStartTxt = New System.Windows.Forms.TextBox()
        Me.txtLNIncrement = New System.Windows.Forms.TextBox()
        Me.btnLNOk = New System.Windows.Forms.Button()
        Me.btnLNCancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStartNumb
        '
        Me.lblStartNumb.AutoSize = True
        Me.lblStartNumb.Location = New System.Drawing.Point(16, 40)
        Me.lblStartNumb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStartNumb.Name = "lblStartNumb"
        Me.lblStartNumb.Size = New System.Drawing.Size(117, 20)
        Me.lblStartNumb.TabIndex = 0
        Me.lblStartNumb.Text = "Start Number ="
        '
        'lblNumbIncrement
        '
        Me.lblNumbIncrement.AutoSize = True
        Me.lblNumbIncrement.Location = New System.Drawing.Point(35, 72)
        Me.lblNumbIncrement.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumbIncrement.Name = "lblNumbIncrement"
        Me.lblNumbIncrement.Size = New System.Drawing.Size(98, 20)
        Me.lblNumbIncrement.TabIndex = 1
        Me.lblNumbIncrement.Text = "Increment = "
        '
        'lblStartTxt
        '
        Me.lblStartTxt.AutoSize = True
        Me.lblStartTxt.Location = New System.Drawing.Point(42, 104)
        Me.lblStartTxt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStartTxt.Name = "lblStartTxt"
        Me.lblStartTxt.Size = New System.Drawing.Size(91, 20)
        Me.lblStartTxt.TabIndex = 2
        Me.lblStartTxt.Text = "Start Text ="
        '
        'txtLNStartNumb
        '
        Me.txtLNStartNumb.Location = New System.Drawing.Point(140, 37)
        Me.txtLNStartNumb.MaxLength = 3
        Me.txtLNStartNumb.Name = "txtLNStartNumb"
        Me.txtLNStartNumb.Size = New System.Drawing.Size(49, 26)
        Me.txtLNStartNumb.TabIndex = 3
        Me.txtLNStartNumb.Text = "10"
        Me.txtLNStartNumb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLNStartTxt
        '
        Me.txtLNStartTxt.Location = New System.Drawing.Point(140, 101)
        Me.txtLNStartTxt.MaxLength = 3
        Me.txtLNStartTxt.Name = "txtLNStartTxt"
        Me.txtLNStartTxt.Size = New System.Drawing.Size(49, 26)
        Me.txtLNStartTxt.TabIndex = 4
        Me.txtLNStartTxt.Text = "N"
        Me.txtLNStartTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLNIncrement
        '
        Me.txtLNIncrement.Location = New System.Drawing.Point(140, 69)
        Me.txtLNIncrement.MaxLength = 3
        Me.txtLNIncrement.Name = "txtLNIncrement"
        Me.txtLNIncrement.Size = New System.Drawing.Size(49, 26)
        Me.txtLNIncrement.TabIndex = 5
        Me.txtLNIncrement.Text = "10"
        Me.txtLNIncrement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnLNOk
        '
        Me.btnLNOk.Location = New System.Drawing.Point(226, 40)
        Me.btnLNOk.Name = "btnLNOk"
        Me.btnLNOk.Size = New System.Drawing.Size(139, 36)
        Me.btnLNOk.TabIndex = 6
        Me.btnLNOk.Text = "Ok"
        Me.btnLNOk.UseVisualStyleBackColor = True
        '
        'btnLNCancel
        '
        Me.btnLNCancel.Location = New System.Drawing.Point(226, 82)
        Me.btnLNCancel.Name = "btnLNCancel"
        Me.btnLNCancel.Size = New System.Drawing.Size(139, 36)
        Me.btnLNCancel.TabIndex = 7
        Me.btnLNCancel.Text = "Cancel"
        Me.btnLNCancel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblStartNumb)
        Me.GroupBox1.Controls.Add(Me.btnLNCancel)
        Me.GroupBox1.Controls.Add(Me.lblNumbIncrement)
        Me.GroupBox1.Controls.Add(Me.btnLNOk)
        Me.GroupBox1.Controls.Add(Me.lblStartTxt)
        Me.GroupBox1.Controls.Add(Me.txtLNIncrement)
        Me.GroupBox1.Controls.Add(Me.txtLNStartNumb)
        Me.GroupBox1.Controls.Add(Me.txtLNStartTxt)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(386, 164)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'frmLineNumbering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(421, 196)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmLineNumbering"
        Me.Text = "Line Numbering"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblStartNumb As System.Windows.Forms.Label
    Friend WithEvents lblNumbIncrement As System.Windows.Forms.Label
    Friend WithEvents lblStartTxt As System.Windows.Forms.Label
    Friend WithEvents txtLNStartNumb As System.Windows.Forms.TextBox
    Friend WithEvents txtLNStartTxt As System.Windows.Forms.TextBox
    Friend WithEvents txtLNIncrement As System.Windows.Forms.TextBox
    Friend WithEvents btnLNOk As System.Windows.Forms.Button
    Friend WithEvents btnLNCancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
