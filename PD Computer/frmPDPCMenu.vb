Public Class frmPDPCMenu
    Public tmrTime As New Stopwatch
    Public Shared curVersion
    Public Shared isExit
    Private Sub btnTickets_Click(sender As Object, e As EventArgs) Handles btnTickets.Click
        Me.Visible = False
        frmPDPCTickets.ShowDialog()
    End Sub

    Private Sub btnStartShift_Click(sender As Object, e As EventArgs) Handles btnStartShift.Click
        btnStartShift.Visible = False
        btnEndShift.Visible = True
        tmrTime.Start()
    End Sub

    Private Sub btnEndShift_Click(sender As Object, e As EventArgs) Handles btnEndShift.Click
        btnEndShift.Visible = False
        btnStartShift.Visible = True
        tmrTime.Stop()
    End Sub

    Private Sub btnTimeUpdate_Click(sender As Object, e As EventArgs) Handles btnTimeUpdate.Click
        Dim mHours As Long, mMinutes As Long, mSeconds As Long
        mSeconds = Math.Round(tmrTime.ElapsedTicks / Stopwatch.Frequency)
        mHours = mSeconds \ 3600
        mMinutes = (mSeconds - (mHours * 3600)) \ 60
        mSeconds = mSeconds - ((mHours * 3600) + (mMinutes * 60))
        MsgBox("You have been playing for: " & mHours & "hrs " & mMinutes & "mins " & mSeconds & "secs")
    End Sub

    Private Sub btnJail_Click(sender As Object, e As EventArgs) Handles btnJail.Click
        Me.Visible = False
        frmPDPCJailTimes.ShowDialog()
    End Sub

    Private Sub btnSitRep_Click(sender As Object, e As EventArgs) Handles btnSitRep.Click
        frmPDPCSitReport.ShowDialog()
    End Sub

    Private Sub btnDrugsCalculator_Click(sender As Object, e As EventArgs) Handles btnDrugsCalculator.Click
        frmDrugsCalculator.ShowDialog()
    End Sub

    Private Sub frmPDPCMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'PDPCSplash.PBLoad.Value = 10
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection
        Dim myConnectionString As String
        'PDPCSplash.PBLoad.Value = 20

        myConnectionString = "server=my03.winhost.com;" _
            & "uid=kylew;" _
            & "pwd=Kmankx23;" _
            & "database=mysql_116925_pdpc"
        'PDPCSplash.PBLoad.Value = 40

        Try
            conn.ConnectionString = myConnectionString
            conn.Open()
            'PDPCSplash.PBLoad.Value = 70
            'MsgBox("Connection Created")

        Catch ex As MySql.Data.MySqlClient.MySqlException
            'PDPCSplash.PBLoad.Value = 100
            MessageBox.Show(Me, TopMost = True, ex.Message)
        End Try

        frmPDPCUpdateInfo.Close()

        Dim newVersion As String

        frmPDPCDataGrid.UpdatesTableAdapter.Fill(frmPDPCDataGrid.Mysql_116925_pdpcDataSet2.updates)
        newVersion = frmPDPCDataGrid.Mysql_116925_pdpcDataSet2.Tables("updates").Rows(0)(1).ToString
        'PDPCSplash.PBLoad.Value = 90

        If (Not (newVersion = curVersion)) Then
            frmPDPCUpdateInfo.ShowDialog()
        End If
        'PDPCSplash.PBLoad.Value = 100
    End Sub
End Class
