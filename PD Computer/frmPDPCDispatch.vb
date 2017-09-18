Public Class frmPDPCDispatch
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
        frmPDPCMenu.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub frmPDPCDispatch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Unit3.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Unit1.Font = New Font(Unit1.Font, FontStyle.Bold)
            CheckBox56.Checked = True
            CheckBox56.BackColor = Color.Lime
            CheckBox72.Checked = False
            CheckBox72.BackColor = Color.Red
        Else
            Unit1.Font = New Font(Unit1.Font, FontStyle.Regular)
            CheckBox56.Checked = False
            CheckBox72.Checked = False
            CheckBox56.BackColor = Color.White
            CheckBox72.BackColor = Color.White
        End If
    End Sub

    Private Sub CheckBox56_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox56.CheckedChanged
        If CheckBox56.Checked = True Then
            CheckBox72.Checked = False
        End If
    End Sub

    Private Sub CheckBox72_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox72.CheckedChanged
        If CheckBox72.Checked = True Then
            CheckBox56.Checked = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Unit2.Font = New Font(Unit2.Font, FontStyle.Bold)
            CheckBox55.Checked = True
            CheckBox55.BackColor = Color.Lime
            CheckBox71.Checked = False
            CheckBox71.BackColor = Color.Red
        Else
            Unit2.Font = New Font(Unit2.Font, FontStyle.Regular)
            CheckBox55.Checked = False
            CheckBox71.Checked = False
            CheckBox55.BackColor = Color.White
            CheckBox71.BackColor = Color.White
        End If
    End Sub

    Private Sub CheckBox55_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox55.CheckedChanged
        If CheckBox55.Checked = True Then
            CheckBox71.Checked = False
        End If
    End Sub

    Private Sub CheckBox71_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox71.CheckedChanged
        If CheckBox71.Checked = True Then
            CheckBox55.Checked = False
        End If
    End Sub

    Private Sub Checkbox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            Unit3.Font = New Font(Unit3.Font, FontStyle.Bold)
            CheckBox54.Checked = True
            CheckBox54.BackColor = Color.Lime
            CheckBox70.Checked = False
            CheckBox70.BackColor = Color.Red
        Else
            Unit3.Font = New Font(Unit3.Font, FontStyle.Regular)
            CheckBox54.Checked = False
            CheckBox70.Checked = False
            CheckBox54.BackColor = Color.White
            CheckBox70.BackColor = Color.White
        End If
    End Sub

    Private Sub CheckBox54_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox54.CheckedChanged
        If CheckBox54.Checked = True Then
            CheckBox70.Checked = False
        End If
    End Sub

    Private Sub CheckBox70_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox70.CheckedChanged
        If CheckBox70.Checked = True Then
            CheckBox54.Checked = False
        End If
    End Sub
    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            Unit4.Font = New Font(Unit4.Font, FontStyle.Bold)
            CheckBox53.Checked = True
            CheckBox53.BackColor = Color.Lime
            CheckBox69.Checked = False
            CheckBox69.BackColor = Color.Red
        Else
            Unit4.Font = New Font(Unit4.Font, FontStyle.Regular)
            CheckBox53.Checked = False
            CheckBox69.Checked = False
            CheckBox53.BackColor = Color.White
            CheckBox69.BackColor = Color.White
        End If
    End Sub

    Private Sub CheckBox53_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox53.CheckedChanged
        If CheckBox53.Checked = True Then
            CheckBox69.Checked = False
        End If
    End Sub

    Private Sub CheckBox69_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox69.CheckedChanged
        If CheckBox69.Checked = True Then
            CheckBox53.Checked = False
        End If
    End Sub
    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            Unit5.Font = New Font(Unit5.Font, FontStyle.Bold)
            CheckBox52.Checked = True
            CheckBox52.BackColor = Color.Lime
            CheckBox68.Checked = False
            CheckBox68.BackColor = Color.Red
        Else
            Unit5.Font = New Font(Unit5.Font, FontStyle.Regular)
            CheckBox52.Checked = False
            CheckBox68.Checked = False
            CheckBox52.BackColor = Color.White
            CheckBox68.BackColor = Color.White
        End If
    End Sub

    Private Sub CheckBox52_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox52.CheckedChanged
        If CheckBox52.Checked = True Then
            CheckBox68.Checked = False
        End If
    End Sub

    Private Sub CheckBox68_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox68.CheckedChanged
        If CheckBox68.Checked = True Then
            CheckBox52.Checked = False
        End If
    End Sub
    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            Unit6.Font = New Font(Unit6.Font, FontStyle.Bold)
            CheckBox51.Checked = True
            CheckBox51.BackColor = Color.Lime
            CheckBox67.Checked = False
            CheckBox67.BackColor = Color.Red
        Else
            Unit6.Font = New Font(Unit6.Font, FontStyle.Regular)
            CheckBox51.Checked = False
            CheckBox67.Checked = False
            CheckBox51.BackColor = Color.White
            CheckBox67.BackColor = Color.White
        End If
    End Sub

    Private Sub CheckBox51_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox51.CheckedChanged
        If CheckBox51.Checked = True Then
            CheckBox67.Checked = False
        End If
    End Sub

    Private Sub CheckBox67_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox67.CheckedChanged
        If CheckBox67.Checked = True Then
            CheckBox51.Checked = False
        End If
    End Sub
    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            Unit7.Font = New Font(Unit7.Font, FontStyle.Bold)
            CheckBox50.Checked = True
            CheckBox50.BackColor = Color.Lime
            CheckBox66.Checked = False
            CheckBox66.BackColor = Color.Red
        Else
            Unit7.Font = New Font(Unit7.Font, FontStyle.Regular)
            CheckBox50.Checked = False
            CheckBox66.Checked = False
            CheckBox50.BackColor = Color.White
            CheckBox66.BackColor = Color.White
        End If
    End Sub

    Private Sub CheckBox50_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox50.CheckedChanged
        If CheckBox50.Checked = True Then
            CheckBox66.Checked = False
        End If
    End Sub

    Private Sub CheckBox66_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox66.CheckedChanged
        If CheckBox66.Checked = True Then
            CheckBox50.Checked = False
        End If
    End Sub
    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked = True Then
            Unit8.Font = New Font(Unit8.Font, FontStyle.Bold)
            CheckBox49.Checked = True
            CheckBox49.BackColor = Color.Lime
            CheckBox65.Checked = False
            CheckBox65.BackColor = Color.Red
        Else
            Unit8.Font = New Font(Unit8.Font, FontStyle.Regular)
            CheckBox49.Checked = False
            CheckBox65.Checked = False
            CheckBox49.BackColor = Color.White
            CheckBox65.BackColor = Color.White
        End If
    End Sub

    Private Sub CheckBox49_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox49.CheckedChanged
        If CheckBox49.Checked = True Then
            CheckBox65.Checked = False
        End If
    End Sub

    Private Sub CheckBox65_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox65.CheckedChanged
        If CheckBox65.Checked = True Then
            CheckBox49.Checked = False
        End If
    End Sub
    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox9.Checked = True Then
            Unit9.Font = New Font(Unit9.Font, FontStyle.Bold)
            CheckBox48.Checked = True
            CheckBox48.BackColor = Color.Lime
            CheckBox64.Checked = False
            CheckBox64.BackColor = Color.Red
        Else
            Unit9.Font = New Font(Unit9.Font, FontStyle.Regular)
            CheckBox48.Checked = False
            CheckBox64.Checked = False
            CheckBox48.BackColor = Color.White
            CheckBox64.BackColor = Color.White
        End If
    End Sub

    Private Sub CheckBox48_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox48.CheckedChanged
        If CheckBox48.Checked = True Then
            CheckBox64.Checked = False
        End If
    End Sub

    Private Sub CheckBox64_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox64.CheckedChanged
        If CheckBox64.Checked = True Then
            CheckBox48.Checked = False
        End If
    End Sub
    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox10.Checked = True Then
            Unit10.Font = New Font(Unit10.Font, FontStyle.Bold)
            CheckBox47.Checked = True
            CheckBox47.BackColor = Color.Lime
            CheckBox63.Checked = False
            CheckBox63.BackColor = Color.Red
        Else
            Unit10.Font = New Font(Unit10.Font, FontStyle.Regular)
            CheckBox47.Checked = False
            CheckBox63.Checked = False
            CheckBox47.BackColor = Color.White
            CheckBox63.BackColor = Color.White
        End If
    End Sub

    Private Sub CheckBox47_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox47.CheckedChanged
        If CheckBox47.Checked = True Then
            CheckBox63.Checked = False
        End If
    End Sub

    Private Sub CheckBox63_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox63.CheckedChanged
        If CheckBox63.Checked = True Then
            CheckBox47.Checked = False
        End If
    End Sub
End Class