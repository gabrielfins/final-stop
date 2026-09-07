Public Class frmFuncionario

    Dim salvar(1) As Boolean
    Dim mouseClicked As Boolean
    Dim showPass As Boolean
    Dim clickedAt As Point

    Private Sub frmFuncionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DbFinalStopDataSet.tbFuncionario'. Você pode movê-la ou removê-la conforme necessário.
        Me.TbFuncionarioTableAdapter.Fill(Me.DbFinalStopDataSet.tbFuncionario)

    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        TbFuncionarioBindingSource.MovePrevious()
    End Sub

    Private Sub btnProximo_Click(sender As Object, e As EventArgs) Handles btnProximo.Click
        TbFuncionarioBindingSource.MoveNext()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        NomeTextBox.Enabled = True
        CpfMaskedTextBox.Enabled = True
        LoginTextBox.Enabled = True
        SenhaTextBox.Enabled = True
        TelefoneMaskedTextBox.Enabled = True
        Data_admissaoMaskedTextBox.Enabled = True
        EmailTextBox.Enabled = True
        SalarioTextBox.Enabled = True
        CargoComboBox.Enabled = True
        NivelComboBox.Enabled = True
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If MessageBox.Show("Deseja realmente apagar o registro?", "Apagando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = vbYes Then
            Try
                TbFuncionarioBindingSource.RemoveCurrent()
                TbFuncionarioTableAdapter.Update(DbFinalStopDataSet.tbFuncionario)
            Catch ex As Exception
                MessageBox.Show("Não há registros para serem excluídos.", "Nenhum registro encontrado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If NomeTextBox.Text.Trim = Nothing Or LoginTextBox.Text.Trim = Nothing Or SenhaTextBox.Text.Trim = Nothing Or salvar(0) = False Or TelefoneMaskedTextBox.MaskFull = False Or EmailTextBox.Text.Trim = Nothing Or CargoComboBox.Text.Trim = Nothing Or salvar(1) = False Or Data_admissaoMaskedTextBox.MaskFull = False Or NivelComboBox.Text.Trim = Nothing Then
            MessageBox.Show("Preencha todos os campos corretamente para realizar o cadastro.", "Algo deu errado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            TbFuncionarioBindingSource.EndEdit()
            TbFuncionarioTableAdapter.Update(DbFinalStopDataSet.tbFuncionario)
            MessageBox.Show("Funcionário salvo com sucesso!", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            NomeTextBox.Enabled = False
            CpfMaskedTextBox.Enabled = False
            LoginTextBox.Enabled = False
            SenhaTextBox.Enabled = False
            TelefoneMaskedTextBox.Enabled = False
            Data_admissaoMaskedTextBox.Enabled = False
            EmailTextBox.Enabled = False
            SalarioTextBox.Enabled = False
            CargoComboBox.Enabled = False
            NivelComboBox.Enabled = False
        End If
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        TbFuncionarioBindingSource.AddNew()
        NomeTextBox.Enabled = True
        CpfMaskedTextBox.Enabled = True
        LoginTextBox.Enabled = True
        SenhaTextBox.Enabled = True
        TelefoneMaskedTextBox.Enabled = True
        Data_admissaoMaskedTextBox.Enabled = True
        EmailTextBox.Enabled = True
        SalarioTextBox.Enabled = True
        CargoComboBox.Enabled = True
        NivelComboBox.Enabled = True
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
                salvar(0) = True
            Else
                lblValidador.Text = "CPF inválido."
                lblValidador.ForeColor = Color.Red
                salvar(0) = False
            End If
        Else
            lblValidador.Text = "..."
            lblValidador.ForeColor = Color.White
            salvar(0) = False
        End If
    End Sub

    Private Sub SalarioTextBox_Leave(sender As Object, e As EventArgs) Handles SalarioTextBox.Leave
        If SalarioTextBox.Text <> Nothing And SalarioTextBox.Text.ToLower = SalarioTextBox.Text.ToUpper Or SalarioTextBox.Text <> Nothing And SalarioTextBox.Text = FormatCurrency(SalarioTextBox.Text) Then
            SalarioTextBox.Text = FormatCurrency(SalarioTextBox.Text)
            salvar(1) = True
        Else
            salvar(1) = False
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

    Private Sub btnViewPass_Click(sender As Object, e As EventArgs) Handles btnViewPass.Click
        If showPass = False Then
            SenhaTextBox.UseSystemPasswordChar = False
            showPass = True
            btnViewPass.BackgroundImage = My.Resources.baseline_visibility_white_36dp
        Else
            SenhaTextBox.UseSystemPasswordChar = True
            showPass = False
            btnViewPass.BackgroundImage = My.Resources.baseline_visibility_off_white_36dp
        End If
    End Sub

    Private Sub SalarioTextBox_TextChanged(sender As Object, e As EventArgs) Handles SalarioTextBox.TextChanged
        Try
            If SalarioTextBox.Text <> Nothing And SalarioTextBox.Text.ToLower = SalarioTextBox.Text.ToUpper Or SalarioTextBox.Text <> Nothing And SalarioTextBox.Text = FormatCurrency(SalarioTextBox.Text) Then
                salvar(1) = True
            Else
                salvar(1) = False
            End If
        Catch ex As Exception
            salvar(1) = False
        End Try
    End Sub
End Class