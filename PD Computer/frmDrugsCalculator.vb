Public Class frmDrugsCalculator

    Dim proCocaine As Integer = 3000
    Dim proWeed As Integer = 2500
    Dim proHeroin As Integer = 5000
    Dim proLSD As Integer = 2500
    Dim proMeth As Integer = 5250
    Dim Whale As Integer = 12000
    Dim Organs As Integer = 15000
    Dim unProLSD As Integer = 3250

    Dim selectedDrug As String = ""
    Dim singleCharge As Integer = 0


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmPDPCMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
        frmPDPCMenu.Close()
    End Sub

    Private Sub cbProcessed_CheckedChanged(sender As Object, e As EventArgs) Handles cbProcessed.CheckedChanged

    End Sub

    Private Sub btnCocaine_Click(sender As Object, e As EventArgs) Handles btnCocaine.Click
        selectedDrug = "Cocaine"
        singleCharge = proCocaine
        cbProcessed.Enabled = True
        lblSelectedDrug.Text = selectedDrug
    End Sub

    Private Sub btnWeed_Click(sender As Object, e As EventArgs) Handles btnWeed.Click
        selectedDrug = "Weed"
        singleCharge = proWeed
        cbProcessed.Enabled = True
        lblSelectedDrug.Text = selectedDrug
    End Sub

    Private Sub btnHeroin_Click(sender As Object, e As EventArgs) Handles btnHeroin.Click
        selectedDrug = "Heroin"
        singleCharge = proHeroin
        cbProcessed.Enabled = True
        lblSelectedDrug.Text = selectedDrug
    End Sub

    Private Sub btnLSD_Click(sender As Object, e As EventArgs) Handles btnLSD.Click
        selectedDrug = "LSD"
        singleCharge = proLSD
        cbProcessed.Enabled = True
        lblSelectedDrug.Text = selectedDrug
    End Sub

    Private Sub btnMeth_Click(sender As Object, e As EventArgs) Handles btnMeth.Click
        selectedDrug = "Meth"
        singleCharge = proMeth
        cbProcessed.Enabled = True
        lblSelectedDrug.Text = selectedDrug
    End Sub

    Private Sub btnWhale_Click(sender As Object, e As EventArgs) Handles btnWhale.Click
        selectedDrug = "Whale"
        singleCharge = Whale
        lblSelectedDrug.Text = selectedDrug
        cbProcessed.Checked = False
        cbProcessed.Enabled = False
    End Sub

    Private Sub btnOrgans_Click(sender As Object, e As EventArgs) Handles btnOrgans.Click
        selectedDrug = "Illegal Organs"
        singleCharge = Organs
        lblSelectedDrug.Text = selectedDrug
        cbProcessed.Checked = False
        cbProcessed.Enabled = False
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim DrugNum As String = txtDrugNum.Text
        Dim Processed As String = "False"
        Dim TotalBounty As Integer

        If txtDrugNum.Text = "" Then
            MsgBox("You must enter a number of drugs!")
            DrugNum = 0
        End If

        If cbProcessed.Checked Then
            Processed = "True"
        End If


        If Processed = "False" Then
            TotalBounty = DrugNum * singleCharge
            lblTotalBounty.Text = ("The total drugs bounty Is : $" & (TotalBounty))
        Else
            If selectedDrug = "Cocaine" Then
                TotalBounty = DrugNum * (singleCharge * 2)
                lblTotalBounty.Text = ("The total drugs bounty is : $" & (TotalBounty))
            ElseIf selectedDrug = "Weed" Then
                TotalBounty = DrugNum * (singleCharge * 2)
                lblTotalBounty.Text = ("The total drugs bounty is : $" & (TotalBounty))
            ElseIf selectedDrug = "Heroin" Then
                TotalBounty = DrugNum * (singleCharge * 2)
                lblTotalBounty.Text = ("The total drugs bounty is : $" & (TotalBounty))
            ElseIf selectedDrug = "Meth" Then
                TotalBounty = DrugNum * (singleCharge * 2)
                lblTotalBounty.Text = ("The total drugs bounty is : $" & (TotalBounty))
            ElseIf selectedDrug = "LSD" Then
                TotalBounty = DrugNum * unProLSD
                lblTotalBounty.Text = ("The total drugs bounty is : $" & (TotalBounty))
            ElseIf selectedDrug = "" Then
                MsgBox("You must enter a number of drugs!")
            Else
                MsgBox("Fatal Error!")
            End If

        End If

        If TotalBounty < 999 Then
            lblJailTime.Text = "No Charge"
        ElseIf TotalBounty > 999 And TotalBounty < 30001 Then
            lblJailTime.Text = "10 Minutes + $10,000 Fine"
        ElseIf TotalBounty > 30000 And TotalBounty < 70001 Then
            lblJailTime.Text = "15 Minutes + $15,000 Fine"
        ElseIf TotalBounty > 70000 And TotalBounty < 120001 Then
            lblJailTime.Text = "20 Minutes + $20,000 Fine"
        ElseIf TotalBounty > 120000 And TotalBounty < 250001 Then
            lblJailTime.Text = "30 Minutes + $30,000 Fine"
        ElseIf TotalBounty > 250000 And TotalBounty < 400001 Then
            lblJailTime.Text = "45 Minutes + $40,000 Fine"
        ElseIf TotalBounty > 400000 Then
            lblJailTime.Text = "60 Minutes + $50,000 Fine"
        Else
            MsgBox("Fatal Error")
        End If

        Processed = "False"
        TotalBounty = 0
    End Sub

End Class