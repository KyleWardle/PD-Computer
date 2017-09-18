Public Class frmPDPCJailTimes
    Dim Bribery As Integer = 10
    Dim ExcessSpeed As Integer = 10
    Dim Abuse911 As Integer = 15
    Dim Fail2Pay As Integer = 5
    Dim Trespass As Integer = 10
    Dim DUI As Integer = 12
    Dim WepDischarge As Integer = 10
    Dim Fail2Comply As Integer = 5
    Dim IllegalWep As Integer = 12
    Dim DrunkDriving As Integer = 12
    Dim DestructionProperty As Integer = 10
    Dim AssistingCriminal As Integer = 15
    Dim Evasion As Integer = 10
    Dim DragRace As Integer = 10
    Dim VechTheft As Integer = 15
    Dim Poaching As Integer = 15
    Dim ChopShop As Integer = 20
    Dim GasStation As Integer = 20
    Dim Robbery As Integer = 20
    Dim AttMurder As Integer = 20
    Dim GunTrafficking As Integer = 30
    Dim DestructionEvidence As Integer = 15
    Dim Rape As Integer = 25
    Dim murder As Integer = 30
    Dim Impersonate As Integer = 30
    Dim Trolling As Integer = 30
    Dim Corruption As Integer = 45
    Dim Bank As Integer = 45
    Dim Hostage As Integer = 50
    Dim JailBreak As Integer = 60
    Dim Terrorism As Integer = 60

    Dim BriberyNum As Integer = 0
    Dim ExcessSpeedNum As Integer = 0
    Dim Abuse911Num As Integer = 0
    Dim Fail2PayNum As Integer = 0
    Dim TrespassNum As Integer = 0
    Dim DUINum As Integer = 0
    Dim WepDischargeNum As Integer = 0
    Dim Fail2ComplyNum As Integer = 0
    Dim IllegalWepNum As Integer = 0
    Dim DrunkDrivingNum As Integer = 0
    Dim DestructionPropertyNum As Integer = 0
    Dim AssistingCriminalNum As Integer = 0
    Dim EvasionNum As Integer = 0
    Dim DragRaceNum As Integer = 0
    Dim VechTheftNum As Integer = 0
    Dim PoachingNum As Integer = 0
    Dim ChopShopNum As Integer = 0
    Dim GasStationNum As Integer = 0
    Dim RobberyNum As Integer = 0
    Dim AttMurderNum As Integer = 0
    Dim GunTraffickingNum As Integer = 0
    Dim DestructionEvidenceNum As Integer = 0
    Dim RapeNum As Integer = 0
    Dim murderNum As Integer = 0
    Dim ImpersonateNum As Integer = 0
    Dim TrollingNum As Integer = 0
    Dim CorruptionNum As Integer = 0
    Dim BankNum As Integer = 0
    Dim HostageNum As Integer = 0
    Dim JailBreakNum As Integer = 0
    Dim TerrorismNum As Integer = 0

    Dim Highest As Integer = 0
    Dim Total As Integer = -5
    Dim SavedTotal As Integer = 0
    Dim TotalFines As Integer = 0
    Dim PoachingVal As Integer = 0
    Private Sub btnMinor_Click(sender As Object, e As EventArgs) Handles btnMinor.Click
        btnAbuse911.Visible = True
        btnBribery.Visible = True
        btnDrunkDriving.Visible = True
        btnFail2Comply.Visible = True
        btnTrespass.Visible = True
        btnNoPayTicket.Visible = True
        btnWepDischarge.Visible = True
        btnUnderInfluence.Visible = True
        btnSpeeding.Visible = True

        btnIllegalWep.Visible = False
        btnPropertyDestruction.Visible = False
        btnAssistingWanted.Visible = False
        btnEvasion.Visible = False
        btnIllegalDragRace.Visible = False
        btnPoaching.Visible = False
        btnChopShop.Visible = False
        btnGasStationRobbery.Visible = False
        btnDestEvidence.Visible = False
        btnVecTheft.Visible = False

        btnRobbery.Visible = False
        btnAttMurder.Visible = False
        btnGunTrafficking.Visible = False
        btnRape.Visible = False
        btnMurder.Visible = False
        btnImpersonate.Visible = False
        btnTrolling.Visible = False
        btnCorruption.Visible = False
        btnBank.Visible = False
        btnHostage.Visible = False
        btnJailBreak.Visible = False
        btnTerrorism.Visible = False
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmPDPCMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
        frmPDPCMenu.Close()
    End Sub

    Private Sub btnMedium_Click(sender As Object, e As EventArgs) Handles btnMedium.Click
        btnIllegalWep.Visible = True
        btnPropertyDestruction.Visible = True
        btnAssistingWanted.Visible = True
        btnEvasion.Visible = True
        btnIllegalDragRace.Visible = True
        btnPoaching.Visible = True
        btnChopShop.Visible = True
        btnGasStationRobbery.Visible = True
        btnDestEvidence.Visible = True
        btnVecTheft.Visible = True

        btnAbuse911.Visible = False
        btnBribery.Visible = False
        btnDrunkDriving.Visible = False
        btnFail2Comply.Visible = False
        btnTrespass.Visible = False
        btnNoPayTicket.Visible = False
        btnWepDischarge.Visible = False
        btnUnderInfluence.Visible = False
        btnSpeeding.Visible = False

        btnRobbery.Visible = False
        btnAttMurder.Visible = False
        btnGunTrafficking.Visible = False
        btnRape.Visible = False
        btnMurder.Visible = False
        btnImpersonate.Visible = False
        btnTrolling.Visible = False
        btnCorruption.Visible = False
        btnBank.Visible = False
        btnHostage.Visible = False
        btnJailBreak.Visible = False
        btnTerrorism.Visible = False
    End Sub

    Private Sub btnMajor_Click(sender As Object, e As EventArgs) Handles btnMajor.Click
        btnRobbery.Visible = True
        btnAttMurder.Visible = True
        btnGunTrafficking.Visible = True
        btnRape.Visible = True
        btnMurder.Visible = True
        btnImpersonate.Visible = True
        btnTrolling.Visible = True
        btnCorruption.Visible = True
        btnBank.Visible = True
        btnHostage.Visible = True
        btnJailBreak.Visible = True
        btnTerrorism.Visible = True

        btnAbuse911.Visible = False
        btnBribery.Visible = False
        btnDrunkDriving.Visible = False
        btnFail2Comply.Visible = False
        btnTrespass.Visible = False
        btnNoPayTicket.Visible = False
        btnWepDischarge.Visible = False
        btnUnderInfluence.Visible = False
        btnSpeeding.Visible = False

        btnIllegalWep.Visible = False
        btnPropertyDestruction.Visible = False
        btnAssistingWanted.Visible = False
        btnEvasion.Visible = False
        btnIllegalDragRace.Visible = False
        btnPoaching.Visible = False
        btnChopShop.Visible = False
        btnGasStationRobbery.Visible = False
        btnDestEvidence.Visible = False
        btnVecTheft.Visible = False
    End Sub

    Private Sub btnPoaching_Click(sender As Object, e As EventArgs) Handles btnPoaching.Click
        lblPoaching.Visible = True
        txtPoaching.Visible = True
        btnPoachingConfirm.Visible = True
    End Sub

    Private Sub btnPoachingConfirm_Click(sender As Object, e As EventArgs) Handles btnPoachingConfirm.Click
        PoachingVal = txtPoaching.Text
        lblPoaching.Visible = False
        txtPoaching.Visible = False
        btnPoachingConfirm.Visible = False
        PoachingNum = PoachingNum + 1
        If Poaching > Highest And PoachingNum = 1 Then
            Highest = Poaching
            Total = Total + 5
        Else
            Total = Total + 5
        End If
        TotalFines = TotalFines + (5000 * PoachingVal)
        lstJailTimes.Items.Add("Poaching x " & PoachingVal)
    End Sub

    Private Sub btnRobbery_Click(sender As Object, e As EventArgs) Handles btnRobbery.Click
        RobberyNum = RobberyNum + 1
        If Robbery > Highest And RobberyNum = 1 Then
            Highest = Robbery
            Total = Total + 5
        Else
            Total = Total + 5
        End If
        lstJailTimes.Items.Add("Robbery")
        TotalFines = TotalFines + 50000
    End Sub

    Private Sub btnAttMurder_Click(sender As Object, e As EventArgs) Handles btnAttMurder.Click
        AttMurderNum = AttMurderNum + 1
        If AttMurder > Highest And AttMurderNum = 1 Then
            Highest = AttMurder
            Total = Total + 5
        Else
            Total = Total + 5
        End If
        lstJailTimes.Items.Add("Attempted Murder")
    End Sub

    Private Sub btnCorruption_Click(sender As Object, e As EventArgs) Handles btnCorruption.Click
        CorruptionNum = CorruptionNum + 1
        If Corruption > Highest And CorruptionNum = 1 Then
            Highest = Corruption
            Total = Total + 5
        Else
            Total = Total + 5
        End If
        lstJailTimes.Items.Add("Government Corruption")
    End Sub

    Private Sub btnGunTrafficking_Click(sender As Object, e As EventArgs) Handles btnGunTrafficking.Click
        GunTraffickingNum = GunTraffickingNum + 1
        If GunTrafficking > Highest And GunTraffickingNum = 1 Then
            Highest = GunTrafficking
            Total = Total + 5
        Else
            Total = Total + 5
        End If
        lstJailTimes.Items.Add("Illegal Gun Trafficking")
    End Sub

    Private Sub btnRape_Click(sender As Object, e As EventArgs) Handles btnRape.Click
        RapeNum = RapeNum + 1
        If Rape > Highest And RapeNum = 1 Then
            Highest = Rape
            Total = Total + 5
        Else
            Total = Total + 5
        End If
        lstJailTimes.Items.Add("Rape")
    End Sub

    Private Sub btnMurder_Click(sender As Object, e As EventArgs) Handles btnMurder.Click
        murderNum = murderNum + 1
        If murder > Highest And murderNum = 1 Then
            Highest = murder
            Total = Total + 5
        Else
            Total = Total + 30
        End If
        lstJailTimes.Items.Add("Murder")
    End Sub

    Private Sub btnImpersonate_Click(sender As Object, e As EventArgs) Handles btnImpersonate.Click
        ImpersonateNum = ImpersonateNum + 1
        If Impersonate > Highest And ImpersonateNum = 1 Then
            Highest = Impersonate
            Total = Total + 5
        Else
            Total = Total + 5
        End If
        lstJailTimes.Items.Add("Impersonating a police officer")
    End Sub

    Private Sub btnTrolling_Click(sender As Object, e As EventArgs) Handles btnTrolling.Click
        TrollingNum = TrollingNum + 1
        If Trolling > Highest And TrollingNum = 1 Then
            Highest = Trolling
            Total = Total + 5
        Else
            Total = Total + 5
        End If
        lstJailTimes.Items.Add("Trolling / Obstruction Of justice")
    End Sub

    Private Sub btnBank_Click(sender As Object, e As EventArgs) Handles btnBank.Click
        BankNum = BankNum + 1
        If Bank > Highest And BankNum = 1 Then
            Highest = Bank
            Total = Total + 5
        Else
            Total = Total + 5
        End If
        lstJailTimes.Items.Add("Bank / Casino Robbery")
        MsgBox("Fine for amount stolen")
    End Sub

    Private Sub btnHostage_Click(sender As Object, e As EventArgs) Handles btnHostage.Click
        HostageNum = HostageNum + 1
        If Hostage > Highest And HostageNum = 1 Then
            Highest = Hostage
            Total = Total + 5
        Else
            Total = Total + 5
        End If
        lstJailTimes.Items.Add("Hostage Taking")
        MsgBox("Fine for the amount paid for the hostage")
    End Sub

    Private Sub btnIllegalWep_Click(sender As Object, e As EventArgs) Handles btnIllegalWep.Click
        IllegalWepNum = IllegalWepNum + 1
        If IllegalWep > Highest And IllegalWepNum = 1 Then
            Highest = IllegalWep
            Total = Total + 5
        Else
            Total = Total + 5
        End If
        lstJailTimes.Items.Add("Illegal Weapon")
        TotalFines = TotalFines + 60000
    End Sub

    Private Sub btnBribery_Click(sender As Object, e As EventArgs) Handles btnBribery.Click
        BriberyNum = BriberyNum + 1
        If Bribery > Highest And BriberyNum = 1 Then
            Highest = Bribery
            Total = Total + 5
        Else
            Total = Total + 5
        End If
        lstJailTimes.Items.Add("Bribery")
    End Sub

    Private Sub btnPropertyDestruction_Click(sender As Object, e As EventArgs) Handles btnPropertyDestruction.Click
        DestructionPropertyNum = DestructionPropertyNum + 1
        If DestructionProperty > Highest And DestructionPropertyNum = 1 Then
            Highest = DestructionProperty
            Total = Total + 5
        Else
            Total = Total + 5
        End If
        lstJailTimes.Items.Add("Destruction of Property")
        TotalFines = TotalFines + 30000
    End Sub

    Private Sub btnSpeeding_Click(sender As Object, e As EventArgs) Handles btnSpeeding.Click
        ExcessSpeedNum = ExcessSpeedNum + 1
        If ExcessSpeed > Highest And ExcessSpeedNum = 1 Then
            Highest = ExcessSpeed
            Total = Total + 5
        Else
            Total = Total + 5
        End If
        lstJailTimes.Items.Add("Excessive Speeding")
    End Sub

    Private Sub btnAssistingWanted_Click(sender As Object, e As EventArgs) Handles btnAssistingWanted.Click
        AssistingCriminalNum = AssistingCriminalNum + 1
        If AssistingCriminal > Highest And AssistingCriminalNum = 1 Then
            Highest = AssistingCriminal
            Total = Total + 5
        Else
            Total = Total + 5
        End If
        lstJailTimes.Items.Add("Assisting A Wanted Criminal")
    End Sub

    Private Sub btnAbuse911_Click(sender As Object, e As EventArgs) Handles btnAbuse911.Click
        Abuse911Num = Abuse911Num + 1
        If Abuse911 > Highest And Abuse911Num = 1 Then
            Highest = Abuse911
            Total = Total + 5
        Else
            Total = Total + 5
        End If
        TotalFines = TotalFines + 40000
        lstJailTimes.Items.Add("Abusing the 911 system")
    End Sub

    Private Sub btnEvasion_Click(sender As Object, e As EventArgs) Handles btnEvasion.Click
        EvasionNum = EvasionNum + 1
        If Evasion > Highest And EvasionNum = 1 Then
            Highest = Evasion
            Total = Total + 5
        Else
            Total = Total + 5
        End If
        lstJailTimes.Items.Add("Evasion")
    End Sub

    Private Sub btnNoPayTicket_Click(sender As Object, e As EventArgs) Handles btnNoPayTicket.Click
        Fail2PayNum = Fail2PayNum + 1
        If Fail2Pay > Highest And Fail2PayNum = 1 Then
            Highest = Fail2Pay
            Total = Total + 5
        Else
            Total = Total + 5
        End If
        lstJailTimes.Items.Add("Failure to pay a ticket")
    End Sub

    Private Sub btnIllegalDragRace_Click(sender As Object, e As EventArgs) Handles btnIllegalDragRace.Click
        DragRaceNum = DragRaceNum + 1
        If DragRace > Highest And DragRaceNum = 1 Then
            Highest = DragRace
            Total = Total + 5
        Else
            Total = Total + 5
        End If
        lstJailTimes.Items.Add("Illegal Drag Race")
        TotalFines = TotalFines + 60000
    End Sub

    Private Sub btnTrespass_Click(sender As Object, e As EventArgs) Handles btnTrespass.Click
        TrespassNum = TrespassNum + 1
        If Trespass > Highest And TrespassNum = 1 Then
            Highest = Trespass
            Total = Total + 5
        Else
            Total = Total + 5
        End If
        lstJailTimes.Items.Add("Trespassing on government property")

    End Sub

    Private Sub btnVecTheft_Click(sender As Object, e As EventArgs) Handles btnVecTheft.Click
        VechTheftNum = VechTheftNum + 1
        If VechTheft > Highest And VechTheftNum = 1 Then
            Highest = VechTheft
            Total = Total + 5
        Else
            Total = Total + 5
        End If
        lstJailTimes.Items.Add("Vehicle Theft")
    End Sub

    Private Sub btnUnderInfluence_Click(sender As Object, e As EventArgs) Handles btnUnderInfluence.Click
        DUINum = DUINum + 1
        If DUI > Highest And DUINum = 1 Then
            Highest = DUI
            Total = Total + 5
        Else
            Total = Total + 5
        End If
        lstJailTimes.Items.Add("Driving Under the influence")
    End Sub

    Private Sub btnWepDischarge_Click(sender As Object, e As EventArgs) Handles btnWepDischarge.Click
        WepDischargeNum = WepDischargeNum + 1
        If WepDischarge > Highest And WepDischargeNum = 1 Then
            Highest = WepDischarge
            Total = Total + 5
        Else
            Total = Total + 5
        End If
        lstJailTimes.Items.Add("Weapon Discharge (In City)")
        TotalFines = TotalFines + 40000
    End Sub

    Private Sub btnChopShop_Click(sender As Object, e As EventArgs) Handles btnChopShop.Click
        ChopShopNum = ChopShopNum + 1
        If ChopShop > Highest And ChopShopNum = 1 Then
            Highest = ChopShop
            Total = Total + 5
        Else
            Total = Total + 5
        End If
        lstJailTimes.Items.Add("Illegal Chop Shop")
    End Sub

    Private Sub btnFail2Comply_Click(sender As Object, e As EventArgs) Handles btnFail2Comply.Click
        Fail2ComplyNum = Fail2ComplyNum + 1
        If Fail2Comply > Highest And Fail2ComplyNum = 1 Then
            Highest = Fail2Comply
            Total = Total + 5
        Else
            Total = Total + 5
        End If
        lstJailTimes.Items.Add("Failure to comply")
    End Sub

    Private Sub btnGasStationRobbery_Click(sender As Object, e As EventArgs) Handles btnGasStationRobbery.Click
        GasStationNum = GasStationNum + 1
        If GasStation > Highest And GasStationNum = 1 Then
            Highest = GasStation
            Total = Total + 5
        Else
            Total = Total + 5
        End If
        lstJailTimes.Items.Add("Gas Station Robbery")
        TotalFines = TotalFines + 25000
    End Sub

    Private Sub btnDrunkDriving_Click(sender As Object, e As EventArgs) Handles btnDrunkDriving.Click
        DrunkDrivingNum = DrunkDrivingNum + 1
        If DrunkDriving > Highest And DrunkDrivingNum = 1 Then
            Highest = DrunkDriving
            Total = Total + 5
        Else
            Total = Total + 5
        End If
        lstJailTimes.Items.Add("Drunk Driving")
        TotalFines = TotalFines + 25000
    End Sub

    Private Sub btnDestEvidence_Click(sender As Object, e As EventArgs) Handles btnDestEvidence.Click
        DestructionEvidenceNum = DestructionEvidenceNum + 1
        If DestructionEvidence > Highest And DestructionEvidenceNum = 1 Then
            Highest = DestructionEvidence
            Total = Total + 5
        Else
            Total = Total + 5
        End If
        lstJailTimes.Items.Add("Destruction of Evidence")
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim file As System.IO.StreamWriter
        Dim Name As String
        Dim MyArray(Me.lstJailTimes.Items.Count) As String
        Me.lstJailTimes.Items.CopyTo(MyArray, 0)
        Dim value As String = String.Join(" | ", MyArray)
        Name = txtName.Text
        If (Total + Highest > 60) And Name.Length > 0 Then
            SavedTotal = Total
            Total = 60
            lblJailTotal.Text = Total & " Minutes"
            lblTotalFines.Text = "$" & TotalFines
            file = My.Computer.FileSystem.OpenTextFileWriter("JailTimes.txt", True)
            If rtxtSitReport.Text <> "" Then
                file.WriteLine(Name & " | " & Total & " Minutes | $" & TotalFines & " | " & value & " Situation Report : [ " & rtxtSitReport.Text & " ] |")
            Else
                file.WriteLine(Name & " | " & Total & " Minutes | $" & TotalFines & " | " & value)
            End If
            file.Close()
            Total = SavedTotal
            MsgBox("Added to database")
            ElseIf Name.Length > 0 And (Total + Highest > 0) Then
                Total = Total + Highest
                file = My.Computer.FileSystem.OpenTextFileWriter("JailTimes.txt", True)
            If rtxtSitReport.Text <> "" Then
                file.WriteLine(Name & " | " & Total & " Minutes | $" & TotalFines & " | " & value & " Situation Report : [ " & rtxtSitReport.Text & " ] |")
            Else
                file.WriteLine(Name & " | " & Total & " Minutes | $" & TotalFines & " | " & value)
            End If
            file.Close()
                lblJailTotal.Text = Total & " Minutes"
                lblTotalFines.Text = "$" & TotalFines
                Total = Total - Highest
                MsgBox("Added to database")
            Else
                MsgBox("No Name / No Fine")
        End If
    End Sub

    Private Sub btnJailBreak_Click(sender As Object, e As EventArgs) Handles btnJailBreak.Click
        JailBreakNum = JailBreakNum + 1
        If JailBreak > Highest And JailBreakNum = 1 Then
            Highest = JailBreak
            Total = Total + 5
        Else
            Total = Total + 5
        End If
        lstJailTimes.Items.Add("JailBreak")
    End Sub

    Private Sub btnTerrorism_Click(sender As Object, e As EventArgs) Handles btnTerrorism.Click
        TerrorismNum = TerrorismNum + 1
        If Terrorism > Highest And TerrorismNum = 1 Then
            Highest = Terrorism
            Total = Total + 5
        Else
            Total = Total + 5
        End If
        lstJailTimes.Items.Add("Terrorism")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        TotalFines = 0
        lblTotalFines.Text = "$0"
        lblJailTotal.Text = "0 Minutes"
        Total = -5
        lstJailTimes.Items.Clear()
        Highest = 0
        SavedTotal = 0
        PoachingVal = 0

        BriberyNum = 0
        ExcessSpeedNum = 0
        Abuse911Num = 0
        Fail2PayNum = 0
        TrespassNum = 0
        DUINum = 0
        WepDischargeNum = 0
        Fail2ComplyNum = 0
        IllegalWepNum = 0
        DrunkDrivingNum = 0
        DestructionPropertyNum = 0
        AssistingCriminalNum = 0
        EvasionNum = 0
        DragRaceNum = 0
        VechTheftNum = 0
        PoachingNum = 0
        ChopShopNum = 0
        GasStationNum = 0
        RobberyNum = 0
        AttMurderNum = 0
        GunTraffickingNum = 0
        DestructionEvidenceNum = 0
        RapeNum = 0
        murderNum = 0
        ImpersonateNum = 0
        TrollingNum = 0
        CorruptionNum = 0
        BankNum = 0
        HostageNum = 0
        JailBreakNum = 0
        TerrorismNum = 0
    End Sub
End Class