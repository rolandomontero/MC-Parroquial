Imports Microsoft.Reporting.WinForms
Public Class frmCertificadoMatrimonio

    Public Sub Registro(ByVal Datos As DataRow)
        Dim Tabla As DataTable = New dbParroquiaDataSet.t_matrimonioDataTable
        Dim fila As DataRow = Tabla.NewRow

        fila.BeginEdit()
        For i = 0 To 19
            fila.Item(i) = Datos.Item(i)
        Next
        fila.EndEdit()

        Tabla.Rows.Add(fila)
        Tabla.AcceptChanges()

        ReportViewer.LocalReport.DataSources.Clear()
        '
        '
        'Establezcamos la lista como Datasource del informe
        '
        ReportViewer.LocalReport.DataSources.Add(New ReportDataSource("DataSetMatrimonio", Tabla))

        '
        'Hagamos un refresh al reportViewer
        '
        ReportViewer.RefreshReport()
    End Sub

    Private Sub frmCertificadoMatrimonio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbParroquiaDataSet.t_matrimonio' Puede moverla o quitarla según sea necesario.
        ReportViewer.SetDisplayMode(DisplayMode.PrintLayout)
        ReportViewer.RefreshReport()
    End Sub
End Class