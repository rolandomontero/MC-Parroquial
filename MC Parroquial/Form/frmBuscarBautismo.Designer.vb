<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarBautismo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarBautismo))
        Me.DataGridViewBautismo = New System.Windows.Forms.DataGridView()
        Me.formFrameSkinner = New Elegant.Ui.FormFrameSkinner()
        Me.bCertificado = New Elegant.Ui.Button()
        Me.Label1 = New Elegant.Ui.Label()
        Me.txtBuscar = New Elegant.Ui.TextBox()
        Me.cmbBuscar = New Elegant.Ui.ComboBox()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingSourceBautismo = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbParroquiaDataSet = New MC_Parroquial.dbParroquiaDataSet()
        Me.T_bautismosTableAdapter1 = New MC_Parroquial.dbParroquiaDataSetTableAdapters.t_bautismosTableAdapter()
        CType(Me.DataGridViewBautismo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceBautismo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbParroquiaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewBautismo
        '
        Me.DataGridViewBautismo.Location = New System.Drawing.Point(12, 103)
        Me.DataGridViewBautismo.Name = "DataGridViewBautismo"
        Me.DataGridViewBautismo.Size = New System.Drawing.Size(767, 430)
        Me.DataGridViewBautismo.TabIndex = 6
        '
        'formFrameSkinner
        '
        Me.formFrameSkinner.Form = Me
        '
        'bCertificado
        '
        Me.bCertificado.Id = "7506ad25-745a-4b80-9047-f1296f12fffd"
        Me.bCertificado.Location = New System.Drawing.Point(639, 20)
        Me.bCertificado.Name = "bCertificado"
        Me.bCertificado.Size = New System.Drawing.Size(92, 56)
        Me.bCertificado.SmallImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", CType(resources.GetObject("bCertificado.SmallImages.Images"), System.Drawing.Image))})
        Me.bCertificado.TabIndex = 2
        Me.bCertificado.Text = "Certificado"
        Me.bCertificado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(34, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Buscar"
        '
        'txtBuscar
        '
        Me.txtBuscar.BannerText = "Texto a buscar ..."
        Me.txtBuscar.Id = "1975eab0-ada6-45d2-a054-ccacc299b75a"
        Me.txtBuscar.Location = New System.Drawing.Point(81, 37)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(310, 21)
        Me.txtBuscar.TabIndex = 4
        Me.txtBuscar.TextEditorWidth = 304
        '
        'cmbBuscar
        '
        Me.cmbBuscar.FormattingEnabled = False
        Me.cmbBuscar.Id = "c5863b37-6d37-41f0-af1c-79a866d137c5"
        Me.cmbBuscar.Items.AddRange(New Object() {"RUN", "Nombres", "Paterno", "Materno"})
        Me.cmbBuscar.Location = New System.Drawing.Point(440, 37)
        Me.cmbBuscar.Name = "cmbBuscar"
        Me.cmbBuscar.Size = New System.Drawing.Size(128, 21)
        Me.cmbBuscar.TabIndex = 5
        Me.cmbBuscar.Text = "Buscar por ..."
        Me.cmbBuscar.TextEditorWidth = 109
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'BindingSourceBautismo
        '
        Me.BindingSourceBautismo.DataMember = "t_bautismos"
        Me.BindingSourceBautismo.DataSource = Me.DbParroquiaDataSet
        '
        'DbParroquiaDataSet
        '
        Me.DbParroquiaDataSet.DataSetName = "dbParroquiaDataSet"
        Me.DbParroquiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'T_bautismosTableAdapter1
        '
        Me.T_bautismosTableAdapter1.ClearBeforeFill = True
        '
        'frmBuscarBautismo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 565)
        Me.Controls.Add(Me.cmbBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bCertificado)
        Me.Controls.Add(Me.DataGridViewBautismo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmBuscarBautismo"
        Me.Text = "Buscar Bautismo"
        CType(Me.DataGridViewBautismo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceBautismo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbParroquiaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewBautismo As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSourceBautismo As System.Windows.Forms.BindingSource
    Friend WithEvents T_bautismosTableAdapter As MC_Parroquial.dbParroquiaDataSetTableAdapters.t_bautismosTableAdapter
    Friend WithEvents formFrameSkinner As Elegant.Ui.FormFrameSkinner
    Friend WithEvents txtBuscar As Elegant.Ui.TextBox
    Friend WithEvents Label1 As Elegant.Ui.Label
    Friend WithEvents bCertificado As Elegant.Ui.Button
    Friend WithEvents RUNDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombresDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbBuscar As Elegant.Ui.ComboBox
    Friend WithEvents DbParroquiaDataSet As MC_Parroquial.dbParroquiaDataSet
    Friend WithEvents T_bautismosTableAdapter1 As MC_Parroquial.dbParroquiaDataSetTableAdapters.t_bautismosTableAdapter

End Class
