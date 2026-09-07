<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelatorioFuncionario
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelatorioFuncionario))
        Me.tbFuncionarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dbFinalStopDataSet = New Final_Stop.dbFinalStopDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tbFuncionarioTableAdapter = New Final_Stop.dbFinalStopDataSetTableAdapters.tbFuncionarioTableAdapter()
        CType(Me.tbFuncionarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbFinalStopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbFuncionarioBindingSource
        '
        Me.tbFuncionarioBindingSource.DataMember = "tbFuncionario"
        Me.tbFuncionarioBindingSource.DataSource = Me.dbFinalStopDataSet
        '
        'dbFinalStopDataSet
        '
        Me.dbFinalStopDataSet.DataSetName = "dbFinalStopDataSet"
        Me.dbFinalStopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "FuncionarioDataSet"
        ReportDataSource1.Value = Me.tbFuncionarioBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Final_Stop.RelatorioFuncionarios.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(634, 661)
        Me.ReportViewer1.TabIndex = 0
        '
        'tbFuncionarioTableAdapter
        '
        Me.tbFuncionarioTableAdapter.ClearBeforeFill = True
        '
        'frmRelatorioFuncionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 661)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRelatorioFuncionario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Final Stop"
        CType(Me.tbFuncionarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbFinalStopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbFuncionarioBindingSource As BindingSource
    Friend WithEvents dbFinalStopDataSet As dbFinalStopDataSet
    Friend WithEvents tbFuncionarioTableAdapter As dbFinalStopDataSetTableAdapters.tbFuncionarioTableAdapter
End Class
