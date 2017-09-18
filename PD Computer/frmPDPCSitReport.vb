Public Class frmPDPCSitReport
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim File As System.IO.StreamWriter
        If rtxtSitRep.Text = "" Then
            MsgBox("No Text was entered!")
        Else
            File = My.Computer.FileSystem.OpenTextFileWriter("Situation Report.txt", True)
            Dim DateandTime
            DateandTime = DateTime.Now.ToString("hh:mm dddd, dd MMMM yyyy")

            File.WriteLine(DateandTime & " - Situation Report : [ " & rtxtSitRep.Text & " ]")
            MsgBox("Situation Report Saved!")
            File.Close()
            rtxtSitRep.Text = ""
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class