Public Class frmLibroMatrimonio


    Private Sub frmMatrimonio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbParroquiaDataSet.t_matrimonio' Puede moverla o quitarla según sea necesario.
        Me.T_matrimonioTableAdapter.Fill(Me.DbParroquiaDataSet.t_matrimonio)
    End Sub

    Public Sub Grabar()
        Me.Validate()
        Me.BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbParroquiaDataSet)
    End Sub

    Public Sub Borrar()
        Me.Validate()
        Me.BindingSource.RemoveCurrent()
        Me.TableAdapterManager.UpdateAll(Me.DbParroquiaDataSet)
    End Sub

    Public Sub VerTabla(ByVal Visible As Boolean)
        DataGridView.Visible = Visible
    End Sub

End Class