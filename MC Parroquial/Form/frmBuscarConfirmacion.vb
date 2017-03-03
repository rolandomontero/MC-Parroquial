Public Class frmBuscarConfirmacion

    Private Sub Inicio()

    End Sub



    Private Sub frmBuscarConfirmacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbParroquiaDataSet.t_confirmación' Puede moverla o quitarla según sea necesario.
        Me.T_confirmaciónTableAdapter.Fill(Me.DbParroquiaDataSet.t_confirmación)

    End Sub
End Class