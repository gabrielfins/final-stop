Public Class frmFornecedor

    Dim cnpjSalvar As Boolean
    Dim mouseClicked As Boolean
    Dim clickedAt As Point

    Private Sub frmFornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DbFinalStopDataSet.tbFornecedor'. Você pode movê-la ou removê-la conforme necessário.
        Me.TbFornecedorTableAdapter.Fill(Me.DbFinalStopDataSet.tbFornecedor)

    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        TbFornecedorBindingSource.MovePrevious()
    End Sub

    Private Sub btnProximo_Click(sender As Object, e As EventArgs) Handles btnProximo.Click
        TbFornecedorBindingSource.MoveNext()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Nome_fantasiaTextBox.Enabled = True
        CnpjMaskedTextBox.Enabled = True
        Razao_socialTextBox.Enabled = True
        CepMaskedTextBox.Enabled = True
        Nome_contatoTextBox.Enabled = True
        EstadoComboBox.Enabled = True
        CidadeTextBox.Enabled = True
        EnderecoTextBox.Enabled = True
        EmailTextBox.Enabled = True
        Telefone1MaskedTextBox.Enabled = True
        Telefone2MaskedTextBox.Enabled = True
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If MessageBox.Show("Deseja realmente apagar o registro?", "Apagando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = vbYes Then
            Try
                TbFornecedorBindingSource.RemoveCurrent()
                TbFornecedorTableAdapter.Update(DbFinalStopDataSet.tbFornecedor)
            Catch ex As Exception
                MessageBox.Show("Não há registros para serem excluídos.", "Nenhum registro encontrado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If Nome_fantasiaTextBox.Text.Trim = Nothing Or Nome_contatoTextBox.Text.Trim = Nothing Or Razao_socialTextBox.Text.Trim = Nothing Or cnpjSalvar = False Or CepMaskedTextBox.MaskFull = False Or EstadoComboBox.Text.Trim = Nothing Or CidadeTextBox.Text.Trim = Nothing Or EnderecoTextBox.Text.Trim = Nothing Or Telefone1MaskedTextBox.MaskFull = False Or Telefone2MaskedTextBox.MaskFull = False Or EmailTextBox.Text.Trim = Nothing Then
            MessageBox.Show("Preencha todos os campos corretamente para realizar o cadastro.", "Algo deu errado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            TbFornecedorBindingSource.EndEdit()
            TbFornecedorTableAdapter.Update(DbFinalStopDataSet.tbFornecedor)
            MessageBox.Show("Fornecedor salvo com sucesso!", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Nome_fantasiaTextBox.Enabled = False
            CnpjMaskedTextBox.Enabled = False
            Razao_socialTextBox.Enabled = False
            CepMaskedTextBox.Enabled = False
            Nome_contatoTextBox.Enabled = False
            EstadoComboBox.Enabled = False
            CidadeTextBox.Enabled = False
            EnderecoTextBox.Enabled = False
            EmailTextBox.Enabled = False
            Telefone1MaskedTextBox.Enabled = False
            Telefone2MaskedTextBox.Enabled = False
        End If
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        TbFornecedorBindingSource.AddNew()
        Nome_fantasiaTextBox.Enabled = True
        CnpjMaskedTextBox.Enabled = True
        Razao_socialTextBox.Enabled = True
        CepMaskedTextBox.Enabled = True
        Nome_contatoTextBox.Enabled = True
        EstadoComboBox.Enabled = True
        CidadeTextBox.Enabled = True
        EnderecoTextBox.Enabled = True
        EmailTextBox.Enabled = True
        Telefone1MaskedTextBox.Enabled = True
        Telefone2MaskedTextBox.Enabled = True
    End Sub

    Private Sub CnpjMaskedTextBox_TextChanged(sender As Object, e As EventArgs) Handles CnpjMaskedTextBox.TextChanged
        Dim validacao As New Valida_CPF_CNPJ
        If CnpjMaskedTextBox.MaskFull Then
            validacao.cnpj = CnpjMaskedTextBox.Text
            If validacao.isCnpjValido And
               CnpjMaskedTextBox.Text <> "00,000,000/0000-00" And
               CnpjMaskedTextBox.Text <> "11,111,111/1111-11" And
               CnpjMaskedTextBox.Text <> "22,222,222/2222-22" And
               CnpjMaskedTextBox.Text <> "33,333,333/3333-33" And
               CnpjMaskedTextBox.Text <> "44,444,444/4444-44" And
               CnpjMaskedTextBox.Text <> "55,555,555/5555-55" And
               CnpjMaskedTextBox.Text <> "66,666,666/6666-66" And
               CnpjMaskedTextBox.Text <> "77,777,777/7777-77" And
               CnpjMaskedTextBox.Text <> "88,888,888/8888-88" And
               CnpjMaskedTextBox.Text <> "99,999,999/9999-99" Then
                lblValidador.Text = "CNPJ válido."
                lblValidador.ForeColor = Color.Green
                cnpjSalvar = True
            Else
                lblValidador.Text = "CNPJ inválido."
                lblValidador.ForeColor = Color.DarkRed
                cnpjSalvar = False
            End If
        Else
            lblValidador.Text = "..."
            lblValidador.ForeColor = Color.White
            cnpjSalvar = False
        End If
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Dispose()
    End Sub

    Private Sub pnlTop_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlTop.MouseDown, MyBase.MouseDown
        If e.Button <> MouseButtons.Left Then
            Return
        End If
        mouseClicked = True
        clickedAt = e.Location
    End Sub

    Private Sub pnlTop_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlTop.MouseMove, MyBase.MouseMove
        If mouseClicked Then
            Location = New Point(Cursor.Position.X - clickedAt.X, Cursor.Position.Y - clickedAt.Y)
        End If
    End Sub

    Private Sub pnlTop_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlTop.MouseUp, MyBase.MouseUp
        mouseClicked = False
    End Sub
End Class