<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCliente
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NomeLabel As System.Windows.Forms.Label
        Dim CpfLabel As System.Windows.Forms.Label
        Dim TelefoneLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim CepLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim CidadeLabel As System.Windows.Forms.Label
        Dim EnderecoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCliente))
        Me.lblValidador = New System.Windows.Forms.Label()
        Me.EnderecoTextBox = New System.Windows.Forms.TextBox()
        Me.TbClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbFinalStopDataSet = New Final_Stop.dbFinalStopDataSet()
        Me.CidadeTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoComboBox = New System.Windows.Forms.ComboBox()
        Me.CepMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.TelefoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.CpfMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnProximo = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.TbClienteTableAdapter = New Final_Stop.dbFinalStopDataSetTableAdapters.tbClienteTableAdapter()
        Me.TableAdapterManager = New Final_Stop.dbFinalStopDataSetTableAdapters.TableAdapterManager()
        Me.cmbPesquisa = New System.Windows.Forms.ComboBox()
        Me.gpbAcoes = New System.Windows.Forms.GroupBox()
        Me.lblPesquisa = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.toolBtn = New System.Windows.Forms.ToolTip(Me.components)
        NomeLabel = New System.Windows.Forms.Label()
        CpfLabel = New System.Windows.Forms.Label()
        TelefoneLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        CepLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        CidadeLabel = New System.Windows.Forms.Label()
        EnderecoLabel = New System.Windows.Forms.Label()
        CType(Me.TbClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbFinalStopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbAcoes.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NomeLabel.Location = New System.Drawing.Point(46, 215)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(61, 19)
        NomeLabel.TabIndex = 3
        NomeLabel.Text = "Nome:"
        '
        'CpfLabel
        '
        CpfLabel.AutoSize = True
        CpfLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CpfLabel.Location = New System.Drawing.Point(409, 215)
        CpfLabel.Name = "CpfLabel"
        CpfLabel.Size = New System.Drawing.Size(42, 19)
        CpfLabel.TabIndex = 6
        CpfLabel.Text = "CPF:"
        '
        'TelefoneLabel
        '
        TelefoneLabel.AutoSize = True
        TelefoneLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefoneLabel.Location = New System.Drawing.Point(46, 275)
        TelefoneLabel.Name = "TelefoneLabel"
        TelefoneLabel.Size = New System.Drawing.Size(78, 19)
        TelefoneLabel.TabIndex = 10
        TelefoneLabel.Text = "Telefone:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(282, 275)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(56, 19)
        EmailLabel.TabIndex = 13
        EmailLabel.Text = "Email:"
        '
        'CepLabel
        '
        CepLabel.AutoSize = True
        CepLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CepLabel.Location = New System.Drawing.Point(47, 337)
        CepLabel.Name = "CepLabel"
        CepLabel.Size = New System.Drawing.Size(42, 19)
        CepLabel.TabIndex = 16
        CepLabel.Text = "CEP:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EstadoLabel.Location = New System.Drawing.Point(406, 387)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(63, 19)
        EstadoLabel.TabIndex = 25
        EstadoLabel.Text = "Estado:"
        '
        'CidadeLabel
        '
        CidadeLabel.AutoSize = True
        CidadeLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CidadeLabel.Location = New System.Drawing.Point(47, 386)
        CidadeLabel.Name = "CidadeLabel"
        CidadeLabel.Size = New System.Drawing.Size(72, 19)
        CidadeLabel.TabIndex = 22
        CidadeLabel.Text = "Cidade:"
        '
        'EnderecoLabel
        '
        EnderecoLabel.AutoSize = True
        EnderecoLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EnderecoLabel.Location = New System.Drawing.Point(224, 337)
        EnderecoLabel.Name = "EnderecoLabel"
        EnderecoLabel.Size = New System.Drawing.Size(87, 19)
        EnderecoLabel.TabIndex = 19
        EnderecoLabel.Text = "Endereço:"
        '
        'lblValidador
        '
        Me.lblValidador.AutoSize = True
        Me.lblValidador.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValidador.ForeColor = System.Drawing.Color.White
        Me.lblValidador.Location = New System.Drawing.Point(409, 241)
        Me.lblValidador.Name = "lblValidador"
        Me.lblValidador.Size = New System.Drawing.Size(21, 19)
        Me.lblValidador.TabIndex = 8
        Me.lblValidador.Text = "..."
        '
        'EnderecoTextBox
        '
        Me.EnderecoTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.EnderecoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EnderecoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbClienteBindingSource, "endereco", True))
        Me.EnderecoTextBox.Enabled = False
        Me.EnderecoTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnderecoTextBox.ForeColor = System.Drawing.Color.White
        Me.EnderecoTextBox.Location = New System.Drawing.Point(317, 336)
        Me.EnderecoTextBox.Name = "EnderecoTextBox"
        Me.EnderecoTextBox.Size = New System.Drawing.Size(280, 20)
        Me.EnderecoTextBox.TabIndex = 21
        '
        'TbClienteBindingSource
        '
        Me.TbClienteBindingSource.DataMember = "tbCliente"
        Me.TbClienteBindingSource.DataSource = Me.DbFinalStopDataSet
        '
        'DbFinalStopDataSet
        '
        Me.DbFinalStopDataSet.DataSetName = "dbFinalStopDataSet"
        Me.DbFinalStopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CidadeTextBox
        '
        Me.CidadeTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.CidadeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbClienteBindingSource, "cidade", True))
        Me.CidadeTextBox.Enabled = False
        Me.CidadeTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CidadeTextBox.ForeColor = System.Drawing.Color.White
        Me.CidadeTextBox.Location = New System.Drawing.Point(125, 385)
        Me.CidadeTextBox.Name = "CidadeTextBox"
        Me.CidadeTextBox.Size = New System.Drawing.Size(259, 20)
        Me.CidadeTextBox.TabIndex = 24
        '
        'EstadoComboBox
        '
        Me.EstadoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.EstadoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.EstadoComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.EstadoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbClienteBindingSource, "estado", True))
        Me.EstadoComboBox.Enabled = False
        Me.EstadoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EstadoComboBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoComboBox.ForeColor = System.Drawing.Color.White
        Me.EstadoComboBox.FormattingEnabled = True
        Me.EstadoComboBox.Items.AddRange(New Object() {"AM", "BA", "DF", "ES", "MG", "RJ", "RS", "SC", "SP"})
        Me.EstadoComboBox.Location = New System.Drawing.Point(471, 383)
        Me.EstadoComboBox.Name = "EstadoComboBox"
        Me.EstadoComboBox.Size = New System.Drawing.Size(72, 27)
        Me.EstadoComboBox.TabIndex = 26
        '
        'CepMaskedTextBox
        '
        Me.CepMaskedTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.CepMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CepMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbClienteBindingSource, "cep", True))
        Me.CepMaskedTextBox.Enabled = False
        Me.CepMaskedTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CepMaskedTextBox.ForeColor = System.Drawing.Color.White
        Me.CepMaskedTextBox.Location = New System.Drawing.Point(95, 336)
        Me.CepMaskedTextBox.Mask = "00000-000"
        Me.CepMaskedTextBox.Name = "CepMaskedTextBox"
        Me.CepMaskedTextBox.Size = New System.Drawing.Size(103, 20)
        Me.CepMaskedTextBox.TabIndex = 18
        '
        'EmailTextBox
        '
        Me.EmailTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbClienteBindingSource, "email", True))
        Me.EmailTextBox.Enabled = False
        Me.EmailTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.ForeColor = System.Drawing.Color.White
        Me.EmailTextBox.Location = New System.Drawing.Point(344, 274)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(254, 20)
        Me.EmailTextBox.TabIndex = 15
        '
        'TelefoneMaskedTextBox
        '
        Me.TelefoneMaskedTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TelefoneMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TelefoneMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbClienteBindingSource, "telefone", True))
        Me.TelefoneMaskedTextBox.Enabled = False
        Me.TelefoneMaskedTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefoneMaskedTextBox.ForeColor = System.Drawing.Color.White
        Me.TelefoneMaskedTextBox.Location = New System.Drawing.Point(130, 274)
        Me.TelefoneMaskedTextBox.Mask = "(00) 00000-0000"
        Me.TelefoneMaskedTextBox.Name = "TelefoneMaskedTextBox"
        Me.TelefoneMaskedTextBox.Size = New System.Drawing.Size(133, 20)
        Me.TelefoneMaskedTextBox.TabIndex = 12
        '
        'CpfMaskedTextBox
        '
        Me.CpfMaskedTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.CpfMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CpfMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbClienteBindingSource, "cpf", True))
        Me.CpfMaskedTextBox.Enabled = False
        Me.CpfMaskedTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CpfMaskedTextBox.ForeColor = System.Drawing.Color.White
        Me.CpfMaskedTextBox.Location = New System.Drawing.Point(457, 214)
        Me.CpfMaskedTextBox.Mask = "000.000.000-00"
        Me.CpfMaskedTextBox.Name = "CpfMaskedTextBox"
        Me.CpfMaskedTextBox.Size = New System.Drawing.Size(142, 20)
        Me.CpfMaskedTextBox.TabIndex = 9
        '
        'NomeTextBox
        '
        Me.NomeTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.NomeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbClienteBindingSource, "nome", True))
        Me.NomeTextBox.Enabled = False
        Me.NomeTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeTextBox.ForeColor = System.Drawing.Color.White
        Me.NomeTextBox.Location = New System.Drawing.Point(113, 214)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(269, 20)
        Me.NomeTextBox.TabIndex = 5
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
        'TbClienteTableAdapter
        '
        Me.TbClienteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbClienteTableAdapter = Me.TbClienteTableAdapter
        Me.TableAdapterManager.tbFornecedorTableAdapter = Nothing
        Me.TableAdapterManager.tbFuncionarioTableAdapter = Nothing
        Me.TableAdapterManager.tbProdutoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Final_Stop.dbFinalStopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'cmbPesquisa
        '
        Me.cmbPesquisa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPesquisa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPesquisa.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.cmbPesquisa.DataSource = Me.TbClienteBindingSource
        Me.cmbPesquisa.DisplayMember = "nome"
        Me.cmbPesquisa.DropDownHeight = 114
        Me.cmbPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPesquisa.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPesquisa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.cmbPesquisa.FormattingEnabled = True
        Me.cmbPesquisa.IntegralHeight = False
        Me.cmbPesquisa.Location = New System.Drawing.Point(134, 141)
        Me.cmbPesquisa.Name = "cmbPesquisa"
        Me.cmbPesquisa.Size = New System.Drawing.Size(380, 27)
        Me.cmbPesquisa.TabIndex = 2
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
        Me.gpbAcoes.Location = New System.Drawing.Point(191, 487)
        Me.gpbAcoes.Name = "gpbAcoes"
        Me.gpbAcoes.Size = New System.Drawing.Size(262, 76)
        Me.gpbAcoes.TabIndex = 27
        Me.gpbAcoes.TabStop = False
        Me.gpbAcoes.Text = "Ações"
        '
        'lblPesquisa
        '
        Me.lblPesquisa.AutoSize = True
        Me.lblPesquisa.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPesquisa.Location = New System.Drawing.Point(130, 119)
        Me.lblPesquisa.Name = "lblPesquisa"
        Me.lblPesquisa.Size = New System.Drawing.Size(76, 19)
        Me.lblPesquisa.TabIndex = 1
        Me.lblPesquisa.Text = "Pesquisa"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(50, 238)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(334, 1)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(286, 297)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(312, 1)
        Me.Panel2.TabIndex = 14
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(228, 359)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(370, 1)
        Me.Panel3.TabIndex = 20
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(51, 408)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(333, 1)
        Me.Panel4.TabIndex = 23
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(413, 237)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(186, 1)
        Me.Panel5.TabIndex = 7
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(50, 297)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(213, 1)
        Me.Panel6.TabIndex = 11
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(51, 359)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(147, 1)
        Me.Panel7.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(96, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(443, 49)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cadastro de Cliente"
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
        Me.PictureBox1.Image = Global.Final_Stop.My.Resources.Resources.cliente2
        Me.PictureBox1.Location = New System.Drawing.Point(16, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(644, 580)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.CepMaskedTextBox)
        Me.Controls.Add(CepLabel)
        Me.Controls.Add(Me.lblPesquisa)
        Me.Controls.Add(EnderecoLabel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(EstadoLabel)
        Me.Controls.Add(Me.EstadoComboBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.EnderecoTextBox)
        Me.Controls.Add(Me.cmbPesquisa)
        Me.Controls.Add(Me.CidadeTextBox)
        Me.Controls.Add(Me.lblValidador)
        Me.Controls.Add(CidadeLabel)
        Me.Controls.Add(Me.gpbAcoes)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(TelefoneLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(Me.TelefoneMaskedTextBox)
        Me.Controls.Add(Me.CpfMaskedTextBox)
        Me.Controls.Add(CpfLabel)
        Me.Controls.Add(Me.pnlTop)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Final Stop"
        CType(Me.TbClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbFinalStopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbAcoes.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnProximo As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents DbFinalStopDataSet As dbFinalStopDataSet
    Friend WithEvents TbClienteBindingSource As BindingSource
    Friend WithEvents TbClienteTableAdapter As dbFinalStopDataSetTableAdapters.tbClienteTableAdapter
    Friend WithEvents TableAdapterManager As dbFinalStopDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents lblValidador As Label
    Friend WithEvents EnderecoTextBox As TextBox
    Friend WithEvents CidadeTextBox As TextBox
    Friend WithEvents EstadoComboBox As ComboBox
    Friend WithEvents CepMaskedTextBox As MaskedTextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents TelefoneMaskedTextBox As MaskedTextBox
    Friend WithEvents CpfMaskedTextBox As MaskedTextBox
    Friend WithEvents cmbPesquisa As ComboBox
    Friend WithEvents gpbAcoes As GroupBox
    Friend WithEvents lblPesquisa As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlTop As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnFechar As Button
    Friend WithEvents toolBtn As ToolTip
End Class
