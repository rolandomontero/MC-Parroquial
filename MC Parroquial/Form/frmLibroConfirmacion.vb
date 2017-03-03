Public Class frmLibroConfirmacion


    Private Sub frmConfirmacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.T_confirmaciónTableAdapter.Fill(DbParroquiaDataSet.t_confirmación)
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

    Public Sub Nuevo()
        BindingSource.AddNew()
    End Sub

    Public Sub VerTabla(ByVal Visible As Boolean)
        DataGridView.Visible = Visible
    End Sub








End Class