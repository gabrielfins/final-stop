<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFuncionario
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
        Dim NomeLabel As System.Windows.Forms.Label
        Dim LoginLabel As System.Windows.Forms.Label
        Dim SenhaLabel As System.Windows.Forms.Label
        Dim CpfLabel As System.Windows.Forms.Label
        Dim TelefoneLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim CargoLabel As System.Windows.Forms.Label
        Dim SalarioLabel As System.Windows.Forms.Label
        Dim Data_admissaoLabel As System.Windows.Forms.Label
        Dim NivelLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFuncionario))
        Me.cmbPesquisa = New System.Windows.Forms.ComboBox()
        Me.TbFuncionarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbFinalStopDataSet = New Final_Stop.dbFinalStopDataSet()
        Me.NivelComboBox = New System.Windows.Forms.ComboBox()
        Me.Data_admissaoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.SalarioTextBox = New System.Windows.Forms.TextBox()
        Me.CargoComboBox = New System.Windows.Forms.ComboBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.TelefoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.lblValidador = New System.Windows.Forms.Label()
        Me.CpfMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.SenhaTextBox = New System.Windows.Forms.TextBox()
        Me.LoginTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.TbFuncionarioTableAdapter = New Final_Stop.dbFinalStopDataSetTableAdapters.tbFuncionarioTableAdapter()
        Me.TableAdapterManager = New Final_Stop.dbFinalStopDataSetTableAdapters.TableAdapterManager()
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.lblPesquisa = New System.Windows.Forms.Label()
        Me.btnViewPass = New System.Windows.Forms.Button()
        Me.toolBtn = New System.Windows.Forms.ToolTip(Me.components)
        NomeLabel = New System.Windows.Forms.Label()
        LoginLabel = New System.Windows.Forms.Label()
        SenhaLabel = New System.Windows.Forms.Label()
        CpfLabel = New System.Windows.Forms.Label()
        TelefoneLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        CargoLabel = New System.Windows.Forms.Label()
        SalarioLabel = New System.Windows.Forms.Label()
        Data_admissaoLabel = New System.Windows.Forms.Label()
        NivelLabel = New System.Windows.Forms.Label()
        CType(Me.TbFuncionarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        NomeLabel.Location = New System.Drawing.Point(34, 213)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(61, 19)
        NomeLabel.TabIndex = 3
        NomeLabel.Text = "Nome:"
        '
        'LoginLabel
        '
        LoginLabel.AutoSize = True
        LoginLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LoginLabel.Location = New System.Drawing.Point(34, 274)
        LoginLabel.Name = "LoginLabel"
        LoginLabel.Size = New System.Drawing.Size(55, 19)
        LoginLabel.TabIndex = 10
        LoginLabel.Text = "Login:"
        '
        'SenhaLabel
        '
        SenhaLabel.AutoSize = True
        SenhaLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SenhaLabel.Location = New System.Drawing.Point(331, 274)
        SenhaLabel.Name = "SenhaLabel"
        SenhaLabel.Size = New System.Drawing.Size(62, 19)
        SenhaLabel.TabIndex = 13
        SenhaLabel.Text = "Senha:"
        '
        'CpfLabel
        '
        CpfLabel.AutoSize = True
        CpfLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CpfLabel.Location = New System.Drawing.Point(411, 213)
        CpfLabel.Name = "CpfLabel"
        CpfLabel.Size = New System.Drawing.Size(42, 19)
        CpfLabel.TabIndex = 6
        CpfLabel.Text = "CPF:"
        '
        'TelefoneLabel
        '
        TelefoneLabel.AutoSize = True
        TelefoneLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefoneLabel.Location = New System.Drawing.Point(34, 332)
        TelefoneLabel.Name = "TelefoneLabel"
        TelefoneLabel.Size = New System.Drawing.Size(78, 19)
        TelefoneLabel.TabIndex = 16
        TelefoneLabel.Text = "Telefone:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(34, 390)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(56, 19)
        EmailLabel.TabIndex = 22
        EmailLabel.Text = "Email:"
        '
        'CargoLabel
        '
        CargoLabel.AutoSize = True
        CargoLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CargoLabel.Location = New System.Drawing.Point(34, 448)
        CargoLabel.Name = "CargoLabel"
        CargoLabel.Size = New System.Drawing.Size(62, 19)
        CargoLabel.TabIndex = 28
        CargoLabel.Text = "Cargo:"
        '
        'SalarioLabel
        '
        SalarioLabel.AutoSize = True
        SalarioLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SalarioLabel.Location = New System.Drawing.Point(408, 390)
        SalarioLabel.Name = "SalarioLabel"
        SalarioLabel.Size = New System.Drawing.Size(66, 19)
        SalarioLabel.TabIndex = 25
        SalarioLabel.Text = "Salário:"
        '
        'Data_admissaoLabel
        '
        Data_admissaoLabel.AutoSize = True
        Data_admissaoLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Data_admissaoLabel.Location = New System.Drawing.Point(281, 332)
        Data_admissaoLabel.Name = "Data_admissaoLabel"
        Data_admissaoLabel.Size = New System.Drawing.Size(155, 19)
        Data_admissaoLabel.TabIndex = 19
        Data_admissaoLabel.Text = "Data de Admissão:"
        '
        'NivelLabel
        '
        NivelLabel.AutoSize = True
        NivelLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NivelLabel.Location = New System.Drawing.Point(364, 448)
        NivelLabel.Name = "NivelLabel"
        NivelLabel.Size = New System.Drawing.Size(52, 19)
        NivelLabel.TabIndex = 30
        NivelLabel.Text = "Nível:"
        '
        'cmbPesquisa
        '
        Me.cmbPesquisa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPesquisa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPesquisa.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.cmbPesquisa.DataSource = Me.TbFuncionarioBindingSource
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
        'TbFuncionarioBindingSource
        '
        Me.TbFuncionarioBindingSource.DataMember = "tbFuncionario"
        Me.TbFuncionarioBindingSource.DataSource = Me.DbFinalStopDataSet
        '
        'DbFinalStopDataSet
        '
        Me.DbFinalStopDataSet.DataSetName = "dbFinalStopDataSet"
        Me.DbFinalStopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NivelComboBox
        '
        Me.NivelComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.NivelComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.NivelComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.NivelComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbFuncionarioBindingSource, "nivel", True))
        Me.NivelComboBox.Enabled = False
        Me.NivelComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NivelComboBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NivelComboBox.ForeColor = System.Drawing.Color.White
        Me.NivelComboBox.FormattingEnabled = True
        Me.NivelComboBox.Items.AddRange(New Object() {"0", "1", "2"})
        Me.NivelComboBox.Location = New System.Drawing.Point(420, 444)
        Me.NivelComboBox.Name = "NivelComboBox"
        Me.NivelComboBox.Size = New System.Drawing.Size(52, 27)
        Me.NivelComboBox.TabIndex = 31
        '
        'Data_admissaoMaskedTextBox
        '
        Me.Data_admissaoMaskedTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Data_admissaoMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Data_admissaoMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbFuncionarioBindingSource, "data_admissao", True))
        Me.Data_admissaoMaskedTextBox.Enabled = False
        Me.Data_admissaoMaskedTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Data_admissaoMaskedTextBox.ForeColor = System.Drawing.Color.White
        Me.Data_admissaoMaskedTextBox.Location = New System.Drawing.Point(450, 331)
        Me.Data_admissaoMaskedTextBox.Mask = "00/00/0000"
        Me.Data_admissaoMaskedTextBox.Name = "Data_admissaoMaskedTextBox"
        Me.Data_admissaoMaskedTextBox.Size = New System.Drawing.Size(99, 20)
        Me.Data_admissaoMaskedTextBox.TabIndex = 21
        '
        'SalarioTextBox
        '
        Me.SalarioTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.SalarioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SalarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbFuncionarioBindingSource, "salario", True))
        Me.SalarioTextBox.Enabled = False
        Me.SalarioTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalarioTextBox.ForeColor = System.Drawing.Color.White
        Me.SalarioTextBox.Location = New System.Drawing.Point(478, 389)
        Me.SalarioTextBox.Name = "SalarioTextBox"
        Me.SalarioTextBox.Size = New System.Drawing.Size(116, 20)
        Me.SalarioTextBox.TabIndex = 27
        '
        'CargoComboBox
        '
        Me.CargoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CargoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CargoComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.CargoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbFuncionarioBindingSource, "cargo", True))
        Me.CargoComboBox.Enabled = False
        Me.CargoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CargoComboBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CargoComboBox.ForeColor = System.Drawing.Color.White
        Me.CargoComboBox.FormattingEnabled = True
        Me.CargoComboBox.Items.AddRange(New Object() {"Administrador", "Atendente", "Consultor", "Analista de Eletrodomésticos", "Analista de Eletroeletrônicos", "Analista de Eletroportáteis", "Gerente de Estoque", "Gerente Geral", "Operador de Caixa"})
        Me.CargoComboBox.Location = New System.Drawing.Point(102, 444)
        Me.CargoComboBox.Name = "CargoComboBox"
        Me.CargoComboBox.Size = New System.Drawing.Size(241, 27)
        Me.CargoComboBox.TabIndex = 29
        '
        'EmailTextBox
        '
        Me.EmailTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbFuncionarioBindingSource, "email", True))
        Me.EmailTextBox.Enabled = False
        Me.EmailTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.ForeColor = System.Drawing.Color.White
        Me.EmailTextBox.Location = New System.Drawing.Point(98, 389)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(293, 20)
        Me.EmailTextBox.TabIndex = 24
        '
        'TelefoneMaskedTextBox
        '
        Me.TelefoneMaskedTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TelefoneMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TelefoneMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbFuncionarioBindingSource, "telefone", True))
        Me.TelefoneMaskedTextBox.Enabled = False
        Me.TelefoneMaskedTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefoneMaskedTextBox.ForeColor = System.Drawing.Color.White
        Me.TelefoneMaskedTextBox.Location = New System.Drawing.Point(115, 331)
        Me.TelefoneMaskedTextBox.Mask = "(00) 00000-0000"
        Me.TelefoneMaskedTextBox.Name = "TelefoneMaskedTextBox"
        Me.TelefoneMaskedTextBox.Size = New System.Drawing.Size(137, 20)
        Me.TelefoneMaskedTextBox.TabIndex = 18
        '
        'lblValidador
        '
        Me.lblValidador.AutoSize = True
        Me.lblValidador.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValidador.Location = New System.Drawing.Point(411, 239)
        Me.lblValidador.Name = "lblValidador"
        Me.lblValidador.Size = New System.Drawing.Size(21, 19)
        Me.lblValidador.TabIndex = 9
        Me.lblValidador.Text = "..."
        '
        'CpfMaskedTextBox
        '
        Me.CpfMaskedTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.CpfMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CpfMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbFuncionarioBindingSource, "cpf", True))
        Me.CpfMaskedTextBox.Enabled = False
        Me.CpfMaskedTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CpfMaskedTextBox.ForeColor = System.Drawing.Color.White
        Me.CpfMaskedTextBox.Location = New System.Drawing.Point(455, 212)
        Me.CpfMaskedTextBox.Mask = "000.000.000-00"
        Me.CpfMaskedTextBox.Name = "CpfMaskedTextBox"
        Me.CpfMaskedTextBox.Size = New System.Drawing.Size(122, 20)
        Me.CpfMaskedTextBox.TabIndex = 8
        '
        'SenhaTextBox
        '
        Me.SenhaTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.SenhaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SenhaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbFuncionarioBindingSource, "senha", True))
        Me.SenhaTextBox.Enabled = False
        Me.SenhaTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SenhaTextBox.ForeColor = System.Drawing.Color.White
        Me.SenhaTextBox.Location = New System.Drawing.Point(397, 273)
        Me.SenhaTextBox.Name = "SenhaTextBox"
        Me.SenhaTextBox.Size = New System.Drawing.Size(166, 20)
        Me.SenhaTextBox.TabIndex = 15
        Me.SenhaTextBox.UseSystemPasswordChar = True
        '
        'LoginTextBox
        '
        Me.LoginTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.LoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LoginTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbFuncionarioBindingSource, "login", True))
        Me.LoginTextBox.Enabled = False
        Me.LoginTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginTextBox.ForeColor = System.Drawing.Color.White
        Me.LoginTextBox.Location = New System.Drawing.Point(92, 273)
        Me.LoginTextBox.Name = "LoginTextBox"
        Me.LoginTextBox.Size = New System.Drawing.Size(227, 20)
        Me.LoginTextBox.TabIndex = 12
        '
        'NomeTextBox
        '
        Me.NomeTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.NomeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbFuncionarioBindingSource, "nome", True))
        Me.NomeTextBox.Enabled = False
        Me.NomeTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeTextBox.ForeColor = System.Drawing.Color.White
        Me.NomeTextBox.Location = New System.Drawing.Point(98, 212)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(293, 20)
        Me.NomeTextBox.TabIndex = 5
        '
        'TbFuncionarioTableAdapter
        '
        Me.TbFuncionarioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbClienteTableAdapter = Nothing
        Me.TableAdapterManager.tbFornecedorTableAdapter = Nothing
        Me.TableAdapterManager.tbFuncionarioTableAdapter = Me.TbFuncionarioTableAdapter
        Me.TableAdapterManager.tbProdutoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Final_Stop.dbFinalStopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        Me.gpbAcoes.Location = New System.Drawing.Point(191, 530)
        Me.gpbAcoes.Name = "gpbAcoes"
        Me.gpbAcoes.Size = New System.Drawing.Size(262, 76)
        Me.gpbAcoes.TabIndex = 32
        Me.gpbAcoes.TabStop = False
        Me.gpbAcoes.Text = "Ações"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.BackgroundImage = Global.Final_Stop.My.Resources.Resources.add
        Me.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdicionar.FlatAppearance.BorderSize = 0
        Me.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdicionar.Location = New System.Drawing.Point(218, 25)
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
        Me.btnSalvar.Location = New System.Drawing.Point(176, 25)
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
        Me.btnExcluir.Location = New System.Drawing.Point(134, 25)
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
        Me.btnEditar.Location = New System.Drawing.Point(92, 25)
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
        Me.btnProximo.Location = New System.Drawing.Point(50, 25)
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
        Me.btnAnterior.Location = New System.Drawing.Point(8, 25)
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
        Me.btnFechar.Location = New System.Drawing.Point(609, 0)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(35, 35)
        Me.btnFechar.TabIndex = 1
        Me.btnFechar.TabStop = False
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Final_Stop.My.Resources.Resources.funcionario
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
        Me.Label1.Location = New System.Drawing.Point(86, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(539, 49)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cadastro de Funcionário"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(38, 235)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(353, 1)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(415, 235)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(162, 1)
        Me.Panel2.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(38, 296)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(281, 1)
        Me.Panel3.TabIndex = 11
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(335, 296)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(262, 1)
        Me.Panel4.TabIndex = 14
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(38, 354)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(214, 1)
        Me.Panel5.TabIndex = 17
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(285, 354)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(264, 1)
        Me.Panel6.TabIndex = 20
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(38, 412)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(353, 1)
        Me.Panel7.TabIndex = 23
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel8.Location = New System.Drawing.Point(412, 412)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(182, 1)
        Me.Panel8.TabIndex = 26
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
        'btnViewPass
        '
        Me.btnViewPass.BackgroundImage = Global.Final_Stop.My.Resources.Resources.baseline_visibility_off_white_36dp
        Me.btnViewPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnViewPass.FlatAppearance.BorderSize = 0
        Me.btnViewPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewPass.Location = New System.Drawing.Point(569, 268)
        Me.btnViewPass.Name = "btnViewPass"
        Me.btnViewPass.Size = New System.Drawing.Size(28, 28)
        Me.btnViewPass.TabIndex = 33
        Me.btnViewPass.TabStop = False
        Me.btnViewPass.UseVisualStyleBackColor = True
        '
        'frmFuncionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(644, 626)
        Me.Controls.Add(Me.btnViewPass)
        Me.Controls.Add(Me.lblPesquisa)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.cmbPesquisa)
        Me.Controls.Add(NivelLabel)
        Me.Controls.Add(Me.gpbAcoes)
        Me.Controls.Add(Me.NivelComboBox)
        Me.Controls.Add(Data_admissaoLabel)
        Me.Controls.Add(Me.Data_admissaoMaskedTextBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(SalarioLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(Me.SalarioTextBox)
        Me.Controls.Add(Me.LoginTextBox)
        Me.Controls.Add(CargoLabel)
        Me.Controls.Add(LoginLabel)
        Me.Controls.Add(Me.CargoComboBox)
        Me.Controls.Add(Me.SenhaTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(SenhaLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.CpfMaskedTextBox)
        Me.Controls.Add(TelefoneLabel)
        Me.Controls.Add(CpfLabel)
        Me.Controls.Add(Me.TelefoneMaskedTextBox)
        Me.Controls.Add(Me.lblValidador)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmFuncionario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Final Stop"
        CType(Me.TbFuncionarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbFinalStopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbAcoes.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbPesquisa As ComboBox
    Friend WithEvents DbFinalStopDataSet As dbFinalStopDataSet
    Friend WithEvents TbFuncionarioBindingSource As BindingSource
    Friend WithEvents TbFuncionarioTableAdapter As dbFinalStopDataSetTableAdapters.tbFuncionarioTableAdapter
    Friend WithEvents TableAdapterManager As dbFinalStopDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents NivelComboBox As ComboBox
    Friend WithEvents Data_admissaoMaskedTextBox As MaskedTextBox
    Friend WithEvents SalarioTextBox As TextBox
    Friend WithEvents CargoComboBox As ComboBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents TelefoneMaskedTextBox As MaskedTextBox
    Friend WithEvents lblValidador As Label
    Friend WithEvents CpfMaskedTextBox As MaskedTextBox
    Friend WithEvents SenhaTextBox As TextBox
    Friend WithEvents LoginTextBox As TextBox
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents lblPesquisa As Label
    Friend WithEvents btnViewPass As Button
    Friend WithEvents toolBtn As ToolTip
End Class
