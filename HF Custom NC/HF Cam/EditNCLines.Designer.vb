<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditNCLines
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditNCLines))
        Me.rtbNcLines = New System.Windows.Forms.RichTextBox()
        Me.lblNCLines = New System.Windows.Forms.Label()
        Me.btnNCLineOk = New System.Windows.Forms.Button()
        Me.btnNCLineCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rtbNcLines
        '
        Me.rtbNcLines.Location = New System.Drawing.Point(26, 38)
        Me.rtbNcLines.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rtbNcLines.Name = "rtbNcLines"
        Me.rtbNcLines.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.rtbNcLines.Size = New System.Drawing.Size(340, 159)
        Me.rtbNcLines.TabIndex = 0
        Me.rtbNcLines.Text = ""
        '
        'lblNCLines
        '
        Me.lblNCLines.AutoSize = True
        Me.lblNCLines.Location = New System.Drawing.Point(13, 9)
        Me.lblNCLines.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNCLines.Name = "lblNCLines"
        Me.lblNCLines.Size = New System.Drawing.Size(77, 20)
        Me.lblNCLines.TabIndex = 1
        Me.lblNCLines.Text = "NC Lines:"
        '
        'btnNCLineOk
        '
        Me.btnNCLineOk.Location = New System.Drawing.Point(383, 34)
        Me.btnNCLineOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnNCLineOk.Name = "btnNCLineOk"
        Me.btnNCLineOk.Size = New System.Drawing.Size(112, 35)
        Me.btnNCLineOk.TabIndex = 2
        Me.btnNCLineOk.Text = "Ok"
        Me.btnNCLineOk.UseVisualStyleBackColor = True
        '
        'btnNCLineCancel
        '
        Me.btnNCLineCancel.Location = New System.Drawing.Point(383, 79)
        Me.btnNCLineCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnNCLineCancel.Name = "btnNCLineCancel"
        Me.btnNCLineCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnNCLineCancel.TabIndex = 3
        Me.btnNCLineCancel.Text = "Cancel"
        Me.btnNCLineCancel.UseVisualStyleBackColor = True
        '
        'frmEditNCLines
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(517, 218)
        Me.Controls.Add(Me.btnNCLineCancel)
        Me.Controls.Add(Me.btnNCLineOk)
        Me.Controls.Add(Me.lblNCLines)
        Me.Controls.Add(Me.rtbNcLines)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmEditNCLines"
        Me.Text = "Edit NC Lines"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rtbNcLines As System.Windows.Forms.RichTextBox
    Friend WithEvents lblNCLines As System.Windows.Forms.Label
    Friend WithEvents btnNCLineOk As System.Windows.Forms.Button
    Friend WithEvents btnNCLineCancel As System.Windows.Forms.Button
End Class
