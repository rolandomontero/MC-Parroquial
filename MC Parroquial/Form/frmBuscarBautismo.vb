Public Class frmBuscarBautismo
    Private DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Private DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Private DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Private DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn

    Private Sub Inicio()
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Materno"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Materno"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Paterno"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Paterno"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Nombres"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombres"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "RUN"
        Me.DataGridViewTextBoxColumn2.HeaderText = "RUN"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"

        '
        'DataGridViewBautismo
        '
        Me.DataGridViewBautismo.AutoGenerateColumns = False
        Me.DataGridViewBautismo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBautismo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.DataGridViewBautismo.DataSource = Me.BindingSourceBautismo
        Me.DataGridViewBautismo.Location = New System.Drawing.Point(12, 79)
        Me.DataGridViewBautismo.Name = "DataGridViewBautismo"
        Me.DataGridViewBautismo.Size = New System.Drawing.Size(719, 364)
        Me.DataGridViewBautismo.TabIndex = 0

    End Sub


    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.  `Matricula2013`.`NL` ASC 
        InitializeComponent()
        Inicio()

    End Sub

 
    Private Sub frmBuscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbParroquiaDataSet.t_bautismos' Puede moverla o quitarla según sea necesario.
        Me.T_bautismosTableAdapter1.Fill(Me.DbParroquiaDataSet.t_bautismos)
        cmbBuscar.SelectedIndex = 0
    End Sub

    Private Sub Aplicar_Filtro()

        ' filtrar por el campo Producto
        ''''''''''''''''''''''''''''''''''''''''''''''''''''
        Try

            Dim busca() As String = {"RUN", "Nombres", "Paterno", "Materno"}
            Dim ret As Integer = Filtrar_DataGridView( _
                                            busca(cmbBuscar.SelectedIndex), _
                                            txtBuscar.Text.Trim, _
                                            BindingSourceBautismo, _
                                            DataGridViewBautismo)

            If ret = 0 Then
                ' si no hay registros cambiar el color del txtbo
                txtBuscar.ForeColor = Color.Red
            Else
                'txtBuscar.Font = FuenteLabel
                txtBuscar.ForeColor = Color.Green
            End If
            ' visualizar la cantidad de registros
        Catch ex As Exception

        End Try
    End Sub


    Function Filtrar_DataGridView( _
     ByVal Columna As String, _
     ByVal texto As String, _
     ByVal BindingSource As BindingSource, _
     ByVal DataGridView As DataGridView) As Integer

        ' verificar que el DataSource no esté vacio
        If BindingSource.DataSource Is Nothing Then
            Return 0
        End If

        Try

            Dim filtro As String = String.Empty
            filtro = " like '%" & texto.Trim & "%'"

            ' armar el sql
            If filtro <> String.Empty Then
                filtro = "[" & Columna & "]" & filtro
            End If

            ' asigar el criterio a la propiedad Filter del BindingSource
            BindingSource.Filter = filtro
            ' enlzar el datagridview al BindingSource
            DataGridView.DataSource = BindingSource

            ' retornar la cantidad de registros encontrados
            Return BindingSource.Count

            ' errores
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try

        Return 0

    End Function

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        Aplicar_Filtro()
    End Sub



    Private Sub cmbBuscar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBuscar.SelectedIndexChanged
        txtBuscar.Text = ""
    End Sub

    Private Sub bCertificado_Click(sender As Object, e As EventArgs) Handles bCertificado.Click
        Dim Certificado As frmCertificadoBautismo = New frmCertificadoBautismo
        Certificado.Registro(DirectCast(BindingSourceBautismo.Current, DataRowView).Row)
        Certificado.ShowDialog()
    End Sub


End Class