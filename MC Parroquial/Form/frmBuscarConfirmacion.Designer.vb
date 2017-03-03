<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarConfirmacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarConfirmacion))
        Me.cmbBuscar = New Elegant.Ui.ComboBox()
        Me.txtBuscar = New Elegant.Ui.TextBox()
        Me.Label1 = New Elegant.Ui.Label()
        Me.bCertificado = New Elegant.Ui.Button()
        Me.DataGridViewConfirmacion = New System.Windows.Forms.DataGridView()
        Me.BindingSourceConfirmacion = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbParroquiaDataSet = New MC_Parroquial.dbParroquiaDataSet()
        Me.T_confirmaciónTableAdapter = New MC_Parroquial.dbParroquiaDataSetTableAdapters.t_confirmaciónTableAdapter()
        Me.RUNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridViewConfirmacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceConfirmacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbParroquiaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbBuscar
        '
        Me.cmbBuscar.FormattingEnabled = False
        Me.cmbBuscar.Id = "688d726b-70db-49c1-af8c-723d091b6f24"
        Me.cmbBuscar.Items.AddRange(New Object() {"Esposo", "Esposa"})
        Me.cmbBuscar.Location = New System.Drawing.Point(431, 24)
        Me.cmbBuscar.Name = "cmbBuscar"
        Me.cmbBuscar.Size = New System.Drawing.Size(128, 21)
        Me.cmbBuscar.TabIndex = 10
        Me.cmbBuscar.Text = "Buscar por ..."
        Me.cmbBuscar.TextEditorWidth = 109
        '
        'txtBuscar
        '
        Me.txtBuscar.BannerText = "Texto a buscar ..."
        Me.txtBuscar.Id = "d0cddf2e-6ebe-4f33-8e81-e1252c309c07"
        Me.txtBuscar.Location = New System.Drawing.Point(72, 24)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(310, 21)
        Me.txtBuscar.TabIndex = 9
        Me.txtBuscar.TextEditorWidth = 304
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(25, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 21)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Buscar"
        '
        'bCertificado
        '
        Me.bCertificado.Id = "79b55753-3e09-4224-982a-82672a45fd84"
        Me.bCertificado.Location = New System.Drawing.Point(630, 7)
        Me.bCertificado.Name = "bCertificado"
        Me.bCertificado.Size = New System.Drawing.Size(92, 64)
        Me.bCertificado.SmallImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", CType(resources.GetObject("bCertificado.SmallImages.Images"), System.Drawing.Image))})
        Me.bCertificado.TabIndex = 7
        Me.bCertificado.Text = "Certificado"
        Me.bCertificado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'DataGridViewConfirmacion
        '
        Me.DataGridViewConfirmacion.AutoGenerateColumns = False
        Me.DataGridViewConfirmacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RUNDataGridViewTextBoxColumn, Me.NombresDataGridViewTextBoxColumn, Me.PaternoDataGridViewTextBoxColumn, Me.MaternoDataGridViewTextBoxColumn})
        Me.DataGridViewConfirmacion.DataSource = Me.BindingSourceConfirmacion
        Me.DataGridViewConfirmacion.Location = New System.Drawing.Point(3, 90)
        Me.DataGridViewConfirmacion.Name = "DataGridViewConfirmacion"
        Me.DataGridViewConfirmacion.Size = New System.Drawing.Size(767, 395)
        Me.DataGridViewConfirmacion.TabIndex = 11
        '
        'BindingSourceConfirmacion
        '
        Me.BindingSourceConfirmacion.DataMember = "t_confirmación"
        Me.BindingSourceConfirmacion.DataSource = Me.DbParroquiaDataSet
        '
        'DbParroquiaDataSet
        '
        Me.DbParroquiaDataSet.DataSetName = "dbParroquiaDataSet"
        Me.DbParroquiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'T_confirmaciónTableAdapter
        '
        Me.T_confirmaciónTableAdapter.ClearBeforeFill = True
        '
        'RUNDataGridViewTextBoxColumn
        '
        Me.RUNDataGridViewTextBoxColumn.DataPropertyName = "RUN"
        Me.RUNDataGridViewTextBoxColumn.HeaderText = "RUN"
        Me.RUNDataGridViewTextBoxColumn.Name = "RUNDataGridViewTextBoxColumn"
        '
        'NombresDataGridViewTextBoxColumn
        '
        Me.NombresDataGridViewTextBoxColumn.DataPropertyName = "Nombres"
        Me.NombresDataGridViewTextBoxColumn.HeaderText = "Nombres"
        Me.NombresDataGridViewTextBoxColumn.Name = "NombresDataGridViewTextBoxColumn"
        '
        'PaternoDataGridViewTextBoxColumn
        '
        Me.PaternoDataGridViewTextBoxColumn.DataPropertyName = "Paterno"
        Me.PaternoDataGridViewTextBoxColumn.HeaderText = "Paterno"
        Me.PaternoDataGridViewTextBoxColumn.Name = "PaternoDataGridViewTextBoxColumn"
        '
        'MaternoDataGridViewTextBoxColumn
        '
        Me.MaternoDataGridViewTextBoxColumn.DataPropertyName = "Materno"
        Me.MaternoDataGridViewTextBoxColumn.HeaderText = "Materno"
        Me.MaternoDataGridViewTextBoxColumn.Name = "MaternoDataGridViewTextBoxColumn"
        '
        'frmBuscarConfirmacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 497)
        Me.Controls.Add(Me.cmbBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bCertificado)
        Me.Controls.Add(Me.DataGridViewConfirmacion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmBuscarConfirmacion"
        Me.Text = "BuscarConfirmacion"
        CType(Me.DataGridViewConfirmacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceConfirmacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbParroquiaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbBuscar As Elegant.Ui.ComboBox
    Friend WithEvents txtBuscar As Elegant.Ui.TextBox
    Friend WithEvents Label1 As Elegant.Ui.Label
    Friend WithEvents bCertificado As Elegant.Ui.Button
    Friend WithEvents DataGridViewConfirmacion As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSourceConfirmacion As System.Windows.Forms.BindingSource
    Friend WithEvents DbParroquiaDataSet As MC_Parroquial.dbParroquiaDataSet
    Friend WithEvents T_confirmaciónTableAdapter As MC_Parroquial.dbParroquiaDataSetTableAdapters.t_confirmaciónTableAdapter
    Friend WithEvents RUNDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombresDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
