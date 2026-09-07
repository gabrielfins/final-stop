<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFornecedor
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
        Dim Nome_fantasiaLabel As System.Windows.Forms.Label
        Dim Nome_contatoLabel As System.Windows.Forms.Label
        Dim Razao_socialLabel As System.Windows.Forms.Label
        Dim CnpjLabel As System.Windows.Forms.Label
        Dim CepLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim CidadeLabel As System.Windows.Forms.Label
        Dim EnderecoLabel As System.Windows.Forms.Label
        Dim Telefone1Label As System.Windows.Forms.Label
        Dim Telefone2Label As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFornecedor))
        Me.gpbAcoes = New System.Windows.Forms.GroupBox()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnProximo = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.lblValidador = New System.Windows.Forms.Label()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.TbFornecedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbFinalStopDataSet = New Final_Stop.dbFinalStopDataSet()
        Me.Telefone2MaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Telefone1MaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.EnderecoTextBox = New System.Windows.Forms.TextBox()
        Me.CidadeTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoComboBox = New System.Windows.Forms.ComboBox()
        Me.CepMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.CnpjMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Razao_socialTextBox = New System.Windows.Forms.TextBox()
        Me.Nome_contatoTextBox = New System.Windows.Forms.TextBox()
        Me.Nome_fantasiaTextBox = New System.Windows.Forms.TextBox()
        Me.cmbPesquisa = New System.Windows.Forms.ComboBox()
        Me.TbFornecedorTableAdapter = New Final_Stop.dbFinalStopDataSetTableAdapters.tbFornecedorTableAdapter()
        Me.TableAdapterManager = New Final_Stop.dbFinalStopDataSetTableAdapters.TableAdapterManager()
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
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.toolBtn = New System.Windows.Forms.ToolTip(Me.components)
        Nome_fantasiaLabel = New System.Windows.Forms.Label()
        Nome_contatoLabel = New System.Windows.Forms.Label()
        Razao_socialLabel = New System.Windows.Forms.Label()
        CnpjLabel = New System.Windows.Forms.Label()
        CepLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        CidadeLabel = New System.Windows.Forms.Label()
        EnderecoLabel = New System.Windows.Forms.Label()
        Telefone1Label = New System.Windows.Forms.Label()
        Telefone2Label = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Me.gpbAcoes.SuspendLayout()
        CType(Me.TbFornecedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbFinalStopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Nome_fantasiaLabel
        '
        Nome_fantasiaLabel.AutoSize = True
        Nome_fantasiaLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nome_fantasiaLabel.Location = New System.Drawing.Point(37, 209)
        Nome_fantasiaLabel.Name = "Nome_fantasiaLabel"
        Nome_fantasiaLabel.Size = New System.Drawing.Size(130, 19)
        Nome_fantasiaLabel.TabIndex = 15
        Nome_fantasiaLabel.Text = "Nome Fantasia:"
        '
        'Nome_contatoLabel
        '
        Nome_contatoLabel.AutoSize = True
        Nome_contatoLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nome_contatoLabel.Location = New System.Drawing.Point(37, 317)
        Nome_contatoLabel.Name = "Nome_contatoLabel"
        Nome_contatoLabel.Size = New System.Drawing.Size(126, 19)
        Nome_contatoLabel.TabIndex = 24
        Nome_contatoLabel.Text = "Nome Contato:"
        '
        'Razao_socialLabel
        '
        Razao_socialLabel.AutoSize = True
        Razao_socialLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Razao_socialLabel.Location = New System.Drawing.Point(37, 266)
        Razao_socialLabel.Name = "Razao_socialLabel"
        Razao_socialLabel.Size = New System.Drawing.Size(112, 19)
        Razao_socialLabel.TabIndex = 20
        Razao_socialLabel.Text = "Razão Social:"
        '
        'CnpjLabel
        '
        CnpjLabel.AutoSize = True
        CnpjLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CnpjLabel.Location = New System.Drawing.Point(374, 209)
        CnpjLabel.Name = "CnpjLabel"
        CnpjLabel.Size = New System.Drawing.Size(54, 19)
        CnpjLabel.TabIndex = 16
        CnpjLabel.Text = "CNPJ:"
        '
        'CepLabel
        '
        CepLabel.AutoSize = True
        CepLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CepLabel.Location = New System.Drawing.Point(418, 266)
        CepLabel.Name = "CepLabel"
        CepLabel.Size = New System.Drawing.Size(42, 19)
        CepLabel.TabIndex = 21
        CepLabel.Text = "CEP:"
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EstadoLabel.Location = New System.Drawing.Point(418, 317)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(63, 19)
        EstadoLabel.TabIndex = 26
        EstadoLabel.Text = "Estado:"
        '
        'CidadeLabel
        '
        CidadeLabel.AutoSize = True
        CidadeLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CidadeLabel.Location = New System.Drawing.Point(37, 368)
        CidadeLabel.Name = "CidadeLabel"
        CidadeLabel.Size = New System.Drawing.Size(72, 19)
        CidadeLabel.TabIndex = 27
        CidadeLabel.Text = "Cidade:"
        '
        'EnderecoLabel
        '
        EnderecoLabel.AutoSize = True
        EnderecoLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EnderecoLabel.Location = New System.Drawing.Point(39, 473)
        EnderecoLabel.Name = "EnderecoLabel"
        EnderecoLabel.Size = New System.Drawing.Size(87, 19)
        EnderecoLabel.TabIndex = 35
        EnderecoLabel.Text = "Endereço:"
        '
        'Telefone1Label
        '
        Telefone1Label.AutoSize = True
        Telefone1Label.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Telefone1Label.Location = New System.Drawing.Point(358, 419)
        Telefone1Label.Name = "Telefone1Label"
        Telefone1Label.Size = New System.Drawing.Size(113, 19)
        Telefone1Label.TabIndex = 33
        Telefone1Label.Text = "Telefone Fixo:"
        '
        'Telefone2Label
        '
        Telefone2Label.AutoSize = True
        Telefone2Label.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Telefone2Label.Location = New System.Drawing.Point(341, 368)
        Telefone2Label.Name = "Telefone2Label"
        Telefone2Label.Size = New System.Drawing.Size(129, 19)
        Telefone2Label.TabIndex = 29
        Telefone2Label.Text = "Telefone Móvel:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(39, 419)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(56, 19)
        EmailLabel.TabIndex = 31
        EmailLabel.Text = "Email:"
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
        Me.gpbAcoes.TabIndex = 12
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
        'lblValidador
        '
        Me.lblValidador.AutoSize = True
        Me.lblValidador.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValidador.Location = New System.Drawing.Point(374, 235)
        Me.lblValidador.Name = "lblValidador"
        Me.lblValidador.Size = New System.Drawing.Size(21, 19)
        Me.lblValidador.TabIndex = 19
        Me.lblValidador.Text = "..."
        '
        'EmailTextBox
        '
        Me.EmailTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbFornecedorBindingSource, "email", True))
        Me.EmailTextBox.Enabled = False
        Me.EmailTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.ForeColor = System.Drawing.Color.White
        Me.EmailTextBox.Location = New System.Drawing.Point(101, 418)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(235, 20)
        Me.EmailTextBox.TabIndex = 9
        '
        'TbFornecedorBindingSource
        '
        Me.TbFornecedorBindingSource.DataMember = "tbFornecedor"
        Me.TbFornecedorBindingSource.DataSource = Me.DbFinalStopDataSet
        '
        'DbFinalStopDataSet
        '
        Me.DbFinalStopDataSet.DataSetName = "dbFinalStopDataSet"
        Me.DbFinalStopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Telefone2MaskedTextBox
        '
        Me.Telefone2MaskedTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Telefone2MaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Telefone2MaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbFornecedorBindingSource, "telefone2", True))
        Me.Telefone2MaskedTextBox.Enabled = False
        Me.Telefone2MaskedTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Telefone2MaskedTextBox.ForeColor = System.Drawing.Color.White
        Me.Telefone2MaskedTextBox.Location = New System.Drawing.Point(476, 367)
        Me.Telefone2MaskedTextBox.Mask = "(00) 00000-0000"
        Me.Telefone2MaskedTextBox.Name = "Telefone2MaskedTextBox"
        Me.Telefone2MaskedTextBox.Size = New System.Drawing.Size(131, 20)
        Me.Telefone2MaskedTextBox.TabIndex = 8
        '
        'Telefone1MaskedTextBox
        '
        Me.Telefone1MaskedTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Telefone1MaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Telefone1MaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbFornecedorBindingSource, "telefone1", True))
        Me.Telefone1MaskedTextBox.Enabled = False
        Me.Telefone1MaskedTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Telefone1MaskedTextBox.ForeColor = System.Drawing.Color.White
        Me.Telefone1MaskedTextBox.Location = New System.Drawing.Point(477, 418)
        Me.Telefone1MaskedTextBox.Mask = "(00) 0000-0000"
        Me.Telefone1MaskedTextBox.Name = "Telefone1MaskedTextBox"
        Me.Telefone1MaskedTextBox.Size = New System.Drawing.Size(128, 20)
        Me.Telefone1MaskedTextBox.TabIndex = 10
        '
        'EnderecoTextBox
        '
        Me.EnderecoTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.EnderecoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EnderecoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbFornecedorBindingSource, "endereco", True))
        Me.EnderecoTextBox.Enabled = False
        Me.EnderecoTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnderecoTextBox.ForeColor = System.Drawing.Color.White
        Me.EnderecoTextBox.Location = New System.Drawing.Point(132, 472)
        Me.EnderecoTextBox.Name = "EnderecoTextBox"
        Me.EnderecoTextBox.Size = New System.Drawing.Size(242, 20)
        Me.EnderecoTextBox.TabIndex = 11
        '
        'CidadeTextBox
        '
        Me.CidadeTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.CidadeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbFornecedorBindingSource, "cidade", True))
        Me.CidadeTextBox.Enabled = False
        Me.CidadeTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CidadeTextBox.ForeColor = System.Drawing.Color.White
        Me.CidadeTextBox.Location = New System.Drawing.Point(115, 367)
        Me.CidadeTextBox.Name = "CidadeTextBox"
        Me.CidadeTextBox.Size = New System.Drawing.Size(206, 20)
        Me.CidadeTextBox.TabIndex = 7
        '
        'EstadoComboBox
        '
        Me.EstadoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.EstadoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.EstadoComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.EstadoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbFornecedorBindingSource, "estado", True))
        Me.EstadoComboBox.DropDownHeight = 152
        Me.EstadoComboBox.Enabled = False
        Me.EstadoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EstadoComboBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstadoComboBox.ForeColor = System.Drawing.Color.White
        Me.EstadoComboBox.FormattingEnabled = True
        Me.EstadoComboBox.IntegralHeight = False
        Me.EstadoComboBox.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.EstadoComboBox.Location = New System.Drawing.Point(488, 313)
        Me.EstadoComboBox.Name = "EstadoComboBox"
        Me.EstadoComboBox.Size = New System.Drawing.Size(62, 27)
        Me.EstadoComboBox.TabIndex = 6
        '
        'CepMaskedTextBox
        '
        Me.CepMaskedTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.CepMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CepMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbFornecedorBindingSource, "cep", True))
        Me.CepMaskedTextBox.Enabled = False
        Me.CepMaskedTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CepMaskedTextBox.ForeColor = System.Drawing.Color.White
        Me.CepMaskedTextBox.Location = New System.Drawing.Point(471, 265)
        Me.CepMaskedTextBox.Mask = "00000-000"
        Me.CepMaskedTextBox.Name = "CepMaskedTextBox"
        Me.CepMaskedTextBox.Size = New System.Drawing.Size(104, 20)
        Me.CepMaskedTextBox.TabIndex = 4
        '
        'CnpjMaskedTextBox
        '
        Me.CnpjMaskedTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.CnpjMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CnpjMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbFornecedorBindingSource, "cnpj", True))
        Me.CnpjMaskedTextBox.Enabled = False
        Me.CnpjMaskedTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CnpjMaskedTextBox.ForeColor = System.Drawing.Color.White
        Me.CnpjMaskedTextBox.Location = New System.Drawing.Point(436, 208)
        Me.CnpjMaskedTextBox.Mask = "00.000.000/0000-00"
        Me.CnpjMaskedTextBox.Name = "CnpjMaskedTextBox"
        Me.CnpjMaskedTextBox.Size = New System.Drawing.Size(151, 20)
        Me.CnpjMaskedTextBox.TabIndex = 2
        '
        'Razao_socialTextBox
        '
        Me.Razao_socialTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Razao_socialTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Razao_socialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbFornecedorBindingSource, "razao_social", True))
        Me.Razao_socialTextBox.Enabled = False
        Me.Razao_socialTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Razao_socialTextBox.ForeColor = System.Drawing.Color.White
        Me.Razao_socialTextBox.Location = New System.Drawing.Point(153, 265)
        Me.Razao_socialTextBox.Name = "Razao_socialTextBox"
        Me.Razao_socialTextBox.Size = New System.Drawing.Size(242, 20)
        Me.Razao_socialTextBox.TabIndex = 3
        '
        'Nome_contatoTextBox
        '
        Me.Nome_contatoTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Nome_contatoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Nome_contatoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbFornecedorBindingSource, "nome_contato", True))
        Me.Nome_contatoTextBox.Enabled = False
        Me.Nome_contatoTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome_contatoTextBox.ForeColor = System.Drawing.Color.White
        Me.Nome_contatoTextBox.Location = New System.Drawing.Point(168, 316)
        Me.Nome_contatoTextBox.Name = "Nome_contatoTextBox"
        Me.Nome_contatoTextBox.Size = New System.Drawing.Size(227, 20)
        Me.Nome_contatoTextBox.TabIndex = 5
        '
        'Nome_fantasiaTextBox
        '
        Me.Nome_fantasiaTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Nome_fantasiaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Nome_fantasiaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbFornecedorBindingSource, "nome_fantasia", True))
        Me.Nome_fantasiaTextBox.Enabled = False
        Me.Nome_fantasiaTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome_fantasiaTextBox.ForeColor = System.Drawing.Color.White
        Me.Nome_fantasiaTextBox.Location = New System.Drawing.Point(171, 208)
        Me.Nome_fantasiaTextBox.Name = "Nome_fantasiaTextBox"
        Me.Nome_fantasiaTextBox.Size = New System.Drawing.Size(185, 20)
        Me.Nome_fantasiaTextBox.TabIndex = 1
        '
        'cmbPesquisa
        '
        Me.cmbPesquisa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPesquisa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPesquisa.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.cmbPesquisa.DataSource = Me.TbFornecedorBindingSource
        Me.cmbPesquisa.DisplayMember = "nome_fantasia"
        Me.cmbPesquisa.DropDownHeight = 114
        Me.cmbPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPesquisa.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPesquisa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.cmbPesquisa.FormattingEnabled = True
        Me.cmbPesquisa.IntegralHeight = False
        Me.cmbPesquisa.Location = New System.Drawing.Point(134, 141)
        Me.cmbPesquisa.Name = "cmbPesquisa"
        Me.cmbPesquisa.Size = New System.Drawing.Size(380, 27)
        Me.cmbPesquisa.TabIndex = 0
        '
        'TbFornecedorTableAdapter
        '
        Me.TbFornecedorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbClienteTableAdapter = Nothing
        Me.TableAdapterManager.tbFornecedorTableAdapter = Me.TbFornecedorTableAdapter
        Me.TableAdapterManager.tbFuncionarioTableAdapter = Nothing
        Me.TableAdapterManager.tbProdutoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Final_Stop.dbFinalStopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        Me.pnlTop.TabIndex = 13
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
        Me.PictureBox1.Image = Global.Final_Stop.My.Resources.Resources.fornecedor
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
        Me.Label1.Size = New System.Drawing.Size(537, 49)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cadastro de Fornecedor"
        '
        'lblPesquisa
        '
        Me.lblPesquisa.AutoSize = True
        Me.lblPesquisa.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPesquisa.Location = New System.Drawing.Point(130, 119)
        Me.lblPesquisa.Name = "lblPesquisa"
        Me.lblPesquisa.Size = New System.Drawing.Size(76, 19)
        Me.lblPesquisa.TabIndex = 14
        Me.lblPesquisa.Text = "Pesquisa"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(41, 231)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(315, 1)
        Me.Panel1.TabIndex = 17
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(378, 231)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(209, 1)
        Me.Panel2.TabIndex = 18
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(41, 288)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(354, 1)
        Me.Panel3.TabIndex = 22
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(422, 288)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(153, 1)
        Me.Panel4.TabIndex = 23
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(41, 339)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(354, 1)
        Me.Panel5.TabIndex = 25
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(43, 390)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(278, 1)
        Me.Panel6.TabIndex = 28
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(43, 495)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(331, 1)
        Me.Panel7.TabIndex = 36
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel8.Location = New System.Drawing.Point(43, 441)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(293, 1)
        Me.Panel8.TabIndex = 32
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel9.Location = New System.Drawing.Point(362, 441)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(243, 1)
        Me.Panel9.TabIndex = 34
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel10.Location = New System.Drawing.Point(345, 390)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(262, 1)
        Me.Panel10.TabIndex = 30
        '
        'frmFornecedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(644, 626)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblPesquisa)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.lblValidador)
        Me.Controls.Add(Me.cmbPesquisa)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.gpbAcoes)
        Me.Controls.Add(Telefone2Label)
        Me.Controls.Add(Nome_fantasiaLabel)
        Me.Controls.Add(Me.Telefone2MaskedTextBox)
        Me.Controls.Add(Me.Nome_fantasiaTextBox)
        Me.Controls.Add(Telefone1Label)
        Me.Controls.Add(Me.Nome_contatoTextBox)
        Me.Controls.Add(Me.Telefone1MaskedTextBox)
        Me.Controls.Add(Nome_contatoLabel)
        Me.Controls.Add(EnderecoLabel)
        Me.Controls.Add(Me.Razao_socialTextBox)
        Me.Controls.Add(Me.EnderecoTextBox)
        Me.Controls.Add(Razao_socialLabel)
        Me.Controls.Add(CidadeLabel)
        Me.Controls.Add(Me.CnpjMaskedTextBox)
        Me.Controls.Add(Me.CidadeTextBox)
        Me.Controls.Add(CnpjLabel)
        Me.Controls.Add(EstadoLabel)
        Me.Controls.Add(Me.CepMaskedTextBox)
        Me.Controls.Add(Me.EstadoComboBox)
        Me.Controls.Add(CepLabel)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmFornecedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Final Stop"
        Me.gpbAcoes.ResumeLayout(False)
        CType(Me.TbFornecedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbFinalStopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gpbAcoes As GroupBox
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnProximo As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents cmbPesquisa As ComboBox
    Friend WithEvents DbFinalStopDataSet As dbFinalStopDataSet
    Friend WithEvents TbFornecedorBindingSource As BindingSource
    Friend WithEvents TbFornecedorTableAdapter As dbFinalStopDataSetTableAdapters.tbFornecedorTableAdapter
    Friend WithEvents TableAdapterManager As dbFinalStopDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Nome_fantasiaTextBox As TextBox
    Friend WithEvents lblValidador As Label
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Telefone2MaskedTextBox As MaskedTextBox
    Friend WithEvents Telefone1MaskedTextBox As MaskedTextBox
    Friend WithEvents EnderecoTextBox As TextBox
    Friend WithEvents CidadeTextBox As TextBox
    Friend WithEvents EstadoComboBox As ComboBox
    Friend WithEvents CepMaskedTextBox As MaskedTextBox
    Friend WithEvents CnpjMaskedTextBox As MaskedTextBox
    Friend WithEvents Razao_socialTextBox As TextBox
    Friend WithEvents Nome_contatoTextBox As TextBox
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
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents toolBtn As ToolTip
End Class
