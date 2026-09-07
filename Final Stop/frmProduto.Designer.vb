<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProduto
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
        Dim FornecedorLabel As System.Windows.Forms.Label
        Dim Preco_unitarioLabel As System.Windows.Forms.Label
        Dim Preco_vendaLabel As System.Windows.Forms.Label
        Dim QuantidadeLabel As System.Windows.Forms.Label
        Dim DescricaoLabel As System.Windows.Forms.Label
        Dim Numero_serieLabel As System.Windows.Forms.Label
        Dim FotoLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim TipoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProduto))
        Me.cmbPesquisa = New System.Windows.Forms.ComboBox()
        Me.TbProdutoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbFinalStopDataSet = New Final_Stop.dbFinalStopDataSet()
        Me.FotoPictureBox = New System.Windows.Forms.PictureBox()
        Me.Numero_serieTextBox = New System.Windows.Forms.TextBox()
        Me.DescricaoTextBox = New System.Windows.Forms.TextBox()
        Me.QuantidadeTextBox = New System.Windows.Forms.TextBox()
        Me.Preco_vendaTextBox = New System.Windows.Forms.TextBox()
        Me.Preco_unitarioTextBox = New System.Windows.Forms.TextBox()
        Me.FornecedorComboBox = New System.Windows.Forms.ComboBox()
        Me.TbFornecedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoComboBox = New System.Windows.Forms.ComboBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.TbProdutoTableAdapter = New Final_Stop.dbFinalStopDataSetTableAdapters.tbProdutoTableAdapter()
        Me.TableAdapterManager = New Final_Stop.dbFinalStopDataSetTableAdapters.TableAdapterManager()
        Me.TbFornecedorTableAdapter = New Final_Stop.dbFinalStopDataSetTableAdapters.tbFornecedorTableAdapter()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.btnRemoverFoto = New System.Windows.Forms.Button()
        Me.gpbAcoes = New System.Windows.Forms.GroupBox()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnProximo = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPesquisa = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.tmrCheck = New System.Windows.Forms.Timer(Me.components)
        Me.toolBtn = New System.Windows.Forms.ToolTip(Me.components)
        FornecedorLabel = New System.Windows.Forms.Label()
        Preco_unitarioLabel = New System.Windows.Forms.Label()
        Preco_vendaLabel = New System.Windows.Forms.Label()
        QuantidadeLabel = New System.Windows.Forms.Label()
        DescricaoLabel = New System.Windows.Forms.Label()
        Numero_serieLabel = New System.Windows.Forms.Label()
        FotoLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        CType(Me.TbProdutoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbFinalStopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FotoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbFornecedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbAcoes.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FornecedorLabel
        '
        FornecedorLabel.AutoSize = True
        FornecedorLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FornecedorLabel.Location = New System.Drawing.Point(44, 265)
        FornecedorLabel.Name = "FornecedorLabel"
        FornecedorLabel.Size = New System.Drawing.Size(102, 19)
        FornecedorLabel.TabIndex = 9
        FornecedorLabel.Text = "Fornecedor:"
        '
        'Preco_unitarioLabel
        '
        Preco_unitarioLabel.AutoSize = True
        Preco_unitarioLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Preco_unitarioLabel.Location = New System.Drawing.Point(44, 312)
        Preco_unitarioLabel.Name = "Preco_unitarioLabel"
        Preco_unitarioLabel.Size = New System.Drawing.Size(119, 19)
        Preco_unitarioLabel.TabIndex = 13
        Preco_unitarioLabel.Text = "Preço Unitário:"
        '
        'Preco_vendaLabel
        '
        Preco_vendaLabel.AutoSize = True
        Preco_vendaLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Preco_vendaLabel.Location = New System.Drawing.Point(329, 312)
        Preco_vendaLabel.Name = "Preco_vendaLabel"
        Preco_vendaLabel.Size = New System.Drawing.Size(139, 19)
        Preco_vendaLabel.TabIndex = 16
        Preco_vendaLabel.Text = "Preço de Venda:"
        '
        'QuantidadeLabel
        '
        QuantidadeLabel.AutoSize = True
        QuantidadeLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QuantidadeLabel.Location = New System.Drawing.Point(359, 215)
        QuantidadeLabel.Name = "QuantidadeLabel"
        QuantidadeLabel.Size = New System.Drawing.Size(108, 19)
        QuantidadeLabel.TabIndex = 6
        QuantidadeLabel.Text = "Quantidade:"
        '
        'DescricaoLabel
        '
        DescricaoLabel.AutoSize = True
        DescricaoLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescricaoLabel.Location = New System.Drawing.Point(44, 412)
        DescricaoLabel.Name = "DescricaoLabel"
        DescricaoLabel.Size = New System.Drawing.Size(90, 19)
        DescricaoLabel.TabIndex = 23
        DescricaoLabel.Text = "Descrição:"
        '
        'Numero_serieLabel
        '
        Numero_serieLabel.AutoSize = True
        Numero_serieLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Numero_serieLabel.Location = New System.Drawing.Point(44, 365)
        Numero_serieLabel.Name = "Numero_serieLabel"
        Numero_serieLabel.Size = New System.Drawing.Size(142, 19)
        Numero_serieLabel.TabIndex = 19
        Numero_serieLabel.Text = "Número de Série:"
        '
        'FotoLabel
        '
        FotoLabel.AutoSize = True
        FotoLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FotoLabel.Location = New System.Drawing.Point(359, 365)
        FotoLabel.Name = "FotoLabel"
        FotoLabel.Size = New System.Drawing.Size(45, 19)
        FotoLabel.TabIndex = 22
        FotoLabel.Text = "Foto:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NomeLabel.Location = New System.Drawing.Point(44, 215)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(61, 19)
        NomeLabel.TabIndex = 3
        NomeLabel.Text = "Nome:"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TipoLabel.Location = New System.Drawing.Point(359, 265)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(45, 19)
        TipoLabel.TabIndex = 11
        TipoLabel.Text = "Tipo:"
        '
        'cmbPesquisa
        '
        Me.cmbPesquisa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPesquisa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPesquisa.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.cmbPesquisa.DataSource = Me.TbProdutoBindingSource
        Me.cmbPesquisa.DisplayMember = "nome"
        Me.cmbPesquisa.DropDownHeight = 114
        Me.cmbPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPesquisa.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPesquisa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.cmbPesquisa.FormattingEnabled = True
        Me.cmbPesquisa.IntegralHeight = False
        Me.cmbPesquisa.Location = New System.Drawing.Point(125, 155)
        Me.cmbPesquisa.Name = "cmbPesquisa"
        Me.cmbPesquisa.Size = New System.Drawing.Size(380, 27)
        Me.cmbPesquisa.TabIndex = 2
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
        'FotoPictureBox
        '
        Me.FotoPictureBox.BackgroundImage = Global.Final_Stop.My.Resources.Resources.select_photo_new
        Me.FotoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FotoPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.TbProdutoBindingSource, "foto", True))
        Me.FotoPictureBox.Enabled = False
        Me.FotoPictureBox.Location = New System.Drawing.Point(410, 365)
        Me.FotoPictureBox.Name = "FotoPictureBox"
        Me.FotoPictureBox.Size = New System.Drawing.Size(160, 160)
        Me.FotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FotoPictureBox.TabIndex = 17
        Me.FotoPictureBox.TabStop = False
        '
        'Numero_serieTextBox
        '
        Me.Numero_serieTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Numero_serieTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Numero_serieTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProdutoBindingSource, "numero_serie", True))
        Me.Numero_serieTextBox.Enabled = False
        Me.Numero_serieTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Numero_serieTextBox.ForeColor = System.Drawing.Color.White
        Me.Numero_serieTextBox.Location = New System.Drawing.Point(192, 364)
        Me.Numero_serieTextBox.Name = "Numero_serieTextBox"
        Me.Numero_serieTextBox.Size = New System.Drawing.Size(145, 20)
        Me.Numero_serieTextBox.TabIndex = 21
        '
        'DescricaoTextBox
        '
        Me.DescricaoTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.DescricaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProdutoBindingSource, "descricao", True))
        Me.DescricaoTextBox.Enabled = False
        Me.DescricaoTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescricaoTextBox.ForeColor = System.Drawing.Color.White
        Me.DescricaoTextBox.Location = New System.Drawing.Point(48, 434)
        Me.DescricaoTextBox.Multiline = True
        Me.DescricaoTextBox.Name = "DescricaoTextBox"
        Me.DescricaoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DescricaoTextBox.Size = New System.Drawing.Size(319, 91)
        Me.DescricaoTextBox.TabIndex = 24
        '
        'QuantidadeTextBox
        '
        Me.QuantidadeTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.QuantidadeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.QuantidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProdutoBindingSource, "quantidade", True))
        Me.QuantidadeTextBox.Enabled = False
        Me.QuantidadeTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantidadeTextBox.ForeColor = System.Drawing.Color.White
        Me.QuantidadeTextBox.Location = New System.Drawing.Point(473, 213)
        Me.QuantidadeTextBox.Name = "QuantidadeTextBox"
        Me.QuantidadeTextBox.Size = New System.Drawing.Size(127, 20)
        Me.QuantidadeTextBox.TabIndex = 8
        '
        'Preco_vendaTextBox
        '
        Me.Preco_vendaTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Preco_vendaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Preco_vendaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProdutoBindingSource, "preco_venda", True))
        Me.Preco_vendaTextBox.Enabled = False
        Me.Preco_vendaTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Preco_vendaTextBox.ForeColor = System.Drawing.Color.White
        Me.Preco_vendaTextBox.Location = New System.Drawing.Point(473, 311)
        Me.Preco_vendaTextBox.Name = "Preco_vendaTextBox"
        Me.Preco_vendaTextBox.Size = New System.Drawing.Size(127, 20)
        Me.Preco_vendaTextBox.TabIndex = 18
        '
        'Preco_unitarioTextBox
        '
        Me.Preco_unitarioTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Preco_unitarioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Preco_unitarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProdutoBindingSource, "preco_unitario", True))
        Me.Preco_unitarioTextBox.Enabled = False
        Me.Preco_unitarioTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Preco_unitarioTextBox.ForeColor = System.Drawing.Color.White
        Me.Preco_unitarioTextBox.Location = New System.Drawing.Point(169, 310)
        Me.Preco_unitarioTextBox.Name = "Preco_unitarioTextBox"
        Me.Preco_unitarioTextBox.Size = New System.Drawing.Size(149, 20)
        Me.Preco_unitarioTextBox.TabIndex = 15
        '
        'FornecedorComboBox
        '
        Me.FornecedorComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.FornecedorComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.FornecedorComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.FornecedorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProdutoBindingSource, "fornecedor", True))
        Me.FornecedorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TbProdutoBindingSource, "fornecedor", True))
        Me.FornecedorComboBox.DataSource = Me.TbFornecedorBindingSource
        Me.FornecedorComboBox.DisplayMember = "nome_fantasia"
        Me.FornecedorComboBox.Enabled = False
        Me.FornecedorComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FornecedorComboBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FornecedorComboBox.ForeColor = System.Drawing.Color.White
        Me.FornecedorComboBox.FormattingEnabled = True
        Me.FornecedorComboBox.Location = New System.Drawing.Point(152, 261)
        Me.FornecedorComboBox.Name = "FornecedorComboBox"
        Me.FornecedorComboBox.Size = New System.Drawing.Size(188, 27)
        Me.FornecedorComboBox.TabIndex = 10
        Me.FornecedorComboBox.ValueMember = "nome_fantasia"
        '
        'TbFornecedorBindingSource
        '
        Me.TbFornecedorBindingSource.DataMember = "tbFornecedor"
        Me.TbFornecedorBindingSource.DataSource = Me.DbFinalStopDataSet
        '
        'TipoComboBox
        '
        Me.TipoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TipoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TipoComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TipoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProdutoBindingSource, "tipo", True))
        Me.TipoComboBox.Enabled = False
        Me.TipoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TipoComboBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoComboBox.ForeColor = System.Drawing.Color.White
        Me.TipoComboBox.FormattingEnabled = True
        Me.TipoComboBox.Items.AddRange(New Object() {"Eletrodoméstico", "Eletroeletrônico", "Eletroportátil"})
        Me.TipoComboBox.Location = New System.Drawing.Point(410, 261)
        Me.TipoComboBox.Name = "TipoComboBox"
        Me.TipoComboBox.Size = New System.Drawing.Size(190, 27)
        Me.TipoComboBox.TabIndex = 12
        '
        'NomeTextBox
        '
        Me.NomeTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.NomeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbProdutoBindingSource, "nome", True))
        Me.NomeTextBox.Enabled = False
        Me.NomeTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeTextBox.ForeColor = System.Drawing.Color.White
        Me.NomeTextBox.Location = New System.Drawing.Point(111, 214)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(229, 20)
        Me.NomeTextBox.TabIndex = 5
        '
        'TbProdutoTableAdapter
        '
        Me.TbProdutoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbClienteTableAdapter = Nothing
        Me.TableAdapterManager.tbFornecedorTableAdapter = Me.TbFornecedorTableAdapter
        Me.TableAdapterManager.tbFuncionarioTableAdapter = Nothing
        Me.TableAdapterManager.tbProdutoTableAdapter = Me.TbProdutoTableAdapter
        Me.TableAdapterManager.UpdateOrder = Final_Stop.dbFinalStopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TbFornecedorTableAdapter
        '
        Me.TbFornecedorTableAdapter.ClearBeforeFill = True
        '
        'ofd
        '
        Me.ofd.FileName = "OpenFileDialog1"
        '
        'btnRemoverFoto
        '
        Me.btnRemoverFoto.BackgroundImage = Global.Final_Stop.My.Resources.Resources.remove
        Me.btnRemoverFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRemoverFoto.FlatAppearance.BorderSize = 0
        Me.btnRemoverFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoverFoto.Location = New System.Drawing.Point(576, 489)
        Me.btnRemoverFoto.Name = "btnRemoverFoto"
        Me.btnRemoverFoto.Size = New System.Drawing.Size(36, 36)
        Me.btnRemoverFoto.TabIndex = 25
        Me.btnRemoverFoto.TabStop = False
        Me.btnRemoverFoto.UseVisualStyleBackColor = True
        Me.btnRemoverFoto.Visible = False
        '
        'gpbAcoes
        '
        Me.gpbAcoes.Controls.Add(Me.btnAdicionar)
        Me.gpbAcoes.Controls.Add(Me.btnSalvar)
        Me.gpbAcoes.Controls.Add(Me.btnExcluir)
        Me.gpbAcoes.Controls.Add(Me.btnEditar)
        Me.gpbAcoes.Controls.Add(Me.btnProximo)
        Me.gpbAcoes.Controls.Add(Me.btnAnterior)
        Me.gpbAcoes.ForeColor = System.Drawing.Color.White
        Me.gpbAcoes.Location = New System.Drawing.Point(191, 561)
        Me.gpbAcoes.Name = "gpbAcoes"
        Me.gpbAcoes.Size = New System.Drawing.Size(262, 76)
        Me.gpbAcoes.TabIndex = 26
        Me.gpbAcoes.TabStop = False
        Me.gpbAcoes.Text = "Ações"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.BackgroundImage = Global.Final_Stop.My.Resources.Resources.add
        Me.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdicionar.FlatAppearance.BorderSize = 0
        Me.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdicionar.Location = New System.Drawing.Point(219, 25)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(36, 36)
        Me.btnAdicionar.TabIndex = 5
        Me.toolBtn.SetToolTip(Me.btnAdicionar, "Adicionar")
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.BackgroundImage = Global.Final_Stop.My.Resources.Resources.save
        Me.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalvar.FlatAppearance.BorderSize = 0
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvar.Location = New System.Drawing.Point(177, 25)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(36, 36)
        Me.btnSalvar.TabIndex = 4
        Me.toolBtn.SetToolTip(Me.btnSalvar, "Salvar")
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.BackgroundImage = Global.Final_Stop.My.Resources.Resources.trash
        Me.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExcluir.FlatAppearance.BorderSize = 0
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Location = New System.Drawing.Point(133, 25)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(36, 36)
        Me.btnExcluir.TabIndex = 3
        Me.toolBtn.SetToolTip(Me.btnExcluir, "Excluir")
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.BackgroundImage = Global.Final_Stop.My.Resources.Resources.edit
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Location = New System.Drawing.Point(91, 25)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(36, 36)
        Me.btnEditar.TabIndex = 2
        Me.toolBtn.SetToolTip(Me.btnEditar, "Editar")
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnProximo
        '
        Me.btnProximo.BackgroundImage = Global.Final_Stop.My.Resources.Resources.arrow_right
        Me.btnProximo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnProximo.FlatAppearance.BorderSize = 0
        Me.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProximo.Location = New System.Drawing.Point(49, 25)
        Me.btnProximo.Name = "btnProximo"
        Me.btnProximo.Size = New System.Drawing.Size(36, 36)
        Me.btnProximo.TabIndex = 1
        Me.toolBtn.SetToolTip(Me.btnProximo, "Avançar")
        Me.btnProximo.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.BackgroundImage = Global.Final_Stop.My.Resources.Resources.arrow_left
        Me.btnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAnterior.FlatAppearance.BorderSize = 0
        Me.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnterior.Location = New System.Drawing.Point(7, 25)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(36, 36)
        Me.btnAnterior.TabIndex = 0
        Me.toolBtn.SetToolTip(Me.btnAnterior, "Voltar")
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.btnFechar)
        Me.pnlTop.Controls.Add(Me.PictureBox1)
        Me.pnlTop.Controls.Add(Me.Label1)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(644, 100)
        Me.pnlTop.TabIndex = 0
        '
        'btnFechar
        '
        Me.btnFechar.BackgroundImage = Global.Final_Stop.My.Resources.Resources.close
        Me.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFechar.FlatAppearance.BorderSize = 0
        Me.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.Location = New System.Drawing.Point(614, 0)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(30, 30)
        Me.btnFechar.TabIndex = 1
        Me.btnFechar.TabStop = False
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Final_Stop.My.Resources.Resources.produto
        Me.PictureBox1.Location = New System.Drawing.Point(16, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(96, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(455, 49)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cadastro de Produto"
        '
        'lblPesquisa
        '
        Me.lblPesquisa.AutoSize = True
        Me.lblPesquisa.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPesquisa.Location = New System.Drawing.Point(121, 133)
        Me.lblPesquisa.Name = "lblPesquisa"
        Me.lblPesquisa.Size = New System.Drawing.Size(76, 19)
        Me.lblPesquisa.TabIndex = 1
        Me.lblPesquisa.Text = "Pesquisa"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(48, 237)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(292, 1)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(48, 334)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(270, 1)
        Me.Panel2.TabIndex = 14
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(333, 334)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(267, 1)
        Me.Panel3.TabIndex = 17
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(363, 237)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(237, 1)
        Me.Panel4.TabIndex = 7
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(48, 387)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(292, 1)
        Me.Panel5.TabIndex = 20
        '
        'tmrCheck
        '
        Me.tmrCheck.Interval = 1
        '
        'frmProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(644, 649)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblPesquisa)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.gpbAcoes)
        Me.Controls.Add(Me.cmbPesquisa)
        Me.Controls.Add(Me.btnRemoverFoto)
        Me.Controls.Add(Numero_serieLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(Me.Numero_serieTextBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(DescricaoLabel)
        Me.Controls.Add(Me.TipoComboBox)
        Me.Controls.Add(Me.DescricaoTextBox)
        Me.Controls.Add(TipoLabel)
        Me.Controls.Add(QuantidadeLabel)
        Me.Controls.Add(Me.FornecedorComboBox)
        Me.Controls.Add(Me.QuantidadeTextBox)
        Me.Controls.Add(FornecedorLabel)
        Me.Controls.Add(Preco_vendaLabel)
        Me.Controls.Add(Me.Preco_unitarioTextBox)
        Me.Controls.Add(Me.Preco_vendaTextBox)
        Me.Controls.Add(Preco_unitarioLabel)
        Me.Controls.Add(Me.FotoPictureBox)
        Me.Controls.Add(FotoLabel)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmProduto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Final Stop"
        CType(Me.TbProdutoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbFinalStopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FotoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbFornecedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbAcoes.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbPesquisa As ComboBox
    Friend WithEvents DbFinalStopDataSet As dbFinalStopDataSet
    Friend WithEvents TbProdutoBindingSource As BindingSource
    Friend WithEvents TbProdutoTableAdapter As dbFinalStopDataSetTableAdapters.tbProdutoTableAdapter
    Friend WithEvents TableAdapterManager As dbFinalStopDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents FotoPictureBox As PictureBox
    Friend WithEvents Numero_serieTextBox As TextBox
    Friend WithEvents DescricaoTextBox As TextBox
    Friend WithEvents QuantidadeTextBox As TextBox
    Friend WithEvents Preco_vendaTextBox As TextBox
    Friend WithEvents Preco_unitarioTextBox As TextBox
    Friend WithEvents FornecedorComboBox As ComboBox
    Friend WithEvents TipoComboBox As ComboBox
    Friend WithEvents TbFornecedorTableAdapter As dbFinalStopDataSetTableAdapters.tbFornecedorTableAdapter
    Friend WithEvents TbFornecedorBindingSource As BindingSource
    Friend WithEvents ofd As OpenFileDialog
    Friend WithEvents btnRemoverFoto As Button
    Friend WithEvents gpbAcoes As GroupBox
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnProximo As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents pnlTop As Panel
    Friend WithEvents btnFechar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPesquisa As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents tmrCheck As Timer
    Friend WithEvents toolBtn As ToolTip
End Class
