﻿Public Class frmLibroBautismo
    Public Sub Grabar()
        Me.Validate()
        Me.BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbParroquiaDataSet)
    End Sub


    Public Sub Borrar()
        Me.BindingSource.RemoveCurrent()
        Me.Validate()
        Me.TableAdapterManager.UpdateAll(Me.DbParroquiaDataSet)
    End Sub

    Private Sub frmBautismo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbParroquiaDataSet.t_bautismos' Puede moverla o quitarla según sea necesario.
        Me.T_bautismosTableAdapter.Fill(Me.DbParroquiaDataSet.t_bautismos)
    End Sub

    Public Sub VerTabla(ByVal Visible As Boolean)
        DataGridView.Visible = Visible
    End Sub
   

End Class