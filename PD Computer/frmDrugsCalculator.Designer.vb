<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDrugsCalculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnCocaine = New System.Windows.Forms.Button()
        Me.btnWeed = New System.Windows.Forms.Button()
        Me.btnHeroin = New System.Windows.Forms.Button()
        Me.btnLSD = New System.Windows.Forms.Button()
        Me.btnMeth = New System.Windows.Forms.Button()
        Me.btnWhale = New System.Windows.Forms.Button()
        Me.btnOrgans = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblHelp = New System.Windows.Forms.Label()
        Me.cbProcessed = New System.Windows.Forms.CheckBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtDrugNum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalBounty = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSelectedDrug = New System.Windows.Forms.Label()
        Me.lblJailTime = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(549, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(549, 41)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 1
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnCocaine
        '
        Me.btnCocaine.Location = New System.Drawing.Point(36, 70)
        Me.btnCocaine.Name = "btnCocaine"
        Me.btnCocaine.Size = New System.Drawing.Size(96, 30)
        Me.btnCocaine.TabIndex = 2
        Me.btnCocaine.Text = "Cocaine"
        Me.btnCocaine.UseVisualStyleBackColor = True
        '
        'btnWeed
        '
        Me.btnWeed.Location = New System.Drawing.Point(36, 106)
        Me.btnWeed.Name = "btnWeed"
        Me.btnWeed.Size = New System.Drawing.Size(96, 30)
        Me.btnWeed.TabIndex = 3
        Me.btnWeed.Text = "Weed"
        Me.btnWeed.UseVisualStyleBackColor = True
        '
        'btnHeroin
        '
        Me.btnHeroin.Location = New System.Drawing.Point(36, 142)
        Me.btnHeroin.Name = "btnHeroin"
        Me.btnHeroin.Size = New System.Drawing.Size(96, 30)
        Me.btnHeroin.TabIndex = 4
        Me.btnHeroin.Text = "Heroin"
        Me.btnHeroin.UseVisualStyleBackColor = True
        '
        'btnLSD
        '
        Me.btnLSD.Location = New System.Drawing.Point(36, 178)
        Me.btnLSD.Name = "btnLSD"
        Me.btnLSD.Size = New System.Drawing.Size(96, 30)
        Me.btnLSD.TabIndex = 5
        Me.btnLSD.Text = "LSD"
        Me.btnLSD.UseVisualStyleBackColor = True
        '
        'btnMeth
        '
        Me.btnMeth.Location = New System.Drawing.Point(36, 214)
        Me.btnMeth.Name = "btnMeth"
        Me.btnMeth.Size = New System.Drawing.Size(96, 30)
        Me.btnMeth.TabIndex = 6
        Me.btnMeth.Text = "Meth"
        Me.btnMeth.UseVisualStyleBackColor = True
        '
        'btnWhale
        '
        Me.btnWhale.Location = New System.Drawing.Point(36, 250)
        Me.btnWhale.Name = "btnWhale"
        Me.btnWhale.Size = New System.Drawing.Size(96, 30)
        Me.btnWhale.TabIndex = 7
        Me.btnWhale.Text = "Whale"
        Me.btnWhale.UseVisualStyleBackColor = True
        '
        'btnOrgans
        '
        Me.btnOrgans.Location = New System.Drawing.Point(36, 286)
        Me.btnOrgans.Name = "btnOrgans"
        Me.btnOrgans.Size = New System.Drawing.Size(96, 30)
        Me.btnOrgans.TabIndex = 8
        Me.btnOrgans.Text = "Illegal Organs"
        Me.btnOrgans.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(192, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(233, 31)
        Me.lblTitle.TabIndex = 9
        Me.lblTitle.Text = "Drugs Calculator"
        '
        'lblHelp
        '
        Me.lblHelp.AutoSize = True
        Me.lblHelp.Location = New System.Drawing.Point(195, 51)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(200, 13)
        Me.lblHelp.TabIndex = 10
        Me.lblHelp.Text = "Please select the drug found from the left"
        '
        'cbProcessed
        '
        Me.cbProcessed.AutoSize = True
        Me.cbProcessed.Location = New System.Drawing.Point(461, 101)
        Me.cbProcessed.Name = "cbProcessed"
        Me.cbProcessed.Size = New System.Drawing.Size(82, 17)
        Me.cbProcessed.TabIndex = 11
        Me.cbProcessed.Text = "Processed?"
        Me.cbProcessed.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(461, 124)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(163, 43)
        Me.btnCalculate.TabIndex = 12
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtDrugNum
        '
        Me.txtDrugNum.Location = New System.Drawing.Point(152, 106)
        Me.txtDrugNum.Name = "txtDrugNum"
        Me.txtDrugNum.Size = New System.Drawing.Size(35, 20)
        Me.txtDrugNum.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(149, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Please enter the amount of drugs found"
        '
        'lblTotalBounty
        '
        Me.lblTotalBounty.AutoSize = True
        Me.lblTotalBounty.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBounty.Location = New System.Drawing.Point(148, 256)
        Me.lblTotalBounty.Name = "lblTotalBounty"
        Me.lblTotalBounty.Size = New System.Drawing.Size(280, 24)
        Me.lblTotalBounty.TabIndex = 15
        Me.lblTotalBounty.Text = "The total drugs bounty is : $0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(147, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 25)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Selected Drug :"
        '
        'lblSelectedDrug
        '
        Me.lblSelectedDrug.AutoSize = True
        Me.lblSelectedDrug.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedDrug.Location = New System.Drawing.Point(147, 178)
        Me.lblSelectedDrug.Name = "lblSelectedDrug"
        Me.lblSelectedDrug.Size = New System.Drawing.Size(0, 25)
        Me.lblSelectedDrug.TabIndex = 17
        '
        'lblJailTime
        '
        Me.lblJailTime.AutoSize = True
        Me.lblJailTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJailTime.Location = New System.Drawing.Point(148, 286)
        Me.lblJailTime.Name = "lblJailTime"
        Me.lblJailTime.Size = New System.Drawing.Size(111, 24)
        Me.lblJailTime.TabIndex = 18
        Me.lblJailTime.Text = "No Charge"
        '
        'frmDrugsCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 329)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblJailTime)
        Me.Controls.Add(Me.lblSelectedDrug)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTotalBounty)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDrugNum)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.cbProcessed)
        Me.Controls.Add(Me.lblHelp)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnOrgans)
        Me.Controls.Add(Me.btnWhale)
        Me.Controls.Add(Me.btnMeth)
        Me.Controls.Add(Me.btnLSD)
        Me.Controls.Add(Me.btnHeroin)
        Me.Controls.Add(Me.btnWeed)
        Me.Controls.Add(Me.btnCocaine)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "frmDrugsCalculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Drugs Calculator"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnCocaine As Button
    Friend WithEvents btnWeed As Button
    Friend WithEvents btnHeroin As Button
    Friend WithEvents btnLSD As Button
    Friend WithEvents btnMeth As Button
    Friend WithEvents btnWhale As Button
    Friend WithEvents btnOrgans As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblHelp As Label
    Friend WithEvents cbProcessed As CheckBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtDrugNum As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotalBounty As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblSelectedDrug As Label
    Friend WithEvents lblJailTime As Label
End Class
