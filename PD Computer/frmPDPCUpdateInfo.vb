Public Class frmPDPCUpdateInfo

    Public Shared isExit = False

    Dim downloadLink As String = ""
    Public Shared curVersion As String = "2.7.9"
    Private Sub btnSkip_Click(sender As Object, e As EventArgs) Handles btnSkip.Click
        MsgBox("This may cause crashes, you have been warned!", MsgBoxStyle.Exclamation)
        frmPDPCMenu.Show()
        Me.Close()
    End Sub

    Private Sub frmPDPCUpdateInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmPDPCDataGrid.UpdatesTableAdapter.Fill(frmPDPCDataGrid.Mysql_116925_pdpcDataSet2.updates)

        Dim newVersion As String = "0.0.0"

        newVersion = frmPDPCDataGrid.Mysql_116925_pdpcDataSet2.Tables("updates").Rows(0)(1).ToString
        downloadLink = frmPDPCDataGrid.Mysql_116925_pdpcDataSet2.Tables("updates").Rows(0)(2).ToString

        lblInstalled.Text = ("Installed Version : " + curVersion)
        lblNew.Text = ("New Version : " + newVersion)
    End Sub

    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        Process.Start(downloadLink)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Close()
        isExit = True
    End Sub
End Class