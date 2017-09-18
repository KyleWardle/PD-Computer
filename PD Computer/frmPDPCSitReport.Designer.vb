<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPDPCSitReport
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
        Me.rtxtSitRep = New System.Windows.Forms.RichTextBox()
        Me.lblDescribe = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(658, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'rtxtSitRep
        '
        Me.rtxtSitRep.Location = New System.Drawing.Point(81, 80)
        Me.rtxtSitRep.Name = "rtxtSitRep"
        Me.rtxtSitRep.Size = New System.Drawing.Size(459, 211)
        Me.rtxtSitRep.TabIndex = 1
        Me.rtxtSitRep.Text = ""
        '
        'lblDescribe
        '
        Me.lblDescribe.AutoSize = True
        Me.lblDescribe.Location = New System.Drawing.Point(78, 47)
        Me.lblDescribe.Name = "lblDescribe"
        Me.lblDescribe.Size = New System.Drawing.Size(306, 17)
        Me.lblDescribe.TabIndex = 2
        Me.lblDescribe.Text = "Briefly describe what happened in the situation:"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(622, 167)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'frmPDPCSitReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 356)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblDescribe)
        Me.Controls.Add(Me.rtxtSitRep)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "frmPDPCSitReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Situation Report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents rtxtSitRep As RichTextBox
    Friend WithEvents lblDescribe As Label
    Friend WithEvents btnSubmit As Button
End Class
