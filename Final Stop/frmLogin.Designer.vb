<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.DbFinalStopDataSet = New Final_Stop.dbFinalStopDataSet()
        Me.TbFuncionarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbFuncionarioTableAdapter = New Final_Stop.dbFinalStopDataSetTableAdapters.tbFuncionarioTableAdapter()
        Me.TableAdapterManager = New Final_Stop.dbFinalStopDataSetTableAdapters.TableAdapterManager()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DbFinalStopDataSet1 = New Final_Stop.dbFinalStopDataSet()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnViewPass = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnEntrar = New System.Windows.Forms.Button()
        CType(Me.DbFinalStopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbFuncionarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbFinalStopDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DbFinalStopDataSet
        '
        Me.DbFinalStopDataSet.DataSetName = "dbFinalStopDataSet"
        Me.DbFinalStopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbFuncionarioBindingSource
        '
        Me.TbFuncionarioBindingSource.DataMember = "tbFuncionario"
        Me.TbFuncionarioBindingSource.DataSource = Me.DbFinalStopDataSet
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
        'txtLogin
        '
        Me.txtLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogin.ForeColor = System.Drawing.Color.White
        Me.txtLogin.Location = New System.Drawing.Point(298, 169)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(221, 20)
        Me.txtLogin.TabIndex = 1
        '
        'txtSenha
        '
        Me.txtSenha.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSenha.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenha.ForeColor = System.Drawing.Color.White
        Me.txtSenha.Location = New System.Drawing.Point(299, 224)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.Size = New System.Drawing.Size(187, 20)
        Me.txtSenha.TabIndex = 2
        Me.txtSenha.UseSystemPasswordChar = True
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.lblLogin.Location = New System.Drawing.Point(315, 58)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(149, 56)
        Me.lblLogin.TabIndex = 6
        Me.lblLogin.Text = "Login"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(258, 252)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(262, 1)
        Me.Panel3.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(258, 197)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(262, 1)
        Me.Panel2.TabIndex = 9
        '
        'DbFinalStopDataSet1
        '
        Me.DbFinalStopDataSet1.DataSetName = "dbFinalStopDataSet"
        Me.DbFinalStopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(230, 380)
        Me.Panel4.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Final_Stop.My.Resources.Resources.final_stop_icon_round_clean
        Me.PictureBox1.Location = New System.Drawing.Point(10, 85)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(210, 210)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'btnViewPass
        '
        Me.btnViewPass.BackgroundImage = Global.Final_Stop.My.Resources.Resources.baseline_visibility_off_white_36dp
        Me.btnViewPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnViewPass.FlatAppearance.BorderSize = 0
        Me.btnViewPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewPass.Location = New System.Drawing.Point(492, 220)
        Me.btnViewPass.Name = "btnViewPass"
        Me.btnViewPass.Size = New System.Drawing.Size(28, 28)
        Me.btnViewPass.TabIndex = 15
        Me.btnViewPass.TabStop = False
        Me.btnViewPass.UseVisualStyleBackColor = True
        '
        'btnMinimizar
        '
        Me.btnMinimizar.BackgroundImage = Global.Final_Stop.My.Resources.Resources.minimize2
        Me.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Location = New System.Drawing.Point(490, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(30, 30)
        Me.btnMinimizar.TabIndex = 1
        Me.btnMinimizar.TabStop = False
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnFechar
        '
        Me.btnFechar.BackgroundImage = Global.Final_Stop.My.Resources.Resources.close
        Me.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFechar.FlatAppearance.BorderSize = 0
        Me.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.Location = New System.Drawing.Point(520, 0)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(30, 30)
        Me.btnFechar.TabIndex = 0
        Me.btnFechar.TabStop = False
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Final_Stop.My.Resources.Resources.user
        Me.PictureBox2.Location = New System.Drawing.Point(257, 161)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(36, 36)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Final_Stop.My.Resources.Resources.pass
        Me.PictureBox3.Location = New System.Drawing.Point(257, 216)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(36, 36)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'btnEntrar
        '
        Me.btnEntrar.FlatAppearance.BorderSize = 0
        Me.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntrar.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnEntrar.Image = Global.Final_Stop.My.Resources.Resources.seta_yellow
        Me.btnEntrar.Location = New System.Drawing.Point(337, 305)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(104, 40)
        Me.btnEntrar.TabIndex = 4
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnEntrar.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(550, 380)
        Me.Controls.Add(Me.btnViewPass)
        Me.Controls.Add(Me.btnMinimizar)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Final Stop"
        CType(Me.DbFinalStopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbFuncionarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbFinalStopDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DbFinalStopDataSet As dbFinalStopDataSet
    Friend WithEvents TbFuncionarioBindingSource As BindingSource
    Friend WithEvents TbFuncionarioTableAdapter As dbFinalStopDataSetTableAdapters.tbFuncionarioTableAdapter
    Friend WithEvents TableAdapterManager As dbFinalStopDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtLogin As TextBox
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents btnEntrar As Button
    Friend WithEvents lblLogin As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents DbFinalStopDataSet1 As dbFinalStopDataSet
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnFechar As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnViewPass As Button
End Class
