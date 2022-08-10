<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.txtName = New System.Windows.Forms.TextBox
    Me.txtGradYear = New System.Windows.Forms.TextBox
    Me.txtSex = New System.Windows.Forms.TextBox
    Me.Label1 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label3 = New System.Windows.Forms.Label
    Me.btnSave = New System.Windows.Forms.Button
    Me.btnClearTextBoxes = New System.Windows.Forms.Button
    Me.btnSort = New System.Windows.Forms.Button
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.btnCleanOneGuest = New System.Windows.Forms.Button
    Me.btnAmend = New System.Windows.Forms.Button
    Me.btnCleanAllGuests = New System.Windows.Forms.Button
    Me.Label4 = New System.Windows.Forms.Label
    Me.txtTableNum = New System.Windows.Forms.TextBox
    Me.GroupBox2 = New System.Windows.Forms.GroupBox
    Me.Label6 = New System.Windows.Forms.Label
    Me.RadioButton2 = New System.Windows.Forms.RadioButton
    Me.RadioButton1 = New System.Windows.Forms.RadioButton
    Me.Label5 = New System.Windows.Forms.Label
    Me.GroupBox1.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    Me.SuspendLayout()
    '
    'txtName
    '
    Me.txtName.Location = New System.Drawing.Point(134, 29)
    Me.txtName.MaxLength = 50
    Me.txtName.Name = "txtName"
    Me.txtName.Size = New System.Drawing.Size(189, 20)
    Me.txtName.TabIndex = 0
    '
    'txtGradYear
    '
    Me.txtGradYear.Location = New System.Drawing.Point(134, 72)
    Me.txtGradYear.MaxLength = 4
    Me.txtGradYear.Name = "txtGradYear"
    Me.txtGradYear.Size = New System.Drawing.Size(103, 20)
    Me.txtGradYear.TabIndex = 1
    '
    'txtSex
    '
    Me.txtSex.Location = New System.Drawing.Point(134, 115)
    Me.txtSex.MaxLength = 6
    Me.txtSex.Name = "txtSex"
    Me.txtSex.Size = New System.Drawing.Size(103, 20)
    Me.txtSex.TabIndex = 2
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(26, 32)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(41, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Name :"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(26, 75)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(102, 13)
    Me.Label2.TabIndex = 0
    Me.Label2.Text = "Year of Graduation :"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(26, 118)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(31, 13)
    Me.Label3.TabIndex = 0
    Me.Label3.Text = "Sex :"
    '
    'btnSave
    '
    Me.btnSave.Location = New System.Drawing.Point(191, 160)
    Me.btnSave.Name = "btnSave"
    Me.btnSave.Size = New System.Drawing.Size(78, 23)
    Me.btnSave.TabIndex = 3
    Me.btnSave.Text = "Save"
    Me.btnSave.UseVisualStyleBackColor = True
    '
    'btnClearTextBoxes
    '
    Me.btnClearTextBoxes.Location = New System.Drawing.Point(29, 204)
    Me.btnClearTextBoxes.Name = "btnClearTextBoxes"
    Me.btnClearTextBoxes.Size = New System.Drawing.Size(129, 23)
    Me.btnClearTextBoxes.TabIndex = 7
    Me.btnClearTextBoxes.TabStop = False
    Me.btnClearTextBoxes.Text = "Empty input textboxes"
    Me.btnClearTextBoxes.UseVisualStyleBackColor = True
    '
    'btnSort
    '
    Me.btnSort.Location = New System.Drawing.Point(132, 196)
    Me.btnSort.Name = "btnSort"
    Me.btnSort.Size = New System.Drawing.Size(126, 31)
    Me.btnSort.TabIndex = 3
    Me.btnSort.TabStop = False
    Me.btnSort.Text = "Sort Saved Records"
    Me.btnSort.UseVisualStyleBackColor = True
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.btnCleanOneGuest)
    Me.GroupBox1.Controls.Add(Me.btnAmend)
    Me.GroupBox1.Controls.Add(Me.btnCleanAllGuests)
    Me.GroupBox1.Controls.Add(Me.Label4)
    Me.GroupBox1.Controls.Add(Me.Label1)
    Me.GroupBox1.Controls.Add(Me.txtName)
    Me.GroupBox1.Controls.Add(Me.btnClearTextBoxes)
    Me.GroupBox1.Controls.Add(Me.txtGradYear)
    Me.GroupBox1.Controls.Add(Me.btnSave)
    Me.GroupBox1.Controls.Add(Me.txtSex)
    Me.GroupBox1.Controls.Add(Me.Label3)
    Me.GroupBox1.Controls.Add(Me.Label2)
    Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
    Me.GroupBox1.Location = New System.Drawing.Point(12, 22)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(381, 256)
    Me.GroupBox1.TabIndex = 0
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Participants' Record"
    '
    'btnCleanOneGuest
    '
    Me.btnCleanOneGuest.Location = New System.Drawing.Point(191, 204)
    Me.btnCleanOneGuest.Name = "btnCleanOneGuest"
    Me.btnCleanOneGuest.Size = New System.Drawing.Size(78, 23)
    Me.btnCleanOneGuest.TabIndex = 5
    Me.btnCleanOneGuest.TabStop = False
    Me.btnCleanOneGuest.Text = "Delete one"
    Me.btnCleanOneGuest.UseVisualStyleBackColor = True
    '
    'btnAmend
    '
    Me.btnAmend.Location = New System.Drawing.Point(281, 160)
    Me.btnAmend.Name = "btnAmend"
    Me.btnAmend.Size = New System.Drawing.Size(78, 22)
    Me.btnAmend.TabIndex = 4
    Me.btnAmend.TabStop = False
    Me.btnAmend.Text = "Amend"
    Me.btnAmend.UseVisualStyleBackColor = True
    '
    'btnCleanAllGuests
    '
    Me.btnCleanAllGuests.Location = New System.Drawing.Point(281, 204)
    Me.btnCleanAllGuests.Name = "btnCleanAllGuests"
    Me.btnCleanAllGuests.Size = New System.Drawing.Size(78, 23)
    Me.btnCleanAllGuests.TabIndex = 6
    Me.btnCleanAllGuests.TabStop = False
    Me.btnCleanAllGuests.Text = "Delete all"
    Me.btnCleanAllGuests.UseVisualStyleBackColor = True
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
    Me.Label4.Location = New System.Drawing.Point(26, 163)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(132, 15)
    Me.Label4.TabIndex = 0
    Me.Label4.Text = "< no record yet saved >"
    Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'txtTableNum
    '
    Me.txtTableNum.Location = New System.Drawing.Point(176, 51)
    Me.txtTableNum.MaxLength = 4
    Me.txtTableNum.Name = "txtTableNum"
    Me.txtTableNum.Size = New System.Drawing.Size(82, 20)
    Me.txtTableNum.TabIndex = 0
    Me.txtTableNum.TabStop = False
    '
    'GroupBox2
    '
    Me.GroupBox2.Controls.Add(Me.Label6)
    Me.GroupBox2.Controls.Add(Me.RadioButton2)
    Me.GroupBox2.Controls.Add(Me.RadioButton1)
    Me.GroupBox2.Controls.Add(Me.Label5)
    Me.GroupBox2.Controls.Add(Me.txtTableNum)
    Me.GroupBox2.Controls.Add(Me.btnSort)
    Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
    Me.GroupBox2.Location = New System.Drawing.Point(399, 22)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(293, 256)
    Me.GroupBox2.TabIndex = 1
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Sort Participants' Records"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(27, 98)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(164, 13)
    Me.Label6.TabIndex = 0
    Me.Label6.Text = "Sorting Orientation in each table :"
    '
    'RadioButton2
    '
    Me.RadioButton2.AutoSize = True
    Me.RadioButton2.Location = New System.Drawing.Point(30, 138)
    Me.RadioButton2.Name = "RadioButton2"
    Me.RadioButton2.Size = New System.Drawing.Size(144, 17)
    Me.RadioButton2.TabIndex = 2
    Me.RadioButton2.Text = "Balance male and female"
    Me.RadioButton2.UseVisualStyleBackColor = True
    '
    'RadioButton1
    '
    Me.RadioButton1.AutoSize = True
    Me.RadioButton1.Location = New System.Drawing.Point(30, 119)
    Me.RadioButton1.Name = "RadioButton1"
    Me.RadioButton1.Size = New System.Drawing.Size(230, 17)
    Me.RadioButton1.TabIndex = 1
    Me.RadioButton1.Text = "Group people with similar year of graduation"
    Me.RadioButton1.UseVisualStyleBackColor = True
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(27, 54)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(143, 13)
    Me.Label5.TabIndex = 0
    Me.Label5.Text = "Number of Tables Required :"
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(700, 300)
    Me.Controls.Add(Me.GroupBox2)
    Me.Controls.Add(Me.GroupBox1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
    Me.MaximizeBox = False
    Me.Name = "Form1"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "School Annual Dinner Registration"
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents txtGradYear As System.Windows.Forms.TextBox
  Friend WithEvents txtSex As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents btnSave As System.Windows.Forms.Button
  Friend WithEvents btnClearTextBoxes As System.Windows.Forms.Button
  Friend WithEvents txtName As System.Windows.Forms.TextBox
  Friend WithEvents btnSort As System.Windows.Forms.Button
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents txtTableNum As System.Windows.Forms.TextBox
  Friend WithEvents btnCleanAllGuests As System.Windows.Forms.Button
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
  Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents btnCleanOneGuest As System.Windows.Forms.Button
  Friend WithEvents btnAmend As System.Windows.Forms.Button

End Class
