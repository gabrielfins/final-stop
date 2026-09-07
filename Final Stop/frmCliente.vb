Public Class frmCliente

    Dim cpfSalvar As Boolean
    Dim mouseClicked As Boolean
    Dim clickedAt As Point

    Private Sub frmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DbFinalStopDataSet.tbCliente'. Você pode movê-la ou removê-la conforme necessário.
        Me.TbClienteTableAdapter.Fill(Me.DbFinalStopDataSet.tbCliente)

    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        TbClienteBindingSource.MovePrevious()
    End Sub

    Private Sub btnProximo_Click(sender As Object, e As EventArgs) Handles btnProximo.Click
        TbClienteBindingSource.MoveNext()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        NomeTextBox.Enabled = True
        CpfMaskedTextBox.Enabled = True
        TelefoneMaskedTextBox.Enabled = True
        EmailTextBox.Enabled = True
        CepMaskedTextBox.Enabled = True
        EnderecoTextBox.Enabled = True
        CidadeTextBox.Enabled = True
        EstadoComboBox.Enabled = True
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Try
            If MessageBox.Show("Deseja realmente apagar o registro?", "Apagando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = vbYes Then
                TbClienteBindingSource.RemoveCurrent()
                TbClienteTableAdapter.Update(DbFinalStopDataSet.tbCliente)
            End If
        Catch ex As Exception
            MessageBox.Show("Não há registros para serem excluídos.", "Nenhum registro encontrado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If NomeTextBox.Text.Trim = Nothing Or cpfSalvar = False Or TelefoneMaskedTextBox.MaskFull = False Or EmailTextBox.Text.Trim = Nothing Or CepMaskedTextBox.MaskFull = False Or EstadoComboBox.Text = Nothing Or CidadeTextBox.Text = Nothing Or EnderecoTextBox.Text = Nothing Then
            MessageBox.Show("Preencha todos os campos corretamente para realizar o cadastro.", "Algo deu errado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            TbClienteBindingSource.EndEdit()
            TbClienteTableAdapter.Update(DbFinalStopDataSet.tbCliente)
            MessageBox.Show("Cliente salvo com sucesso!", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            NomeTextBox.Enabled = False
            CpfMaskedTextBox.Enabled = False
            TelefoneMaskedTextBox.Enabled = False
            EmailTextBox.Enabled = False
            CepMaskedTextBox.Enabled = False
            EnderecoTextBox.Enabled = False
            CidadeTextBox.Enabled = False
            EstadoComboBox.Enabled = False
        End If
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        TbClienteBindingSource.AddNew()
        NomeTextBox.Enabled = True
        CpfMaskedTextBox.Enabled = True
        TelefoneMaskedTextBox.Enabled = True
        EmailTextBox.Enabled = True
        CepMaskedTextBox.Enabled = True
        EnderecoTextBox.Enabled = True
        CidadeTextBox.Enabled = True
        EstadoComboBox.Enabled = True
    End Sub

    Private Sub CpfMaskedTextBox_TextChanged(sender As Object, e As EventArgs) Handles CpfMaskedTextBox.TextChanged
        Dim validacao As New Valida_CPF_CNPJ
        If CpfMaskedTextBox.MaskFull Then
            validacao.cpf = CpfMaskedTextBox.Text
            If validacao.isCpfValido And
               CpfMaskedTextBox.Text <> "000,000,000-00" And
               CpfMaskedTextBox.Text <> "111,111,111-11" And
               CpfMaskedTextBox.Text <> "222,222,222-22" And
               CpfMaskedTextBox.Text <> "333,333,333-33" And
               CpfMaskedTextBox.Text <> "444,444,444-44" And
               CpfMaskedTextBox.Text <> "555,555,555-55" And
               CpfMaskedTextBox.Text <> "666,666,666-66" And
               CpfMaskedTextBox.Text <> "777,777,777-77" And
               CpfMaskedTextBox.Text <> "888,888,888-88" And
               CpfMaskedTextBox.Text <> "999,999,999-99" Then
                lblValidador.Text = "CPF válido."
                lblValidador.ForeColor = Color.Green
                cpfSalvar = True
            Else
                lblValidador.Text = "CPF inválido."
                lblValidador.ForeColor = Color.DarkRed
                cpfSalvar = False
            End If
        Else
            lblValidador.Text = "..."
            lblValidador.ForeColor = Color.White
            cpfSalvar = False
        End If
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

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Dispose()
    End Sub
End Class