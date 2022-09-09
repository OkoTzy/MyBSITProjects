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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.JapaneseButton = New System.Windows.Forms.Button
        Me.IndonesianButton = New System.Windows.Forms.Button
        Me.PrintButton = New System.Windows.Forms.Button
        Me.ExitButton = New System.Windows.Forms.Button
        Me.HelloText = New System.Windows.Forms.Label
        Me.HelloText2 = New System.Windows.Forms.Label
        Me.ButtonLabel = New System.Windows.Forms.Label
        Me.MessageLabel = New System.Windows.Forms.Label
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.SuspendLayout()
        '
        'JapaneseButton
        '
        Me.JapaneseButton.AutoSize = True
        Me.JapaneseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JapaneseButton.Location = New System.Drawing.Point(29, 189)
        Me.JapaneseButton.Name = "JapaneseButton"
        Me.JapaneseButton.Size = New System.Drawing.Size(84, 26)
        Me.JapaneseButton.TabIndex = 0
        Me.JapaneseButton.Text = "Japanese "
        Me.JapaneseButton.UseVisualStyleBackColor = True
        '
        'IndonesianButton
        '
        Me.IndonesianButton.AutoSize = True
        Me.IndonesianButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IndonesianButton.Location = New System.Drawing.Point(29, 218)
        Me.IndonesianButton.Name = "IndonesianButton"
        Me.IndonesianButton.Size = New System.Drawing.Size(84, 26)
        Me.IndonesianButton.TabIndex = 1
        Me.IndonesianButton.Text = "Indonesian"
        Me.IndonesianButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintButton.Location = New System.Drawing.Point(447, 298)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintButton.TabIndex = 2
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(29, 298)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'HelloText
        '
        Me.HelloText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HelloText.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelloText.Location = New System.Drawing.Point(25, 72)
        Me.HelloText.Name = "HelloText"
        Me.HelloText.Size = New System.Drawing.Size(165, 23)
        Me.HelloText.TabIndex = 4
        Me.HelloText.Text = """Hello World"" in"
        Me.HelloText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HelloText2
        '
        Me.HelloText2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HelloText2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelloText2.Location = New System.Drawing.Point(267, 72)
        Me.HelloText2.Name = "HelloText2"
        Me.HelloText2.Size = New System.Drawing.Size(41, 23)
        Me.HelloText2.TabIndex = 5
        Me.HelloText2.Text = " : "
        Me.HelloText2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonLabel
        '
        Me.ButtonLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLabel.Location = New System.Drawing.Point(182, 72)
        Me.ButtonLabel.Name = "ButtonLabel"
        Me.ButtonLabel.Size = New System.Drawing.Size(100, 23)
        Me.ButtonLabel.TabIndex = 6
        Me.ButtonLabel.Text = "____________"
        Me.ButtonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MessageLabel
        '
        Me.MessageLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MessageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessageLabel.Location = New System.Drawing.Point(302, 72)
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(220, 23)
        Me.MessageLabel.TabIndex = 7
        Me.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 343)
        Me.Controls.Add(Me.MessageLabel)
        Me.Controls.Add(Me.ButtonLabel)
        Me.Controls.Add(Me.HelloText2)
        Me.Controls.Add(Me.HelloText)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.IndonesianButton)
        Me.Controls.Add(Me.JapaneseButton)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Programming Exercise 1.1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents JapaneseButton As System.Windows.Forms.Button
    Friend WithEvents IndonesianButton As System.Windows.Forms.Button
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents HelloText As System.Windows.Forms.Label
    Friend WithEvents HelloText2 As System.Windows.Forms.Label
    Friend WithEvents ButtonLabel As System.Windows.Forms.Label
    Friend WithEvents MessageLabel As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm

End Class
