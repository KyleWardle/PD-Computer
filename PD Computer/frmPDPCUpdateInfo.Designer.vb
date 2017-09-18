<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPDPCUpdateInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPDPCUpdateInfo))
        Me.lblUpdateTitle = New System.Windows.Forms.Label()
        Me.lblInstalled = New System.Windows.Forms.Label()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.btnSkip = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblUpdateTitle
        '
        Me.lblUpdateTitle.AutoSize = True
        Me.lblUpdateTitle.Location = New System.Drawing.Point(140, 88)
        Me.lblUpdateTitle.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblUpdateTitle.Name = "lblUpdateTitle"
        Me.lblUpdateTitle.Size = New System.Drawing.Size(436, 40)
        Me.lblUpdateTitle.TabIndex = 0
        Me.lblUpdateTitle.Text = "There is an update available!"
        '
        'lblInstalled
        '
        Me.lblInstalled.AutoSize = True
        Me.lblInstalled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblInstalled.Location = New System.Drawing.Point(12, 175)
        Me.lblInstalled.Name = "lblInstalled"
        Me.lblInstalled.Size = New System.Drawing.Size(358, 40)
        Me.lblInstalled.TabIndex = 1
        Me.lblInstalled.Text = "Installed Version : 0.0.0"
        '
        'lblNew
        '
        Me.lblNew.AutoSize = True
        Me.lblNew.ForeColor = System.Drawing.Color.Blue
        Me.lblNew.Location = New System.Drawing.Point(388, 175)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(297, 40)
        Me.lblNew.TabIndex = 2
        Me.lblNew.Text = "New Version : 0.0.0"
        '
        'btnDownload
        '
        Me.btnDownload.Location = New System.Drawing.Point(162, 254)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(414, 76)
        Me.btnDownload.TabIndex = 3
        Me.btnDownload.Text = "Download Latest Now!"
        Me.btnDownload.UseVisualStyleBackColor = True
        '
        'btnSkip
        '
        Me.btnSkip.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSkip.Location = New System.Drawing.Point(645, 283)
        Me.btnSkip.Name = "btnSkip"
        Me.btnSkip.Size = New System.Drawing.Size(75, 33)
        Me.btnSkip.TabIndex = 4
        Me.btnSkip.Text = "Skip"
        Me.btnSkip.UseVisualStyleBackColor = True
        '
        'frmPDPCUpdateInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 40.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 342)
        Me.Controls.Add(Me.btnSkip)
        Me.Controls.Add(Me.btnDownload)
        Me.Controls.Add(Me.lblNew)
        Me.Controls.Add(Me.lblInstalled)
        Me.Controls.Add(Me.lblUpdateTitle)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPDPCUpdateInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Available"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUpdateTitle As Label
    Friend WithEvents lblInstalled As Label
    Friend WithEvents lblNew As Label
    Friend WithEvents btnDownload As Button
    Friend WithEvents btnSkip As Button
End Class
