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
        Me.PrintButton = New System.Windows.Forms.Button
        Me.ExitButton = New System.Windows.Forms.Button
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.SoupButton = New System.Windows.Forms.Button
        Me.SpecialButton = New System.Windows.Forms.Button
        Me.DailyButton = New System.Windows.Forms.Button
        Me.DinerName = New System.Windows.Forms.Label
        Me.MessageLabel = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'PrintButton
        '
        Me.PrintButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrintButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PrintButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintButton.Location = New System.Drawing.Point(358, 244)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintButton.TabIndex = 0
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(358, 273)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 1
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'SoupButton
        '
        Me.SoupButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SoupButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SoupButton.Location = New System.Drawing.Point(41, 110)
        Me.SoupButton.Name = "SoupButton"
        Me.SoupButton.Size = New System.Drawing.Size(111, 39)
        Me.SoupButton.TabIndex = 2
        Me.SoupButton.Text = "Soup of the day"
        Me.SoupButton.UseVisualStyleBackColor = True
        '
        'SpecialButton
        '
        Me.SpecialButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.SpecialButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SpecialButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpecialButton.Location = New System.Drawing.Point(186, 110)
        Me.SpecialButton.Name = "SpecialButton"
        Me.SpecialButton.Size = New System.Drawing.Size(104, 39)
        Me.SpecialButton.TabIndex = 3
        Me.SpecialButton.Text = "Chef's Special"
        Me.SpecialButton.UseVisualStyleBackColor = True
        '
        'DailyButton
        '
        Me.DailyButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DailyButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DailyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DailyButton.Location = New System.Drawing.Point(332, 110)
        Me.DailyButton.Name = "DailyButton"
        Me.DailyButton.Size = New System.Drawing.Size(101, 39)
        Me.DailyButton.TabIndex = 4
        Me.DailyButton.Text = "Daily Fish"
        Me.DailyButton.UseVisualStyleBackColor = True
        '
        'DinerName
        '
        Me.DinerName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DinerName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DinerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DinerName.ForeColor = System.Drawing.Color.LightCoral
        Me.DinerName.Location = New System.Drawing.Point(39, 9)
        Me.DinerName.Name = "DinerName"
        Me.DinerName.Size = New System.Drawing.Size(393, 77)
        Me.DinerName.TabIndex = 5
        Me.DinerName.Text = "Cabalse's Diner"
        Me.DinerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MessageLabel
        '
        Me.MessageLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MessageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessageLabel.Location = New System.Drawing.Point(38, 164)
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(395, 60)
        Me.MessageLabel.TabIndex = 6
        Me.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 315)
        Me.Controls.Add(Me.MessageLabel)
        Me.Controls.Add(Me.DinerName)
        Me.Controls.Add(Me.DailyButton)
        Me.Controls.Add(Me.SpecialButton)
        Me.Controls.Add(Me.SoupButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exercise 1.5"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents DailyButton As System.Windows.Forms.Button
    Friend WithEvents SpecialButton As System.Windows.Forms.Button
    Friend WithEvents SoupButton As System.Windows.Forms.Button
    Friend WithEvents DinerName As System.Windows.Forms.Label
    Friend WithEvents MessageLabel As System.Windows.Forms.Label

End Class
