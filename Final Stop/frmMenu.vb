Imports System.Drawing.ColorTranslator

Public Class frmMenu

    Dim cadastro As Boolean = False
    Dim relatorio As Boolean = False
    Dim sobre As Boolean = False
    Dim projetosFuturos As Boolean = False
    Dim mouseClicked As Boolean
    Dim total As Double
    Dim clickedAt As Point
    Dim currentItem As Integer = 0

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DbFinalStopDataSet.tbProduto'. Você pode movê-la ou removê-la conforme necessário.
        TbProdutoTableAdapter.FillQuantidade(DbFinalStopDataSet.tbProduto)
        lblBemVindo.Text = "Bem vindo, " + userName
        lblHora.Text = TimeOfDay
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Application.Exit()
    End Sub

    Private Sub tmrHora_Tick(sender As Object, e As EventArgs) Handles tmrHora.Tick
        lblHora.Text = TimeOfDay
    End Sub

    Private Sub btnCadastros_Click(sender As Object, e As EventArgs) Handles btnCadastros.Click
        If userLevel = 0 Then
            btnFuncionario.Visible = False
            btnProduto.Visible = False
            pnlBotoes.Size = New Size(150, 100)
        ElseIf userLevel = 1 Then
            btnFuncionario.Visible = False
            btnProduto.Location = New Point(0, 100)
            pnlBotoes.Size = New Size(150, 150)
        End If
        If cadastro = False Then
            cadastro = True
            relatorio = False
            pnlBotoes.Top = btnCadastros.Top
            pnlBotoes.Visible = True
            btnCadastros.BackColor = FromHtml("#202020")
            btnRelatorios.BackColor = FromHtml("#101010")
        Else
            cadastro = False
            relatorio = False
            btnRelatorios.Top = btnCadastros.Bottom
            pnlBotoes.Visible = False
            btnCadastros.BackColor = FromHtml("#101010")
        End If
    End Sub

    Private Sub btnRelatorios_Click(sender As Object, e As EventArgs) Handles btnRelatorios.Click
        If relatorio = False Then
            cadastro = False
            relatorio = True
            pnlBotoes.Top = btnRelatorios.Top
            pnlBotoes.Visible = True
            btnCadastros.BackColor = FromHtml("#101010")
            btnRelatorios.BackColor = FromHtml("#202020")
        Else
            cadastro = False
            relatorio = False
            pnlBotoes.Visible = False
            btnRelatorios.BackColor = FromHtml("#101010")
        End If
        If userLevel = 2 Then
            btnFuncionario.Visible = True
            btnProduto.Location = New Point(0, 150)
            pnlBotoes.Size = New Size(150, 200)
        Else
            btnFuncionario.Visible = False
            btnProduto.Location = New Point(0, 100)
            pnlBotoes.Size = New Size(150, 150)
        End If
        btnProduto.Visible = True
    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        If cadastro = True Then
            Dim frm As New frmCliente
            frm.ShowDialog()
        ElseIf relatorio = True Then
            Dim frm As New frmRelatorioCliente
            frm.ShowDialog()
        End If
    End Sub

    Private Sub btnFornecedor_Click(sender As Object, e As EventArgs) Handles btnFornecedor.Click
        If cadastro = True Then
            Dim frm As New frmFornecedor
            frm.ShowDialog()
        ElseIf relatorio = True Then
            Dim frm As New frmRelatorioFornecedor
            frm.ShowDialog()
        End If
    End Sub

    Private Sub btnFuncionario_Click(sender As Object, e As EventArgs) Handles btnFuncionario.Click
        If cadastro = True Then
            Dim frm As New frmFuncionario
            frm.ShowDialog()
        ElseIf relatorio = True Then
            Dim frm As New frmRelatorioFuncionario
            frm.ShowDialog()
        End If
    End Sub

    Private Sub btnProduto_Click(sender As Object, e As EventArgs) Handles btnProduto.Click
        If cadastro = True Then
            Dim frm As New frmProduto
            frm.ShowDialog()
        ElseIf relatorio = True Then
            Dim frm = New frmRelatorioProduto
            frm.ShowDialog()
        End If
    End Sub

    Private Sub btnDeslogar_Click(sender As Object, e As EventArgs) Handles btnDeslogar.Click
        If MessageBox.Show("Deseja realmente deslogar?", "Deslogando", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            Dispose()
            Dim frm As New frmLogin
            frm.ShowDialog()
        End If
    End Sub

    Private Sub frmMenu_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, pnlSidebar.MouseDown
        If e.Button <> MouseButtons.Left Then
            Return
        End If
        mouseClicked = True
        clickedAt = e.Location
    End Sub

    Private Sub frmMenu_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, pnlSidebar.MouseMove
        If mouseClicked Then
            Location = New Point(Cursor.Position.X - clickedAt.X, Cursor.Position.Y - clickedAt.Y)
        End If
    End Sub

    Private Sub frmMenu_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, pnlSidebar.MouseUp
        mouseClicked = False
    End Sub

    Private Sub btnSobre_Click(sender As Object, e As EventArgs) Handles btnSobre.Click
        If sobre = False Then
            'cduSobre.Visible = True
            'cduProjetosFuturos.Visible = False
            sobre = True
            projetosFuturos = False
        Else
            'cduSobre.Visible = False
            sobre = False
        End If
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        Try
            Dim id As Integer = cbbProdutos.SelectedValue
            TbProdutoTableAdapter.ConsultaProduto(DbFinalStopDataSet.tbProduto, id)

            lsvProdutos.Items.Add(DbFinalStopDataSet.Tables("tbProduto").Rows(0)("nome"))
            lsvProdutos.Items(currentItem).SubItems.Add(1)
            lsvProdutos.Items(currentItem).SubItems.Add(DbFinalStopDataSet.Tables("tbProduto").Rows(0)("preco_venda"))
            lsvProdutos.Items(currentItem).SubItems.Add(id)

            Dim quantidade = DbFinalStopDataSet.Tables("tbProduto").Rows(0)("quantidade") - 1
            TbProdutoTableAdapter.UpdateQuantidade(quantidade, id)
            TbProdutoTableAdapter.FillQuantidade(DbFinalStopDataSet.tbProduto)
            cbbProdutos.SelectedValue = id

            currentItem += 1
            tmrTotal.Start()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub tmrTotal_Tick(sender As Object, e As EventArgs) Handles tmrTotal.Tick
        Dim precoTotal As Double
        For Each lstItem As ListViewItem In lsvProdutos.Items
            precoTotal += Double.Parse(CDec(lstItem.SubItems(2).Text))
            lblPrecoTotal.Text = FormatCurrency(precoTotal)
        Next
        tmrTotal.Stop()
    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles btnRemover.Click
        Try
            Dim id = lsvProdutos.SelectedItems(0).SubItems(3).Text
            TbProdutoTableAdapter.ConsultaProduto(DbFinalStopDataSet.tbProduto, id)
            Dim quantidade = DbFinalStopDataSet.Tables("tbProduto").Rows(0)("quantidade") + 1
            TbProdutoTableAdapter.UpdateQuantidade(quantidade, id)

            lsvProdutos.Items.RemoveAt(lsvProdutos.SelectedIndices(0))
            currentItem -= 1

            TbProdutoTableAdapter.FillQuantidade(DbFinalStopDataSet.tbProduto)
            cbbProdutos.SelectedValue = id

            tmrTotal.Start()
            If lsvProdutos.Items.Count = 0 Then
                lblPrecoTotal.Text = "R$ 0,00"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnFecharVenda_Click(sender As Object, e As EventArgs) Handles btnFecharVenda.Click
        If lsvProdutos.Items.Count > 0 Then
            lsvProdutos.Items.Clear()
            MessageBox.Show("Venda realizada com sucesso. Total: " + lblPrecoTotal.Text, "Final Stop", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lblPrecoTotal.Text = "R$ 0,00"
            currentItem = 0
        End If
    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click
        TbProdutoTableAdapter.FillQuantidade(DbFinalStopDataSet.tbProduto)
    End Sub

    Private Sub btnProjetosFuturos_Click(sender As Object, e As EventArgs) Handles btnProjetosFuturos.Click
        If projetosFuturos = False Then
            'cduSobre.Visible = False
            'cduProjetosFuturos.Visible = True
            sobre = False
            projetosFuturos = True
        Else
            'cduProjetosFuturos.Visible = False
            projetosFuturos = False
        End If
    End Sub
End Class