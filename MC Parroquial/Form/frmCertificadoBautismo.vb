Imports Microsoft.Reporting.WinForms

Public Class frmCertificadoBautismo

    Public Sub Registro(ByVal Datos As DataRow)

        Dim Tabla As DataTable = New dbParroquiaDataSet.t_bautismosDataTable
        Dim fila As DataRow = Tabla.NewRow

        fila.BeginEdit()
        For i = 0 To 12
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
        ReportViewer.LocalReport.DataSources.Add(New ReportDataSource("DataSetBautismo", Tabla))

        '
        'Hagamos un refresh al reportViewer
        '
        ReportViewer.RefreshReport()
    End Sub


    Private Sub frmCertificadoBautismo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportViewer.SetDisplayMode(DisplayMode.PrintLayout)
        ReportViewer.RefreshReport()
    End Sub

End Class