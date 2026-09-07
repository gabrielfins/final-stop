Public Class frmRelatorioCliente
    Private Sub frmRelatorioCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'dbFinalStopDataSet.tbCliente'. Você pode movê-la ou removê-la conforme necessário.
        Me.tbClienteTableAdapter.Fill(Me.dbFinalStopDataSet.tbCliente)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class