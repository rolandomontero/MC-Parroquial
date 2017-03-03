<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLibroConfirmacion
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
        Dim PáginaLabel As System.Windows.Forms.Label
        Dim Id_folioLabel As System.Windows.Forms.Label
        Dim FechaConfirmacionLabel As System.Windows.Forms.Label
        Dim ParroquiaLabel As System.Windows.Forms.Label
        Dim PárrocoLabel As System.Windows.Forms.Label
        Dim RUNLabel As System.Windows.Forms.Label
        Dim NombresLabel As System.Windows.Forms.Label
        Dim PaternoLabel As System.Windows.Forms.Label
        Dim MaternoLabel As System.Windows.Forms.Label
        Dim ParroquiabautismoLabel As System.Windows.Forms.Label
        Dim AñoBautismoLabel As System.Windows.Forms.Label
        Dim EdadConfirmacionLabel As System.Windows.Forms.Label
        Dim PapaLabel As System.Windows.Forms.Label
        Dim MamaLabel As System.Windows.Forms.Label
        Dim PadrinoLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PadrinoTextBox = New System.Windows.Forms.TextBox()
        Me.BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbParroquiaDataSet = New MC_Parroquial.dbParroquiaDataSet()
        Me.MamaTextBox = New System.Windows.Forms.TextBox()
        Me.PapaTextBox = New System.Windows.Forms.TextBox()
        Me.EdadConfirmacionTextBox = New System.Windows.Forms.TextBox()
        Me.AñoBautismoTextBox = New System.Windows.Forms.TextBox()
        Me.ParroquiabautismoTextBox = New System.Windows.Forms.TextBox()
        Me.MaternoTextBox = New System.Windows.Forms.TextBox()
        Me.PaternoTextBox = New System.Windows.Forms.TextBox()
        Me.NombresTextBox = New System.Windows.Forms.TextBox()
        Me.RUNTextBox = New System.Windows.Forms.TextBox()
        Me.PárrocoTextBox = New System.Windows.Forms.TextBox()
        Me.ParroquiaTextBox = New System.Windows.Forms.TextBox()
        Me.FechaConfirmacionDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Id_folioTextBox = New System.Windows.Forms.TextBox()
        Me.PáginaTextBox = New System.Windows.Forms.TextBox()
        Me.LibroTextBox = New System.Windows.Forms.TextBox()
        Me.TableAdapterManager = New MC_Parroquial.dbParroquiaDataSetTableAdapters.TableAdapterManager()
        Me.T_confirmaciónTableAdapter = New MC_Parroquial.dbParroquiaDataSetTableAdapters.t_confirmaciónTableAdapter()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.IdfolioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PáginaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaConfirmacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ParroquiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PárrocoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AñoBautismoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ParroquiabautismoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RUNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EdadConfirmacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PadrinoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PapaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        LibroLabel = New System.Windows.Forms.Label()
        PáginaLabel = New System.Windows.Forms.Label()
        Id_folioLabel = New System.Windows.Forms.Label()
        FechaConfirmacionLabel = New System.Windows.Forms.Label()
        ParroquiaLabel = New System.Windows.Forms.Label()
        PárrocoLabel = New System.Windows.Forms.Label()
        RUNLabel = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        PaternoLabel = New System.Windows.Forms.Label()
        MaternoLabel = New System.Windows.Forms.Label()
        ParroquiabautismoLabel = New System.Windows.Forms.Label()
        AñoBautismoLabel = New System.Windows.Forms.Label()
        EdadConfirmacionLabel = New System.Windows.Forms.Label()
        PapaLabel = New System.Windows.Forms.Label()
        MamaLabel = New System.Windows.Forms.Label()
        PadrinoLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbParroquiaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LibroLabel
        '
        LibroLabel.AutoSize = True
        LibroLabel.Location = New System.Drawing.Point(11, 31)
        LibroLabel.Name = "LibroLabel"
        LibroLabel.Size = New System.Drawing.Size(49, 21)
        LibroLabel.TabIndex = 0
        LibroLabel.Text = "Libro:"
        '
        'PáginaLabel
        '
        PáginaLabel.AutoSize = True
        PáginaLabel.Location = New System.Drawing.Point(127, 31)
        PáginaLabel.Name = "PáginaLabel"
        PáginaLabel.Size = New System.Drawing.Size(59, 21)
        PáginaLabel.TabIndex = 2
        PáginaLabel.Text = "Página:"
        '
        'Id_folioLabel
        '
        Id_folioLabel.AutoSize = True
        Id_folioLabel.Location = New System.Drawing.Point(242, 31)
        Id_folioLabel.Name = "Id_folioLabel"
        Id_folioLabel.Size = New System.Drawing.Size(47, 21)
        Id_folioLabel.TabIndex = 4
        Id_folioLabel.Text = "Folio:"
        '
        'FechaConfirmacionLabel
        '
        FechaConfirmacionLabel.AutoSize = True
        FechaConfirmacionLabel.Location = New System.Drawing.Point(456, 32)
        FechaConfirmacionLabel.Name = "FechaConfirmacionLabel"
        FechaConfirmacionLabel.Size = New System.Drawing.Size(151, 21)
        FechaConfirmacionLabel.TabIndex = 6
        FechaConfirmacionLabel.Text = "Fecha Confirmacion:"
        '
        'ParroquiaLabel
        '
        ParroquiaLabel.AutoSize = True
        ParroquiaLabel.Location = New System.Drawing.Point(14, 88)
        ParroquiaLabel.Name = "ParroquiaLabel"
        ParroquiaLabel.Size = New System.Drawing.Size(80, 21)
        ParroquiaLabel.TabIndex = 8
        ParroquiaLabel.Text = "Parroquia:"
        '
        'PárrocoLabel
        '
        PárrocoLabel.AutoSize = True
        PárrocoLabel.Location = New System.Drawing.Point(456, 83)
        PárrocoLabel.Name = "PárrocoLabel"
        PárrocoLabel.Size = New System.Drawing.Size(66, 21)
        PárrocoLabel.TabIndex = 10
        PárrocoLabel.Text = "Párroco:"
        '
        'RUNLabel
        '
        RUNLabel.AutoSize = True
        RUNLabel.Location = New System.Drawing.Point(14, 148)
        RUNLabel.Name = "RUNLabel"
        RUNLabel.Size = New System.Drawing.Size(46, 21)
        RUNLabel.TabIndex = 12
        RUNLabel.Text = "RUN:"
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Location = New System.Drawing.Point(11, 204)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(78, 21)
        NombresLabel.TabIndex = 14
        NombresLabel.Text = "Nombres:"
        '
        'PaternoLabel
        '
        PaternoLabel.AutoSize = True
        PaternoLabel.Location = New System.Drawing.Point(312, 204)
        PaternoLabel.Name = "PaternoLabel"
        PaternoLabel.Size = New System.Drawing.Size(66, 21)
        PaternoLabel.TabIndex = 16
        PaternoLabel.Text = "Paterno:"
        '
        'MaternoLabel
        '
        MaternoLabel.AutoSize = True
        MaternoLabel.Location = New System.Drawing.Point(524, 204)
        MaternoLabel.Name = "MaternoLabel"
        MaternoLabel.Size = New System.Drawing.Size(72, 21)
        MaternoLabel.TabIndex = 18
        MaternoLabel.Text = "Materno:"
        '
        'ParroquiabautismoLabel
        '
        ParroquiabautismoLabel.AutoSize = True
        ParroquiabautismoLabel.Location = New System.Drawing.Point(14, 282)
        ParroquiabautismoLabel.Name = "ParroquiabautismoLabel"
        ParroquiabautismoLabel.Size = New System.Drawing.Size(149, 21)
        ParroquiabautismoLabel.TabIndex = 20
        ParroquiabautismoLabel.Text = "Parroquia Bautismo:"
        '
        'AñoBautismoLabel
        '
        AñoBautismoLabel.AutoSize = True
        AñoBautismoLabel.Location = New System.Drawing.Point(550, 282)
        AñoBautismoLabel.Name = "AñoBautismoLabel"
        AñoBautismoLabel.Size = New System.Drawing.Size(110, 21)
        AñoBautismoLabel.TabIndex = 22
        AñoBautismoLabel.Text = "Año Bautismo:"
        '
        'EdadConfirmacionLabel
        '
        EdadConfirmacionLabel.AutoSize = True
        EdadConfirmacionLabel.Location = New System.Drawing.Point(483, 143)
        EdadConfirmacionLabel.Name = "EdadConfirmacionLabel"
        EdadConfirmacionLabel.Size = New System.Drawing.Size(145, 21)
        EdadConfirmacionLabel.TabIndex = 24
        EdadConfirmacionLabel.Text = "Edad Confirmacion:"
        '
        'PapaLabel
        '
        PapaLabel.AutoSize = True
        PapaLabel.Location = New System.Drawing.Point(14, 333)
        PapaLabel.Name = "PapaLabel"
        PapaLabel.Size = New System.Drawing.Size(46, 21)
        PapaLabel.TabIndex = 26
        PapaLabel.Text = "Papa:"
        '
        'MamaLabel
        '
        MamaLabel.AutoSize = True
        MamaLabel.Location = New System.Drawing.Point(460, 333)
        MamaLabel.Name = "MamaLabel"
        MamaLabel.Size = New System.Drawing.Size(57, 21)
        MamaLabel.TabIndex = 28
        MamaLabel.Text = "Mama:"
        '
        'PadrinoLabel
        '
        PadrinoLabel.AutoSize = True
        PadrinoLabel.Location = New System.Drawing.Point(14, 384)
        PadrinoLabel.Name = "PadrinoLabel"
        PadrinoLabel.Size = New System.Drawing.Size(66, 21)
        PadrinoLabel.TabIndex = 30
        PadrinoLabel.Text = "Padrino:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(PadrinoLabel)
        Me.GroupBox1.Controls.Add(Me.PadrinoTextBox)
        Me.GroupBox1.Controls.Add(MamaLabel)
        Me.GroupBox1.Controls.Add(Me.MamaTextBox)
        Me.GroupBox1.Controls.Add(PapaLabel)
        Me.GroupBox1.Controls.Add(Me.PapaTextBox)
        Me.GroupBox1.Controls.Add(EdadConfirmacionLabel)
        Me.GroupBox1.Controls.Add(Me.EdadConfirmacionTextBox)
        Me.GroupBox1.Controls.Add(AñoBautismoLabel)
        Me.GroupBox1.Controls.Add(Me.AñoBautismoTextBox)
        Me.GroupBox1.Controls.Add(ParroquiabautismoLabel)
        Me.GroupBox1.Controls.Add(Me.ParroquiabautismoTextBox)
        Me.GroupBox1.Controls.Add(MaternoLabel)
        Me.GroupBox1.Controls.Add(Me.MaternoTextBox)
        Me.GroupBox1.Controls.Add(PaternoLabel)
        Me.GroupBox1.Controls.Add(Me.PaternoTextBox)
        Me.GroupBox1.Controls.Add(NombresLabel)
        Me.GroupBox1.Controls.Add(Me.NombresTextBox)
        Me.GroupBox1.Controls.Add(RUNLabel)
        Me.GroupBox1.Controls.Add(Me.RUNTextBox)
        Me.GroupBox1.Controls.Add(PárrocoLabel)
        Me.GroupBox1.Controls.Add(Me.PárrocoTextBox)
        Me.GroupBox1.Controls.Add(ParroquiaLabel)
        Me.GroupBox1.Controls.Add(Me.ParroquiaTextBox)
        Me.GroupBox1.Controls.Add(FechaConfirmacionLabel)
        Me.GroupBox1.Controls.Add(Me.FechaConfirmacionDateTimePicker)
        Me.GroupBox1.Controls.Add(Id_folioLabel)
        Me.GroupBox1.Controls.Add(Me.Id_folioTextBox)
        Me.GroupBox1.Controls.Add(PáginaLabel)
        Me.GroupBox1.Controls.Add(Me.PáginaTextBox)
        Me.GroupBox1.Controls.Add(LibroLabel)
        Me.GroupBox1.Controls.Add(Me.LibroTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(754, 433)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'PadrinoTextBox
        '
        Me.PadrinoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "Padrino", True))
        Me.PadrinoTextBox.Location = New System.Drawing.Point(86, 381)
        Me.PadrinoTextBox.Name = "PadrinoTextBox"
        Me.PadrinoTextBox.Size = New System.Drawing.Size(213, 29)
        Me.PadrinoTextBox.TabIndex = 31
        '
        'BindingSource
        '
        Me.BindingSource.DataMember = "t_confirmación"
        Me.BindingSource.DataSource = Me.DbParroquiaDataSet
        '
        'DbParroquiaDataSet
        '
        Me.DbParroquiaDataSet.DataSetName = "dbParroquiaDataSet"
        Me.DbParroquiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MamaTextBox
        '
        Me.MamaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "Mama", True))
        Me.MamaTextBox.Location = New System.Drawing.Point(523, 330)
        Me.MamaTextBox.Name = "MamaTextBox"
        Me.MamaTextBox.Size = New System.Drawing.Size(211, 29)
        Me.MamaTextBox.TabIndex = 29
        '
        'PapaTextBox
        '
        Me.PapaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "Papa", True))
        Me.PapaTextBox.Location = New System.Drawing.Point(66, 330)
        Me.PapaTextBox.Name = "PapaTextBox"
        Me.PapaTextBox.Size = New System.Drawing.Size(233, 29)
        Me.PapaTextBox.TabIndex = 27
        '
        'EdadConfirmacionTextBox
        '
        Me.EdadConfirmacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "EdadConfirmacion", True))
        Me.EdadConfirmacionTextBox.Location = New System.Drawing.Point(634, 140)
        Me.EdadConfirmacionTextBox.Name = "EdadConfirmacionTextBox"
        Me.EdadConfirmacionTextBox.Size = New System.Drawing.Size(100, 29)
        Me.EdadConfirmacionTextBox.TabIndex = 25
        '
        'AñoBautismoTextBox
        '
        Me.AñoBautismoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "AñoBautismo", True))
        Me.AñoBautismoTextBox.Location = New System.Drawing.Point(666, 282)
        Me.AñoBautismoTextBox.Name = "AñoBautismoTextBox"
        Me.AñoBautismoTextBox.Size = New System.Drawing.Size(68, 29)
        Me.AñoBautismoTextBox.TabIndex = 23
        '
        'ParroquiabautismoTextBox
        '
        Me.ParroquiabautismoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "Parroquiabautismo", True))
        Me.ParroquiabautismoTextBox.Location = New System.Drawing.Point(192, 282)
        Me.ParroquiabautismoTextBox.Name = "ParroquiabautismoTextBox"
        Me.ParroquiabautismoTextBox.Size = New System.Drawing.Size(281, 29)
        Me.ParroquiabautismoTextBox.TabIndex = 21
        '
        'MaternoTextBox
        '
        Me.MaternoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "Materno", True))
        Me.MaternoTextBox.Location = New System.Drawing.Point(528, 228)
        Me.MaternoTextBox.Name = "MaternoTextBox"
        Me.MaternoTextBox.Size = New System.Drawing.Size(206, 29)
        Me.MaternoTextBox.TabIndex = 19
        '
        'PaternoTextBox
        '
        Me.PaternoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "Paterno", True))
        Me.PaternoTextBox.Location = New System.Drawing.Point(316, 228)
        Me.PaternoTextBox.Name = "PaternoTextBox"
        Me.PaternoTextBox.Size = New System.Drawing.Size(193, 29)
        Me.PaternoTextBox.TabIndex = 17
        '
        'NombresTextBox
        '
        Me.NombresTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "Nombres", True))
        Me.NombresTextBox.Location = New System.Drawing.Point(15, 228)
        Me.NombresTextBox.Name = "NombresTextBox"
        Me.NombresTextBox.Size = New System.Drawing.Size(284, 29)
        Me.NombresTextBox.TabIndex = 15
        '
        'RUNTextBox
        '
        Me.RUNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "RUN", True))
        Me.RUNTextBox.Location = New System.Drawing.Point(66, 145)
        Me.RUNTextBox.Name = "RUNTextBox"
        Me.RUNTextBox.Size = New System.Drawing.Size(100, 29)
        Me.RUNTextBox.TabIndex = 13
        '
        'PárrocoTextBox
        '
        Me.PárrocoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "Párroco", True))
        Me.PárrocoTextBox.Location = New System.Drawing.Point(528, 80)
        Me.PárrocoTextBox.Name = "PárrocoTextBox"
        Me.PárrocoTextBox.Size = New System.Drawing.Size(206, 29)
        Me.PárrocoTextBox.TabIndex = 11
        '
        'ParroquiaTextBox
        '
        Me.ParroquiaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "Parroquia", True))
        Me.ParroquiaTextBox.Location = New System.Drawing.Point(100, 85)
        Me.ParroquiaTextBox.Name = "ParroquiaTextBox"
        Me.ParroquiaTextBox.Size = New System.Drawing.Size(248, 29)
        Me.ParroquiaTextBox.TabIndex = 9
        '
        'FechaConfirmacionDateTimePicker
        '
        Me.FechaConfirmacionDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource, "FechaConfirmacion", True))
        Me.FechaConfirmacionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaConfirmacionDateTimePicker.Location = New System.Drawing.Point(613, 28)
        Me.FechaConfirmacionDateTimePicker.Name = "FechaConfirmacionDateTimePicker"
        Me.FechaConfirmacionDateTimePicker.Size = New System.Drawing.Size(121, 29)
        Me.FechaConfirmacionDateTimePicker.TabIndex = 7
        '
        'Id_folioTextBox
        '
        Me.Id_folioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "id_folio", True))
        Me.Id_folioTextBox.Location = New System.Drawing.Point(309, 28)
        Me.Id_folioTextBox.Name = "Id_folioTextBox"
        Me.Id_folioTextBox.Size = New System.Drawing.Size(39, 29)
        Me.Id_folioTextBox.TabIndex = 5
        '
        'PáginaTextBox
        '
        Me.PáginaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "Página", True))
        Me.PáginaTextBox.Location = New System.Drawing.Point(192, 28)
        Me.PáginaTextBox.Name = "PáginaTextBox"
        Me.PáginaTextBox.Size = New System.Drawing.Size(30, 29)
        Me.PáginaTextBox.TabIndex = 3
        '
        'LibroTextBox
        '
        Me.LibroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "Libro", True))
        Me.LibroTextBox.Location = New System.Drawing.Point(66, 28)
        Me.LibroTextBox.Name = "LibroTextBox"
        Me.LibroTextBox.Size = New System.Drawing.Size(32, 29)
        Me.LibroTextBox.TabIndex = 1
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.t_bautismosTableAdapter = Nothing
        Me.TableAdapterManager.t_confirmaciónTableAdapter = Me.T_confirmaciónTableAdapter
        Me.TableAdapterManager.t_matrimonioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MC_Parroquial.dbParroquiaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'T_confirmaciónTableAdapter
        '
        Me.T_confirmaciónTableAdapter.ClearBeforeFill = True
        '
        'DataGridView
        '
        Me.DataGridView.AutoGenerateColumns = False
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdfolioDataGridViewTextBoxColumn, Me.LibroDataGridViewTextBoxColumn, Me.PáginaDataGridViewTextBoxColumn, Me.FechaConfirmacionDataGridViewTextBoxColumn, Me.ParroquiaDataGridViewTextBoxColumn, Me.PárrocoDataGridViewTextBoxColumn, Me.AñoBautismoDataGridViewTextBoxColumn, Me.ParroquiabautismoDataGridViewTextBoxColumn, Me.RUNDataGridViewTextBoxColumn, Me.NombresDataGridViewTextBoxColumn, Me.EdadConfirmacionDataGridViewTextBoxColumn, Me.PaternoDataGridViewTextBoxColumn, Me.MaternoDataGridViewTextBoxColumn, Me.PadrinoDataGridViewTextBoxColumn, Me.PapaDataGridViewTextBoxColumn, Me.MamaDataGridViewTextBoxColumn})
        Me.DataGridView.DataSource = Me.BindingSource
        Me.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.Size = New System.Drawing.Size(781, 466)
        Me.DataGridView.TabIndex = 1
        Me.DataGridView.Visible = False
        '
        'IdfolioDataGridViewTextBoxColumn
        '
        Me.IdfolioDataGridViewTextBoxColumn.DataPropertyName = "id_folio"
        Me.IdfolioDataGridViewTextBoxColumn.HeaderText = "id_folio"
        Me.IdfolioDataGridViewTextBoxColumn.Name = "IdfolioDataGridViewTextBoxColumn"
        '
        'LibroDataGridViewTextBoxColumn
        '
        Me.LibroDataGridViewTextBoxColumn.DataPropertyName = "Libro"
        Me.LibroDataGridViewTextBoxColumn.HeaderText = "Libro"
        Me.LibroDataGridViewTextBoxColumn.Name = "LibroDataGridViewTextBoxColumn"
        '
        'PáginaDataGridViewTextBoxColumn
        '
        Me.PáginaDataGridViewTextBoxColumn.DataPropertyName = "Página"
        Me.PáginaDataGridViewTextBoxColumn.HeaderText = "Página"
        Me.PáginaDataGridViewTextBoxColumn.Name = "PáginaDataGridViewTextBoxColumn"
        '
        'FechaConfirmacionDataGridViewTextBoxColumn
        '
        Me.FechaConfirmacionDataGridViewTextBoxColumn.DataPropertyName = "FechaConfirmacion"
        Me.FechaConfirmacionDataGridViewTextBoxColumn.HeaderText = "FechaConfirmacion"
        Me.FechaConfirmacionDataGridViewTextBoxColumn.Name = "FechaConfirmacionDataGridViewTextBoxColumn"
        '
        'ParroquiaDataGridViewTextBoxColumn
        '
        Me.ParroquiaDataGridViewTextBoxColumn.DataPropertyName = "Parroquia"
        Me.ParroquiaDataGridViewTextBoxColumn.HeaderText = "Parroquia"
        Me.ParroquiaDataGridViewTextBoxColumn.Name = "ParroquiaDataGridViewTextBoxColumn"
        '
        'PárrocoDataGridViewTextBoxColumn
        '
        Me.PárrocoDataGridViewTextBoxColumn.DataPropertyName = "Párroco"
        Me.PárrocoDataGridViewTextBoxColumn.HeaderText = "Párroco"
        Me.PárrocoDataGridViewTextBoxColumn.Name = "PárrocoDataGridViewTextBoxColumn"
        '
        'AñoBautismoDataGridViewTextBoxColumn
        '
        Me.AñoBautismoDataGridViewTextBoxColumn.DataPropertyName = "AñoBautismo"
        Me.AñoBautismoDataGridViewTextBoxColumn.HeaderText = "AñoBautismo"
        Me.AñoBautismoDataGridViewTextBoxColumn.Name = "AñoBautismoDataGridViewTextBoxColumn"
        '
        'ParroquiabautismoDataGridViewTextBoxColumn
        '
        Me.ParroquiabautismoDataGridViewTextBoxColumn.DataPropertyName = "Parroquiabautismo"
        Me.ParroquiabautismoDataGridViewTextBoxColumn.HeaderText = "Parroquiabautismo"
        Me.ParroquiabautismoDataGridViewTextBoxColumn.Name = "ParroquiabautismoDataGridViewTextBoxColumn"
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
        'EdadConfirmacionDataGridViewTextBoxColumn
        '
        Me.EdadConfirmacionDataGridViewTextBoxColumn.DataPropertyName = "EdadConfirmacion"
        Me.EdadConfirmacionDataGridViewTextBoxColumn.HeaderText = "EdadConfirmacion"
        Me.EdadConfirmacionDataGridViewTextBoxColumn.Name = "EdadConfirmacionDataGridViewTextBoxColumn"
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
        'PadrinoDataGridViewTextBoxColumn
        '
        Me.PadrinoDataGridViewTextBoxColumn.DataPropertyName = "Padrino"
        Me.PadrinoDataGridViewTextBoxColumn.HeaderText = "Padrino"
        Me.PadrinoDataGridViewTextBoxColumn.Name = "PadrinoDataGridViewTextBoxColumn"
        '
        'PapaDataGridViewTextBoxColumn
        '
        Me.PapaDataGridViewTextBoxColumn.DataPropertyName = "Papa"
        Me.PapaDataGridViewTextBoxColumn.HeaderText = "Papa"
        Me.PapaDataGridViewTextBoxColumn.Name = "PapaDataGridViewTextBoxColumn"
        '
        'MamaDataGridViewTextBoxColumn
        '
        Me.MamaDataGridViewTextBoxColumn.DataPropertyName = "Mama"
        Me.MamaDataGridViewTextBoxColumn.HeaderText = "Mama"
        Me.MamaDataGridViewTextBoxColumn.Name = "MamaDataGridViewTextBoxColumn"
        '
        'frmLibroConfirmacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 466)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmLibroConfirmacion"
        Me.Text = "frmConfirmacion"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbParroquiaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MaternoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PaternoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombresTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RUNTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PárrocoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ParroquiaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaConfirmacionDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Id_folioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PáginaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LibroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PadrinoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MamaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PapaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EdadConfirmacionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AñoBautismoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ParroquiabautismoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DbParroquiaDataSet As MC_Parroquial.dbParroquiaDataSet
    Friend WithEvents TableAdapterManager As MC_Parroquial.dbParroquiaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents T_confirmaciónTableAdapter As MC_Parroquial.dbParroquiaDataSetTableAdapters.t_confirmaciónTableAdapter
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents IdfolioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LibroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PáginaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaConfirmacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ParroquiaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PárrocoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AñoBautismoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ParroquiabautismoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RUNDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombresDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EdadConfirmacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PadrinoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PapaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MamaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
