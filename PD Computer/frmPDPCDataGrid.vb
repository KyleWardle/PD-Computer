Public Class frmPDPCDataGrid
    Private Sub frmPDPCDataGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Mysql_116925_pdpcDataSet2.updates' table. You can move, or remove it, as needed.
        Me.UpdatesTableAdapter.Fill(Me.Mysql_116925_pdpcDataSet2.updates)
        'TODO: This line of code loads data into the 'Mysql_116925_pdpcDataSet.users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.FinesTableAdapater.users)
        'TODO: This line of code loads data into the 'Mysql_116925_pdpcDataSet.sessions' table. You can move, or remove it, as needed.
        Me.SessionsTableAdapter.Fill(Me.FinesTableAdapater.sessions)
        'TODO: This line of code loads data into the 'Mysql_116925_pdpcDataSet.reports' table. You can move, or remove it, as needed.
        Me.ReportsTableAdapter.Fill(Me.FinesTableAdapater.reports)
        'TODO: This line of code loads data into the 'Mysql_116925_pdpcDataSet.jailtimes' table. You can move, or remove it, as needed.
        Me.JailtimesTableAdapter.Fill(Me.FinesTableAdapater.jailtimes)
        'TODO: This line of code loads data into the 'Mysql_116925_pdpcDataSet.fines' table. You can move, or remove it, as needed.
        Me.FinesTableAdapter.Fill(Me.FinesTableAdapater.fines)
    End Sub
End Class