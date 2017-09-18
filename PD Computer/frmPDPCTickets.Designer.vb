<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPDPCTickets
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPDPCTickets))
        Me.btnJaywalking = New System.Windows.Forms.Button()
        Me.btnStopSign = New System.Windows.Forms.Button()
        Me.btnRedLight = New System.Windows.Forms.Button()
        Me.btnNoLights = New System.Windows.Forms.Button()
        Me.btnOffRoading = New System.Windows.Forms.Button()
        Me.btnSpeeding = New System.Windows.Forms.Button()
        Me.btnWindshield = New System.Windows.Forms.Button()
        Me.btnNotStreetLegal = New System.Windows.Forms.Button()
        Me.btnDrunkDriving = New System.Windows.Forms.Button()
        Me.btnBOP = New System.Windows.Forms.Button()
        Me.btnAbuse911 = New System.Windows.Forms.Button()
        Me.btnDrivingWithoutLs = New System.Windows.Forms.Button()
        Me.btnHeliLand = New System.Windows.Forms.Button()
        Me.btnAironRoad = New System.Windows.Forms.Button()
        Me.btnUnholsWep = New System.Windows.Forms.Button()
        Me.btnFailure2Yield = New System.Windows.Forms.Button()
        Me.btnWeaponNoLicense = New System.Windows.Forms.Button()
        Me.btnVehicleNoLicense = New System.Windows.Forms.Button()
        Me.lblSpeeding = New System.Windows.Forms.Label()
        Me.btnReckless = New System.Windows.Forms.Button()
        Me.txtSpeeding = New System.Windows.Forms.TextBox()
        Me.lblSpeeding2 = New System.Windows.Forms.Label()
        Me.btnSpeedingConfirm = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.lstTickets = New System.Windows.Forms.ListBox()
        Me.btnTerror = New System.Windows.Forms.Button()
        Me.btnConfirmFine = New System.Windows.Forms.Button()
        Me.lblTotalFine = New System.Windows.Forms.Label()
        Me.btnImpedingTraffic = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnJaywalking
        '
        Me.btnJaywalking.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnJaywalking.Location = New System.Drawing.Point(44, 44)
        Me.btnJaywalking.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnJaywalking.Name = "btnJaywalking"
        Me.btnJaywalking.Size = New System.Drawing.Size(183, 25)
        Me.btnJaywalking.TabIndex = 0
        Me.btnJaywalking.Text = "Jaywalking (In city limits)"
        Me.btnJaywalking.UseVisualStyleBackColor = True
        '
        'btnStopSign
        '
        Me.btnStopSign.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnStopSign.Location = New System.Drawing.Point(44, 74)
        Me.btnStopSign.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnStopSign.Name = "btnStopSign"
        Me.btnStopSign.Size = New System.Drawing.Size(183, 25)
        Me.btnStopSign.TabIndex = 1
        Me.btnStopSign.Text = "Running a stop sign"
        Me.btnStopSign.UseVisualStyleBackColor = True
        '
        'btnRedLight
        '
        Me.btnRedLight.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnRedLight.Location = New System.Drawing.Point(44, 104)
        Me.btnRedLight.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnRedLight.Name = "btnRedLight"
        Me.btnRedLight.Size = New System.Drawing.Size(183, 25)
        Me.btnRedLight.TabIndex = 2
        Me.btnRedLight.TabStop = False
        Me.btnRedLight.Text = "Running a red light"
        Me.btnRedLight.UseVisualStyleBackColor = True
        '
        'btnNoLights
        '
        Me.btnNoLights.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNoLights.Location = New System.Drawing.Point(44, 134)
        Me.btnNoLights.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnNoLights.Name = "btnNoLights"
        Me.btnNoLights.Size = New System.Drawing.Size(183, 25)
        Me.btnNoLights.TabIndex = 3
        Me.btnNoLights.Text = "Driving with no lights on at night"
        Me.btnNoLights.UseVisualStyleBackColor = True
        '
        'btnOffRoading
        '
        Me.btnOffRoading.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnOffRoading.Location = New System.Drawing.Point(44, 164)
        Me.btnOffRoading.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnOffRoading.Name = "btnOffRoading"
        Me.btnOffRoading.Size = New System.Drawing.Size(183, 25)
        Me.btnOffRoading.TabIndex = 4
        Me.btnOffRoading.Text = "Off Roading (Within city limits)"
        Me.btnOffRoading.UseVisualStyleBackColor = True
        '
        'btnSpeeding
        '
        Me.btnSpeeding.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSpeeding.Location = New System.Drawing.Point(418, 44)
        Me.btnSpeeding.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSpeeding.Name = "btnSpeeding"
        Me.btnSpeeding.Size = New System.Drawing.Size(183, 25)
        Me.btnSpeeding.TabIndex = 5
        Me.btnSpeeding.Text = "Speeding"
        Me.btnSpeeding.UseVisualStyleBackColor = True
        '
        'btnWindshield
        '
        Me.btnWindshield.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnWindshield.Location = New System.Drawing.Point(44, 224)
        Me.btnWindshield.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnWindshield.Name = "btnWindshield"
        Me.btnWindshield.Size = New System.Drawing.Size(183, 25)
        Me.btnWindshield.TabIndex = 6
        Me.btnWindshield.Text = "Cracked Windshield (All Windows)"
        Me.btnWindshield.UseVisualStyleBackColor = True
        '
        'btnNotStreetLegal
        '
        Me.btnNotStreetLegal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNotStreetLegal.Location = New System.Drawing.Point(44, 284)
        Me.btnNotStreetLegal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnNotStreetLegal.Name = "btnNotStreetLegal"
        Me.btnNotStreetLegal.Size = New System.Drawing.Size(183, 25)
        Me.btnNotStreetLegal.TabIndex = 8
        Me.btnNotStreetLegal.Text = "Non street legal vehicle"
        Me.btnNotStreetLegal.UseVisualStyleBackColor = True
        '
        'btnDrunkDriving
        '
        Me.btnDrunkDriving.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDrunkDriving.Location = New System.Drawing.Point(44, 314)
        Me.btnDrunkDriving.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDrunkDriving.Name = "btnDrunkDriving"
        Me.btnDrunkDriving.Size = New System.Drawing.Size(183, 25)
        Me.btnDrunkDriving.TabIndex = 9
        Me.btnDrunkDriving.Text = "Drunk Driving"
        Me.btnDrunkDriving.UseVisualStyleBackColor = True
        '
        'btnBOP
        '
        Me.btnBOP.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBOP.Location = New System.Drawing.Point(231, 44)
        Me.btnBOP.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBOP.Name = "btnBOP"
        Me.btnBOP.Size = New System.Drawing.Size(183, 25)
        Me.btnBOP.TabIndex = 10
        Me.btnBOP.Text = "Breach of Peace"
        Me.btnBOP.UseVisualStyleBackColor = True
        '
        'btnAbuse911
        '
        Me.btnAbuse911.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAbuse911.Location = New System.Drawing.Point(231, 74)
        Me.btnAbuse911.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAbuse911.Name = "btnAbuse911"
        Me.btnAbuse911.Size = New System.Drawing.Size(183, 25)
        Me.btnAbuse911.TabIndex = 11
        Me.btnAbuse911.Text = "Abusing 911 system"
        Me.btnAbuse911.UseVisualStyleBackColor = True
        '
        'btnDrivingWithoutLs
        '
        Me.btnDrivingWithoutLs.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDrivingWithoutLs.Location = New System.Drawing.Point(231, 104)
        Me.btnDrivingWithoutLs.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDrivingWithoutLs.Name = "btnDrivingWithoutLs"
        Me.btnDrivingWithoutLs.Size = New System.Drawing.Size(183, 25)
        Me.btnDrivingWithoutLs.TabIndex = 12
        Me.btnDrivingWithoutLs.Text = "Driving without a license"
        Me.btnDrivingWithoutLs.UseVisualStyleBackColor = True
        '
        'btnHeliLand
        '
        Me.btnHeliLand.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnHeliLand.Location = New System.Drawing.Point(231, 134)
        Me.btnHeliLand.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnHeliLand.Name = "btnHeliLand"
        Me.btnHeliLand.Size = New System.Drawing.Size(183, 25)
        Me.btnHeliLand.TabIndex = 13
        Me.btnHeliLand.Text = "Landing a helicopter in city"
        Me.btnHeliLand.UseVisualStyleBackColor = True
        '
        'btnAironRoad
        '
        Me.btnAironRoad.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAironRoad.Location = New System.Drawing.Point(231, 164)
        Me.btnAironRoad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAironRoad.Name = "btnAironRoad"
        Me.btnAironRoad.Size = New System.Drawing.Size(183, 25)
        Me.btnAironRoad.TabIndex = 14
        Me.btnAironRoad.Text = "Using air vehicle on road"
        Me.btnAironRoad.UseVisualStyleBackColor = True
        '
        'btnUnholsWep
        '
        Me.btnUnholsWep.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnUnholsWep.Location = New System.Drawing.Point(231, 194)
        Me.btnUnholsWep.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnUnholsWep.Name = "btnUnholsWep"
        Me.btnUnholsWep.Size = New System.Drawing.Size(183, 25)
        Me.btnUnholsWep.TabIndex = 15
        Me.btnUnholsWep.Text = "Unholstered weapon (City)"
        Me.btnUnholsWep.UseVisualStyleBackColor = True
        '
        'btnFailure2Yield
        '
        Me.btnFailure2Yield.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnFailure2Yield.Location = New System.Drawing.Point(231, 224)
        Me.btnFailure2Yield.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnFailure2Yield.Name = "btnFailure2Yield"
        Me.btnFailure2Yield.Size = New System.Drawing.Size(183, 25)
        Me.btnFailure2Yield.TabIndex = 16
        Me.btnFailure2Yield.Text = "Failure to yield"
        Me.btnFailure2Yield.UseVisualStyleBackColor = True
        '
        'btnWeaponNoLicense
        '
        Me.btnWeaponNoLicense.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnWeaponNoLicense.Location = New System.Drawing.Point(231, 254)
        Me.btnWeaponNoLicense.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnWeaponNoLicense.Name = "btnWeaponNoLicense"
        Me.btnWeaponNoLicense.Size = New System.Drawing.Size(183, 25)
        Me.btnWeaponNoLicense.TabIndex = 17
        Me.btnWeaponNoLicense.Text = "Weapon without a license"
        Me.btnWeaponNoLicense.UseVisualStyleBackColor = True
        '
        'btnVehicleNoLicense
        '
        Me.btnVehicleNoLicense.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnVehicleNoLicense.Location = New System.Drawing.Point(231, 284)
        Me.btnVehicleNoLicense.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnVehicleNoLicense.Name = "btnVehicleNoLicense"
        Me.btnVehicleNoLicense.Size = New System.Drawing.Size(183, 25)
        Me.btnVehicleNoLicense.TabIndex = 18
        Me.btnVehicleNoLicense.Text = "Vehicle without license"
        Me.btnVehicleNoLicense.UseVisualStyleBackColor = True
        '
        'lblSpeeding
        '
        Me.lblSpeeding.AutoSize = True
        Me.lblSpeeding.Location = New System.Drawing.Point(418, 80)
        Me.lblSpeeding.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSpeeding.Name = "lblSpeeding"
        Me.lblSpeeding.Size = New System.Drawing.Size(204, 13)
        Me.lblSpeeding.TabIndex = 20
        Me.lblSpeeding.Text = "How fast were they going above the limit?"
        Me.lblSpeeding.Visible = False
        '
        'btnReckless
        '
        Me.btnReckless.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnReckless.Location = New System.Drawing.Point(44, 194)
        Me.btnReckless.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnReckless.Name = "btnReckless"
        Me.btnReckless.Size = New System.Drawing.Size(183, 25)
        Me.btnReckless.TabIndex = 21
        Me.btnReckless.Text = "Reckless Driving"
        Me.btnReckless.UseVisualStyleBackColor = True
        '
        'txtSpeeding
        '
        Me.txtSpeeding.Location = New System.Drawing.Point(421, 107)
        Me.txtSpeeding.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSpeeding.Name = "txtSpeeding"
        Me.txtSpeeding.Size = New System.Drawing.Size(76, 20)
        Me.txtSpeeding.TabIndex = 22
        Me.txtSpeeding.Visible = False
        '
        'lblSpeeding2
        '
        Me.lblSpeeding2.AutoSize = True
        Me.lblSpeeding2.Location = New System.Drawing.Point(500, 110)
        Me.lblSpeeding2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSpeeding2.Name = "lblSpeeding2"
        Me.lblSpeeding2.Size = New System.Drawing.Size(29, 13)
        Me.lblSpeeding2.TabIndex = 23
        Me.lblSpeeding2.Text = "KPH"
        Me.lblSpeeding2.Visible = False
        '
        'btnSpeedingConfirm
        '
        Me.btnSpeedingConfirm.Location = New System.Drawing.Point(532, 106)
        Me.btnSpeedingConfirm.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSpeedingConfirm.Name = "btnSpeedingConfirm"
        Me.btnSpeedingConfirm.Size = New System.Drawing.Size(56, 23)
        Me.btnSpeedingConfirm.TabIndex = 24
        Me.btnSpeedingConfirm.Text = "Confirm"
        Me.btnSpeedingConfirm.UseVisualStyleBackColor = True
        Me.btnSpeedingConfirm.Visible = False
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(658, 321)
        Me.btnQuit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(63, 19)
        Me.btnQuit.TabIndex = 25
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'lstTickets
        '
        Me.lstTickets.FormattingEnabled = True
        Me.lstTickets.Location = New System.Drawing.Point(421, 134)
        Me.lstTickets.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstTickets.Name = "lstTickets"
        Me.lstTickets.Size = New System.Drawing.Size(215, 160)
        Me.lstTickets.TabIndex = 26
        '
        'btnTerror
        '
        Me.btnTerror.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnTerror.Location = New System.Drawing.Point(231, 314)
        Me.btnTerror.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnTerror.Name = "btnTerror"
        Me.btnTerror.Size = New System.Drawing.Size(183, 25)
        Me.btnTerror.TabIndex = 27
        Me.btnTerror.Text = "Driving a terror vehicle"
        Me.btnTerror.UseVisualStyleBackColor = True
        '
        'btnConfirmFine
        '
        Me.btnConfirmFine.Location = New System.Drawing.Point(658, 224)
        Me.btnConfirmFine.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnConfirmFine.Name = "btnConfirmFine"
        Me.btnConfirmFine.Size = New System.Drawing.Size(63, 49)
        Me.btnConfirmFine.TabIndex = 28
        Me.btnConfirmFine.Text = "Confirm Fine"
        Me.btnConfirmFine.UseVisualStyleBackColor = True
        '
        'lblTotalFine
        '
        Me.lblTotalFine.AutoSize = True
        Me.lblTotalFine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalFine.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalFine.Location = New System.Drawing.Point(646, 151)
        Me.lblTotalFine.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalFine.Name = "lblTotalFine"
        Me.lblTotalFine.Size = New System.Drawing.Size(2, 28)
        Me.lblTotalFine.TabIndex = 29
        '
        'btnImpedingTraffic
        '
        Me.btnImpedingTraffic.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnImpedingTraffic.Location = New System.Drawing.Point(44, 254)
        Me.btnImpedingTraffic.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnImpedingTraffic.Name = "btnImpedingTraffic"
        Me.btnImpedingTraffic.Size = New System.Drawing.Size(183, 25)
        Me.btnImpedingTraffic.TabIndex = 30
        Me.btnImpedingTraffic.Text = "Impeding Traffic"
        Me.btnImpedingTraffic.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(658, 80)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(63, 37)
        Me.btnClear.TabIndex = 31
        Me.btnClear.Text = "Clear Fines"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(430, 318)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(110, 20)
        Me.txtName.TabIndex = 32
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(428, 296)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(160, 13)
        Me.lblName.TabIndex = 33
        Me.lblName.Text = "Please enter the suspect's name"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(658, 293)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(63, 19)
        Me.btnBack.TabIndex = 34
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmPDPCTickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 356)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnImpedingTraffic)
        Me.Controls.Add(Me.lblTotalFine)
        Me.Controls.Add(Me.btnConfirmFine)
        Me.Controls.Add(Me.btnTerror)
        Me.Controls.Add(Me.lstTickets)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnSpeedingConfirm)
        Me.Controls.Add(Me.lblSpeeding2)
        Me.Controls.Add(Me.txtSpeeding)
        Me.Controls.Add(Me.btnReckless)
        Me.Controls.Add(Me.lblSpeeding)
        Me.Controls.Add(Me.btnVehicleNoLicense)
        Me.Controls.Add(Me.btnWeaponNoLicense)
        Me.Controls.Add(Me.btnFailure2Yield)
        Me.Controls.Add(Me.btnUnholsWep)
        Me.Controls.Add(Me.btnAironRoad)
        Me.Controls.Add(Me.btnHeliLand)
        Me.Controls.Add(Me.btnDrivingWithoutLs)
        Me.Controls.Add(Me.btnAbuse911)
        Me.Controls.Add(Me.btnBOP)
        Me.Controls.Add(Me.btnDrunkDriving)
        Me.Controls.Add(Me.btnNotStreetLegal)
        Me.Controls.Add(Me.btnWindshield)
        Me.Controls.Add(Me.btnSpeeding)
        Me.Controls.Add(Me.btnOffRoading)
        Me.Controls.Add(Me.btnNoLights)
        Me.Controls.Add(Me.btnRedLight)
        Me.Controls.Add(Me.btnStopSign)
        Me.Controls.Add(Me.btnJaywalking)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmPDPCTickets"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OLRPG Ticketing System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnJaywalking As Button
    Friend WithEvents btnStopSign As Button
    Friend WithEvents btnRedLight As Button
    Friend WithEvents btnNoLights As Button
    Friend WithEvents btnOffRoading As Button
    Friend WithEvents btnSpeeding As Button
    Friend WithEvents btnWindshield As Button
    Friend WithEvents btnNotStreetLegal As Button
    Friend WithEvents btnDrunkDriving As Button
    Friend WithEvents btnBOP As Button
    Friend WithEvents btnAbuse911 As Button
    Friend WithEvents btnDrivingWithoutLs As Button
    Friend WithEvents btnHeliLand As Button
    Friend WithEvents btnAironRoad As Button
    Friend WithEvents btnUnholsWep As Button
    Friend WithEvents btnFailure2Yield As Button
    Friend WithEvents btnWeaponNoLicense As Button
    Friend WithEvents btnVehicleNoLicense As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents lblSpeeding As Label
    Friend WithEvents btnReckless As Button
    Friend WithEvents txtSpeeding As TextBox
    Friend WithEvents lblSpeeding2 As Label
    Friend WithEvents btnSpeedingConfirm As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents lstTickets As ListBox
    Friend WithEvents btnTerror As Button
    Friend WithEvents btnConfirmFine As Button
    Friend WithEvents lblTotalFine As Label
    Friend WithEvents btnImpedingTraffic As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents btnBack As Button
End Class
