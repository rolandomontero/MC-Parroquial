<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCertificadoBautismo
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
        ApplicationCommands.cmdCerrarFormulario.Execute()

    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'ReportViewer
        '
        Me.ReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer.LocalReport.DisplayName = "Certificado de Bautismo"
        Me.ReportViewer.LocalReport.ReportEmbeddedResource = "MC_Parroquial.rBautismo.rdlc"
        Me.ReportViewer.LocalReport.ReportPath = ""
        Me.ReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer.Name = "ReportViewer"
        Me.ReportViewer.ShowBackButton = False
        Me.ReportViewer.ShowContextMenu = False
        Me.ReportViewer.ShowCredentialPrompts = False
        Me.ReportViewer.ShowDocumentMapButton = False
        Me.ReportViewer.ShowFindControls = False
        Me.ReportViewer.ShowPageNavigationControls = False
        Me.ReportViewer.ShowParameterPrompts = False
        Me.ReportViewer.ShowProgress = False
        Me.ReportViewer.ShowPromptAreaButton = False
        Me.ReportViewer.ShowRefreshButton = False
        Me.ReportViewer.ShowStopButton = False
        Me.ReportViewer.Size = New System.Drawing.Size(674, 618)
        Me.ReportViewer.TabIndex = 0
        Me.ReportViewer.WaitControlDisplayAfter = 10
        '
        'frmCertificadoBautismo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 618)
        Me.Controls.Add(Me.ReportViewer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmCertificadoBautismo"
        Me.Text = "Certificado de Bautismo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer As Microsoft.Reporting.WinForms.ReportViewer
End Class
