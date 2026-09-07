Public Class frmRelatorioFornecedor
    Private Sub frmRelatorioFornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'dbFinalStopDataSet.tbFornecedor'. Você pode movê-la ou removê-la conforme necessário.
        Me.tbFornecedorTableAdapter.Fill(Me.dbFinalStopDataSet.tbFornecedor)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class