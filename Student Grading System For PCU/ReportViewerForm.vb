Imports System.Data.OleDb

Public Class ReportViewerForm

    Private Sub ReportViewerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        Using con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\markl edcel hipol\Documents\StudentGradeRecord.mdb")
            con.Open()
            Using cmd As New OleDbCommand("Select * From StudentGradeRecord", con)
                Dim da As New OleDbDataAdapter
                da.SelectCommand = cmd
                da.Fill(dt)
            End Using
        End Using

        With Me.ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = "C:\Users\markl edcel hipol\documents\visual studio 2012\Projects\Student Grading System For PCU\Student Grading System For PCU\StudentGradeReport.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
        End With
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class