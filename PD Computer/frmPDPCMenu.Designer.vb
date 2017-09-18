<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPDPCMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPDPCMenu))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btnStartShift = New System.Windows.Forms.Button()
        Me.btnTimeUpdate = New System.Windows.Forms.Button()
        Me.btnEndShift = New System.Windows.Forms.Button()
        Me.btnTickets = New System.Windows.Forms.Button()
        Me.btnSitRep = New System.Windows.Forms.Button()
        Me.btnDrugsCalculator = New System.Windows.Forms.Button()
        Me.btnJail = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(90, 23)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(553, 246)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(323, 279)
        Me.lblVersion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(55, 15)
        Me.lblVersion.TabIndex = 3
        Me.lblVersion.Text = "V. 2.7.9"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(513, 279)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Created by Kyle W."
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(323, 188)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(0, 24)
        Me.lblTime.TabIndex = 7
        '
        'btnStartShift
        '
        Me.btnStartShift.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnStartShift.Location = New System.Drawing.Point(243, 149)
        Me.btnStartShift.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStartShift.Name = "btnStartShift"
        Me.btnStartShift.Size = New System.Drawing.Size(80, 37)
        Me.btnStartShift.TabIndex = 5
        Me.btnStartShift.Text = "Start Your Shift"
        Me.btnStartShift.UseVisualStyleBackColor = False
        '
        'btnTimeUpdate
        '
        Me.btnTimeUpdate.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnTimeUpdate.Location = New System.Drawing.Point(327, 149)
        Me.btnTimeUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTimeUpdate.Name = "btnTimeUpdate"
        Me.btnTimeUpdate.Size = New System.Drawing.Size(80, 37)
        Me.btnTimeUpdate.TabIndex = 8
        Me.btnTimeUpdate.Text = "Update Time"
        Me.btnTimeUpdate.UseVisualStyleBackColor = False
        '
        'btnEndShift
        '
        Me.btnEndShift.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnEndShift.Location = New System.Drawing.Point(243, 149)
        Me.btnEndShift.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEndShift.Name = "btnEndShift"
        Me.btnEndShift.Size = New System.Drawing.Size(80, 37)
        Me.btnEndShift.TabIndex = 6
        Me.btnEndShift.Text = "End Your Shift"
        Me.btnEndShift.UseVisualStyleBackColor = False
        Me.btnEndShift.Visible = False
        '
        'btnTickets
        '
        Me.btnTickets.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnTickets.Location = New System.Drawing.Point(93, 197)
        Me.btnTickets.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTickets.Name = "btnTickets"
        Me.btnTickets.Size = New System.Drawing.Size(141, 46)
        Me.btnTickets.TabIndex = 1
        Me.btnTickets.Text = "Tickets"
        Me.btnTickets.UseVisualStyleBackColor = False
        '
        'btnSitRep
        '
        Me.btnSitRep.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnSitRep.Location = New System.Drawing.Point(243, 202)
        Me.btnSitRep.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSitRep.Name = "btnSitRep"
        Me.btnSitRep.Size = New System.Drawing.Size(80, 37)
        Me.btnSitRep.TabIndex = 9
        Me.btnSitRep.Text = "Situation Report"
        Me.btnSitRep.UseVisualStyleBackColor = False
        '
        'btnDrugsCalculator
        '
        Me.btnDrugsCalculator.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnDrugsCalculator.Location = New System.Drawing.Point(326, 202)
        Me.btnDrugsCalculator.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDrugsCalculator.Name = "btnDrugsCalculator"
        Me.btnDrugsCalculator.Size = New System.Drawing.Size(80, 37)
        Me.btnDrugsCalculator.TabIndex = 10
        Me.btnDrugsCalculator.Text = "Drugs Calculator"
        Me.btnDrugsCalculator.UseVisualStyleBackColor = False
        '
        'btnJail
        '
        Me.btnJail.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnJail.Location = New System.Drawing.Point(415, 197)
        Me.btnJail.Margin = New System.Windows.Forms.Padding(2)
        Me.btnJail.Name = "btnJail"
        Me.btnJail.Size = New System.Drawing.Size(141, 46)
        Me.btnJail.TabIndex = 2
        Me.btnJail.Text = "Jail Time"
        Me.btnJail.UseVisualStyleBackColor = False
        '
        'frmPDPCMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(685, 300)
        Me.Controls.Add(Me.btnDrugsCalculator)
        Me.Controls.Add(Me.btnSitRep)
        Me.Controls.Add(Me.btnTimeUpdate)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.btnEndShift)
        Me.Controls.Add(Me.btnStartShift)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.btnJail)
        Me.Controls.Add(Me.btnTickets)
        Me.Controls.Add(Me.PictureBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmPDPCMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OLRPG Police Computer"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblVersion As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents btnStartShift As Button
    Friend WithEvents btnTimeUpdate As Button
    Friend WithEvents btnEndShift As Button
    Friend WithEvents btnTickets As Button
    Friend WithEvents btnSitRep As Button
    Friend WithEvents btnDrugsCalculator As Button
    Friend WithEvents btnJail As Button
End Class
