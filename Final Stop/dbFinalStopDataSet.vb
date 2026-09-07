Partial Class dbFinalStopDataSet
    Partial Public Class tbProdutoDataTable
        Private Sub tbProdutoDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.quantidadeColumn.ColumnName) Then
                'Adicionar o código do usuário aqui
            End If

        End Sub

    End Class
End Class

Namespace dbFinalStopDataSetTableAdapters

    Partial Public Class tbProdutoTableAdapter
    End Class
End Namespace
