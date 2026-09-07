Public Class frmRelatorioFuncionario
    Private Sub frmRelatorioFuncionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'dbFinalStopDataSet.tbFuncionario'. Você pode movê-la ou removê-la conforme necessário.
        Me.tbFuncionarioTableAdapter.Fill(Me.dbFinalStopDataSet.tbFuncionario)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class