Public Class frmPDPCTickets
    Dim Jaywalking As Integer = 4000
    Dim StopSign As Integer = 8000
    Dim RedLight As Integer = 8000
    Dim NoLights As Integer = 10000
    Dim OffRoading As Integer = 30000
    Dim Speeding As Integer = 20000
    Dim RecklessDriving As Integer = 35000
    Dim CrackedWinshield As Integer = 15000
    Dim ImpedingTraffic As Integer = 12000
    Dim NotStreetLegal As Integer = 20000
    Dim DrunkDriving As Integer = 25000
    Dim BOP As Integer = 20000
    Dim Abuse911 As Integer = 40000
    Dim DrivingNoLicense As Integer = 35000
    Dim LandHeli As Integer = 40000
    Dim AirRoad As Integer = 60000
    Dim UnholsteredWep As Integer = 40000
    Dim NoYield As Integer = 50000
    Dim WepNoLicense As Integer = 60000
    Dim VehicleNoLicense As Integer = 50000
    Dim TerrorVehicle As Integer = 100000
    Dim TotalFine As Integer = 0
    Dim SpeedOver As Integer = 0

    Private Sub btnSpeeding_Click(sender As Object, e As EventArgs) Handles btnSpeeding.Click
        txtSpeeding.Visible = True
        lblSpeeding.Visible = True
        lblSpeeding2.Visible = True
        btnSpeedingConfirm.Visible = True
    End Sub

    Private Sub btnSpeedingConfirm_Click(sender As Object, e As EventArgs) Handles btnSpeedingConfirm.Click
        txtSpeeding.Visible = False
        lblSpeeding.Visible = False
        lblSpeeding2.Visible = False
        btnSpeedingConfirm.Visible = False
        SpeedOver = txtSpeeding.Text
        If SpeedOver >= 0 And SpeedOver <= 9 Then
            MsgBox("No fine")
            SpeedOver = 0
        ElseIf SpeedOver > 9 And SpeedOver <= 19 Then
            SpeedOver = 1
        ElseIf SpeedOver > 19 And SpeedOver <= 29 Then
            SpeedOver = 2
        ElseIf SpeedOver > 29 And SpeedOver <= 39 Then
            SpeedOver = 3
        ElseIf SpeedOver > 39 And SpeedOver <= 49 Then
            SpeedOver = 4
        ElseIf SpeedOver > 49 And SpeedOver <= 59 Then
            SpeedOver = 5
        ElseIf SpeedOver > 59 Then
            MsgBox("Excessive Speeding, Take to jail")
        Else
            MsgBox("Invalid Number")
        End If
        If SpeedOver > 0 And SpeedOver < 6 Then
            lstTickets.Items.Add("Speeding - $" & (Speeding * SpeedOver))
            TotalFine = TotalFine + (Speeding * SpeedOver)
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
        frmPDPCMenu.Close()
    End Sub

    Private Sub btnDrivingWithoutLs_Click(sender As Object, e As EventArgs) Handles btnDrivingWithoutLs.Click
        MsgBox("Please impound their Car")
        lstTickets.Items.Add("Driving without a License - $" & DrivingNoLicense)
        TotalFine = TotalFine + DrivingNoLicense
    End Sub

    Private Sub btnHeliLand_Click(sender As Object, e As EventArgs) Handles btnHeliLand.Click
        MsgBox("Please impound their Helicopter")
        lstTickets.Items.Add("Landing a Helicopter within city limits - $" & LandHeli)
        TotalFine = TotalFine + LandHeli
    End Sub

    Private Sub btnAironRoad_Click(sender As Object, e As EventArgs) Handles btnAironRoad.Click
        MsgBox("Please impound their Helicopter")
        lstTickets.Items.Add("Air Vehicle on Road - $" & AirRoad)
        TotalFine = TotalFine + AirRoad
    End Sub

    Private Sub btnUnholsWep_Click(sender As Object, e As EventArgs) Handles btnUnholsWep.Click
        MsgBox("Seize their weapon from them too")
        lstTickets.Items.Add("Unholstered Weapon in City - $" & UnholsteredWep)
        TotalFine = TotalFine + UnholsteredWep
    End Sub

    Private Sub btnFailure2Yield_Click(sender As Object, e As EventArgs) Handles btnFailure2Yield.Click
        MsgBox("Impound their Vehicle")
        lstTickets.Items.Add("Failure to Yield - $" & NoYield)
        TotalFine = TotalFine + NoYield
    End Sub

    Private Sub btnWeaponNoLicense_Click(sender As Object, e As EventArgs) Handles btnWeaponNoLicense.Click
        MsgBox("Seize their weapon")
        lstTickets.Items.Add("Unlicensed Weapon - $" & WepNoLicense)
        TotalFine = TotalFine + WepNoLicense
    End Sub

    Private Sub btnVehicleNoLicense_Click(sender As Object, e As EventArgs) Handles btnVehicleNoLicense.Click
        MsgBox("Impound their vehicle")
        lstTickets.Items.Add("Vehicle with No License - $" & VehicleNoLicense)
        TotalFine = TotalFine + VehicleNoLicense
    End Sub

    Private Sub btnTerror_Click(sender As Object, e As EventArgs) Handles btnTerror.Click
        MsgBox("Impound their vehicle")
        lstTickets.Items.Add("Driving a Terror Vehicle - $" & TerrorVehicle)
        TotalFine = TotalFine + TerrorVehicle
    End Sub

    Private Sub btnJaywalking_Click(sender As Object, e As EventArgs) Handles btnJaywalking.Click
        lstTickets.Items.Add("JayWalking - $" & Jaywalking)
        TotalFine = TotalFine + Jaywalking
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnConfirmFine.Click
        frmPDPCDataGrid.FinesTableAdapter.Fill(frmPDPCDataGrid.FinesTableAdapater.fines)

        'Dim file As System.IO.StreamWriter
        Dim Name As String
        Dim RowCount As Integer
        Dim MyArray(Me.lstTickets.Items.Count) As String
        Me.lstTickets.Items.CopyTo(MyArray, 0)
        Dim value As String = String.Join(" | ", MyArray)
        Name = txtName.Text
        If Name.Length > 0 And TotalFine > 0 Then
            RowCount = frmPDPCDataGrid.FinesTableAdapater.Tables("fines").Rows.Count
            frmPDPCDataGrid.FinesTableAdapater.Tables("fines").Rows.Add(New String() {(RowCount + 1), Name, TotalFine, value})
            'file = My.Computer.FileSystem.OpenTextFileWriter("Fines.txt", True)  
            'file.WriteLine(Name & " | $" & TotalFine & " | " & value)
            'file.Close()
            lblTotalFine.Text = ("$" & TotalFine)
            frmPDPCDataGrid.FinesTableAdapter.Update(frmPDPCDataGrid.FinesTableAdapater.fines)
            MsgBox("Fine Added to the database")
        Else
            MsgBox("No Name / No Fine")
        End If
    End Sub

    Private Sub btnStopSign_Click(sender As Object, e As EventArgs) Handles btnStopSign.Click
        lstTickets.Items.Add("Running Stop Sign - $" & StopSign)
        TotalFine = TotalFine + StopSign
    End Sub

    Private Sub btnRedLight_Click(sender As Object, e As EventArgs) Handles btnRedLight.Click
        lstTickets.Items.Add("Running Red Light - $" & RedLight)
        TotalFine = TotalFine + RedLight
    End Sub

    Private Sub btnNoLights_Click(sender As Object, e As EventArgs) Handles btnNoLights.Click
        lstTickets.Items.Add("Driving with No Lights - $" & NoLights)
        TotalFine = TotalFine + NoLights
    End Sub

    Private Sub btnOffRoading_Click(sender As Object, e As EventArgs) Handles btnOffRoading.Click
        lstTickets.Items.Add("Off Roading - $" & OffRoading)
        TotalFine = TotalFine + OffRoading
    End Sub

    Private Sub btnReckless_Click(sender As Object, e As EventArgs) Handles btnReckless.Click
        lstTickets.Items.Add("Reckless Driving - $" & RecklessDriving)
        TotalFine = TotalFine + RecklessDriving
    End Sub

    Private Sub btnWindshield_Click(sender As Object, e As EventArgs) Handles btnWindshield.Click
        lstTickets.Items.Add("Cracked Windshield - $" & CrackedWinshield)
        TotalFine = TotalFine + CrackedWinshield
    End Sub

    Private Sub btnImpedingTraffic_Click(sender As Object, e As EventArgs) Handles btnImpedingTraffic.Click
        lstTickets.Items.Add("Impeding Traffic - $" & ImpedingTraffic)
        TotalFine = TotalFine + ImpedingTraffic
    End Sub

    Private Sub btnNotStreetLegal_Click(sender As Object, e As EventArgs) Handles btnNotStreetLegal.Click
        lstTickets.Items.Add("Vehicle Not Street Legal - $" & NotStreetLegal)
        TotalFine = TotalFine + NotStreetLegal
    End Sub

    Private Sub btnDrunkDriving_Click(sender As Object, e As EventArgs) Handles btnDrunkDriving.Click
        lstTickets.Items.Add("Drunk Driving - $" & DrunkDriving)
        TotalFine = TotalFine + DrunkDriving
    End Sub

    Private Sub btnBOP_Click(sender As Object, e As EventArgs) Handles btnBOP.Click
        lstTickets.Items.Add("Breach of Peace - $" & BOP)
        TotalFine = TotalFine + BOP
    End Sub

    Private Sub btnAbuse911_Click(sender As Object, e As EventArgs) Handles btnAbuse911.Click
        lstTickets.Items.Add("Abusing 911 system - $" & Abuse911)
        TotalFine = TotalFine + Abuse911
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstTickets.Items.Clear()
        TotalFine = 0
        lblTotalFine.Text = "$0"
    End Sub

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        frmPDPCMenu.Show()
        Me.Close()
    End Sub
End Class