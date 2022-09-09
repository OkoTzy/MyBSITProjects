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
        Me.DevName = New System.Windows.Forms.Label
        Me.FirstButton = New System.Windows.Forms.Button
        Me.ContactText = New System.Windows.Forms.Label
        Me.SecondButton = New System.Windows.Forms.Button
        Me.FourthButton = New System.Windows.Forms.Button
        Me.ThirdButton = New System.Windows.Forms.Button
        Me.DepartmentText = New System.Windows.Forms.Label
        Me.PhoneText = New System.Windows.Forms.Label
        Me.First_DL = New System.Windows.Forms.Label
        Me.Second_DL = New System.Windows.Forms.Label
        Me.Third_DL = New System.Windows.Forms.Label
        Me.Fourth_DL = New System.Windows.Forms.Label
        Me.F_Phone = New System.Windows.Forms.Label
        Me.L_Phone = New System.Windows.Forms.Label
        Me.T_Phone = New System.Windows.Forms.Label
        Me.S_Phone = New System.Windows.Forms.Label
        Me.CompanyLabel = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'PrintButton
        '
        Me.PrintButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PrintButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PrintButton.Location = New System.Drawing.Point(47, 336)
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
        Me.ExitButton.Location = New System.Drawing.Point(434, 340)
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
        'DevName
        '
        Me.DevName.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DevName.Location = New System.Drawing.Point(0, 362)
        Me.DevName.Name = "DevName"
        Me.DevName.Size = New System.Drawing.Size(561, 13)
        Me.DevName.TabIndex = 5
        Me.DevName.Text = "Cabalse Darlito Jr."
        Me.DevName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FirstButton
        '
        Me.FirstButton.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.FirstButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FirstButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.FirstButton.Location = New System.Drawing.Point(47, 131)
        Me.FirstButton.Name = "FirstButton"
        Me.FirstButton.Size = New System.Drawing.Size(97, 26)
        Me.FirstButton.TabIndex = 6
        Me.FirstButton.Text = "John Miller"
        Me.FirstButton.UseVisualStyleBackColor = True
        '
        'ContactText
        '
        Me.ContactText.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ContactText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactText.Location = New System.Drawing.Point(45, 93)
        Me.ContactText.Name = "ContactText"
        Me.ContactText.Size = New System.Drawing.Size(99, 23)
        Me.ContactText.TabIndex = 10
        Me.ContactText.Text = "Contact Person"
        Me.ContactText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SecondButton
        '
        Me.SecondButton.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.SecondButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SecondButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SecondButton.Location = New System.Drawing.Point(47, 173)
        Me.SecondButton.Name = "SecondButton"
        Me.SecondButton.Size = New System.Drawing.Size(97, 26)
        Me.SecondButton.TabIndex = 11
        Me.SecondButton.Text = "Emma Moore"
        Me.SecondButton.UseVisualStyleBackColor = True
        '
        'FourthButton
        '
        Me.FourthButton.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.FourthButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FourthButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.FourthButton.Location = New System.Drawing.Point(47, 258)
        Me.FourthButton.Name = "FourthButton"
        Me.FourthButton.Size = New System.Drawing.Size(97, 26)
        Me.FourthButton.TabIndex = 12
        Me.FourthButton.Text = "Miguel Lopez"
        Me.FourthButton.UseVisualStyleBackColor = True
        '
        'ThirdButton
        '
        Me.ThirdButton.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ThirdButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ThirdButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ThirdButton.Location = New System.Drawing.Point(47, 215)
        Me.ThirdButton.Name = "ThirdButton"
        Me.ThirdButton.Size = New System.Drawing.Size(97, 26)
        Me.ThirdButton.TabIndex = 13
        Me.ThirdButton.Text = "Casey Smith"
        Me.ThirdButton.UseVisualStyleBackColor = True
        '
        'DepartmentText
        '
        Me.DepartmentText.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.DepartmentText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepartmentText.Location = New System.Drawing.Point(220, 93)
        Me.DepartmentText.Name = "DepartmentText"
        Me.DepartmentText.Size = New System.Drawing.Size(97, 23)
        Me.DepartmentText.TabIndex = 14
        Me.DepartmentText.Text = "Department"
        Me.DepartmentText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PhoneText
        '
        Me.PhoneText.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PhoneText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneText.Location = New System.Drawing.Point(402, 93)
        Me.PhoneText.Name = "PhoneText"
        Me.PhoneText.Size = New System.Drawing.Size(97, 23)
        Me.PhoneText.TabIndex = 15
        Me.PhoneText.Text = "Phone"
        Me.PhoneText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'First_DL
        '
        Me.First_DL.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.First_DL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.First_DL.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.First_DL.Location = New System.Drawing.Point(220, 134)
        Me.First_DL.Name = "First_DL"
        Me.First_DL.Size = New System.Drawing.Size(97, 23)
        Me.First_DL.TabIndex = 16
        Me.First_DL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Second_DL
        '
        Me.Second_DL.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Second_DL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Second_DL.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Second_DL.Location = New System.Drawing.Point(220, 176)
        Me.Second_DL.Name = "Second_DL"
        Me.Second_DL.Size = New System.Drawing.Size(97, 23)
        Me.Second_DL.TabIndex = 17
        Me.Second_DL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Third_DL
        '
        Me.Third_DL.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Third_DL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Third_DL.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Third_DL.Location = New System.Drawing.Point(220, 218)
        Me.Third_DL.Name = "Third_DL"
        Me.Third_DL.Size = New System.Drawing.Size(97, 23)
        Me.Third_DL.TabIndex = 18
        Me.Third_DL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Fourth_DL
        '
        Me.Fourth_DL.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Fourth_DL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Fourth_DL.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Fourth_DL.Location = New System.Drawing.Point(220, 261)
        Me.Fourth_DL.Name = "Fourth_DL"
        Me.Fourth_DL.Size = New System.Drawing.Size(97, 23)
        Me.Fourth_DL.TabIndex = 19
        Me.Fourth_DL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'F_Phone
        '
        Me.F_Phone.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.F_Phone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.F_Phone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.F_Phone.Location = New System.Drawing.Point(402, 134)
        Me.F_Phone.Name = "F_Phone"
        Me.F_Phone.Size = New System.Drawing.Size(97, 23)
        Me.F_Phone.TabIndex = 20
        Me.F_Phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L_Phone
        '
        Me.L_Phone.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.L_Phone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.L_Phone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.L_Phone.Location = New System.Drawing.Point(402, 261)
        Me.L_Phone.Name = "L_Phone"
        Me.L_Phone.Size = New System.Drawing.Size(97, 23)
        Me.L_Phone.TabIndex = 21
        Me.L_Phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'T_Phone
        '
        Me.T_Phone.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.T_Phone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.T_Phone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.T_Phone.Location = New System.Drawing.Point(402, 217)
        Me.T_Phone.Name = "T_Phone"
        Me.T_Phone.Size = New System.Drawing.Size(97, 23)
        Me.T_Phone.TabIndex = 22
        Me.T_Phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'S_Phone
        '
        Me.S_Phone.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.S_Phone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.S_Phone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.S_Phone.Location = New System.Drawing.Point(402, 173)
        Me.S_Phone.Name = "S_Phone"
        Me.S_Phone.Size = New System.Drawing.Size(97, 23)
        Me.S_Phone.TabIndex = 23
        Me.S_Phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CompanyLabel
        '
        Me.CompanyLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CompanyLabel.Font = New System.Drawing.Font("Impact", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompanyLabel.ForeColor = System.Drawing.Color.Brown
        Me.CompanyLabel.Location = New System.Drawing.Point(0, -2)
        Me.CompanyLabel.Name = "CompanyLabel"
        Me.CompanyLabel.Size = New System.Drawing.Size(561, 83)
        Me.CompanyLabel.TabIndex = 24
        Me.CompanyLabel.Text = "EMERGENCY HOTLINES"
        Me.CompanyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 375)
        Me.Controls.Add(Me.CompanyLabel)
        Me.Controls.Add(Me.S_Phone)
        Me.Controls.Add(Me.T_Phone)
        Me.Controls.Add(Me.L_Phone)
        Me.Controls.Add(Me.F_Phone)
        Me.Controls.Add(Me.Fourth_DL)
        Me.Controls.Add(Me.Third_DL)
        Me.Controls.Add(Me.Second_DL)
        Me.Controls.Add(Me.First_DL)
        Me.Controls.Add(Me.PhoneText)
        Me.Controls.Add(Me.DepartmentText)
        Me.Controls.Add(Me.ThirdButton)
        Me.Controls.Add(Me.FourthButton)
        Me.Controls.Add(Me.SecondButton)
        Me.Controls.Add(Me.ContactText)
        Me.Controls.Add(Me.FirstButton)
        Me.Controls.Add(Me.DevName)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exercise 1.4"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents DevName As System.Windows.Forms.Label
    Friend WithEvents FirstButton As System.Windows.Forms.Button
    Friend WithEvents ContactText As System.Windows.Forms.Label
    Friend WithEvents ThirdButton As System.Windows.Forms.Button
    Friend WithEvents FourthButton As System.Windows.Forms.Button
    Friend WithEvents SecondButton As System.Windows.Forms.Button
    Friend WithEvents PhoneText As System.Windows.Forms.Label
    Friend WithEvents DepartmentText As System.Windows.Forms.Label
    Friend WithEvents S_Phone As System.Windows.Forms.Label
    Friend WithEvents T_Phone As System.Windows.Forms.Label
    Friend WithEvents L_Phone As System.Windows.Forms.Label
    Friend WithEvents F_Phone As System.Windows.Forms.Label
    Friend WithEvents Fourth_DL As System.Windows.Forms.Label
    Friend WithEvents Third_DL As System.Windows.Forms.Label
    Friend WithEvents Second_DL As System.Windows.Forms.Label
    Friend WithEvents First_DL As System.Windows.Forms.Label
    Friend WithEvents CompanyLabel As System.Windows.Forms.Label

End Class
