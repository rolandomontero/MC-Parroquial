<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLibroMatrimonio
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
        Dim FechaLabel As System.Windows.Forms.Label
        Dim H_RUNLabel As System.Windows.Forms.Label
        Dim H_NombresLabel As System.Windows.Forms.Label
        Dim H_ApellidosLabel As System.Windows.Forms.Label
        Dim H_PadreLabel As System.Windows.Forms.Label
        Dim H_MadreLabel As System.Windows.Forms.Label
        Dim H_ParroquiaLabel As System.Windows.Forms.Label
        Dim H_LibroLabel As System.Windows.Forms.Label
        Dim H_PáginaLabel As System.Windows.Forms.Label
        Dim M_RUNLabel As System.Windows.Forms.Label
        Dim M_NombresLabel As System.Windows.Forms.Label
        Dim M_ApellidosLabel As System.Windows.Forms.Label
        Dim M_PadreLabel As System.Windows.Forms.Label
        Dim M_MadreLabel As System.Windows.Forms.Label
        Dim M_ParroquiaLabel As System.Windows.Forms.Label
        Dim M_LibroLabel As System.Windows.Forms.Label
        Dim M_PáginaLabel As System.Windows.Forms.Label
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbParroquiaDataSet = New MC_Parroquial.dbParroquiaDataSet()
        Me.Id_folioTextBox = New System.Windows.Forms.TextBox()
        Me.PáginaTextBox = New System.Windows.Forms.TextBox()
        Me.LibroTextBox = New System.Windows.Forms.TextBox()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.H_PáginaTextBox = New System.Windows.Forms.TextBox()
        Me.H_LibroTextBox = New System.Windows.Forms.TextBox()
        Me.H_ParroquiaTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.H_MadreTextBox = New System.Windows.Forms.TextBox()
        Me.H_PadreTextBox = New System.Windows.Forms.TextBox()
        Me.H_ApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.H_NombresTextBox = New System.Windows.Forms.TextBox()
        Me.H_RUNTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.M_PáginaTextBox = New System.Windows.Forms.TextBox()
        Me.M_LibroTextBox = New System.Windows.Forms.TextBox()
        Me.M_ParroquiaTextBox = New System.Windows.Forms.TextBox()
        Me.M_MadreTextBox = New System.Windows.Forms.TextBox()
        Me.M_PadreTextBox = New System.Windows.Forms.TextBox()
        Me.M_ApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.M_NombresTextBox = New System.Windows.Forms.TextBox()
        Me.M_RUNTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.T_matrimonioTableAdapter = New MC_Parroquial.dbParroquiaDataSetTableAdapters.t_matrimonioTableAdapter()
        Me.TableAdapterManager = New MC_Parroquial.dbParroquiaDataSetTableAdapters.TableAdapterManager()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.IdfolioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LibroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PáginaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HRUNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HNombresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HPadreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HMadreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HParroquiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HLibroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HPáginaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MRUNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MNombresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MPadreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MMadreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MParroquiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MLibroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MPáginaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        LibroLabel = New System.Windows.Forms.Label()
        PáginaLabel = New System.Windows.Forms.Label()
        Id_folioLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        H_RUNLabel = New System.Windows.Forms.Label()
        H_NombresLabel = New System.Windows.Forms.Label()
        H_ApellidosLabel = New System.Windows.Forms.Label()
        H_PadreLabel = New System.Windows.Forms.Label()
        H_MadreLabel = New System.Windows.Forms.Label()
        H_ParroquiaLabel = New System.Windows.Forms.Label()
        H_LibroLabel = New System.Windows.Forms.Label()
        H_PáginaLabel = New System.Windows.Forms.Label()
        M_RUNLabel = New System.Windows.Forms.Label()
        M_NombresLabel = New System.Windows.Forms.Label()
        M_ApellidosLabel = New System.Windows.Forms.Label()
        M_PadreLabel = New System.Windows.Forms.Label()
        M_MadreLabel = New System.Windows.Forms.Label()
        M_ParroquiaLabel = New System.Windows.Forms.Label()
        M_LibroLabel = New System.Windows.Forms.Label()
        M_PáginaLabel = New System.Windows.Forms.Label()
        Me.GroupBox.SuspendLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbParroquiaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LibroLabel
        '
        LibroLabel.AutoSize = True
        LibroLabel.Location = New System.Drawing.Point(36, 44)
        LibroLabel.Name = "LibroLabel"
        LibroLabel.Size = New System.Drawing.Size(49, 21)
        LibroLabel.TabIndex = 1
        LibroLabel.Text = "Libro:"
        '
        'PáginaLabel
        '
        PáginaLabel.AutoSize = True
        PáginaLabel.Location = New System.Drawing.Point(167, 44)
        PáginaLabel.Name = "PáginaLabel"
        PáginaLabel.Size = New System.Drawing.Size(59, 21)
        PáginaLabel.TabIndex = 3
        PáginaLabel.Text = "Página:"
        '
        'Id_folioLabel
        '
        Id_folioLabel.AutoSize = True
        Id_folioLabel.Location = New System.Drawing.Point(310, 44)
        Id_folioLabel.Name = "Id_folioLabel"
        Id_folioLabel.Size = New System.Drawing.Size(47, 21)
        Id_folioLabel.TabIndex = 5
        Id_folioLabel.Text = "Folio:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(598, 45)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(53, 21)
        FechaLabel.TabIndex = 7
        FechaLabel.Text = "Fecha:"
        '
        'H_RUNLabel
        '
        H_RUNLabel.AutoSize = True
        H_RUNLabel.Location = New System.Drawing.Point(16, 35)
        H_RUNLabel.Name = "H_RUNLabel"
        H_RUNLabel.Size = New System.Drawing.Size(46, 21)
        H_RUNLabel.TabIndex = 0
        H_RUNLabel.Text = "RUN:"
        '
        'H_NombresLabel
        '
        H_NombresLabel.AutoSize = True
        H_NombresLabel.Location = New System.Drawing.Point(16, 85)
        H_NombresLabel.Name = "H_NombresLabel"
        H_NombresLabel.Size = New System.Drawing.Size(78, 21)
        H_NombresLabel.TabIndex = 2
        H_NombresLabel.Text = "Nombres:"
        '
        'H_ApellidosLabel
        '
        H_ApellidosLabel.AutoSize = True
        H_ApellidosLabel.Location = New System.Drawing.Point(184, 85)
        H_ApellidosLabel.Name = "H_ApellidosLabel"
        H_ApellidosLabel.Size = New System.Drawing.Size(77, 21)
        H_ApellidosLabel.TabIndex = 4
        H_ApellidosLabel.Text = "Apellidos:"
        '
        'H_PadreLabel
        '
        H_PadreLabel.AutoSize = True
        H_PadreLabel.Location = New System.Drawing.Point(363, 85)
        H_PadreLabel.Name = "H_PadreLabel"
        H_PadreLabel.Size = New System.Drawing.Size(52, 21)
        H_PadreLabel.TabIndex = 6
        H_PadreLabel.Text = "Padre:"
        '
        'H_MadreLabel
        '
        H_MadreLabel.AutoSize = True
        H_MadreLabel.Location = New System.Drawing.Point(582, 85)
        H_MadreLabel.Name = "H_MadreLabel"
        H_MadreLabel.Size = New System.Drawing.Size(58, 21)
        H_MadreLabel.TabIndex = 8
        H_MadreLabel.Text = "Madre:"
        '
        'H_ParroquiaLabel
        '
        H_ParroquiaLabel.AutoSize = True
        H_ParroquiaLabel.Location = New System.Drawing.Point(17, 216)
        H_ParroquiaLabel.Name = "H_ParroquiaLabel"
        H_ParroquiaLabel.Size = New System.Drawing.Size(84, 21)
        H_ParroquiaLabel.TabIndex = 11
        H_ParroquiaLabel.Text = " Parroquia:"
        '
        'H_LibroLabel
        '
        H_LibroLabel.AutoSize = True
        H_LibroLabel.Location = New System.Drawing.Point(366, 216)
        H_LibroLabel.Name = "H_LibroLabel"
        H_LibroLabel.Size = New System.Drawing.Size(49, 21)
        H_LibroLabel.TabIndex = 13
        H_LibroLabel.Text = "Libro:"
        '
        'H_PáginaLabel
        '
        H_PáginaLabel.AutoSize = True
        H_PáginaLabel.Location = New System.Drawing.Point(508, 216)
        H_PáginaLabel.Name = "H_PáginaLabel"
        H_PáginaLabel.Size = New System.Drawing.Size(59, 21)
        H_PáginaLabel.TabIndex = 15
        H_PáginaLabel.Text = "Página:"
        '
        'M_RUNLabel
        '
        M_RUNLabel.AutoSize = True
        M_RUNLabel.Location = New System.Drawing.Point(11, 32)
        M_RUNLabel.Name = "M_RUNLabel"
        M_RUNLabel.Size = New System.Drawing.Size(46, 21)
        M_RUNLabel.TabIndex = 11
        M_RUNLabel.Text = "RUN:"
        '
        'M_NombresLabel
        '
        M_NombresLabel.AutoSize = True
        M_NombresLabel.Location = New System.Drawing.Point(10, 92)
        M_NombresLabel.Name = "M_NombresLabel"
        M_NombresLabel.Size = New System.Drawing.Size(78, 21)
        M_NombresLabel.TabIndex = 12
        M_NombresLabel.Text = "Nombres:"
        '
        'M_ApellidosLabel
        '
        M_ApellidosLabel.AutoSize = True
        M_ApellidosLabel.Location = New System.Drawing.Point(183, 92)
        M_ApellidosLabel.Name = "M_ApellidosLabel"
        M_ApellidosLabel.Size = New System.Drawing.Size(77, 21)
        M_ApellidosLabel.TabIndex = 13
        M_ApellidosLabel.Text = "Apellidos:"
        '
        'M_PadreLabel
        '
        M_PadreLabel.AutoSize = True
        M_PadreLabel.Location = New System.Drawing.Point(384, 92)
        M_PadreLabel.Name = "M_PadreLabel"
        M_PadreLabel.Size = New System.Drawing.Size(52, 21)
        M_PadreLabel.TabIndex = 14
        M_PadreLabel.Text = "Padre:"
        '
        'M_MadreLabel
        '
        M_MadreLabel.AutoSize = True
        M_MadreLabel.Location = New System.Drawing.Point(566, 92)
        M_MadreLabel.Name = "M_MadreLabel"
        M_MadreLabel.Size = New System.Drawing.Size(58, 21)
        M_MadreLabel.TabIndex = 15
        M_MadreLabel.Text = "Madre:"
        '
        'M_ParroquiaLabel
        '
        M_ParroquiaLabel.AutoSize = True
        M_ParroquiaLabel.Location = New System.Drawing.Point(10, 222)
        M_ParroquiaLabel.Name = "M_ParroquiaLabel"
        M_ParroquiaLabel.Size = New System.Drawing.Size(80, 21)
        M_ParroquiaLabel.TabIndex = 16
        M_ParroquiaLabel.Text = "Parroquia:"
        '
        'M_LibroLabel
        '
        M_LibroLabel.AutoSize = True
        M_LibroLabel.Location = New System.Drawing.Point(430, 222)
        M_LibroLabel.Name = "M_LibroLabel"
        M_LibroLabel.Size = New System.Drawing.Size(49, 21)
        M_LibroLabel.TabIndex = 17
        M_LibroLabel.Text = "Libro:"
        '
        'M_PáginaLabel
        '
        M_PáginaLabel.AutoSize = True
        M_PáginaLabel.Location = New System.Drawing.Point(616, 222)
        M_PáginaLabel.Name = "M_PáginaLabel"
        M_PáginaLabel.Size = New System.Drawing.Size(59, 21)
        M_PáginaLabel.TabIndex = 18
        M_PáginaLabel.Text = "Página:"
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(FechaLabel)
        Me.GroupBox.Controls.Add(Me.FechaDateTimePicker)
        Me.GroupBox.Controls.Add(Id_folioLabel)
        Me.GroupBox.Controls.Add(Me.Id_folioTextBox)
        Me.GroupBox.Controls.Add(PáginaLabel)
        Me.GroupBox.Controls.Add(Me.PáginaTextBox)
        Me.GroupBox.Controls.Add(LibroLabel)
        Me.GroupBox.Controls.Add(Me.LibroTextBox)
        Me.GroupBox.Controls.Add(Me.TabControl)
        Me.GroupBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(815, 423)
        Me.GroupBox.TabIndex = 0
        Me.GroupBox.TabStop = False
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(657, 41)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(134, 29)
        Me.FechaDateTimePicker.TabIndex = 8
        '
        'BindingSource
        '
        Me.BindingSource.DataMember = "t_matrimonio"
        Me.BindingSource.DataSource = Me.DbParroquiaDataSet
        '
        'DbParroquiaDataSet
        '
        Me.DbParroquiaDataSet.DataSetName = "dbParroquiaDataSet"
        Me.DbParroquiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Id_folioTextBox
        '
        Me.Id_folioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "id_folio", True))
        Me.Id_folioTextBox.Location = New System.Drawing.Point(377, 41)
        Me.Id_folioTextBox.Name = "Id_folioTextBox"
        Me.Id_folioTextBox.Size = New System.Drawing.Size(43, 29)
        Me.Id_folioTextBox.TabIndex = 6
        '
        'PáginaTextBox
        '
        Me.PáginaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "Página", True))
        Me.PáginaTextBox.Location = New System.Drawing.Point(232, 41)
        Me.PáginaTextBox.Name = "PáginaTextBox"
        Me.PáginaTextBox.Size = New System.Drawing.Size(31, 29)
        Me.PáginaTextBox.TabIndex = 4
        '
        'LibroTextBox
        '
        Me.LibroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "Libro", True))
        Me.LibroTextBox.Location = New System.Drawing.Point(91, 41)
        Me.LibroTextBox.Name = "LibroTextBox"
        Me.LibroTextBox.Size = New System.Drawing.Size(32, 29)
        Me.LibroTextBox.TabIndex = 2
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Controls.Add(Me.TabPage2)
        Me.TabControl.Location = New System.Drawing.Point(13, 96)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(789, 308)
        Me.TabControl.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(H_PáginaLabel)
        Me.TabPage1.Controls.Add(Me.H_PáginaTextBox)
        Me.TabPage1.Controls.Add(H_LibroLabel)
        Me.TabPage1.Controls.Add(Me.H_LibroTextBox)
        Me.TabPage1.Controls.Add(H_ParroquiaLabel)
        Me.TabPage1.Controls.Add(Me.H_ParroquiaTextBox)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(H_MadreLabel)
        Me.TabPage1.Controls.Add(Me.H_MadreTextBox)
        Me.TabPage1.Controls.Add(H_PadreLabel)
        Me.TabPage1.Controls.Add(Me.H_PadreTextBox)
        Me.TabPage1.Controls.Add(H_ApellidosLabel)
        Me.TabPage1.Controls.Add(Me.H_ApellidosTextBox)
        Me.TabPage1.Controls.Add(H_NombresLabel)
        Me.TabPage1.Controls.Add(Me.H_NombresTextBox)
        Me.TabPage1.Controls.Add(H_RUNLabel)
        Me.TabPage1.Controls.Add(Me.H_RUNTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 30)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(781, 274)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Esposo"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'H_PáginaTextBox
        '
        Me.H_PáginaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "h_Página", True))
        Me.H_PáginaTextBox.Location = New System.Drawing.Point(586, 213)
        Me.H_PáginaTextBox.Name = "H_PáginaTextBox"
        Me.H_PáginaTextBox.Size = New System.Drawing.Size(65, 29)
        Me.H_PáginaTextBox.TabIndex = 16
        '
        'H_LibroTextBox
        '
        Me.H_LibroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "h_Libro", True))
        Me.H_LibroTextBox.Location = New System.Drawing.Point(434, 213)
        Me.H_LibroTextBox.Name = "H_LibroTextBox"
        Me.H_LibroTextBox.Size = New System.Drawing.Size(55, 29)
        Me.H_LibroTextBox.TabIndex = 14
        '
        'H_ParroquiaTextBox
        '
        Me.H_ParroquiaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "h_Parroquia", True))
        Me.H_ParroquiaTextBox.Location = New System.Drawing.Point(116, 213)
        Me.H_ParroquiaTextBox.Name = "H_ParroquiaTextBox"
        Me.H_ParroquiaTextBox.Size = New System.Drawing.Size(231, 29)
        Me.H_ParroquiaTextBox.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(16, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(759, 22)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Bautisado"
        '
        'H_MadreTextBox
        '
        Me.H_MadreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "h_Madre", True))
        Me.H_MadreTextBox.Location = New System.Drawing.Point(586, 109)
        Me.H_MadreTextBox.Name = "H_MadreTextBox"
        Me.H_MadreTextBox.Size = New System.Drawing.Size(189, 29)
        Me.H_MadreTextBox.TabIndex = 9
        '
        'H_PadreTextBox
        '
        Me.H_PadreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "h_Padre", True))
        Me.H_PadreTextBox.Location = New System.Drawing.Point(367, 109)
        Me.H_PadreTextBox.Name = "H_PadreTextBox"
        Me.H_PadreTextBox.Size = New System.Drawing.Size(213, 29)
        Me.H_PadreTextBox.TabIndex = 7
        '
        'H_ApellidosTextBox
        '
        Me.H_ApellidosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "h_Apellidos", True))
        Me.H_ApellidosTextBox.Location = New System.Drawing.Point(188, 109)
        Me.H_ApellidosTextBox.Name = "H_ApellidosTextBox"
        Me.H_ApellidosTextBox.Size = New System.Drawing.Size(162, 29)
        Me.H_ApellidosTextBox.TabIndex = 5
        '
        'H_NombresTextBox
        '
        Me.H_NombresTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "h_Nombres", True))
        Me.H_NombresTextBox.Location = New System.Drawing.Point(20, 109)
        Me.H_NombresTextBox.Name = "H_NombresTextBox"
        Me.H_NombresTextBox.Size = New System.Drawing.Size(161, 29)
        Me.H_NombresTextBox.TabIndex = 3
        '
        'H_RUNTextBox
        '
        Me.H_RUNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "h_RUN", True))
        Me.H_RUNTextBox.Location = New System.Drawing.Point(81, 32)
        Me.H_RUNTextBox.Name = "H_RUNTextBox"
        Me.H_RUNTextBox.Size = New System.Drawing.Size(100, 29)
        Me.H_RUNTextBox.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(M_PáginaLabel)
        Me.TabPage2.Controls.Add(Me.M_PáginaTextBox)
        Me.TabPage2.Controls.Add(M_LibroLabel)
        Me.TabPage2.Controls.Add(Me.M_LibroTextBox)
        Me.TabPage2.Controls.Add(M_ParroquiaLabel)
        Me.TabPage2.Controls.Add(Me.M_ParroquiaTextBox)
        Me.TabPage2.Controls.Add(M_MadreLabel)
        Me.TabPage2.Controls.Add(Me.M_MadreTextBox)
        Me.TabPage2.Controls.Add(M_PadreLabel)
        Me.TabPage2.Controls.Add(Me.M_PadreTextBox)
        Me.TabPage2.Controls.Add(M_ApellidosLabel)
        Me.TabPage2.Controls.Add(Me.M_ApellidosTextBox)
        Me.TabPage2.Controls.Add(M_NombresLabel)
        Me.TabPage2.Controls.Add(Me.M_NombresTextBox)
        Me.TabPage2.Controls.Add(M_RUNLabel)
        Me.TabPage2.Controls.Add(Me.M_RUNTextBox)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 30)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(781, 274)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Esposa"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'M_PáginaTextBox
        '
        Me.M_PáginaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "m_Página", True))
        Me.M_PáginaTextBox.Location = New System.Drawing.Point(681, 219)
        Me.M_PáginaTextBox.Name = "M_PáginaTextBox"
        Me.M_PáginaTextBox.Size = New System.Drawing.Size(65, 29)
        Me.M_PáginaTextBox.TabIndex = 19
        '
        'M_LibroTextBox
        '
        Me.M_LibroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "m_Libro", True))
        Me.M_LibroTextBox.Location = New System.Drawing.Point(485, 219)
        Me.M_LibroTextBox.Name = "M_LibroTextBox"
        Me.M_LibroTextBox.Size = New System.Drawing.Size(79, 29)
        Me.M_LibroTextBox.TabIndex = 18
        '
        'M_ParroquiaTextBox
        '
        Me.M_ParroquiaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "m_Parroquia", True))
        Me.M_ParroquiaTextBox.Location = New System.Drawing.Point(114, 219)
        Me.M_ParroquiaTextBox.Name = "M_ParroquiaTextBox"
        Me.M_ParroquiaTextBox.Size = New System.Drawing.Size(240, 29)
        Me.M_ParroquiaTextBox.TabIndex = 17
        '
        'M_MadreTextBox
        '
        Me.M_MadreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "m_Madre", True))
        Me.M_MadreTextBox.Location = New System.Drawing.Point(570, 116)
        Me.M_MadreTextBox.Name = "M_MadreTextBox"
        Me.M_MadreTextBox.Size = New System.Drawing.Size(176, 29)
        Me.M_MadreTextBox.TabIndex = 16
        '
        'M_PadreTextBox
        '
        Me.M_PadreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "m_Padre", True))
        Me.M_PadreTextBox.Location = New System.Drawing.Point(388, 116)
        Me.M_PadreTextBox.Name = "M_PadreTextBox"
        Me.M_PadreTextBox.Size = New System.Drawing.Size(176, 29)
        Me.M_PadreTextBox.TabIndex = 15
        '
        'M_ApellidosTextBox
        '
        Me.M_ApellidosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "m_Apellidos", True))
        Me.M_ApellidosTextBox.Location = New System.Drawing.Point(187, 116)
        Me.M_ApellidosTextBox.Name = "M_ApellidosTextBox"
        Me.M_ApellidosTextBox.Size = New System.Drawing.Size(167, 29)
        Me.M_ApellidosTextBox.TabIndex = 14
        '
        'M_NombresTextBox
        '
        Me.M_NombresTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "m_Nombres", True))
        Me.M_NombresTextBox.Location = New System.Drawing.Point(14, 116)
        Me.M_NombresTextBox.Name = "M_NombresTextBox"
        Me.M_NombresTextBox.Size = New System.Drawing.Size(167, 29)
        Me.M_NombresTextBox.TabIndex = 13
        '
        'M_RUNTextBox
        '
        Me.M_RUNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource, "m_RUN", True))
        Me.M_RUNTextBox.Location = New System.Drawing.Point(81, 29)
        Me.M_RUNTextBox.Name = "M_RUNTextBox"
        Me.M_RUNTextBox.Size = New System.Drawing.Size(100, 29)
        Me.M_RUNTextBox.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(11, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(759, 22)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Bautisado"
        '
        'T_matrimonioTableAdapter
        '
        Me.T_matrimonioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.t_bautismosTableAdapter = Nothing
        Me.TableAdapterManager.t_confirmaciónTableAdapter = Nothing
        Me.TableAdapterManager.t_matrimonioTableAdapter = Me.T_matrimonioTableAdapter
        Me.TableAdapterManager.UpdateOrder = MC_Parroquial.dbParroquiaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridView
        '
        Me.DataGridView.AutoGenerateColumns = False
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdfolioDataGridViewTextBoxColumn, Me.LibroDataGridViewTextBoxColumn, Me.PáginaDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.HRUNDataGridViewTextBoxColumn, Me.HNombresDataGridViewTextBoxColumn, Me.HApellidosDataGridViewTextBoxColumn, Me.HPadreDataGridViewTextBoxColumn, Me.HMadreDataGridViewTextBoxColumn, Me.HParroquiaDataGridViewTextBoxColumn, Me.HLibroDataGridViewTextBoxColumn, Me.HPáginaDataGridViewTextBoxColumn, Me.MRUNDataGridViewTextBoxColumn, Me.MNombresDataGridViewTextBoxColumn, Me.MApellidosDataGridViewTextBoxColumn, Me.MPadreDataGridViewTextBoxColumn, Me.MMadreDataGridViewTextBoxColumn, Me.MParroquiaDataGridViewTextBoxColumn, Me.MLibroDataGridViewTextBoxColumn, Me.MPáginaDataGridViewTextBoxColumn})
        Me.DataGridView.DataSource = Me.BindingSource
        Me.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.Size = New System.Drawing.Size(871, 504)
        Me.DataGridView.TabIndex = 9
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
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        '
        'HRUNDataGridViewTextBoxColumn
        '
        Me.HRUNDataGridViewTextBoxColumn.DataPropertyName = "h_RUN"
        Me.HRUNDataGridViewTextBoxColumn.HeaderText = "h_RUN"
        Me.HRUNDataGridViewTextBoxColumn.Name = "HRUNDataGridViewTextBoxColumn"
        '
        'HNombresDataGridViewTextBoxColumn
        '
        Me.HNombresDataGridViewTextBoxColumn.DataPropertyName = "h_Nombres"
        Me.HNombresDataGridViewTextBoxColumn.HeaderText = "h_Nombres"
        Me.HNombresDataGridViewTextBoxColumn.Name = "HNombresDataGridViewTextBoxColumn"
        '
        'HApellidosDataGridViewTextBoxColumn
        '
        Me.HApellidosDataGridViewTextBoxColumn.DataPropertyName = "h_Apellidos"
        Me.HApellidosDataGridViewTextBoxColumn.HeaderText = "h_Apellidos"
        Me.HApellidosDataGridViewTextBoxColumn.Name = "HApellidosDataGridViewTextBoxColumn"
        '
        'HPadreDataGridViewTextBoxColumn
        '
        Me.HPadreDataGridViewTextBoxColumn.DataPropertyName = "h_Padre"
        Me.HPadreDataGridViewTextBoxColumn.HeaderText = "h_Padre"
        Me.HPadreDataGridViewTextBoxColumn.Name = "HPadreDataGridViewTextBoxColumn"
        '
        'HMadreDataGridViewTextBoxColumn
        '
        Me.HMadreDataGridViewTextBoxColumn.DataPropertyName = "h_Madre"
        Me.HMadreDataGridViewTextBoxColumn.HeaderText = "h_Madre"
        Me.HMadreDataGridViewTextBoxColumn.Name = "HMadreDataGridViewTextBoxColumn"
        '
        'HParroquiaDataGridViewTextBoxColumn
        '
        Me.HParroquiaDataGridViewTextBoxColumn.DataPropertyName = "h_Parroquia"
        Me.HParroquiaDataGridViewTextBoxColumn.HeaderText = "h_Parroquia"
        Me.HParroquiaDataGridViewTextBoxColumn.Name = "HParroquiaDataGridViewTextBoxColumn"
        '
        'HLibroDataGridViewTextBoxColumn
        '
        Me.HLibroDataGridViewTextBoxColumn.DataPropertyName = "h_Libro"
        Me.HLibroDataGridViewTextBoxColumn.HeaderText = "h_Libro"
        Me.HLibroDataGridViewTextBoxColumn.Name = "HLibroDataGridViewTextBoxColumn"
        '
        'HPáginaDataGridViewTextBoxColumn
        '
        Me.HPáginaDataGridViewTextBoxColumn.DataPropertyName = "h_Página"
        Me.HPáginaDataGridViewTextBoxColumn.HeaderText = "h_Página"
        Me.HPáginaDataGridViewTextBoxColumn.Name = "HPáginaDataGridViewTextBoxColumn"
        '
        'MRUNDataGridViewTextBoxColumn
        '
        Me.MRUNDataGridViewTextBoxColumn.DataPropertyName = "m_RUN"
        Me.MRUNDataGridViewTextBoxColumn.HeaderText = "m_RUN"
        Me.MRUNDataGridViewTextBoxColumn.Name = "MRUNDataGridViewTextBoxColumn"
        '
        'MNombresDataGridViewTextBoxColumn
        '
        Me.MNombresDataGridViewTextBoxColumn.DataPropertyName = "m_Nombres"
        Me.MNombresDataGridViewTextBoxColumn.HeaderText = "m_Nombres"
        Me.MNombresDataGridViewTextBoxColumn.Name = "MNombresDataGridViewTextBoxColumn"
        '
        'MApellidosDataGridViewTextBoxColumn
        '
        Me.MApellidosDataGridViewTextBoxColumn.DataPropertyName = "m_Apellidos"
        Me.MApellidosDataGridViewTextBoxColumn.HeaderText = "m_Apellidos"
        Me.MApellidosDataGridViewTextBoxColumn.Name = "MApellidosDataGridViewTextBoxColumn"
        '
        'MPadreDataGridViewTextBoxColumn
        '
        Me.MPadreDataGridViewTextBoxColumn.DataPropertyName = "m_Padre"
        Me.MPadreDataGridViewTextBoxColumn.HeaderText = "m_Padre"
        Me.MPadreDataGridViewTextBoxColumn.Name = "MPadreDataGridViewTextBoxColumn"
        '
        'MMadreDataGridViewTextBoxColumn
        '
        Me.MMadreDataGridViewTextBoxColumn.DataPropertyName = "m_Madre"
        Me.MMadreDataGridViewTextBoxColumn.HeaderText = "m_Madre"
        Me.MMadreDataGridViewTextBoxColumn.Name = "MMadreDataGridViewTextBoxColumn"
        '
        'MParroquiaDataGridViewTextBoxColumn
        '
        Me.MParroquiaDataGridViewTextBoxColumn.DataPropertyName = "m_Parroquia"
        Me.MParroquiaDataGridViewTextBoxColumn.HeaderText = "m_Parroquia"
        Me.MParroquiaDataGridViewTextBoxColumn.Name = "MParroquiaDataGridViewTextBoxColumn"
        '
        'MLibroDataGridViewTextBoxColumn
        '
        Me.MLibroDataGridViewTextBoxColumn.DataPropertyName = "m_Libro"
        Me.MLibroDataGridViewTextBoxColumn.HeaderText = "m_Libro"
        Me.MLibroDataGridViewTextBoxColumn.Name = "MLibroDataGridViewTextBoxColumn"
        '
        'MPáginaDataGridViewTextBoxColumn
        '
        Me.MPáginaDataGridViewTextBoxColumn.DataPropertyName = "m_Página"
        Me.MPáginaDataGridViewTextBoxColumn.HeaderText = "m_Página"
        Me.MPáginaDataGridViewTextBoxColumn.Name = "MPáginaDataGridViewTextBoxColumn"
        '
        'frmLibroMatrimonio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 504)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.GroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmLibroMatrimonio"
        Me.Text = "Registro de Matrimonio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbParroquiaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DbParroquiaDataSet As Global.MC_Parroquial.dbParroquiaDataSet
    Friend WithEvents BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T_matrimonioTableAdapter As dbParroquiaDataSetTableAdapters.t_matrimonioTableAdapter
    Friend WithEvents TableAdapterManager As dbParroquiaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Id_folioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PáginaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LibroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents H_NombresTextBox As System.Windows.Forms.TextBox
    Friend WithEvents H_RUNTextBox As System.Windows.Forms.TextBox
    Friend WithEvents H_PáginaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents H_LibroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents H_ParroquiaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents H_MadreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents H_PadreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents H_ApellidosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents M_PáginaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents M_LibroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents M_ParroquiaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents M_MadreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents M_PadreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents M_ApellidosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents M_NombresTextBox As System.Windows.Forms.TextBox
    Friend WithEvents M_RUNTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents IdfolioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LibroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PáginaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HRUNDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HNombresDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HApellidosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HPadreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HMadreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HParroquiaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HLibroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HPáginaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MRUNDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MNombresDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MApellidosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MPadreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MMadreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MParroquiaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MLibroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MPáginaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
