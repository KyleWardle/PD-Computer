<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPDPCDataGrid
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinesTableAdapater = New PD_Computer.mysql_116925_pdpcDataSet()
        Me.FinesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinesTableAdapter = New PD_Computer.mysql_116925_pdpcDataSetTableAdapters.finesTableAdapter()
        Me.JailtimesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JailtimesTableAdapter = New PD_Computer.mysql_116925_pdpcDataSetTableAdapters.jailtimesTableAdapter()
        Me.ReportsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportsTableAdapter = New PD_Computer.mysql_116925_pdpcDataSetTableAdapters.reportsTableAdapter()
        Me.SessionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SessionsTableAdapter = New PD_Computer.mysql_116925_pdpcDataSetTableAdapters.sessionsTableAdapter()
        Me.UsersTableAdapter = New PD_Computer.mysql_116925_pdpcDataSetTableAdapters.usersTableAdapter()
        Me.FinesTableAdapaterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mysql_116925_pdpcDataSet2 = New PD_Computer.mysql_116925_pdpcDataSet2()
        Me.UpdatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UpdatesTableAdapter = New PD_Computer.mysql_116925_pdpcDataSet2TableAdapters.updatesTableAdapter()
        Me.VersionIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VersionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DownloadLinkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinesTableAdapater, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JailtimesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SessionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinesTableAdapaterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mysql_116925_pdpcDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UpdatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VersionIDDataGridViewTextBoxColumn, Me.VersionDataGridViewTextBoxColumn, Me.DownloadLinkDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.UpdatesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(663, 306)
        Me.DataGridView1.TabIndex = 0
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "users"
        Me.UsersBindingSource.DataSource = Me.FinesTableAdapater
        '
        'FinesTableAdapater
        '
        Me.FinesTableAdapater.DataSetName = "mysql_116925_pdpcDataSet"
        Me.FinesTableAdapater.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FinesBindingSource
        '
        Me.FinesBindingSource.DataMember = "fines"
        Me.FinesBindingSource.DataSource = Me.FinesTableAdapater
        '
        'FinesTableAdapter
        '
        Me.FinesTableAdapter.ClearBeforeFill = True
        '
        'JailtimesBindingSource
        '
        Me.JailtimesBindingSource.DataMember = "jailtimes"
        Me.JailtimesBindingSource.DataSource = Me.FinesTableAdapater
        '
        'JailtimesTableAdapter
        '
        Me.JailtimesTableAdapter.ClearBeforeFill = True
        '
        'ReportsBindingSource
        '
        Me.ReportsBindingSource.DataMember = "reports"
        Me.ReportsBindingSource.DataSource = Me.FinesTableAdapater
        '
        'ReportsTableAdapter
        '
        Me.ReportsTableAdapter.ClearBeforeFill = True
        '
        'SessionsBindingSource
        '
        Me.SessionsBindingSource.DataMember = "sessions"
        Me.SessionsBindingSource.DataSource = Me.FinesTableAdapater
        '
        'SessionsTableAdapter
        '
        Me.SessionsTableAdapter.ClearBeforeFill = True
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'FinesTableAdapaterBindingSource
        '
        Me.FinesTableAdapaterBindingSource.DataSource = Me.FinesTableAdapater
        Me.FinesTableAdapaterBindingSource.Position = 0
        '
        'Mysql_116925_pdpcDataSet2
        '
        Me.Mysql_116925_pdpcDataSet2.DataSetName = "mysql_116925_pdpcDataSet2"
        Me.Mysql_116925_pdpcDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UpdatesBindingSource
        '
        Me.UpdatesBindingSource.DataMember = "updates"
        Me.UpdatesBindingSource.DataSource = Me.Mysql_116925_pdpcDataSet2
        '
        'UpdatesTableAdapter
        '
        Me.UpdatesTableAdapter.ClearBeforeFill = True
        '
        'VersionIDDataGridViewTextBoxColumn
        '
        Me.VersionIDDataGridViewTextBoxColumn.DataPropertyName = "VersionID"
        Me.VersionIDDataGridViewTextBoxColumn.HeaderText = "VersionID"
        Me.VersionIDDataGridViewTextBoxColumn.Name = "VersionIDDataGridViewTextBoxColumn"
        '
        'VersionDataGridViewTextBoxColumn
        '
        Me.VersionDataGridViewTextBoxColumn.DataPropertyName = "Version"
        Me.VersionDataGridViewTextBoxColumn.HeaderText = "Version"
        Me.VersionDataGridViewTextBoxColumn.Name = "VersionDataGridViewTextBoxColumn"
        '
        'DownloadLinkDataGridViewTextBoxColumn
        '
        Me.DownloadLinkDataGridViewTextBoxColumn.DataPropertyName = "DownloadLink"
        Me.DownloadLinkDataGridViewTextBoxColumn.HeaderText = "DownloadLink"
        Me.DownloadLinkDataGridViewTextBoxColumn.Name = "DownloadLinkDataGridViewTextBoxColumn"
        '
        'frmPDPCDataGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(687, 381)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmPDPCDataGrid"
        Me.Opacity = 0R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "frmPDPCDataGrid"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinesTableAdapater, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JailtimesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SessionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinesTableAdapaterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mysql_116925_pdpcDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UpdatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents FinesTableAdapater As mysql_116925_pdpcDataSet
    Friend WithEvents FinesBindingSource As BindingSource
    Friend WithEvents FinesTableAdapter As mysql_116925_pdpcDataSetTableAdapters.finesTableAdapter
    Friend WithEvents JailtimesBindingSource As BindingSource
    Friend WithEvents JailtimesTableAdapter As mysql_116925_pdpcDataSetTableAdapters.jailtimesTableAdapter
    Friend WithEvents ReportsBindingSource As BindingSource
    Friend WithEvents ReportsTableAdapter As mysql_116925_pdpcDataSetTableAdapters.reportsTableAdapter
    Friend WithEvents SessionsBindingSource As BindingSource
    Friend WithEvents SessionsTableAdapter As mysql_116925_pdpcDataSetTableAdapters.sessionsTableAdapter
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As mysql_116925_pdpcDataSetTableAdapters.usersTableAdapter
    Friend WithEvents FinesTableAdapaterBindingSource As BindingSource
    Friend WithEvents Mysql_116925_pdpcDataSet2 As mysql_116925_pdpcDataSet2
    Friend WithEvents UpdatesBindingSource As BindingSource
    Friend WithEvents UpdatesTableAdapter As mysql_116925_pdpcDataSet2TableAdapters.updatesTableAdapter
    Friend WithEvents VersionIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VersionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DownloadLinkDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
