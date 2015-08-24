<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnFindType = New System.Windows.Forms.Button()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTemp2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnFindType
        '
        Me.btnFindType.Location = New System.Drawing.Point(73, 160)
        Me.btnFindType.Name = "btnFindType"
        Me.btnFindType.Size = New System.Drawing.Size(100, 23)
        Me.btnFindType.TabIndex = 0
        Me.btnFindType.Text = "Run TryParse"
        Me.btnFindType.UseVisualStyleBackColor = True
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(73, 101)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 20)
        Me.txtInput.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(55, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 36)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Input a couple integers, or something else."
        '
        'txtTemp2
        '
        Me.txtTemp2.Location = New System.Drawing.Point(73, 128)
        Me.txtTemp2.Name = "txtTemp2"
        Me.txtTemp2.Size = New System.Drawing.Size(100, 20)
        Me.txtTemp2.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(245, 214)
        Me.Controls.Add(Me.txtTemp2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.btnFindType)
        Me.Name = "Form1"
        Me.Text = "Some Input Validation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFindType As System.Windows.Forms.Button
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTemp2 As System.Windows.Forms.TextBox

End Class
