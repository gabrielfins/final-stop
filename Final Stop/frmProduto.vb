Public Class frmProduto

    Dim salvar(3) As Boolean
    Dim foto As Image
    Dim mouseClicked As Boolean
    Dim clickedAt As Point

    Private Sub frmProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DbFinalStopDataSet.tbFornecedor'. Você pode movê-la ou removê-la conforme necessário.
        TbFornecedorTableAdapter.Fill(Me.DbFinalStopDataSet.tbFornecedor)
        'TODO: esta linha de código carrega dados na tabela 'DbFinalStopDataSet.tbProduto'. Você pode movê-la ou removê-la conforme necessário.
        TbProdutoTableAdapter.Fill(Me.DbFinalStopDataSet.tbProduto)

        FotoPictureBox.AllowDrop = True
        CheckImage()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        TbProdutoBindingSource.MovePrevious()
        CheckImage()
    End Sub

    Private Sub btnProximo_Click(sender As Object, e As EventArgs) Handles btnProximo.Click
        TbProdutoBindingSource.MoveNext()
        CheckImage()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        NomeTextBox.Enabled = True
        QuantidadeTextBox.Enabled = True
        FornecedorComboBox.Enabled = True
        TipoComboBox.Enabled = True
        Preco_vendaTextBox.Enabled = True
        Preco_unitarioTextBox.Enabled = True
        Numero_serieTextBox.Enabled = True
        FotoPictureBox.Enabled = True
        DescricaoTextBox.Enabled = True
        btnRemoverFoto.Visible = True
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Try
            If MessageBox.Show("Deseja realmente apagar o registro?", "Apagando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = vbYes Then
                TbProdutoBindingSource.RemoveCurrent()
                TbProdutoTableAdapter.Update(DbFinalStopDataSet.tbProduto)
            End If
        Catch ex As Exception
            MessageBox.Show("Não há registros para serem excluídos.", "Nenhum registro encontrado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If NomeTextBox.Text.Trim = Nothing Or TipoComboBox.Text.Trim = Nothing Or FornecedorComboBox.Text.Trim = Nothing Or salvar(0) = False Or salvar(1) = False Or salvar(2) = False Or Numero_serieTextBox.Text.Trim = Nothing Or DescricaoTextBox.Text.Trim = Nothing Then
            MessageBox.Show("Preencha todos os campos corretamente para realizar o cadastro.", "Algo deu errado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            TbProdutoBindingSource.EndEdit()
            TbProdutoTableAdapter.Update(DbFinalStopDataSet.tbProduto)
            MessageBox.Show("Produto salvo com sucesso!", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TbProdutoTableAdapter.Fill(DbFinalStopDataSet.tbProduto)
            NomeTextBox.Enabled = False
            QuantidadeTextBox.Enabled = False
            FornecedorComboBox.Enabled = False
            TipoComboBox.Enabled = False
            Preco_vendaTextBox.Enabled = False
            Preco_unitarioTextBox.Enabled = False
            Numero_serieTextBox.Enabled = False
            FotoPictureBox.Enabled = False
            DescricaoTextBox.Enabled = False
            btnRemoverFoto.Visible = False
        End If
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        TbProdutoBindingSource.AddNew()
        NomeTextBox.Enabled = True
        QuantidadeTextBox.Enabled = True
        FornecedorComboBox.Enabled = True
        TipoComboBox.Enabled = True
        Preco_vendaTextBox.Enabled = True
        Preco_unitarioTextBox.Enabled = True
        Numero_serieTextBox.Enabled = True
        FotoPictureBox.Enabled = True
        DescricaoTextBox.Enabled = True
        btnRemoverFoto.Visible = True
        CheckImage()
    End Sub

    Private Sub Preco_unitarioTextBox_Leave(sender As Object, e As EventArgs) Handles Preco_unitarioTextBox.Leave
        If Preco_unitarioTextBox.Text <> Nothing And Preco_unitarioTextBox.Text = FormatCurrency(Preco_unitarioTextBox.Text) Or Preco_unitarioTextBox.Text <> Nothing And Preco_unitarioTextBox.Text.ToLower = Preco_unitarioTextBox.Text.ToUpper Then
            Preco_unitarioTextBox.Text = FormatCurrency(Preco_unitarioTextBox.Text)
            salvar(0) = True
        Else
            salvar(0) = False
        End If
    End Sub

    Private Sub Preco_vendaTextBox_Leave(sender As Object, e As EventArgs) Handles Preco_vendaTextBox.Leave
        If Preco_vendaTextBox.Text <> Nothing And Preco_vendaTextBox.Text = FormatCurrency(Preco_vendaTextBox.Text) Or Preco_vendaTextBox.Text <> Nothing And Preco_vendaTextBox.Text.ToLower = Preco_vendaTextBox.Text.ToUpper Then
            Preco_vendaTextBox.Text = FormatCurrency(Preco_vendaTextBox.Text)
            salvar(1) = True
        Else
            salvar(1) = False
        End If
    End Sub

    Private Sub QuantidadeTextBox_TextChanged(sender As Object, e As EventArgs) Handles QuantidadeTextBox.TextChanged
        If QuantidadeTextBox.Text.ToLower = QuantidadeTextBox.Text.ToUpper Then
            salvar(2) = True
        Else
            salvar(2) = False
        End If
    End Sub
    Private Sub FotoPictureBox_Click(sender As Object, e As EventArgs) Handles FotoPictureBox.Click
        If ofd.ShowDialog = 1 Then
            FotoPictureBox.Image = Image.FromFile(ofd.FileName)
            CheckImage()
        End If
    End Sub

    Private Sub FotoPictureBox_DragDrop(sender As Object, e As DragEventArgs) Handles FotoPictureBox.DragDrop
        Dim data = e.Data.GetData(DataFormats.FileDrop)
        If data IsNot Nothing Then
            Try
                Dim filenames() As String = data
                If filenames.Length > 0 Then
                    FotoPictureBox.Image = Image.FromFile(filenames(0))
                    CheckImage()
                End If
            Catch ex As Exception
                MessageBox.Show("O arquivo arrastado não é uma imagem válida. Verifique a extensão do arquivo e tente novamente.", "Algo deu errado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CheckImage()
            End Try
        End If
    End Sub

    Private Sub FotoPictureBox_DragEnter(sender As Object, e As DragEventArgs) Handles FotoPictureBox.DragEnter
        e.Effect = DragDropEffects.Copy
        FotoPictureBox.BackgroundImage = My.Resources.drop_image
        FotoPictureBox.Image = Nothing
    End Sub

    Private Sub FotoPictureBox_DragLeave(sender As Object, e As EventArgs) Handles FotoPictureBox.DragLeave
        FotoPictureBox.BackgroundImage = My.Resources.select_photo_new
        FotoPictureBox.Image = foto
        CheckImage()
    End Sub

    Private Sub btnRemoverFoto_Click(sender As Object, e As EventArgs) Handles btnRemoverFoto.Click
        FotoPictureBox.Image = Nothing
        CheckImage()
    End Sub

    Private Sub CheckImage()
        foto = FotoPictureBox.Image
        If FotoPictureBox.Image Is Nothing Then
            FotoPictureBox.BackgroundImage = My.Resources.select_photo_new
        Else
            FotoPictureBox.BackgroundImage = Nothing
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

    Private Sub Preco_unitarioTextBox_TextChanged(sender As Object, e As EventArgs) Handles Preco_unitarioTextBox.TextChanged
        Try
            If Preco_unitarioTextBox.Text <> Nothing And Preco_unitarioTextBox.Text = FormatCurrency(Preco_unitarioTextBox.Text) Or Preco_unitarioTextBox.Text <> Nothing And Preco_unitarioTextBox.Text.ToLower = Preco_unitarioTextBox.Text.ToUpper Then
                salvar(0) = True
            Else
                salvar(0) = False
            End If
        Catch ex As Exception
            salvar(0) = False
        End Try
    End Sub

    Private Sub Preco_vendaTextBox_TextChanged(sender As Object, e As EventArgs) Handles Preco_vendaTextBox.TextChanged
        Try
            If Preco_vendaTextBox.Text <> Nothing And Preco_vendaTextBox.Text = FormatCurrency(Preco_vendaTextBox.Text) Or Preco_vendaTextBox.Text <> Nothing And Preco_vendaTextBox.Text.ToLower = Preco_vendaTextBox.Text.ToUpper Then
                salvar(1) = True
            Else
                salvar(1) = False
            End If
        Catch ex As Exception
            salvar(1) = False
        End Try
    End Sub

    Private Sub cmbPesquisa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPesquisa.SelectedIndexChanged
        tmrCheck.Start()
    End Sub

    Private Sub tmrCheck_Tick(sender As Object, e As EventArgs) Handles tmrCheck.Tick
        CheckImage()
        tmrCheck.Stop()
    End Sub
End Class