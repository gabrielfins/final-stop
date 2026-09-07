<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.tmrHora = New System.Windows.Forms.Timer(Me.components)
        Me.pnlBotoes = New System.Windows.Forms.Panel()
        Me.btnProduto = New System.Windows.Forms.Button()
        Me.btnFornecedor = New System.Windows.Forms.Button()
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.btnFuncionario = New System.Windows.Forms.Button()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.btnDeslogar = New System.Windows.Forms.Button()
        Me.btnSobre = New System.Windows.Forms.Button()
        Me.btnRelatorios = New System.Windows.Forms.Button()
        Me.btnCadastros = New System.Windows.Forms.Button()
        Me.TbProdutoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbFinalStopDataSet = New Final_Stop.dbFinalStopDataSet()
        Me.TbProdutoTableAdapter = New Final_Stop.dbFinalStopDataSetTableAdapters.tbProdutoTableAdapter()
        Me.TableAdapterManager = New Final_Stop.dbFinalStopDataSetTableAdapters.TableAdapterManager()
        Me.tmrTotal = New System.Windows.Forms.Timer(Me.components)
        Me.btnRemover = New System.Windows.Forms.Button()
        Me.lsvProdutos = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblPrecoTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.cbbProdutos = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblBemVindo = New System.Windows.Forms.Label()
        Me.btnFecharVenda = New System.Windows.Forms.Button()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.btnProjetosFuturos = New System.Windows.Forms.Button()
        Me.btnAtualizar = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.tipBtn = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlBotoes.SuspendLayout()
        CType(Me.TbProdutoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbFinalStopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSidebar.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrHora
        '
        Me.tmrHora.Enabled = True
        Me.tmrHora.Interval = 1000
        '
        'pnlBotoes
        '
        Me.pnlBotoes.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.pnlBotoes.Controls.Add(Me.btnProduto)
        Me.pnlBotoes.Controls.Add(Me.btnFornecedor)
        Me.pnlBotoes.Controls.Add(Me.btnCliente)
        Me.pnlBotoes.Controls.Add(Me.btnFuncionario)
        Me.pnlBotoes.Location = New System.Drawing.Point(190, 130)
        Me.pnlBotoes.Name = "pnlBotoes"
        Me.pnlBotoes.Size = New System.Drawing.Size(150, 200)
        Me.pnlBotoes.TabIndex = 1
        Me.pnlBotoes.Visible = False
        '
        'btnProduto
        '
        Me.btnProduto.FlatAppearance.BorderSize = 0
        Me.btnProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProduto.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnProduto.Location = New System.Drawing.Point(0, 150)
        Me.btnProduto.Name = "btnProduto"
        Me.btnProduto.Size = New System.Drawing.Size(150, 50)
        Me.btnProduto.TabIndex = 3
        Me.btnProduto.Text = "Produto"
        Me.btnProduto.UseVisualStyleBackColor = True
        '
        'btnFornecedor
        '
        Me.btnFornecedor.FlatAppearance.BorderSize = 0
        Me.btnFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFornecedor.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFornecedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnFornecedor.Location = New System.Drawing.Point(0, 50)
        Me.btnFornecedor.Name = "btnFornecedor"
        Me.btnFornecedor.Size = New System.Drawing.Size(150, 50)
        Me.btnFornecedor.TabIndex = 1
        Me.btnFornecedor.Text = "Fornecedor"
        Me.btnFornecedor.UseVisualStyleBackColor = True
        '
        'btnCliente
        '
        Me.btnCliente.FlatAppearance.BorderSize = 0
        Me.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCliente.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnCliente.Location = New System.Drawing.Point(0, 0)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(150, 50)
        Me.btnCliente.TabIndex = 0
        Me.btnCliente.Text = "Cliente"
        Me.btnCliente.UseVisualStyleBackColor = True
        '
        'btnFuncionario
        '
        Me.btnFuncionario.FlatAppearance.BorderSize = 0
        Me.btnFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFuncionario.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFuncionario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnFuncionario.Location = New System.Drawing.Point(0, 100)
        Me.btnFuncionario.Name = "btnFuncionario"
        Me.btnFuncionario.Size = New System.Drawing.Size(150, 50)
        Me.btnFuncionario.TabIndex = 2
        Me.btnFuncionario.Text = "Funcionário"
        Me.btnFuncionario.UseVisualStyleBackColor = True
        '
        'lblMenu
        '
        Me.lblMenu.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.ForeColor = System.Drawing.Color.White
        Me.lblMenu.Location = New System.Drawing.Point(0, 0)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(187, 100)
        Me.lblMenu.TabIndex = 0
        Me.lblMenu.Text = "Menu"
        Me.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDeslogar
        '
        Me.btnDeslogar.FlatAppearance.BorderSize = 0
        Me.btnDeslogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeslogar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeslogar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnDeslogar.Location = New System.Drawing.Point(0, 500)
        Me.btnDeslogar.Name = "btnDeslogar"
        Me.btnDeslogar.Size = New System.Drawing.Size(190, 50)
        Me.btnDeslogar.TabIndex = 4
        Me.btnDeslogar.Text = "Deslogar"
        Me.btnDeslogar.UseVisualStyleBackColor = True
        '
        'btnSobre
        '
        Me.btnSobre.FlatAppearance.BorderSize = 0
        Me.btnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSobre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSobre.ForeColor = System.Drawing.Color.White
        Me.btnSobre.Location = New System.Drawing.Point(0, 450)
        Me.btnSobre.Name = "btnSobre"
        Me.btnSobre.Size = New System.Drawing.Size(190, 50)
        Me.btnSobre.TabIndex = 3
        Me.btnSobre.Text = "Sobre"
        Me.btnSobre.UseVisualStyleBackColor = True
        '
        'btnRelatorios
        '
        Me.btnRelatorios.FlatAppearance.BorderSize = 0
        Me.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRelatorios.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRelatorios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnRelatorios.Image = Global.Final_Stop.My.Resources.Resources.seta_yellow
        Me.btnRelatorios.Location = New System.Drawing.Point(0, 180)
        Me.btnRelatorios.Name = "btnRelatorios"
        Me.btnRelatorios.Size = New System.Drawing.Size(190, 50)
        Me.btnRelatorios.TabIndex = 2
        Me.btnRelatorios.Text = "Relatórios"
        Me.btnRelatorios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRelatorios.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnRelatorios.UseVisualStyleBackColor = True
        '
        'btnCadastros
        '
        Me.btnCadastros.FlatAppearance.BorderSize = 0
        Me.btnCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastros.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastros.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnCadastros.Image = Global.Final_Stop.My.Resources.Resources.seta_yellow
        Me.btnCadastros.Location = New System.Drawing.Point(0, 130)
        Me.btnCadastros.Name = "btnCadastros"
        Me.btnCadastros.Size = New System.Drawing.Size(190, 50)
        Me.btnCadastros.TabIndex = 1
        Me.btnCadastros.Text = "Cadastros"
        Me.btnCadastros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCadastros.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnCadastros.UseVisualStyleBackColor = False
        '
        'TbProdutoBindingSource
        '
        Me.TbProdutoBindingSource.DataMember = "tbProduto"
        Me.TbProdutoBindingSource.DataSource = Me.DbFinalStopDataSet
        '
        'DbFinalStopDataSet
        '
        Me.DbFinalStopDataSet.DataSetName = "dbFinalStopDataSet"
        Me.DbFinalStopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbProdutoTableAdapter
        '
        Me.TbProdutoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbClienteTableAdapter = Nothing
        Me.TableAdapterManager.tbFornecedorTableAdapter = Nothing
        Me.TableAdapterManager.tbFuncionarioTableAdapter = Nothing
        Me.TableAdapterManager.tbProdutoTableAdapter = Me.TbProdutoTableAdapter
        Me.TableAdapterManager.UpdateOrder = Final_Stop.dbFinalStopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'tmrTotal
        '
        Me.tmrTotal.Enabled = True
        Me.tmrTotal.Interval = 1
        '
        'btnRemover
        '
        Me.btnRemover.BackgroundImage = Global.Final_Stop.My.Resources.Resources.remove_yellow
        Me.btnRemover.FlatAppearance.BorderSize = 0
        Me.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemover.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemover.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnRemover.Location = New System.Drawing.Point(779, 442)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(36, 36)
        Me.btnRemover.TabIndex = 26
        Me.tipBtn.SetToolTip(Me.btnRemover, "Remover")
        Me.btnRemover.UseVisualStyleBackColor = True
        '
        'lsvProdutos
        '
        Me.lsvProdutos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lsvProdutos.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvProdutos.FullRowSelect = True
        Me.lsvProdutos.HideSelection = False
        Me.lsvProdutos.Location = New System.Drawing.Point(255, 182)
        Me.lsvProdutos.MultiSelect = False
        Me.lsvProdutos.Name = "lsvProdutos"
        Me.lsvProdutos.Size = New System.Drawing.Size(560, 247)
        Me.lsvProdutos.TabIndex = 25
        Me.lsvProdutos.UseCompatibleStateImageBehavior = False
        Me.lsvProdutos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Produto"
        Me.ColumnHeader1.Width = 257
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Quantidade"
        Me.ColumnHeader2.Width = 97
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Preço"
        Me.ColumnHeader3.Width = 138
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "ID"
        '
        'lblPrecoTotal
        '
        Me.lblPrecoTotal.AutoSize = True
        Me.lblPrecoTotal.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecoTotal.ForeColor = System.Drawing.Color.White
        Me.lblPrecoTotal.Location = New System.Drawing.Point(306, 451)
        Me.lblPrecoTotal.Name = "lblPrecoTotal"
        Me.lblPrecoTotal.Size = New System.Drawing.Size(62, 19)
        Me.lblPrecoTotal.TabIndex = 24
        Me.lblPrecoTotal.Text = "R$ 0,00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(252, 451)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 19)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Total:"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.BackgroundImage = Global.Final_Stop.My.Resources.Resources.add_circle_yellow
        Me.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdicionar.FlatAppearance.BorderSize = 0
        Me.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdicionar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdicionar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnAdicionar.Location = New System.Drawing.Point(779, 129)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(36, 36)
        Me.btnAdicionar.TabIndex = 22
        Me.tipBtn.SetToolTip(Me.btnAdicionar, "Adicionar")
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'cbbProdutos
        '
        Me.cbbProdutos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbbProdutos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbbProdutos.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.cbbProdutos.DataSource = Me.TbProdutoBindingSource
        Me.cbbProdutos.DisplayMember = "nome"
        Me.cbbProdutos.DropDownHeight = 108
        Me.cbbProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbbProdutos.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbProdutos.ForeColor = System.Drawing.Color.White
        Me.cbbProdutos.FormattingEnabled = True
        Me.cbbProdutos.IntegralHeight = False
        Me.cbbProdutos.Location = New System.Drawing.Point(326, 135)
        Me.cbbProdutos.Name = "cbbProdutos"
        Me.cbbProdutos.Size = New System.Drawing.Size(427, 26)
        Me.cbbProdutos.TabIndex = 21
        Me.cbbProdutos.ValueMember = "id_produto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(252, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 18)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Produto:"
        '
        'btnMinimizar
        '
        Me.btnMinimizar.BackgroundImage = Global.Final_Stop.My.Resources.Resources.minimize2
        Me.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Location = New System.Drawing.Point(820, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(30, 30)
        Me.btnMinimizar.TabIndex = 19
        Me.btnMinimizar.TabStop = False
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'lblHora
        '
        Me.lblHora.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.lblHora.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblHora.Location = New System.Drawing.Point(798, 512)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(76, 27)
        Me.lblHora.TabIndex = 18
        Me.lblHora.Text = "Hora"
        Me.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnFechar
        '
        Me.btnFechar.BackgroundImage = Global.Final_Stop.My.Resources.Resources.close
        Me.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFechar.FlatAppearance.BorderSize = 0
        Me.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.Location = New System.Drawing.Point(850, 0)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(30, 30)
        Me.btnFechar.TabIndex = 15
        Me.btnFechar.TabStop = False
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Final_Stop.My.Resources.Resources.final_stop_logo_new_no_borders
        Me.PictureBox1.Location = New System.Drawing.Point(335, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(401, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'lblBemVindo
        '
        Me.lblBemVindo.AutoSize = True
        Me.lblBemVindo.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.lblBemVindo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBemVindo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblBemVindo.Location = New System.Drawing.Point(208, 517)
        Me.lblBemVindo.Name = "lblBemVindo"
        Me.lblBemVindo.Size = New System.Drawing.Size(112, 16)
        Me.lblBemVindo.TabIndex = 17
        Me.lblBemVindo.Text = "Bem vindo, Nome"
        '
        'btnFecharVenda
        '
        Me.btnFecharVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFecharVenda.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFecharVenda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnFecharVenda.Location = New System.Drawing.Point(468, 442)
        Me.btnFecharVenda.Name = "btnFecharVenda"
        Me.btnFecharVenda.Size = New System.Drawing.Size(135, 36)
        Me.btnFecharVenda.TabIndex = 27
        Me.btnFecharVenda.Text = "Fechar Venda"
        Me.btnFecharVenda.UseVisualStyleBackColor = True
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.btnProjetosFuturos)
        Me.pnlSidebar.Controls.Add(Me.lblMenu)
        Me.pnlSidebar.Controls.Add(Me.btnDeslogar)
        Me.pnlSidebar.Controls.Add(Me.btnCadastros)
        Me.pnlSidebar.Controls.Add(Me.btnSobre)
        Me.pnlSidebar.Controls.Add(Me.btnRelatorios)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(190, 550)
        Me.pnlSidebar.TabIndex = 28
        '
        'btnProjetosFuturos
        '
        Me.btnProjetosFuturos.FlatAppearance.BorderSize = 0
        Me.btnProjetosFuturos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProjetosFuturos.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProjetosFuturos.ForeColor = System.Drawing.Color.White
        Me.btnProjetosFuturos.Location = New System.Drawing.Point(0, 400)
        Me.btnProjetosFuturos.Name = "btnProjetosFuturos"
        Me.btnProjetosFuturos.Size = New System.Drawing.Size(190, 50)
        Me.btnProjetosFuturos.TabIndex = 5
        Me.btnProjetosFuturos.Text = "Projetos Futuros"
        Me.btnProjetosFuturos.UseVisualStyleBackColor = True
        '
        'btnAtualizar
        '
        Me.btnAtualizar.BackgroundImage = Global.Final_Stop.My.Resources.Resources.refresh_yellow
        Me.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAtualizar.FlatAppearance.BorderSize = 0
        Me.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtualizar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtualizar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnAtualizar.Location = New System.Drawing.Point(737, 442)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(36, 36)
        Me.btnAtualizar.TabIndex = 29
        Me.tipBtn.SetToolTip(Me.btnAtualizar, "Atualizar")
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(880, 550)
        Me.Controls.Add(Me.pnlBotoes)
        Me.Controls.Add(Me.btnMinimizar)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnAtualizar)
        Me.Controls.Add(Me.btnFecharVenda)
        Me.Controls.Add(Me.btnRemover)
        Me.Controls.Add(Me.lblPrecoTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Controls.Add(Me.lsvProdutos)
        Me.Controls.Add(Me.cbbProdutos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.lblBemVindo)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Final Stop"
        Me.pnlBotoes.ResumeLayout(False)
        CType(Me.TbProdutoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbFinalStopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSidebar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrHora As Timer
    Friend WithEvents btnCadastros As Button
    Friend WithEvents btnDeslogar As Button
    Friend WithEvents btnSobre As Button
    Friend WithEvents btnRelatorios As Button
    Friend WithEvents pnlBotoes As Panel
    Friend WithEvents btnFornecedor As Button
    Friend WithEvents btnCliente As Button
    Friend WithEvents lblMenu As Label
    Friend WithEvents btnProduto As Button
    Friend WithEvents btnFuncionario As Button
    Friend WithEvents DbFinalStopDataSet As dbFinalStopDataSet
    Friend WithEvents TbProdutoBindingSource As BindingSource
    Friend WithEvents TbProdutoTableAdapter As dbFinalStopDataSetTableAdapters.tbProdutoTableAdapter
    Friend WithEvents TableAdapterManager As dbFinalStopDataSetTableAdapters.TableAdapterManager
    Friend WithEvents tmrTotal As Timer
    Friend WithEvents btnRemover As Button
    Friend WithEvents lsvProdutos As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents lblPrecoTotal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents cbbProdutos As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents lblHora As Label
    Friend WithEvents btnFechar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblBemVindo As Label
    Friend WithEvents btnFecharVenda As Button
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents btnAtualizar As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents btnProjetosFuturos As Button
    Friend WithEvents tipBtn As ToolTip
End Class
