Imports System.Data
Imports System.Data.OleDb

Public Class Record
    Dim Record As New DataTable


    Dim A As String
    Dim B As String
    Dim C As String

    Dim con As OleDbConnection = New OleDbConnection
    'Provider=Microsoft.Jet.OLEDB.4.0;Data Source="C:\Users\markl edcel hipol\Documents\StudentGradeRecord.mdb"
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\markl edcel hipol\Documents\StudentGradeRecord.mdb")

    'SAVE RECORD BUTTON
    Private Sub saveBtn_Click_1(sender As Object, e As EventArgs) Handles saveBtn.Click
        ' Provider=Microsoft.Jet.OLEDB.4.0;Data Source="C:\Users\markl edcel hipol\Documents\StudentGradeRecord.mdb"
        A = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\markl edcel hipol\Documents\StudentGradeRecord.mdb")
        B = A

        Try


            con.ConnectionString = B
            con.Open()
            C = "Insert into StudentGradeRecord([ID],[s_name],[s_lastName],[s_yrSection],[grading_period],[s_attendance],[s_attendance(out-of)],[s_attendance(Percent)],[s_activities],[s_activities(out-of)],[s_activities(Percent)],[s_quiz],[s_quiz(out-of)],[s_quiz(Percent)],[s_exam],[s_exam(out-of)],[s_exam(Percent)],[s_grade],[s_remarks]) values('" & IDtxt.Text & "', '" & firstNametxt.Text & "', '" & lastNametxt.Text & "', '" & yrSectiontxt.Text & "', '" & termCB.Text & "', '" & attendtxt.Text & "', '" & AttendanceOutOftxt.Text & "', '" & attendancePercentTxt.Text & "', '" & activitytxt.Text & "', '" & activityOutOftxt.Text & "', '" & activityPercentTxt.Text & "', '" & quiztxt.Text & "', '" & quizOutOftxt.Text & "', '" & quizPercentTxt.Text & "', '" & examtxt.Text & "', '" & examOutOftxt.Text & "', '" & ExamPercentTxt.Text & "', '" & gradetxt.Text & "', '" & remarkstxt.Text & "' )"

            Dim cmd As OleDbCommand = New OleDbCommand(C, con)
            cmd.Parameters.Add(New OleDbParameter("ID", CType(IDtxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("s_name", CType(firstNametxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("s_lastName", CType(lastNametxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("s_yrSection", CType(yrSectiontxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("grading_period", CType(termCB.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("s_attendance", CType(attendtxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("s_attendance(out-of)", CType(AttendanceOutOftxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("s_attendance(Percent)", CType(attendancePercentTxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("s_activities", CType(activitytxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("s_activities(out-of)", CType(activityOutOftxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("s_activities(Percent)", CType(activityPercentTxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("s_quiz", CType(quiztxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("s_quiz(out-of)", CType(quizOutOftxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("s_quiz(Percent)", CType(quizPercentTxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("s_exam", CType(examtxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("s_exam(out-of)", CType(examOutOftxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("s_exam(Percent)", CType(ExamPercentTxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("s_grade", CType(gradetxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("s_remarks", CType(remarkstxt.Text, String)))
            MsgBox("Insert Successfully")

            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                con.Close()

                bind_data()

                'Student Info
                IDtxt.Clear()
                firstNametxt.Clear()
                lastNametxt.Clear()
                yrSectiontxt.Clear()
                'Attendance
                attendtxt.Clear()
                attendanceEGtxt.Clear()
                AttendanceOutOftxt.Clear()
                attendancePertxt.Clear()
                'activity
                activitytxt.Clear()
                activityEGtxt.Clear()
                activityOutOftxt.Clear()
                activityPertxt.Clear()
                'quiz
                quiztxt.Clear()
                quizEGtxt.Clear()
                quizOutOftxt.Clear()
                quizPertxt.Clear()
                'exam
                examtxt.Clear()
                examEGtxt.Clear()
                examOutOftxt.Clear()
                examPertxt.Clear()
                'computed grade
                gradetxt.Clear()
                remarkstxt.Clear()
                lettertxt.Clear()

                lettertxt.BackColor = Color.Gainsboro
                gradetxt.BackColor = Color.Gainsboro
                remarkstxt.BackColor = Color.Gainsboro
                attendanceEGtxt.BackColor = Color.Gainsboro
                attendancePertxt.BackColor = Color.Gainsboro
                activityEGtxt.BackColor = Color.Gainsboro
                activityPertxt.BackColor = Color.Gainsboro
                quizEGtxt.BackColor = Color.Gainsboro
                quizPertxt.BackColor = Color.Gainsboro
                examEGtxt.BackColor = Color.Gainsboro
                examPertxt.BackColor = Color.Gainsboro

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

        Catch ex As Exception
            MsgBox("Insert Unsuccessful, Please try again")
            con.Close()
        End Try

    End Sub

    'UPDATE RECORD BUTTON
    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        A = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\markl edcel hipol\Documents\StudentGradeRecord.mdb")
        B = A

        Try

        
            con.ConnectionString = B
            con.Open()
            C = "Update StudentGradeRecord set [s_name]= '" & firstNametxt.Text & "', [s_lastname]= '" & lastNametxt.Text & "', [s_yrSection]= '" & yrSectiontxt.Text & "', [grading_period]= '" & termCB.Text & "', [s_attendance]= '" & attendtxt.Text & "', [s_attendance(out-of)]= '" & AttendanceOutOftxt.Text & "', [s_attendance(Percent)]= '" & attendancePercentTxt.Text & "', [s_activities]= '" & activitytxt.Text & "', [s_activities(out-of)]= '" & activityOutOftxt.Text & "', [s_activities(Percent)]= '" & activityPercentTxt.Text & "', [s_quiz]= '" & quiztxt.Text & "', [s_quiz(out-of)]= '" & quizOutOftxt.Text & "', [s_quiz(Percent)]= '" & quizPercentTxt.Text & "', [s_exam]= '" & examtxt.Text & "', [s_exam(out-of)]= '" & examOutOftxt.Text & "', [s_exam(Percent)]= '" & ExamPercentTxt.Text & "', [s_grade]= '" & gradetxt.Text & "', [s_remarks]= '" & remarkstxt.Text & "' where [ID] = " & IDtxt.Text & " "
            Dim cmd As OleDbCommand = New OleDbCommand(C, con)

            MsgBox("Update Succesfully")

            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                con.Close()

                bind_data()

                'Student Info
                IDtxt.Clear()
                firstNametxt.Clear()
                lastNametxt.Clear()
                yrSectiontxt.Clear()
                'Attendance
                attendtxt.Clear()
                attendanceEGtxt.Clear()
                AttendanceOutOftxt.Clear()
                attendancePertxt.Clear()
                'activity
                activitytxt.Clear()
                activityEGtxt.Clear()
                activityOutOftxt.Clear()
                activityPertxt.Clear()
                'quiz
                quiztxt.Clear()
                quizEGtxt.Clear()
                quizOutOftxt.Clear()
                quizPertxt.Clear()
                'exam
                examtxt.Clear()
                examEGtxt.Clear()
                examOutOftxt.Clear()
                examPertxt.Clear()
                'computed grade
                gradetxt.Clear()
                remarkstxt.Clear()
                lettertxt.Clear()

                lettertxt.BackColor = Color.Gainsboro
                gradetxt.BackColor = Color.Gainsboro
                remarkstxt.BackColor = Color.Gainsboro
                attendanceEGtxt.BackColor = Color.Gainsboro
                attendancePertxt.BackColor = Color.Gainsboro
                activityEGtxt.BackColor = Color.Gainsboro
                activityPertxt.BackColor = Color.Gainsboro
                quizEGtxt.BackColor = Color.Gainsboro
                quizPertxt.BackColor = Color.Gainsboro
                examEGtxt.BackColor = Color.Gainsboro
                examPertxt.BackColor = Color.Gainsboro
            Catch ex As Exception
                MsgBox("Insert Unsuccessful, Please try again")
            End Try

        Catch ex As Exception
            con.Close()
        End Try
    End Sub

    'DELETE BUTTON
    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        A = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\markl edcel hipol\Documents\StudentGradeRecord.mdb"
        B = A

        Try

        con.ConnectionString = B
        con.Open()
            C = "Delete From [StudentGradeRecord] where [ID] = " & IDtxt.Text & ""
        Dim cmd As OleDbCommand = New OleDbCommand(C, con)

        MsgBox("Delete Succesfully")

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()

            bind_data()

            'Student Info
            IDtxt.Clear()
            firstNametxt.Clear()
            lastNametxt.Clear()
            yrSectiontxt.Clear()
            'attendance
            attendtxt.Clear()
            attendanceEGtxt.Clear()
            AttendanceOutOftxt.Clear()
            attendancePertxt.Clear()
            'activity
            activitytxt.Clear()
            activityEGtxt.Clear()
            activityOutOftxt.Clear()
            activityPertxt.Clear()
            'quiz
            quiztxt.Clear()
            quizEGtxt.Clear()
            quizOutOftxt.Clear()
            quizPertxt.Clear()
            'exam
            examtxt.Clear()
            examEGtxt.Clear()
            examOutOftxt.Clear()
            examPertxt.Clear()
            'computed grade
            gradetxt.Clear()
                remarkstxt.Clear()
                lettertxt.Clear()

                lettertxt.BackColor = Color.Gainsboro
            gradetxt.BackColor = Color.Gainsboro
            remarkstxt.BackColor = Color.Gainsboro
            attendanceEGtxt.BackColor = Color.Gainsboro
            attendancePertxt.BackColor = Color.Gainsboro
            activityEGtxt.BackColor = Color.Gainsboro
            activityPertxt.BackColor = Color.Gainsboro
            quizEGtxt.BackColor = Color.Gainsboro
            quizPertxt.BackColor = Color.Gainsboro
            examEGtxt.BackColor = Color.Gainsboro
            examPertxt.BackColor = Color.Gainsboro
        Catch ex As Exception
                MsgBox("Insert Unsuccessful, Please try again")
            End Try

        Catch ex As Exception
            con.Close()
        End Try
    End Sub



    'COMPUTE BUTTON
    Private Sub computeBtn_Click_1(sender As Object, e As EventArgs) Handles computeBtn.Click
        bind_data()

        'ATTENDANCE CODE
        If IsNumeric(attendtxt.Text) Then 'ACCEPTS THE INPUT IF IT'S NUMERIC
            Dim sc1 As Integer
            Dim per1 As Decimal

            'IF THE SCORE INPUT IS LESS THAN THE TOTAL(OUT OF "SCORE/OutOftxt")
            If (attendtxt.Text <= AttendanceOutOftxt.Text) Then
                sc1 = (attendtxt.Text * 100) / AttendanceOutOftxt.Text 'EG(EQUIVALENT GRADE)
                attendanceEGtxt.Text = sc1 'DISPLAY EG

                'TEXTBOX BACKCOLOR CHANGE
                If (attendanceEGtxt.Text >= 75) Then
                    attendanceEGtxt.BackColor = Color.Lime
                    attendancePertxt.BackColor = Color.Lime
                Else
                    attendanceEGtxt.BackColor = Color.Red
                    attendancePertxt.BackColor = Color.Red
                End If

                'PERCENT
                If (attendancePercentTxt.Text <= 10) Then
                    per1 = sc1 * 0.1
                    attendancePertxt.Text = CDec(per1)
                ElseIf (attendancePercentTxt.Text = 20) Then
                    per1 = sc1 * 0.2
                    attendancePertxt.Text = CDec(per1)
                ElseIf (attendancePercentTxt.Text = 30) Then
                    per1 = sc1 * 0.3
                    attendancePertxt.Text = CDec(per1)
                ElseIf (attendancePercentTxt.Text = 40) Then
                    per1 = sc1 * 0.4
                    attendancePertxt.Text = CDec(per1)
                ElseIf (attendancePercentTxt.Text = 50) Then
                    per1 = sc1 * 0.5
                    attendancePertxt.Text = CDec(per1)
                ElseIf (attendancePercentTxt.Text = 60) Then
                    per1 = sc1 * 0.6
                    attendancePertxt.Text = CDec(per1)

                Else 'DISPLAY MSGBOX IF THE PERCENT INPUT IS INVALID
                    MsgBox("Invalid input (Attendance %)")

                End If
            Else 'DISPLAY MSGBOX IF THE SCORE INPUT IS LARGER THAN THE TOTAL(OUT OF "/30")
                MessageBox.Show("Please enter a value less than or equal to " & AttendanceOutOftxt.Text & " (Attendance)")
            End If
        Else 'DISPLAY MSGBOX IF THE SCORE INPUT IS NON-NUMERIC
            MessageBox.Show("Invalid Score Input (Attendance)")
        End If

        'ACTIVITY CODE
        If IsNumeric(activitytxt.Text) Then
            Dim sc2 As Integer
            Dim per2 As Decimal

            If (activitytxt.Text <= activityOutOftxt.Text) Then
                sc2 = (activitytxt.Text * 100) / activityOutOftxt.Text
                activityEGtxt.Text = sc2

                If (activityEGtxt.Text >= 75) Then
                    activityEGtxt.BackColor = Color.Lime
                    activityPertxt.BackColor = Color.Lime
                Else
                    activityEGtxt.BackColor = Color.Red
                    activityPertxt.BackColor = Color.Red
                End If

                If (activityPercentTxt.Text = 10) Then
                    per2 = sc2 * 0.1
                    activityPertxt.Text = CDec(per2)
                ElseIf (activityPercentTxt.Text = 20) Then
                    per2 = sc2 * 0.2
                    activityPertxt.Text = CDec(per2)
                ElseIf (activityPercentTxt.Text = 30) Then
                    per2 = sc2 * 0.3
                    activityPertxt.Text = CDec(per2)
                ElseIf (activityPercentTxt.Text = 40) Then
                    per2 = sc2 * 0.4
                    activityPertxt.Text = CDec(per2)
                ElseIf (activityPercentTxt.Text = 50) Then
                    per2 = sc2 * 0.5
                    activityPertxt.Text = CDec(per2)
                ElseIf (activityPercentTxt.Text = 60) Then
                    per2 = sc2 * 0.6
                    activityPertxt.Text = CDec(per2)
                ElseIf (activityPercentTxt.Text = 70) Then
                    per2 = sc2 * 0.7
                    activityPertxt.Text = CDec(per2)

                Else
                    MsgBox("Invalid (Activity %)")
                End If
            Else
                MessageBox.Show("Please enter value less than or equal to " & activityOutOftxt.Text & " (Activity)")
            End If
        Else
            MessageBox.Show("Invalid Score Input (Activity)")
        End If

        'QUIZ CODE
        If IsNumeric(quiztxt.Text) Then
            Dim sc3 As Integer
            Dim per3 As Decimal

            If (quiztxt.Text <= quizOutOftxt.Text) Then
                sc3 = (quiztxt.Text * 100) / quizOutOftxt.Text
                quizEGtxt.Text = sc3

                If (quizEGtxt.Text >= 75) Then
                    quizEGtxt.BackColor = Color.Lime
                    quizPertxt.BackColor = Color.Lime
                Else
                    quizEGtxt.BackColor = Color.Red
                    quizPertxt.BackColor = Color.Red
                End If

                If (quizPercentTxt.Text = 10) Then
                    per3 = sc3 * 0.1
                    quizPertxt.Text = CDec(per3)
                ElseIf (quizPercentTxt.Text = 20) Then
                    per3 = sc3 * 0.2
                    quizPertxt.Text = CDec(per3)
                ElseIf (quizPercentTxt.Text = 30) Then
                    per3 = sc3 * 0.3
                    quizPertxt.Text = CDec(per3)
                ElseIf (quizPercentTxt.Text = 40) Then
                    per3 = sc3 * 0.4
                    quizPertxt.Text = CDec(per3)
                ElseIf (quizPercentTxt.Text = 50) Then
                    per3 = sc3 * 0.5
                    quizPertxt.Text = CDec(per3)
                ElseIf (quizPercentTxt.Text = 60) Then
                    per3 = sc3 * 0.6
                    quizPertxt.Text = CDec(per3)
                ElseIf (quizPercentTxt.Text = 70) Then
                    per3 = sc3 * 0.7
                    quizPertxt.Text = CDec(per3)

                Else
                    MsgBox("Invalid (Quiz %)")
                End If
            Else
                MessageBox.Show("Please enter value less than or equal to " & quizOutOftxt.Text & " (Quiz)")
            End If
        Else
            MessageBox.Show("Invalid Score Input (Quiz)")
        End If


        'EXAM CODE
        If IsNumeric(examtxt.Text) Then
            Dim sc4 As Integer
            Dim per4 As Decimal

            If (examtxt.Text <= examOutOftxt.Text) Then
                sc4 = (examtxt.Text * 100) / examOutOftxt.Text 'EG
                examEGtxt.Text = sc4 'DISPLAY EG

                If (examEGtxt.Text >= 75) Then
                    examEGtxt.BackColor = Color.Lime
                    examPertxt.BackColor = Color.Lime
                Else
                    examEGtxt.BackColor = Color.Red
                    examPertxt.BackColor = Color.Red
                End If

                'PERCENT
                If (ExamPercentTxt.Text = 10) Then
                    per4 = sc4 * 0.1
                    examPertxt.Text = CDec(per4)
                ElseIf (ExamPercentTxt.Text = 20) Then
                    per4 = sc4 * 0.2
                    examPertxt.Text = CDec(per4)
                ElseIf (ExamPercentTxt.Text = 30) Then
                    per4 = sc4 * 0.3
                    examPertxt.Text = CDec(per4)
                ElseIf (ExamPercentTxt.Text = 40) Then
                    per4 = sc4 * 0.4
                    examPertxt.Text = CDec(per4)
                ElseIf (ExamPercentTxt.Text = 50) Then
                    per4 = sc4 * 0.5
                    examPertxt.Text = CDec(per4)
                ElseIf (ExamPercentTxt.Text = 60) Then
                    per4 = sc4 * 0.6
                    examPertxt.Text = CDec(per4)
                ElseIf (ExamPercentTxt.Text = 70) Then
                    per4 = sc4 * 0.7
                    examPertxt.Text = CDec(per4)
                ElseIf (ExamPercentTxt.Text = 80) Then
                    per4 = sc4 * 0.8
                    examPertxt.Text = CDec(per4)

                Else
                    MessageBox.Show("Invalid (Exam %)")
                End If
            Else
                MessageBox.Show("Please enter value less than or equal to '" & examOutOftxt.Text & "' (Exam)")
            End If
        Else
            MessageBox.Show("Invalid Score Input (Exam)")
        End If

        'COMPUTING TOTAL GRADE & DISPLAYING REMARKS(PASSED/FAILED)
        Dim totalGrade As Decimal
        Dim grade As Double

        totalGrade = Val(attendancePertxt.Text) + Val(activityPertxt.Text) + Val(quizPertxt.Text) + Val(examPertxt.Text)
        lettertxt.Text = totalGrade
        grade = lettertxt.Text

        If (lettertxt.Text >= 75) Then
            remarkstxt.Text = "PASSED"

            remarkstxt.BackColor = Color.Lime
            lettertxt.BackColor = Color.Lime
            gradetxt.BackColor = Color.Lime
        Else
            remarkstxt.Text = "FAILED"

            remarkstxt.BackColor = Color.Red
            lettertxt.BackColor = Color.Red
            gradetxt.BackColor = Color.Red
        End If

        Select Case grade
            Case 0 To 74.99
                gradetxt.Text = "5.00"
            Case 75 To 77.99
                gradetxt.Text = "3.00"
            Case 78 To 80.99
                gradetxt.Text = "2.75"
            Case 81 To 83.99
                gradetxt.Text = "2.50"
            Case 84 To 86.99
                gradetxt.Text = "2.25"
            Case 87 To 89.99
                gradetxt.Text = "2.00"
            Case 90 To 92.99
                gradetxt.Text = "1.75"
            Case 93 To 95.99
                gradetxt.Text = "1.50"
            Case 96 To 98.99
                gradetxt.Text = "1.25"
            Case 99.99 To 100
                gradetxt.Text = "1.00"

        End Select
        

    End Sub

    'CLEAR BUTTON
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Student Info Textbox Clear
        IDtxt.Clear()
        firstNametxt.Clear()
        lastNametxt.Clear()
        yrSectiontxt.Clear()
        'Attendance Textbox Clear
        attendtxt.Clear()
        AttendanceOutOftxt.Clear()
        attendancePercentTxt.Clear()
        attendanceEGtxt.Clear()
        attendancePertxt.Clear()
        'Activity Textbox Clear
        activitytxt.Clear()
        activityOutOftxt.Clear()
        activityPercentTxt.Clear()
        activityEGtxt.Clear()
        activityPertxt.Clear()
        'Quiz Textbox Clear
        quiztxt.Clear()
        quizOutOftxt.Clear()
        quizPercentTxt.Clear()
        quizEGtxt.Clear()
        quizPertxt.Clear()
        'Exam Textbox Clear
        examtxt.Clear()
        examOutOftxt.Clear()
        examPertxt.Clear()
        examEGtxt.Clear()
        ExamPercentTxt.Clear()
        'Computed Grade Clear
        gradetxt.Clear()
        remarkstxt.Clear()
        lettertxt.Clear()

        'Colors
        attendanceEGtxt.BackColor = Color.Gainsboro
        attendancePertxt.BackColor = Color.Gainsboro
        activityEGtxt.BackColor = Color.Gainsboro
        activityPertxt.BackColor = Color.Gainsboro
        quizEGtxt.BackColor = Color.Gainsboro
        quizPertxt.BackColor = Color.Gainsboro
        examEGtxt.BackColor = Color.Gainsboro
        examPertxt.BackColor = Color.Gainsboro
        gradetxt.BackColor = Color.Gainsboro
        remarkstxt.BackColor = Color.Gainsboro
        lettertxt.BackColor = Color.Gainsboro

        bind_data()
    End Sub

    'MouseHover events
    Private Sub computeBtn_MouseHover(sender As Object, e As EventArgs) Handles computeBtn.MouseHover
        computeBtn.BackColor = Color.CornflowerBlue
    End Sub

    Private Sub saveBtn_MouseHover(sender As Object, e As EventArgs) Handles saveBtn.MouseHover
        saveBtn.BackColor = Color.SpringGreen
    End Sub

    Private Sub updateBtn_MouseHover(sender As Object, e As EventArgs) Handles updateBtn.MouseHover
        updateBtn.BackColor = Color.Pink
    End Sub

    Private Sub DeleteBtn_MouseHover(sender As Object, e As EventArgs) Handles DeleteBtn.MouseHover
        DeleteBtn.BackColor = Color.Red
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.Yellow
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        Button2.BackColor = Color.Purple
    End Sub

    'MouseLeave events
    Private Sub computeBtn_MouseLeave(sender As Object, e As EventArgs) Handles computeBtn.MouseLeave
        computeBtn.BackColor = Color.Teal
    End Sub

    Private Sub saveBtn_MouseLeave(sender As Object, e As EventArgs) Handles saveBtn.MouseLeave
        saveBtn.BackColor = Color.Aqua
    End Sub

    Private Sub updateBtn_MouseLeave(sender As Object, e As EventArgs) Handles updateBtn.MouseLeave
        updateBtn.BackColor = Color.Aqua
    End Sub

    Private Sub DeleteBtn_MouseLeave(sender As Object, e As EventArgs) Handles DeleteBtn.MouseLeave
        DeleteBtn.BackColor = Color.Aqua
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.Teal
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.Aqua
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        firstNametxt.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString '= FIRSTNAME TEXTBOX
        lastNametxt.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString '= LASTNAME TEXTBOX
        yrSectiontxt.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString '= YEAR/SECTION TEXTBOX
        termCB.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString '= GRADING PERIOD
        attendtxt.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString '= ATTENDANCE SCORE TEXTBOX
        AttendanceOutOftxt.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString '= ATTENDANCE OUT-OF TEXTBOX
        attendancePercentTxt.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString '= ATTENDANCE PERCENT TEXTBOX
        activitytxt.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString '= ACTIVITY SCORE TEXTBOX
        activityOutOftxt.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value.ToString '= ACTIVITY OUT-OF TEXTBOX
        activityPercentTxt.Text = DataGridView1.Rows(e.RowIndex).Cells(10).Value.ToString '= ACTIVITY PERCENT TEXTBOX
        quiztxt.Text = DataGridView1.Rows(e.RowIndex).Cells(11).Value.ToString '= QUIZ SCORE TEXTBOX
        quizOutOftxt.Text = DataGridView1.Rows(e.RowIndex).Cells(12).Value.ToString '= QUIZ OUT-OF TEXTBOX
        quizPercentTxt.Text = DataGridView1.Rows(e.RowIndex).Cells(13).Value.ToString '= QUIZ PERCENT TEXTBOX
        examtxt.Text = DataGridView1.Rows(e.RowIndex).Cells(14).Value.ToString '= EXAM SCORE TEXTBOX
        examOutOftxt.Text = DataGridView1.Rows(e.RowIndex).Cells(15).Value.ToString '= EXAM OUT-OF TEXTBOX
        ExamPercentTxt.Text = DataGridView1.Rows(e.RowIndex).Cells(16).Value.ToString '= EXAM PERCENT TEXTBOX
        gradetxt.Text = DataGridView1.Rows(e.RowIndex).Cells(17).Value.ToString '= COMPUTED GRADE TEXTBOX
        remarkstxt.Text = DataGridView1.Rows(e.RowIndex).Cells(18).Value.ToString '= REMARKS TEXTBOX
        IDtxt.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString '= ID TEXTBOX

        bind_data()

        Try
            gradetxt.BackColor = Color.Gainsboro
            remarkstxt.BackColor = Color.Gainsboro
            attendanceEGtxt.BackColor = Color.Gainsboro
            attendancePertxt.BackColor = Color.Gainsboro
            activityEGtxt.BackColor = Color.Gainsboro
            activityPertxt.BackColor = Color.Gainsboro
            quizEGtxt.BackColor = Color.Gainsboro
            quizPertxt.BackColor = Color.Gainsboro
            examEGtxt.BackColor = Color.Gainsboro
            examPertxt.BackColor = Color.Gainsboro

            'Attendance
            attendanceEGtxt.Clear()
            attendancePertxt.Clear()
            'acitivity
            activityEGtxt.Clear()
            activityPertxt.Clear()
            'quiz
            quizEGtxt.Clear()
            quizPertxt.Clear()
            'exam
            examEGtxt.Clear()
            examPertxt.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Record_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentGradeRecordDataSet.StudentGradeRecord' table. You can move, or remove it, as needed.
        Me.StudentGradeRecordTableAdapter.Fill(Me.StudentGradeRecordDataSet.StudentGradeRecord)

        Dim connect As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\markl edcel hipol\Documents\StudentGradeRecord.mdb")

        bind_data()

        Try
            connect.Open()
            lbl_Connection.Text = "Connected"
            lbl_Connection.ForeColor = Color.Lime
        Catch ex As Exception
            lbl_Connection.Text = "Disconnected"
            lbl_Connection.ForeColor = Color.Red
        End Try
        connect.Close()
    End Sub

    Private Sub bind_data()
        Dim cmd1 As New OleDbCommand("Select * from StudentGradeRecord", conn)

        Dim adap As New OleDbDataAdapter
        adap.SelectCommand = cmd1
        Dim Record As New DataTable
        Record.Clear()
        adap.Fill(Record)
        DataGridView1.DataSource = Record

    End Sub

    Private Sub Searchtxt_TextChanged(sender As Object, e As EventArgs) Handles Searchtxt.TextChanged
        A = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\markl edcel hipol\Documents\StudentGradeRecord.mdb")
        B = A

        con.ConnectionString = B
        con.Open()

        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("Select * from StudentGradeRecord where ID like '%" & Searchtxt.Text & "%' or s_name like '%" & Searchtxt.Text & "%' or s_lastName like '%" & Searchtxt.Text & "%' or s_yrSection like '%" & Searchtxt.Text & "%' or s_remarks like '%" & Searchtxt.Text & "%' ", con)
        da.Fill(dt)

        DataGridView1.DataSource = dt.DefaultView

        con.Close()


    End Sub
    
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            ReportViewerForm.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class