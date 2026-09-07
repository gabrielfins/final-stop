Public Class frmLogin

    Dim mouseClicked As Boolean
    Dim showPass As Boolean = False
    Dim clickedAt As Point

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DbFinalStopDataSet.tbFuncionario'. Você pode movê-la ou removê-la conforme necessário.
        Me.TbFuncionarioTableAdapter.Fill(Me.DbFinalStopDataSet.tbFuncionario)

    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        Dim login = TbFuncionarioTableAdapter.Login(DbFinalStopDataSet.tbFuncionario, txtLogin.Text, txtSenha.Text)
        If login = 0 Then
            MessageBox.Show("Usuário ou senha inválidos.", "Dados incorretos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            userName = DbFinalStopDataSet.Tables("tbFuncionario").Rows(0)("nome")
            userLevel = DbFinalStopDataSet.Tables("tbFuncionario").Rows(0)("nivel")
            Hide()
            Dim frm As New frmMenu
            frm.ShowDialog()
            Dispose()
        End If
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Application.Exit()
    End Sub

    Private Sub pnlTopBar_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, Panel4.MouseDown
        If e.Button <> MouseButtons.Left Then
            Return
        End If
        mouseClicked = True
        clickedAt = e.Location
    End Sub

    Private Sub pnlTopBar_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, Panel4.MouseMove
        If mouseClicked Then
            Location = New Point(Cursor.Position.X - clickedAt.X, Cursor.Position.Y - clickedAt.Y)
        End If
    End Sub

    Private Sub pnlTopBar_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, Panel4.MouseUp
        mouseClicked = False
    End Sub

    Private Sub btnViewPass_Click(sender As Object, e As EventArgs) Handles btnViewPass.Click
        If showPass = False Then
            txtSenha.UseSystemPasswordChar = False
            showPass = True
            btnViewPass.BackgroundImage = My.Resources.baseline_visibility_white_36dp
        Else
            txtSenha.UseSystemPasswordChar = True
            showPass = False
            btnViewPass.BackgroundImage = My.Resources.baseline_visibility_off_white_36dp
        End If
    End Sub

    Private Sub txtLogin_Enter(sender As Object, e As EventArgs) Handles txtLogin.Enter, txtSenha.Enter
        sender.SelectAll()
    End Sub
End Class
