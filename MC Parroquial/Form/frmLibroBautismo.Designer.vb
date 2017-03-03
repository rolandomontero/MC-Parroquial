<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLibroBautismo
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
        Dim LibroLabel As System.Windows.Forms.Label
        Dim PaginaLabel As System.Windows.Forms.Label
        Dim Id_folioLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim RUNLabel As System.Windows.Forms.Label
        Dim FechaNacimientoLabel As System.Windows.Forms.Label
        Dim NombresLabel As System.Windows.Forms.Label
        Dim PaternoLabel As System.Windows.Forms.Label
        Dim MaternoLabel As System.Windows.Forms.Label
        Dim PapaLabel As System.Windows.Forms.Label
        Dim MamaLabel As System.Windows.Forms.Label
        Dim PadrinoLabel As System.Windows.Forms.Label
        Dim MadrinaLabel As System.Windows.Forms.Label
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.MadrinaTextBox = New System.Windows.Forms.TextBox()
        Me.BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbParroquiaDataSet = New MC_Parroquial.dbParroquiaDataSet()
        Me.PadrinoTextBox = New System.Windows.Forms.TextBox()
        Me.MamaTextBox = New System.Windows.Forms.TextBox()
        Me.PapaTextBox = New System.Windows.Forms.TextBox()
        Me.MaternoTextBox = New System.Windows.Forms.TextBox()
        Me.PaternoTextBox = New System.Windows.Forms.TextBox()
        Me.NombresTextBox = New System.Windows.Forms.TextBox()
        Me.FechaNacimientoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.RUNTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Id_folioTextBox = New System.Windows.Forms.TextBox()
        Me.PaginaTextBox = New System.Windows.Forms.TextBox()
        Me.LibroTextBox = New System.Windows.Forms.TextBox()
        Me.T_bautismosTableAdapter = New MC_Parroquial.dbParroquiaDataSetTableAdapters.t_bautismosTableAdapter()
        Me.TableAdapterManager = New MC_Parroquial.dbParroquiaDataSetTableAdapters.TableAdapterManager()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.IdfolioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaginaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RUNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaNacimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PapaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PadrinoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MadrinaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        LibroLabel = New System.Windows.Forms.Label()
        PaginaLabel = New System.Windows.Forms.Label()
        Id_folioLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        RUNLabel = New System.Windows.Forms.Label()
        FechaNacimientoLabel = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        PaternoLabel = New System.Windows.Forms.Label()
        MaternoLabel = New System.Windows.Forms.Label()
        PapaLabel = New System.Windows.Forms.Label()
        MamaLabel = New System.Windows.Forms.Label()
        PadrinoLabel = New System.Windows.Forms.Label()
        MadrinaLabel = New System.Windows.Forms.Label()
        Me.GroupBox.SuspendLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbParroquiaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LibroLabel
        '
        LibroLabel.AutoSize = True
        LibroLabel.Location = New System.Drawing.Point(29, 29)
        LibroLabel.Name = "LibroLabel"
        LibroLabel.Size = New System.Drawing.Size(46, 20)
        LibroLabel.TabIndex = 0
        LibroLabel.Text = "Libro:"
        '
        'PaginaLabel
        '
        PaginaLabel.AutoSize = True
        PaginaLabel.Location = New System.Drawing.Point(167, 29)
        PaginaLabel.Name = "PaginaLabel"
        PaginaLabel.Size = New System.Drawing.Size(56, 20)
        PaginaLabel.TabIndex = 2
        PaginaLabel.Text = "Pagina:"
        '
        'Id_folioLabel
        '
        Id_folioLabel.AutoSize = True
        Id_folioLabel.Location = New System.Drawing.Point(299, 29)
        Id_folioLabel.Name = "Id_folioLabel"
        Id_folioLabel.Size = New System.Drawing.Size(60, 20)
        Id_folioLabel.TabIndex = 4
        Id_folioLabel.Text = "Id folio:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(462, 29)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(50, 20)
        FechaLabel.TabIndex = 6
        FechaLabel.Text = "Fecha:"
        '
        'RUNLabel
        '
        RUNLabel.AutoSize = True
        RUNLabel.Location = New System.Drawing.Point(33, 106)
        RUNLabel.Name = "RUNLabel"
        RUNLabel.Size = New System.Drawing.Size(42, 20)
        RUNLabel.TabIndex = 8
        RUNLabel.Text = "RUN:"
        '
        'FechaNacimientoLabel
        '
        FechaNacimientoLabel.AutoSize = True
        FechaNacimientoLabel.Location = New System.Drawing.Point(381, 106)
        FechaNacimientoLabel.Name = "FechaNacimientoLabel"
        FechaNacimientoLabel.Size = New System.Drawing.Size(131, 20)
        FechaNacimientoLabel.TabIndex = 10
        FechaNacimientoLabel.Text = "Fecha Nacimiento:"
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Location = New System.Drawing.Point(17, 164)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(73, 20)
        NombresLabel.TabIndex = 12
        NombresLabel.Text = "Nombres:"
        '
        'PaternoLabel
        '
        PaternoLabel.AutoSize = True
        PaternoLabel.Location = New System.Drawing.Point(252, 164)
        PaternoLabel.Name = "PaternoLabel"
        PaternoLabel.Size = New System.Drawing.Size(62, 20)
        PaternoLabel.TabIndex = 14
        PaternoLabel.Text = "Paterno:"
        '
        'MaternoLabel
        '
        MaternoLabel.AutoSize = True
        MaternoLabel.Location = New System.Drawing.Point(453, 164)
        MaternoLabel.Name = "MaternoLabel"
        MaternoLabel.Size = New System.Drawing.Size(68, 20)
        MaternoLabel.TabIndex = 16
        MaternoLabel.Text = "Materno:"
        '
        'PapaLabel
        '
        PapaLabel.AutoSize = True
        PapaLabel.Location = New System.Drawing.Point(17, 256)
        PapaLabel.Name = "PapaLabel"
        PapaLabel.Size = New System.Drawing.Size(44, 20)
        PapaLabel.TabIndex = 18
        PapaLabel.Text = "Papa:"
        '
        'MamaLabel
        '
        MamaLabel.AutoSize = True
        MamaLabel.Location = New System.Drawing.Point(361, 259)
        MamaLabel.Name = "MamaLabel"
        MamaLabel.Size = New System.Drawing.Size(54, 20)
        MamaLabel.TabIndex = 20
        MamaLabel.Text = "Mama:"
        '
        'PadrinoLabel
        '
        PadrinoLabel.AutoSize = True
        PadrinoLabel.Location = New System.Drawing.Point(17, 309)
        PadrinoLabel.Name = "PadrinoLabel"
        PadrinoLabel.Size = New System.Drawing.Size(62, 20)
        PadrinoLabel.TabIndex = 22
        PadrinoLabel.Text = "Padrino:"
        '
        'MadrinaLabel
        '
        MadrinaLabel.AutoSize = True
        MadrinaLabel.Location = New System.Drawing.Point(348, 309)
        MadrinaLabel.Name = "MadrinaLabel"
        MadrinaLabel.Size = New System.Drawing.Size(67, 20)
        MadrinaLabel.TabIndex = 24
        MadrinaLabel.Text = "Madrina:"
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(MadrinaLabel)
        Me.GroupBox.Controls.Add(Me.MadrinaTextBox)
        Me.GroupBox.Controls.Add(PadrinoLabel)
        Me.GroupBox.Controls.Add(Me.PadrinoTextBox)
        Me.GroupBox.Controls.Add(MamaLabel)
        Me.GroupBox.Controls.Add(Me.MamaTextBox)
        Me.GroupBox.Controls.Add(PapaLabel)
        Me.GroupBox.Controls.Add(Me.PapaTextBox)
        Me.GroupBox.Controls.Add(MaternoLabel)
        Me.GroupBox.Controls.Add(Me.MaternoTextBox)
        Me.GroupBox.Controls.Add(PaternoLabel)
        Me.GroupBox.Controls.Add(Me.PaternoTextBox)
        Me.GroupBox.Controls.Add(NombresLabel)
        Me.GroupBox.Controls.Add(Me.NombresTextBox)
        Me.GroupBox.Controls.Add(FechaNacimientoLabel)
        Me.GroupBox.Controls.Add(Me.FechaNacimientoDateTimePicker)
        Me.GroupBox.Controls.Add(RUNLabel)
        Me.GroupBox.Controls.Add(Me.RUNTextBox)
        Me.GroupBox.Controls.Add(FechaLabel)
        Me.GroupBox.Controls.Add(Me.FechaDateTimePicker)
        Me.GroupBox.Controls.Add(Id_folioLabel)
        Me.GroupBox.Controls.Add(Me.Id_folioTextBox)
        Me.GroupBox.Controls.Add(PaginaLabel)
        Me.GroupBox.Controls.Add(Me.PaginaTextBox)
        Me.GroupBox.Controls.Add(LibroLabel)
        Me.GroupBox.Controls.Add(Me.LibroTextBox)
        Me.GroupBox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox.Location = New System.Drawing.Point(123, 34)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(682, 373)
        Me.GroupBox.TabIndex = 1
        Me.GroupBox.TabStop = False
        '
        'MadrinaTextBox
        '
        Me.MadrinaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "Madrina", True))
        Me.MadrinaTextBox.Location = New System.Drawing.Point(421, 306)
        Me.MadrinaTextBox.Name = "MadrinaTextBox"
        Me.MadrinaTextBox.Size = New System.Drawing.Size(226, 27)
        Me.MadrinaTextBox.TabIndex = 25
        '
        'BindingSource
        '
        Me.BindingSource.DataMember = "t_bautismos"
        Me.BindingSource.DataSource = Me.DbParroquiaDataSet
        '
        'DbParroquiaDataSet
        '
        Me.DbParroquiaDataSet.DataSetName = "dbParroquiaDataSet"
        Me.DbParroquiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PadrinoTextBox
        '
        Me.PadrinoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "Padrino", True))
        Me.PadrinoTextBox.Location = New System.Drawing.Point(85, 306)
        Me.PadrinoTextBox.Name = "PadrinoTextBox"
        Me.PadrinoTextBox.Size = New System.Drawing.Size(226, 27)
        Me.PadrinoTextBox.TabIndex = 23
        '
        'MamaTextBox
        '
        Me.MamaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "Mama", True))
        Me.MamaTextBox.Location = New System.Drawing.Point(421, 256)
        Me.MamaTextBox.Name = "MamaTextBox"
        Me.MamaTextBox.Size = New System.Drawing.Size(226, 27)
        Me.MamaTextBox.TabIndex = 21
        '
        'PapaTextBox
        '
        Me.PapaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "Papa", True))
        Me.PapaTextBox.Location = New System.Drawing.Point(85, 253)
        Me.PapaTextBox.Name = "PapaTextBox"
        Me.PapaTextBox.Size = New System.Drawing.Size(226, 27)
        Me.PapaTextBox.TabIndex = 19
        '
        'MaternoTextBox
        '
        Me.MaternoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "Materno", True))
        Me.MaternoTextBox.Location = New System.Drawing.Point(457, 187)
        Me.MaternoTextBox.Name = "MaternoTextBox"
        Me.MaternoTextBox.Size = New System.Drawing.Size(190, 27)
        Me.MaternoTextBox.TabIndex = 17
        '
        'PaternoTextBox
        '
        Me.PaternoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "Paterno", True))
        Me.PaternoTextBox.Location = New System.Drawing.Point(256, 187)
        Me.PaternoTextBox.Name = "PaternoTextBox"
        Me.PaternoTextBox.Size = New System.Drawing.Size(190, 27)
        Me.PaternoTextBox.TabIndex = 15
        '
        'NombresTextBox
        '
        Me.NombresTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "Nombres", True))
        Me.NombresTextBox.Location = New System.Drawing.Point(21, 187)
        Me.NombresTextBox.Name = "NombresTextBox"
        Me.NombresTextBox.Size = New System.Drawing.Size(223, 27)
        Me.NombresTextBox.TabIndex = 13
        '
        'FechaNacimientoDateTimePicker
        '
        Me.FechaNacimientoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource, "FechaNacimiento", True))
        Me.FechaNacimientoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaNacimientoDateTimePicker.Location = New System.Drawing.Point(527, 103)
        Me.FechaNacimientoDateTimePicker.Name = "FechaNacimientoDateTimePicker"
        Me.FechaNacimientoDateTimePicker.Size = New System.Drawing.Size(120, 27)
        Me.FechaNacimientoDateTimePicker.TabIndex = 11
        '
        'RUNTextBox
        '
        Me.RUNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "RUN", True))
        Me.RUNTextBox.Location = New System.Drawing.Point(81, 103)
        Me.RUNTextBox.Name = "RUNTextBox"
        Me.RUNTextBox.Size = New System.Drawing.Size(100, 27)
        Me.RUNTextBox.TabIndex = 9
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(527, 26)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(120, 27)
        Me.FechaDateTimePicker.TabIndex = 7
        '
        'Id_folioTextBox
        '
        Me.Id_folioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "Id_folio", True))
        Me.Id_folioTextBox.Location = New System.Drawing.Point(365, 26)
        Me.Id_folioTextBox.Name = "Id_folioTextBox"
        Me.Id_folioTextBox.Size = New System.Drawing.Size(52, 27)
        Me.Id_folioTextBox.TabIndex = 5
        '
        'PaginaTextBox
        '
        Me.PaginaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "Pagina", True))
        Me.PaginaTextBox.Location = New System.Drawing.Point(229, 26)
        Me.PaginaTextBox.Name = "PaginaTextBox"
        Me.PaginaTextBox.Size = New System.Drawing.Size(42, 27)
        Me.PaginaTextBox.TabIndex = 3
        '
        'LibroTextBox
        '
        Me.LibroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "Libro", True))
        Me.LibroTextBox.Location = New System.Drawing.Point(81, 26)
        Me.LibroTextBox.Name = "LibroTextBox"
        Me.LibroTextBox.Size = New System.Drawing.Size(40, 27)
        Me.LibroTextBox.TabIndex = 1
        '
        'T_bautismosTableAdapter
        '
        Me.T_bautismosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.t_bautismosTableAdapter = Me.T_bautismosTableAdapter
        Me.TableAdapterManager.t_confirmaciónTableAdapter = Nothing
        Me.TableAdapterManager.t_matrimonioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MC_Parroquial.dbParroquiaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridView
        '
        Me.DataGridView.AutoGenerateColumns = False
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdfolioDataGridViewTextBoxColumn, Me.LibroDataGridViewTextBoxColumn, Me.PaginaDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.RUNDataGridViewTextBoxColumn, Me.NombresDataGridViewTextBoxColumn, Me.PaternoDataGridViewTextBoxColumn, Me.MaternoDataGridViewTextBoxColumn, Me.FechaNacimientoDataGridViewTextBoxColumn, Me.MamaDataGridViewTextBoxColumn, Me.PapaDataGridViewTextBoxColumn, Me.PadrinoDataGridViewTextBoxColumn, Me.MadrinaDataGridViewTextBoxColumn})
        Me.DataGridView.DataSource = Me.BindingSource
        Me.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.Size = New System.Drawing.Size(910, 447)
        Me.DataGridView.TabIndex = 3
        Me.DataGridView.Visible = False
        '
        'IdfolioDataGridViewTextBoxColumn
        '
        Me.IdfolioDataGridViewTextBoxColumn.DataPropertyName = "Id_folio"
        Me.IdfolioDataGridViewTextBoxColumn.HeaderText = "Id_folio"
        Me.IdfolioDataGridViewTextBoxColumn.Name = "IdfolioDataGridViewTextBoxColumn"
        '
        'LibroDataGridViewTextBoxColumn
        '
        Me.LibroDataGridViewTextBoxColumn.DataPropertyName = "Libro"
        Me.LibroDataGridViewTextBoxColumn.HeaderText = "Libro"
        Me.LibroDataGridViewTextBoxColumn.Name = "LibroDataGridViewTextBoxColumn"
        '
        'PaginaDataGridViewTextBoxColumn
        '
        Me.PaginaDataGridViewTextBoxColumn.DataPropertyName = "Pagina"
        Me.PaginaDataGridViewTextBoxColumn.HeaderText = "Pagina"
        Me.PaginaDataGridViewTextBoxColumn.Name = "PaginaDataGridViewTextBoxColumn"
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
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
        'FechaNacimientoDataGridViewTextBoxColumn
        '
        Me.FechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaNacimiento"
        Me.FechaNacimientoDataGridViewTextBoxColumn.HeaderText = "FechaNacimiento"
        Me.FechaNacimientoDataGridViewTextBoxColumn.Name = "FechaNacimientoDataGridViewTextBoxColumn"
        '
        'MamaDataGridViewTextBoxColumn
        '
        Me.MamaDataGridViewTextBoxColumn.DataPropertyName = "Mama"
        Me.MamaDataGridViewTextBoxColumn.HeaderText = "Mama"
        Me.MamaDataGridViewTextBoxColumn.Name = "MamaDataGridViewTextBoxColumn"
        '
        'PapaDataGridViewTextBoxColumn
        '
        Me.PapaDataGridViewTextBoxColumn.DataPropertyName = "Papa"
        Me.PapaDataGridViewTextBoxColumn.HeaderText = "Papa"
        Me.PapaDataGridViewTextBoxColumn.Name = "PapaDataGridViewTextBoxColumn"
        '
        'PadrinoDataGridViewTextBoxColumn
        '
        Me.PadrinoDataGridViewTextBoxColumn.DataPropertyName = "Padrino"
        Me.PadrinoDataGridViewTextBoxColumn.HeaderText = "Padrino"
        Me.PadrinoDataGridViewTextBoxColumn.Name = "PadrinoDataGridViewTextBoxColumn"
        '
        'MadrinaDataGridViewTextBoxColumn
        '
        Me.MadrinaDataGridViewTextBoxColumn.DataPropertyName = "Madrina"
        Me.MadrinaDataGridViewTextBoxColumn.HeaderText = "Madrina"
        Me.MadrinaDataGridViewTextBoxColumn.Name = "MadrinaDataGridViewTextBoxColumn"
        '
        'frmLibroBautismo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 447)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.GroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmLibroBautismo"
        Me.Text = "Libro de Bautismo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbParroquiaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents DbParroquiaDataSet As Global.MC_Parroquial.dbParroquiaDataSet
    Friend WithEvents BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T_bautismosTableAdapter As Global.MC_Parroquial.dbParroquiaDataSetTableAdapters.t_bautismosTableAdapter
    Friend WithEvents TableAdapterManager As Global.MC_Parroquial.dbParroquiaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MaternoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PaternoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombresTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaNacimientoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents RUNTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Id_folioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PaginaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LibroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MadrinaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PadrinoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MamaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PapaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents IdfolioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LibroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaginaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RUNDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombresDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaNacimientoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MamaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PapaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PadrinoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MadrinaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
