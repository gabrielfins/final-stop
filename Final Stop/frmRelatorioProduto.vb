Public Class frmRelatorioProduto
    Private Sub frmRelatorioProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'dbFinalStopDataSet.tbProduto'. Você pode movê-la ou removê-la conforme necessário.
        Me.tbProdutoTableAdapter.Fill(Me.dbFinalStopDataSet.tbProduto)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class