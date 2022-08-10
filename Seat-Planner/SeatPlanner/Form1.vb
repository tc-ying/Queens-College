Public Class Form1
  Dim AllGuests As New AllGuestsClass
  Dim AllTables As New AllTablesClass
  Dim i, j, k As Short
  Dim OKFlag As Boolean

#Region "Manipulation Buttons"

  Private Sub btnClearTextBoxes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClearTextBoxes.Click
    Call ClearTextBoxes()
  End Sub

  Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click

    'participants data input validation
    Dim temp1, temp2 As Short
    If txtName.Text = "" Then
      MessageBox.Show("Please input the name of the participant", "Invalid name of participant", MessageBoxButtons.OK, MessageBoxIcon.Error)
      txtName.Focus()
      Exit Sub
    End If
    For i = 0 To AllGuests.Count - 1
      If txtName.Text = AllGuests(i).Name Then
        MessageBox.Show("There is a record with the same name" & vbCrLf & "Please input another unique name of participant", "Invalid name of participant", MessageBoxButtons.OK, MessageBoxIcon.Error)
        txtName.Focus()
        Exit Sub
      End If
    Next
    Try
      temp1 = Short.Parse(txtGradYear.Text)
      If (temp1 < 1000) Or (temp1 > 3000) Then Throw New FormatException
    Catch ex As FormatException
      MessageBox.Show("Please input a whole number ranging from 1000 to 3000", "Invalid year of graduation of participant", MessageBoxButtons.OK, MessageBoxIcon.Error)
      txtGradYear.Text = ""
      txtGradYear.Focus()
      Exit Sub
    End Try
    If (txtSex.Text.ToUpper = "M") Or (txtSex.Text.ToUpper = "MALE") Then
      temp2 = 1
    ElseIf (txtSex.Text.ToUpper = "F") Or (txtSex.Text.ToUpper = "FEMALE") Then
      temp2 = -1
    Else
      MessageBox.Show("Please input ""m"" or ""f"" for male or female respectively", "Invalid sex of participant", MessageBoxButtons.OK, MessageBoxIcon.Error)
      txtSex.Text = ""
      txtSex.Focus()
      Exit Sub
    End If

    'create and save a new record
    Select Case AllGuests.Count
      Case 0 To 999
        Dim Guest As New GuestClass()
        Guest.Name = txtName.Text
        Guest.GradYear = temp1
        Guest.Sex = temp2
        AllGuests.Add(Guest)
        Label4.Text = "< " & AllGuests.Count.ToString() & " records saved ! >"
        Call ClearTextBoxes()
      Case 1000
        MessageBox.Show("You haved reach the maximum number of records to be saved" & vbCrLf & "The new record cannot be saved", "This program does not support records saved to be over 1000", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Select
  End Sub

  Private Sub btnAmend_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAmend.Click
    Dim temp1, temp2 As Short
    If txtName.Text = "" Then
      MessageBox.Show("Please input the name of the participant", "Invalid name of participant", MessageBoxButtons.OK, MessageBoxIcon.Error)
      txtName.Focus()
      Exit Sub
    End If
    For i = 0 To AllGuests.Count - 1
      If AllGuests(i).Name = txtName.Text Then
        Try
          temp1 = Short.Parse(txtGradYear.Text)
          If (temp1 < 1000) Or (temp1 > 3000) Then Throw New FormatException
        Catch ex As FormatException
          MessageBox.Show("Please input a whole number ranging from 1000 to 3000", "Invalid year of graduation of participant", MessageBoxButtons.OK, MessageBoxIcon.Error)
          txtGradYear.Text = ""
          txtGradYear.Focus()
          Exit Sub
        End Try
        If (txtSex.Text.ToUpper = "M") Or (txtSex.Text.ToUpper = "MALE") Then
          temp2 = 1
        ElseIf (txtSex.Text.ToUpper = "F") Or (txtSex.Text.ToUpper = "FEMALE") Then
          temp2 = -1
        Else
          MessageBox.Show("Please input ""m"" or ""f"" for male or female respectively", "Invalid sex of participant", MessageBoxButtons.OK, MessageBoxIcon.Error)
          txtSex.Text = ""
          txtSex.Focus()
          Exit Sub
        End If
        With AllGuests(i)
          .GradYear = temp1
          .Sex = temp2
        End With
        Label4.Text = "< record amended ! >"
        Call ClearTextBoxes()
        Exit Sub
      End If
    Next
    MessageBox.Show("Record not found", "Record not found", MessageBoxButtons.OK, MessageBoxIcon.Information)
    txtName.Focus()
  End Sub

  Private Sub btnCleanOneGuest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCleanOneGuest.Click
    Dim tempName As String
    tempName = InputBox("Please input the name of the participant", "Record to delete")
    For i = 0 To AllGuests.Count - 1
      If AllGuests(i).Name = tempName Then
        AllGuests.RemoveAt(i)
        Label4.Text = "< record deleted ! >"
        txtName.Focus()
        Exit Sub
      End If
    Next i
    MessageBox.Show("Record not found", "Record not found", MessageBoxButtons.OK, MessageBoxIcon.Information)
    txtName.Focus()
  End Sub

  Private Sub btnCleanAllGuests_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCleanAllGuests.Click
    'remove all participants record from the memory
    Dim result As DialogResult
    result = MessageBox.Show("All participants records in the memory will be lost !" & vbCrLf & "Continue ?", "Confirm Records Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
    If result = Windows.Forms.DialogResult.Yes Then
      If AllGuests.Count > 0 Then
        AllGuests.Clear()
        Label4.Text = "< all records are deleted ! >"
        txtName.Focus()
      ElseIf AllGuests.Count = 0 Then
        MessageBox.Show("There are no participants records to delete", "No records found", MessageBoxButtons.OK, MessageBoxIcon.Stop)
      End If
    End If
  End Sub

#End Region

  Private Sub btnSort_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSort.Click
    Dim numTable, numSeat As Short
    Dim numSexBalance, numSexDifference As Short

    'parameters validation
    If AllGuests.Count = 0 Then
      MessageBox.Show("Please input at least one participant record", "No participant record for sorting", MessageBoxButtons.OK, MessageBoxIcon.Error)
      Exit Sub
    End If
    Try
      numTable = Short.Parse(txtTableNum.Text)
      If numTable > AllGuests.Count Then Throw New FormatException
    Catch ex As FormatException
      MessageBox.Show("Please input a whole number that is not larger than" & vbCrLf & "the number of participants to be sort", "Invalid number of tables", MessageBoxButtons.OK, MessageBoxIcon.Error)
      txtTableNum.Focus()
      Exit Sub
    End Try
    If Not (RadioButton1.Checked Or RadioButton2.Checked) Then
      MessageBox.Show("Please select one sorting orientation in each table", "No sorting orientation selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
      Exit Sub
    End If

    'main sorting algorithm

    Call SortByYear(AllGuests.Count - 1)

    'create the specified number of tables required
    AllTables.Clear()
    For i = 1 To numTable
      AllTables.Add(New TableClass)
    Next

    numSeat = Math.Ceiling(AllGuests.Count / numTable)

    For i = 0 To AllTables.Count - 2
      numSexBalance = 0
      For j = 0 To numSeat - 1
        AllTables(i).Add(AllGuests(numSeat * i + j))
        numSexBalance += AllGuests(numSeat * i + j).Sex
      Next j
      AllTables(i).SexBalance = numSexBalance
    Next i
    numSexBalance = 0
    For j = 0 To numSeat - (AllGuests.Count Mod numTable) - 1
      AllTables(i).Add(AllGuests(numSeat * i + j))
      numSexBalance += AllGuests(numSeat * i + j).Sex
    Next
    AllTables(i).SexBalance = numSexBalance

    Do
      OKFlag = True
      For i = 0 To AllTables.Count - 2
        numSexDifference = AllTables(i).SexBalance - AllTables(i + 1).SexBalance
        If numSexDifference >= 3 Then
          For j = AllTables(i).Count - 1 To 0 Step -1
            If AllTables(i)(j).Sex = 1 Then Exit For
          Next
          For k = 0 To AllTables(i + 1).Count - 1
            If AllTables(i + 1)(k).Sex = -1 Then Exit For
          Next
          If RadioButton2.Checked Then
            Call SwapBetweenTables()
            AllTables(i).SexBalance += -2
            AllTables(i + 1).SexBalance += 2
          ElseIf RadioButton1.Checked Then
            If AllTables(i)(j).GradYear = AllTables(i + 1)(k).GradYear Then
              Call SwapBetweenTables()
              AllTables(i).SexBalance += -2
              AllTables(i + 1).SexBalance += 2
            ElseIf (i = AllTables.Count - 2) And Not (AllTables(i)(j).GradYear = AllTables(i + 1)(k).GradYear) Then
              Exit Do
            End If
          End If
          OKFlag = False
        ElseIf numSexDifference <= -3 Then
          For j = AllTables(i).Count - 1 To 0 Step -1
            If AllTables(i)(j).Sex = -1 Then Exit For
          Next j
          For k = 0 To AllTables(i + 1).Count - 1
            If AllTables(i + 1)(k).Sex = 1 Then Exit For
          Next k
          If RadioButton2.Checked Then
            Call SwapBetweenTables()
            AllTables(i).SexBalance += 2
            AllTables(i + 1).SexBalance += -2
          ElseIf RadioButton1.Checked Then
            If AllTables(i)(j).GradYear = AllTables(i + 1)(k).GradYear Then
              Call SwapBetweenTables()
              AllTables(i).SexBalance += 2
              AllTables(i + 1).SexBalance += -2
            ElseIf (i = AllTables.Count - 2) And Not (AllTables(i)(j).GradYear = AllTables(i + 1)(k).GradYear) Then
              Exit Do
            End If
          End If
          OKFlag = False
        End If
      Next i
    Loop Until OKFlag = True

    Call SaveToTextFile()

    'display system information after sorting
    If AllGuests.Count = 1 Then
      Label4.Text = "< " & AllGuests.Count.ToString() & " record in memory >"
    Else
      Label4.Text = "< " & AllGuests.Count.ToString() & " records in memory >"
    End If
    MessageBox.Show("The seating plan is saved" & vbCrLf & "in the same location as this program", "Seating plan successfully built")
  End Sub

  Public Sub ClearTextBoxes()
    'empty all participatns data input textboxes
    txtName.Text = ""
    txtGradYear.Text = ""
    txtSex.Text = ""
    txtName.Focus()
  End Sub

  Public Sub SortByYear(ByVal UpperBound As Short)
    'rearrange participants records in ascending order of year of graduation by insertion sort
    For i = 1 To UpperBound
      For j = i - 1 To 0 Step -1
        If AllGuests(j).GradYear <= AllGuests(i).GradYear Then Exit For
      Next
      AllGuests.Insert(j + 1, AllGuests(i))
      AllGuests.RemoveAt(i + 1)
    Next i
  End Sub

  Public Sub SwapBetweenTables()
    AllTables(i + 1).Insert(k + 1, AllTables(i)(j))
    AllTables(i).Insert(j + 1, AllTables(i + 1)(k))
    AllTables(i).RemoveAt(j)
    AllTables(i + 1).RemoveAt(k)
  End Sub

  Public Sub SaveToTextFile()
    'save the records into a text file
    Dim file As System.IO.StreamWriter
    file = My.Computer.FileSystem.OpenTextFileWriter(My.Computer.FileSystem.CurrentDirectory & "\SeatingPlans.txt", True)
    file.WriteLine("---------------------------------------")
    file.WriteLine("A seating plan for school annual dinner")
    For i = 0 To AllTables.Count - 1
      file.WriteLine()
      file.WriteLine("Table " & (i + 1).ToString())
      For Each oneGuest As GuestClass In AllTables(i)
        file.Write("  " & oneGuest.GradYear.ToString() & ", ")
        If oneGuest.Sex = 1 Then file.Write("M, ")
        If oneGuest.Sex = -1 Then file.Write("F, ")
        file.Write(oneGuest.Name)
        file.WriteLine()
      Next
    Next
    file.WriteLine()
    file.Close()
  End Sub

End Class