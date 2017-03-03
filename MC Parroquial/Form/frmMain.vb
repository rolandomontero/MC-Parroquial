Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.FileIO
Imports Timer = System.Windows.Forms.Timer
Imports System.Diagnostics
Imports System.IO
Imports Elegant.Ui

Enum TipoRegistro
    BAUTISMO = 1
    CONFIRMACION = 2
    MATRIMONIO = 3
End Enum


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class frmMain
    Inherits System.Windows.Forms.Form

    Private REGISTRO As TipoRegistro
    Friend WithEvents RibbonGroup1 As Elegant.Ui.RibbonGroup
    Friend WithEvents ddCertificado As Elegant.Ui.DropDown
    Friend WithEvents PopupMenu1 As Elegant.Ui.PopupMenu
    Friend WithEvents bCerBautismo As Elegant.Ui.Button
    Friend WithEvents bCerConfirmación As Elegant.Ui.Button
    Friend WithEvents bCerMatrimonio As Elegant.Ui.Button
    Friend WithEvents lbtxtRegistro As Elegant.Ui.Label
    Friend WithEvents bCerrarFormulario As Elegant.Ui.Button
    Private Pestana() As String = {"INICIO", "BAUTISMO", "CONFIRMACION", "Matrimonio"}


#Region "COMPONENTES"


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

    Friend WithEvents CINTA As Elegant.Ui.Ribbon
    Friend WithEvents tpInicio As Elegant.Ui.RibbonTabPage
    Friend WithEvents rgRegistros As Elegant.Ui.RibbonGroup
    Friend WithEvents ApplicationMenu As Elegant.Ui.ApplicationMenu
    Friend WithEvents bBautismo As Elegant.Ui.Button
    Friend WithEvents bConfirmacion As Elegant.Ui.Button
    Friend WithEvents bMatrimonio As Elegant.Ui.Button
    Friend WithEvents tpRegistros As Elegant.Ui.RibbonTabPage
    Friend WithEvents DropDown1 As Elegant.Ui.DropDown
    Friend WithEvents ApplicationMenuRightPanePopupMenu1 As Elegant.Ui.ApplicationMenuRightPanePopupMenu
    Friend WithEvents bBackUp As Elegant.Ui.Button
    Friend WithEvents Separator1 As Elegant.Ui.Separator
    Friend WithEvents rgAcciones As Elegant.Ui.RibbonGroup
    Friend WithEvents bActualizar As Elegant.Ui.Button
    Friend WithEvents Separator2 As Elegant.Ui.Separator
    Friend WithEvents bEditar As Elegant.Ui.Button
    Friend WithEvents bBorrar As Elegant.Ui.Button
    Friend WithEvents rgNavegar As Elegant.Ui.RibbonGroup
    Friend WithEvents bNuevo As Elegant.Ui.Button
    Friend WithEvents bPrimer As Elegant.Ui.Button
    Friend WithEvents bAnterior As Elegant.Ui.Button
    Friend WithEvents bSiguiente As Elegant.Ui.Button
    Friend WithEvents bUltimo As Elegant.Ui.Button
    Friend WithEvents rgVista As Elegant.Ui.RibbonGroup
    Friend WithEvents tbTabla As Elegant.Ui.ToggleButton
    Friend WithEvents StatusBar1 As Elegant.Ui.StatusBar
    Friend WithEvents StatusBarNotificationsArea1 As Elegant.Ui.StatusBarNotificationsArea
    Friend WithEvents StatusBarPane2 As Elegant.Ui.StatusBarPane
    Friend WithEvents StatusBarControlsArea1 As Elegant.Ui.StatusBarControlsArea
    Friend WithEvents StatusBarPaneRegistro As Elegant.Ui.StatusBarPane
    Friend WithEvents lbInfo As Elegant.Ui.Label
    Friend WithEvents StatusBarPaneProgressBar As Elegant.Ui.StatusBarPane
    Friend WithEvents ProgressBar As Elegant.Ui.ProgressBar
    Friend WithEvents txtRegistro As Elegant.Ui.TextBox
    Friend WithEvents lbRegistros As Elegant.Ui.Label
    Friend WithEvents StatusBarPane4 As Elegant.Ui.StatusBarPane
    Friend WithEvents btnCertificado As Elegant.Ui.Button
    Friend WithEvents Separator3 As Elegant.Ui.Separator

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim themeSelector As Elegant.Ui.ThemeSelector
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.formFrameSkinner = New Elegant.Ui.FormFrameSkinner()
        Me.CINTA = New Elegant.Ui.Ribbon()
        Me.ApplicationMenu = New Elegant.Ui.ApplicationMenu(Me.components)
        Me.DropDown1 = New Elegant.Ui.DropDown()
        Me.ApplicationMenuRightPanePopupMenu1 = New Elegant.Ui.ApplicationMenuRightPanePopupMenu(Me.components)
        Me.bBackUp = New Elegant.Ui.Button()
        Me.Separator1 = New Elegant.Ui.Separator()
        Me.tpInicio = New Elegant.Ui.RibbonTabPage()
        Me.rgRegistros = New Elegant.Ui.RibbonGroup()
        Me.bBautismo = New Elegant.Ui.Button()
        Me.bConfirmacion = New Elegant.Ui.Button()
        Me.bMatrimonio = New Elegant.Ui.Button()
        Me.RibbonGroup1 = New Elegant.Ui.RibbonGroup()
        Me.ddCertificado = New Elegant.Ui.DropDown()
        Me.PopupMenu1 = New Elegant.Ui.PopupMenu(Me.components)
        Me.bCerBautismo = New Elegant.Ui.Button()
        Me.bCerConfirmación = New Elegant.Ui.Button()
        Me.bCerMatrimonio = New Elegant.Ui.Button()
        Me.tpRegistros = New Elegant.Ui.RibbonTabPage()
        Me.rgAcciones = New Elegant.Ui.RibbonGroup()
        Me.bNuevo = New Elegant.Ui.Button()
        Me.Separator2 = New Elegant.Ui.Separator()
        Me.bEditar = New Elegant.Ui.Button()
        Me.bBorrar = New Elegant.Ui.Button()
        Me.bActualizar = New Elegant.Ui.Button()
        Me.rgNavegar = New Elegant.Ui.RibbonGroup()
        Me.bPrimer = New Elegant.Ui.Button()
        Me.bAnterior = New Elegant.Ui.Button()
        Me.bSiguiente = New Elegant.Ui.Button()
        Me.bUltimo = New Elegant.Ui.Button()
        Me.rgVista = New Elegant.Ui.RibbonGroup()
        Me.btnCertificado = New Elegant.Ui.Button()
        Me.tbTabla = New Elegant.Ui.ToggleButton()
        Me.Separator3 = New Elegant.Ui.Separator()
        Me.bCerrarFormulario = New Elegant.Ui.Button()
        Me.StatusBar1 = New Elegant.Ui.StatusBar()
        Me.StatusBarNotificationsArea1 = New Elegant.Ui.StatusBarNotificationsArea()
        Me.StatusBarPane2 = New Elegant.Ui.StatusBarPane()
        Me.lbInfo = New Elegant.Ui.Label()
        Me.StatusBarPaneProgressBar = New Elegant.Ui.StatusBarPane()
        Me.ProgressBar = New Elegant.Ui.ProgressBar()
        Me.StatusBarControlsArea1 = New Elegant.Ui.StatusBarControlsArea()
        Me.StatusBarPaneRegistro = New Elegant.Ui.StatusBarPane()
        Me.lbtxtRegistro = New Elegant.Ui.Label()
        Me.txtRegistro = New Elegant.Ui.TextBox()
        Me.lbRegistros = New Elegant.Ui.Label()
        Me.StatusBarPane4 = New Elegant.Ui.StatusBarPane()
        themeSelector = New Elegant.Ui.ThemeSelector(Me.components)
        CType(Me.CINTA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplicationMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplicationMenuRightPanePopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tpInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpInicio.SuspendLayout()
        CType(Me.rgRegistros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.rgRegistros.SuspendLayout()
        CType(Me.RibbonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonGroup1.SuspendLayout()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tpRegistros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpRegistros.SuspendLayout()
        CType(Me.rgAcciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.rgAcciones.SuspendLayout()
        CType(Me.rgNavegar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.rgNavegar.SuspendLayout()
        CType(Me.rgVista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.rgVista.SuspendLayout()
        Me.StatusBar1.SuspendLayout()
        Me.StatusBarNotificationsArea1.SuspendLayout()
        Me.StatusBarPane2.SuspendLayout()
        Me.StatusBarPaneProgressBar.SuspendLayout()
        Me.StatusBarControlsArea1.SuspendLayout()
        Me.StatusBarPaneRegistro.SuspendLayout()
        Me.SuspendLayout()
        '
        'formFrameSkinner
        '
        Me.formFrameSkinner.AllowGlass = False
        Me.formFrameSkinner.Form = Me
        '
        'CINTA
        '
        Me.CINTA.ApplicationButtonImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", Global.MC_Parroquial.My.Resources.Resources.icono)})
        Me.CINTA.ApplicationButtonPopup = Me.ApplicationMenu
        Me.CINTA.CurrentTabPage = Me.tpInicio
        Me.CINTA.Dock = System.Windows.Forms.DockStyle.Top
        Me.CINTA.Id = "22e2148a-8014-494e-a19f-7ab1ca0a1fb2"
        Me.CINTA.LargeImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", CType(resources.GetObject("CINTA.LargeImages.Images"), System.Drawing.Image))})
        Me.CINTA.Location = New System.Drawing.Point(0, 0)
        Me.CINTA.Name = "CINTA"
        Me.CINTA.QuickAccessToolbarPlacementMode = Elegant.Ui.QuickAccessToolbarPlacementMode.Hidden
        Me.CINTA.Size = New System.Drawing.Size(924, 148)
        Me.CINTA.TabIndex = 1
        Me.CINTA.TabPages.AddRange(New Elegant.Ui.RibbonTabPage() {Me.tpInicio, Me.tpRegistros})
        Me.CINTA.Text = "Ribbon"
        '
        'ApplicationMenu
        '
        Me.ApplicationMenu.ContentMinimumHeight = 0
        Me.ApplicationMenu.ExitButtonCommandName = "cmSalir"
        Me.ApplicationMenu.ExitButtonText = "Salir"
        Me.ApplicationMenu.Items.AddRange(New System.Windows.Forms.Control() {Me.DropDown1, Me.Separator1})
        Me.ApplicationMenu.KeepPopupsWithOffsetPlacementWithinPlacementArea = False
        Me.ApplicationMenu.OptionsButtonVisible = False
        Me.ApplicationMenu.PlacementMode = Elegant.Ui.PopupPlacementMode.Bottom
        Me.ApplicationMenu.Size = New System.Drawing.Size(400, 400)
        Me.ApplicationMenu.SizeToContentMode = Elegant.Ui.SizeToContentMode.None
        '
        'DropDown1
        '
        Me.DropDown1.Id = "89f1f8bf-bf2f-432c-800c-b1ead45ecc12"
        Me.DropDown1.Location = New System.Drawing.Point(0, 0)
        Me.DropDown1.Name = "DropDown1"
        Me.DropDown1.Popup = Me.ApplicationMenuRightPanePopupMenu1
        Me.DropDown1.Size = New System.Drawing.Size(130, 23)
        Me.DropDown1.TabIndex = 7
        Me.DropDown1.Text = "Herramientas"
        Me.DropDown1.TogglePopupByClickWhenOpen = False
        '
        'ApplicationMenuRightPanePopupMenu1
        '
        Me.ApplicationMenuRightPanePopupMenu1.Items.AddRange(New System.Windows.Forms.Control() {Me.bBackUp})
        Me.ApplicationMenuRightPanePopupMenu1.KeepPopupsWithOffsetPlacementWithinPlacementArea = False
        Me.ApplicationMenuRightPanePopupMenu1.PlacementMode = Elegant.Ui.PopupPlacementMode.Right
        Me.ApplicationMenuRightPanePopupMenu1.Size = New System.Drawing.Size(100, 100)
        '
        'bBackUp
        '
        Me.bBackUp.DescriptionText = "Crear un archivo de respaldo."
        Me.bBackUp.Id = "4c08a70b-1579-4200-a2c7-254f1cd553db"
        Me.bBackUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bBackUp.InformativenessMinimumLevel = "Elegant.Ui.ApplicationMenuButtonInformativenessLevel:LargeWithDescription"
        Me.bBackUp.LargeImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", CType(resources.GetObject("bBackUp.LargeImages.Images"), System.Drawing.Image)), New Elegant.Ui.ControlImage("Default", CType(resources.GetObject("bBackUp.LargeImages.Images1"), System.Drawing.Image))})
        Me.bBackUp.Location = New System.Drawing.Point(2, 2)
        Me.bBackUp.Name = "bBackUp"
        Me.ApplicationMenuRightPanePopupMenu1.SetShortcutKeys(Me.bBackUp, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys))
        Me.bBackUp.Size = New System.Drawing.Size(252, 55)
        Me.bBackUp.TabIndex = 3
        Me.bBackUp.Text = "BackUp"
        Me.bBackUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'Separator1
        '
        Me.Separator1.Id = "69e58bd4-7051-4cf8-b19b-12937c9e61b3"
        Me.Separator1.InformativenessFixedLevel = "Elegant.Ui.ApplicationMenuSeparatorInformativenessLevel:SeparatorWithText"
        Me.Separator1.Location = New System.Drawing.Point(0, 23)
        Me.Separator1.Name = "Separator1"
        Me.Separator1.Orientation = Elegant.Ui.SeparatorOrientation.Horizontal
        Me.Separator1.Size = New System.Drawing.Size(130, 27)
        Me.Separator1.TabIndex = 8
        Me.Separator1.Text = "Herramientas"
        '
        'tpInicio
        '
        Me.tpInicio.Controls.Add(Me.rgRegistros)
        Me.tpInicio.Controls.Add(Me.RibbonGroup1)
        Me.tpInicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tpInicio.KeyTip = Nothing
        Me.tpInicio.Location = New System.Drawing.Point(0, 0)
        Me.tpInicio.Name = "tpInicio"
        Me.tpInicio.Size = New System.Drawing.Size(924, 101)
        Me.tpInicio.TabIndex = 0
        Me.tpInicio.Text = "INICIO"
        '
        'rgRegistros
        '
        Me.rgRegistros.Controls.Add(Me.bBautismo)
        Me.rgRegistros.Controls.Add(Me.bConfirmacion)
        Me.rgRegistros.Controls.Add(Me.bMatrimonio)
        Me.rgRegistros.DialogLauncherButtonVisible = False
        Me.rgRegistros.Location = New System.Drawing.Point(4, 3)
        Me.rgRegistros.Name = "rgRegistros"
        Me.rgRegistros.Size = New System.Drawing.Size(211, 94)
        Me.rgRegistros.TabIndex = 0
        Me.rgRegistros.Text = "Registros Sacramentales"
        '
        'bBautismo
        '
        Me.bBautismo.CommandName = "cmdBautismo"
        Me.bBautismo.Id = "0596b816-9e8f-4dee-b5e1-301d5d67630c"
        Me.bBautismo.LargeImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", Global.MC_Parroquial.My.Resources.Resources.Icono_Bautiso)})
        Me.bBautismo.Location = New System.Drawing.Point(4, 2)
        Me.bBautismo.Name = "bBautismo"
        Me.bBautismo.ScreenTip.Text = "Administra registro del libro de bautismo."
        Me.bBautismo.Size = New System.Drawing.Size(54, 72)
        Me.bBautismo.TabIndex = 0
        Me.bBautismo.Text = "Bautismo"
        '
        'bConfirmacion
        '
        Me.bConfirmacion.CommandName = "cmdConfirmacion"
        Me.bConfirmacion.Id = "5bccd11a-e6f3-4a22-8e6e-7fbb608a6819"
        Me.bConfirmacion.LargeImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", Global.MC_Parroquial.My.Resources.Resources.Icono_confirmacion)})
        Me.bConfirmacion.Location = New System.Drawing.Point(60, 2)
        Me.bConfirmacion.Name = "bConfirmacion"
        Me.bConfirmacion.ScreenTip.Text = "Administra registro del libro de confirmación."
        Me.bConfirmacion.Size = New System.Drawing.Size(77, 72)
        Me.bConfirmacion.TabIndex = 1
        Me.bConfirmacion.Text = "Confirmación"
        '
        'bMatrimonio
        '
        Me.bMatrimonio.CommandName = "cmdMatrimonio"
        Me.bMatrimonio.Id = "d26db84c-944a-4c4b-86d4-20b18fe195d6"
        Me.bMatrimonio.LargeImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", Global.MC_Parroquial.My.Resources.Resources.Icono_Matrimoniopng)})
        Me.bMatrimonio.Location = New System.Drawing.Point(139, 2)
        Me.bMatrimonio.Name = "bMatrimonio"
        Me.bMatrimonio.Size = New System.Drawing.Size(67, 72)
        Me.bMatrimonio.TabIndex = 2
        Me.bMatrimonio.Text = "Matrimonio"
        '
        'RibbonGroup1
        '
        Me.RibbonGroup1.Controls.Add(Me.ddCertificado)
        Me.RibbonGroup1.DialogLauncherButtonVisible = False
        Me.RibbonGroup1.Location = New System.Drawing.Point(217, 3)
        Me.RibbonGroup1.Name = "RibbonGroup1"
        Me.RibbonGroup1.Size = New System.Drawing.Size(73, 94)
        Me.RibbonGroup1.TabIndex = 1
        '
        'ddCertificado
        '
        Me.ddCertificado.Id = "f7415384-dd9d-4629-b239-9a3bacc6b2f7"
        Me.ddCertificado.LargeImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", Global.MC_Parroquial.My.Resources.Resources.install_ssl_certificate)})
        Me.ddCertificado.Location = New System.Drawing.Point(4, 2)
        Me.ddCertificado.Name = "ddCertificado"
        Me.ddCertificado.Popup = Me.PopupMenu1
        Me.ddCertificado.Size = New System.Drawing.Size(64, 72)
        Me.ddCertificado.TabIndex = 0
        Me.ddCertificado.Text = "Certificado"
        '
        'PopupMenu1
        '
        Me.PopupMenu1.Items.AddRange(New System.Windows.Forms.Control() {Me.bCerBautismo, Me.bCerConfirmación, Me.bCerMatrimonio})
        Me.PopupMenu1.KeepPopupsWithOffsetPlacementWithinPlacementArea = False
        Me.PopupMenu1.PlacementMode = Elegant.Ui.PopupPlacementMode.Bottom
        Me.PopupMenu1.Size = New System.Drawing.Size(100, 100)
        '
        'bCerBautismo
        '
        Me.bCerBautismo.Id = "78cbe985-f899-468b-9386-d77fe9e1af0f"
        Me.bCerBautismo.Location = New System.Drawing.Point(2, 2)
        Me.bCerBautismo.Name = "bCerBautismo"
        Me.bCerBautismo.Size = New System.Drawing.Size(132, 23)
        Me.bCerBautismo.SmallImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", Global.MC_Parroquial.My.Resources.Resources.sm_Icono_Bautiso)})
        Me.bCerBautismo.TabIndex = 3
        Me.bCerBautismo.Text = "Bautismo"
        '
        'bCerConfirmación
        '
        Me.bCerConfirmación.Id = "9124bbe8-9567-49da-b852-550581d0534b"
        Me.bCerConfirmación.Location = New System.Drawing.Point(2, 25)
        Me.bCerConfirmación.Name = "bCerConfirmación"
        Me.bCerConfirmación.Size = New System.Drawing.Size(132, 23)
        Me.bCerConfirmación.SmallImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", Global.MC_Parroquial.My.Resources.Resources.sm_Icono_confirmacion)})
        Me.bCerConfirmación.TabIndex = 4
        Me.bCerConfirmación.Text = "Confirmación"
        '
        'bCerMatrimonio
        '
        Me.bCerMatrimonio.Id = "b839f4e9-c020-4b8e-a303-8d700f80c20a"
        Me.bCerMatrimonio.Location = New System.Drawing.Point(2, 48)
        Me.bCerMatrimonio.Name = "bCerMatrimonio"
        Me.bCerMatrimonio.Size = New System.Drawing.Size(132, 23)
        Me.bCerMatrimonio.SmallImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", Global.MC_Parroquial.My.Resources.Resources.sm_Icono_Matrimoniopng)})
        Me.bCerMatrimonio.TabIndex = 5
        Me.bCerMatrimonio.Text = "Matrimonio"
        '
        'tpRegistros
        '
        Me.tpRegistros.Controls.Add(Me.rgAcciones)
        Me.tpRegistros.Controls.Add(Me.rgNavegar)
        Me.tpRegistros.Controls.Add(Me.rgVista)
        Me.tpRegistros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tpRegistros.Enabled = False
        Me.tpRegistros.KeyTip = Nothing
        Me.tpRegistros.Location = New System.Drawing.Point(0, 0)
        Me.tpRegistros.Name = "tpRegistros"
        Me.tpRegistros.Size = New System.Drawing.Size(1000, 101)
        Me.tpRegistros.TabIndex = 0
        Me.tpRegistros.Text = "REGISTROS"
        '
        'rgAcciones
        '
        Me.rgAcciones.Controls.Add(Me.bNuevo)
        Me.rgAcciones.Controls.Add(Me.Separator2)
        Me.rgAcciones.Controls.Add(Me.bEditar)
        Me.rgAcciones.Controls.Add(Me.bBorrar)
        Me.rgAcciones.Controls.Add(Me.bActualizar)
        Me.rgAcciones.DialogLauncherButtonVisible = False
        Me.rgAcciones.Location = New System.Drawing.Point(4, 3)
        Me.rgAcciones.Name = "rgAcciones"
        Me.rgAcciones.Size = New System.Drawing.Size(205, 0)
        Me.rgAcciones.TabIndex = 0
        Me.rgAcciones.Text = "Acciones de Registros"
        '
        'bNuevo
        '
        Me.bNuevo.Id = "b489a630-0dc2-444d-a1bd-5f4f9286f53e"
        Me.bNuevo.LargeImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", Global.MC_Parroquial.My.Resources.Resources.book_add)})
        Me.bNuevo.Location = New System.Drawing.Point(74, 2)
        Me.bNuevo.Name = "bNuevo"
        Me.bNuevo.Size = New System.Drawing.Size(41, 0)
        Me.bNuevo.TabIndex = 5
        Me.bNuevo.Text = "Nuevo"
        '
        'Separator2
        '
        Me.Separator2.Id = "c47636ff-c3dd-4ece-bfd2-8adc09b1fdc0"
        Me.Separator2.Location = New System.Drawing.Point(76, 7)
        Me.Separator2.Name = "Separator2"
        Me.Separator2.Size = New System.Drawing.Size(2, -12)
        Me.Separator2.TabIndex = 3
        Me.Separator2.Text = "Separator2"
        '
        'bEditar
        '
        Me.bEditar.Id = "9aeebe17-f79d-4e45-b664-ced77a7cd0f3"
        Me.bEditar.LargeImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", Global.MC_Parroquial.My.Resources.Resources.book_edit)})
        Me.bEditar.Location = New System.Drawing.Point(74, 2)
        Me.bEditar.Name = "bEditar"
        Me.bEditar.Size = New System.Drawing.Size(36, 0)
        Me.bEditar.TabIndex = 0
        Me.bEditar.Text = "Editar"
        '
        'bBorrar
        '
        Me.bBorrar.Id = "3ab306f1-19fd-4ec5-9234-d096552146cd"
        Me.bBorrar.LargeImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", Global.MC_Parroquial.My.Resources.Resources.book_delete)})
        Me.bBorrar.Location = New System.Drawing.Point(74, 2)
        Me.bBorrar.Name = "bBorrar"
        Me.bBorrar.Size = New System.Drawing.Size(37, 0)
        Me.bBorrar.TabIndex = 2
        Me.bBorrar.Text = "Borrar"
        '
        'bActualizar
        '
        Me.bActualizar.DescriptionText = "Actualizar Base de Datos"
        Me.bActualizar.Id = "d9c3072e-a0b0-4413-8cfc-f11cee74e856"
        Me.bActualizar.LargeImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", CType(resources.GetObject("bActualizar.LargeImages.Images"), System.Drawing.Image))})
        Me.bActualizar.Location = New System.Drawing.Point(74, 2)
        Me.bActualizar.Name = "bActualizar"
        Me.bActualizar.Size = New System.Drawing.Size(55, 0)
        Me.bActualizar.TabIndex = 4
        Me.bActualizar.Text = "Actualizar"
        '
        'rgNavegar
        '
        Me.rgNavegar.Controls.Add(Me.bPrimer)
        Me.rgNavegar.Controls.Add(Me.bAnterior)
        Me.rgNavegar.Controls.Add(Me.bSiguiente)
        Me.rgNavegar.Controls.Add(Me.bUltimo)
        Me.rgNavegar.DialogLauncherButtonVisible = False
        Me.rgNavegar.Location = New System.Drawing.Point(211, 3)
        Me.rgNavegar.Name = "rgNavegar"
        Me.rgNavegar.Size = New System.Drawing.Size(203, 0)
        Me.rgNavegar.TabIndex = 1
        Me.rgNavegar.Text = "Navegar"
        '
        'bPrimer
        '
        Me.bPrimer.DescriptionText = "Se posiciona en el primer registro"
        Me.bPrimer.Id = "a15fbf7f-b6cf-4c69-bc44-3b32b98563c0"
        Me.bPrimer.LargeImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", CType(resources.GetObject("bPrimer.LargeImages.Images"), System.Drawing.Image))})
        Me.bPrimer.Location = New System.Drawing.Point(74, 2)
        Me.bPrimer.Name = "bPrimer"
        Me.bPrimer.Size = New System.Drawing.Size(44, 0)
        Me.bPrimer.TabIndex = 3
        Me.bPrimer.Text = "Primero"
        '
        'bAnterior
        '
        Me.bAnterior.Id = "1ab0b89d-9ec9-416b-b43c-de5c753d5895"
        Me.bAnterior.LargeImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", CType(resources.GetObject("bAnterior.LargeImages.Images"), System.Drawing.Image))})
        Me.bAnterior.Location = New System.Drawing.Point(74, 2)
        Me.bAnterior.Name = "bAnterior"
        Me.bAnterior.ScreenTip.Caption = "Navegar"
        Me.bAnterior.ScreenTip.Text = "Retrocede un registro"
        Me.bAnterior.Size = New System.Drawing.Size(45, 0)
        Me.bAnterior.TabIndex = 2
        Me.bAnterior.Text = "Anterior"
        '
        'bSiguiente
        '
        Me.bSiguiente.Id = "2064af64-e52f-4162-9d0e-1ffdc4c63b58"
        Me.bSiguiente.LargeImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", CType(resources.GetObject("bSiguiente.LargeImages.Images"), System.Drawing.Image))})
        Me.bSiguiente.Location = New System.Drawing.Point(74, 2)
        Me.bSiguiente.Name = "bSiguiente"
        Me.bSiguiente.Size = New System.Drawing.Size(53, 0)
        Me.bSiguiente.TabIndex = 1
        Me.bSiguiente.Text = "Siguiente"
        '
        'bUltimo
        '
        Me.bUltimo.Id = "e48c40a8-f962-4192-a8a6-3f7966c5cf30"
        Me.bUltimo.LargeImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", CType(resources.GetObject("bUltimo.LargeImages.Images"), System.Drawing.Image))})
        Me.bUltimo.Location = New System.Drawing.Point(74, 2)
        Me.bUltimo.Name = "bUltimo"
        Me.bUltimo.Size = New System.Drawing.Size(38, 0)
        Me.bUltimo.TabIndex = 0
        Me.bUltimo.Text = "Último"
        '
        'rgVista
        '
        Me.rgVista.Controls.Add(Me.btnCertificado)
        Me.rgVista.Controls.Add(Me.tbTabla)
        Me.rgVista.Controls.Add(Me.Separator3)
        Me.rgVista.Controls.Add(Me.bCerrarFormulario)
        Me.rgVista.DialogLauncherButtonVisible = False
        Me.rgVista.Location = New System.Drawing.Point(416, 3)
        Me.rgVista.Name = "rgVista"
        Me.rgVista.Size = New System.Drawing.Size(167, 0)
        Me.rgVista.TabIndex = 2
        Me.rgVista.Text = "Vista"
        '
        'btnCertificado
        '
        Me.btnCertificado.CommandName = "cmdCertificado"
        Me.btnCertificado.Id = "514152b6-69a9-4707-aa6c-4048fe8597ec"
        Me.btnCertificado.LargeImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", Global.MC_Parroquial.My.Resources.Resources.install_ssl_certificate)})
        Me.btnCertificado.Location = New System.Drawing.Point(53, 2)
        Me.btnCertificado.Name = "btnCertificado"
        Me.btnCertificado.Size = New System.Drawing.Size(59, 0)
        Me.btnCertificado.TabIndex = 4
        Me.btnCertificado.Text = "Certificado"
        '
        'tbTabla
        '
        Me.tbTabla.Id = "b31fb324-3e7b-4dac-8abb-b34225a99cfb"
        Me.tbTabla.LargeImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", CType(resources.GetObject("tbTabla.LargeImages.Images"), System.Drawing.Image))})
        Me.tbTabla.Location = New System.Drawing.Point(53, 2)
        Me.tbTabla.Name = "tbTabla"
        Me.tbTabla.Size = New System.Drawing.Size(36, 0)
        Me.tbTabla.TabIndex = 2
        Me.tbTabla.Text = "Tabla"
        '
        'Separator3
        '
        Me.Separator3.Id = "84fd10af-9c91-4d88-946a-5bb7db348e02"
        Me.Separator3.Location = New System.Drawing.Point(55, 7)
        Me.Separator3.Name = "Separator3"
        Me.Separator3.Size = New System.Drawing.Size(2, -12)
        Me.Separator3.TabIndex = 3
        Me.Separator3.Text = "Separator3"
        '
        'bCerrarFormulario
        '
        Me.bCerrarFormulario.CommandName = "cmdCerrarFormulario"
        Me.bCerrarFormulario.Id = "7414e576-4e07-4989-9929-d556d9569e83"
        Me.bCerrarFormulario.LargeImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", Global.MC_Parroquial.My.Resources.Resources.cancel)})
        Me.bCerrarFormulario.Location = New System.Drawing.Point(53, 2)
        Me.bCerrarFormulario.Name = "bCerrarFormulario"
        Me.bCerrarFormulario.Size = New System.Drawing.Size(37, 0)
        Me.bCerrarFormulario.TabIndex = 5
        Me.bCerrarFormulario.Text = "Cerrar"
        '
        'StatusBar1
        '
        Me.StatusBar1.Controls.Add(Me.StatusBarNotificationsArea1)
        Me.StatusBar1.Controls.Add(Me.StatusBarControlsArea1)
        Me.StatusBar1.ControlsArea = Me.StatusBarControlsArea1
        Me.StatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.StatusBar1.Location = New System.Drawing.Point(0, 571)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.NotificationsArea = Me.StatusBarNotificationsArea1
        Me.StatusBar1.Size = New System.Drawing.Size(924, 24)
        Me.StatusBar1.TabIndex = 3
        Me.StatusBar1.Text = "StatusBar1"
        '
        'StatusBarNotificationsArea1
        '
        Me.StatusBarNotificationsArea1.Controls.Add(Me.StatusBarPane2)
        Me.StatusBarNotificationsArea1.Controls.Add(Me.StatusBarPaneProgressBar)
        Me.StatusBarNotificationsArea1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatusBarNotificationsArea1.Location = New System.Drawing.Point(0, 0)
        Me.StatusBarNotificationsArea1.MaximumSize = New System.Drawing.Size(0, 24)
        Me.StatusBarNotificationsArea1.MinimumSize = New System.Drawing.Size(0, 24)
        Me.StatusBarNotificationsArea1.Name = "StatusBarNotificationsArea1"
        Me.StatusBarNotificationsArea1.Size = New System.Drawing.Size(727, 24)
        Me.StatusBarNotificationsArea1.TabIndex = 1
        '
        'StatusBarPane2
        '
        Me.StatusBarPane2.Controls.Add(Me.lbInfo)
        Me.StatusBarPane2.Location = New System.Drawing.Point(0, 0)
        Me.StatusBarPane2.MaximumSize = New System.Drawing.Size(0, 24)
        Me.StatusBarPane2.MinimumSize = New System.Drawing.Size(0, 24)
        Me.StatusBarPane2.Name = "StatusBarPane2"
        Me.StatusBarPane2.Size = New System.Drawing.Size(60, 24)
        Me.StatusBarPane2.TabIndex = 0
        '
        'lbInfo
        '
        Me.lbInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbInfo.Location = New System.Drawing.Point(5, 6)
        Me.lbInfo.Name = "lbInfo"
        Me.lbInfo.Size = New System.Drawing.Size(22, 13)
        Me.lbInfo.TabIndex = 0
        Me.lbInfo.Text = "Listo"
        '
        'StatusBarPaneProgressBar
        '
        Me.StatusBarPaneProgressBar.Controls.Add(Me.ProgressBar)
        Me.StatusBarPaneProgressBar.Location = New System.Drawing.Point(60, 0)
        Me.StatusBarPaneProgressBar.MaximumSize = New System.Drawing.Size(0, 24)
        Me.StatusBarPaneProgressBar.MinimumSize = New System.Drawing.Size(0, 24)
        Me.StatusBarPaneProgressBar.Name = "StatusBarPaneProgressBar"
        Me.StatusBarPaneProgressBar.Size = New System.Drawing.Size(134, 24)
        Me.StatusBarPaneProgressBar.TabIndex = 1
        Me.StatusBarPaneProgressBar.Visible = False
        '
        'ProgressBar
        '
        Me.ProgressBar.DesiredWidth = 100
        Me.ProgressBar.Id = "c38f8788-3808-41fa-b804-f826a91e6895"
        Me.ProgressBar.Location = New System.Drawing.Point(3, 6)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(100, 12)
        Me.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar.TabIndex = 0
        Me.ProgressBar.Text = "ProgressBar"
        '
        'StatusBarControlsArea1
        '
        Me.StatusBarControlsArea1.Controls.Add(Me.StatusBarPaneRegistro)
        Me.StatusBarControlsArea1.Controls.Add(Me.StatusBarPane4)
        Me.StatusBarControlsArea1.Dock = System.Windows.Forms.DockStyle.Right
        Me.StatusBarControlsArea1.Location = New System.Drawing.Point(727, 0)
        Me.StatusBarControlsArea1.MaximumSize = New System.Drawing.Size(0, 24)
        Me.StatusBarControlsArea1.MinimumSize = New System.Drawing.Size(0, 24)
        Me.StatusBarControlsArea1.Name = "StatusBarControlsArea1"
        Me.StatusBarControlsArea1.Size = New System.Drawing.Size(197, 24)
        Me.StatusBarControlsArea1.TabIndex = 0
        '
        'StatusBarPaneRegistro
        '
        Me.StatusBarPaneRegistro.Controls.Add(Me.lbtxtRegistro)
        Me.StatusBarPaneRegistro.Controls.Add(Me.txtRegistro)
        Me.StatusBarPaneRegistro.Controls.Add(Me.lbRegistros)
        Me.StatusBarPaneRegistro.Location = New System.Drawing.Point(0, 0)
        Me.StatusBarPaneRegistro.MaximumSize = New System.Drawing.Size(0, 24)
        Me.StatusBarPaneRegistro.MinimumSize = New System.Drawing.Size(0, 24)
        Me.StatusBarPaneRegistro.Name = "StatusBarPaneRegistro"
        Me.StatusBarPaneRegistro.Size = New System.Drawing.Size(125, 24)
        Me.StatusBarPaneRegistro.TabIndex = 0
        Me.StatusBarPaneRegistro.Visible = False
        '
        'lbtxtRegistro
        '
        Me.lbtxtRegistro.Location = New System.Drawing.Point(5, 6)
        Me.lbtxtRegistro.Name = "lbtxtRegistro"
        Me.lbtxtRegistro.Size = New System.Drawing.Size(42, 13)
        Me.lbtxtRegistro.TabIndex = 2
        Me.lbtxtRegistro.Text = "Registro "
        '
        'txtRegistro
        '
        Me.txtRegistro.Id = "2da67c8c-b7da-4b37-8aee-873a2d9a3ae9"
        Me.txtRegistro.Location = New System.Drawing.Point(51, 2)
        Me.txtRegistro.Name = "txtRegistro"
        Me.txtRegistro.Size = New System.Drawing.Size(12, 21)
        Me.txtRegistro.TabIndex = 0
        Me.txtRegistro.Text = "0"
        Me.txtRegistro.TextEditorWidth = 6
        '
        'lbRegistros
        '
        Me.lbRegistros.Location = New System.Drawing.Point(67, 6)
        Me.lbRegistros.Name = "lbRegistros"
        Me.lbRegistros.Size = New System.Drawing.Size(29, 13)
        Me.lbRegistros.TabIndex = 1
        Me.lbRegistros.Text = "de {0}"
        '
        'StatusBarPane4
        '
        Me.StatusBarPane4.Location = New System.Drawing.Point(125, 0)
        Me.StatusBarPane4.MaximumSize = New System.Drawing.Size(0, 24)
        Me.StatusBarPane4.MinimumSize = New System.Drawing.Size(0, 24)
        Me.StatusBarPane4.Name = "StatusBarPane4"
        Me.StatusBarPane4.Size = New System.Drawing.Size(20, 24)
        Me.StatusBarPane4.TabIndex = 1
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(924, 595)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.CINTA)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.IsMdiContainer = True
        Me.Location = New System.Drawing.Point(64, 32)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "MC Administrador Parroquial"
        CType(Me.CINTA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplicationMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplicationMenuRightPanePopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tpInicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpInicio.ResumeLayout(False)
        Me.tpInicio.PerformLayout()
        CType(Me.rgRegistros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.rgRegistros.ResumeLayout(False)
        Me.rgRegistros.PerformLayout()
        CType(Me.RibbonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonGroup1.ResumeLayout(False)
        Me.RibbonGroup1.PerformLayout()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tpRegistros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpRegistros.ResumeLayout(False)
        Me.tpRegistros.PerformLayout()
        CType(Me.rgAcciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.rgAcciones.ResumeLayout(False)
        Me.rgAcciones.PerformLayout()
        CType(Me.rgNavegar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.rgNavegar.ResumeLayout(False)
        Me.rgNavegar.PerformLayout()
        CType(Me.rgVista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.rgVista.ResumeLayout(False)
        Me.rgVista.PerformLayout()
        Me.StatusBar1.ResumeLayout(False)
        Me.StatusBar1.PerformLayout()
        Me.StatusBarNotificationsArea1.ResumeLayout(False)
        Me.StatusBarNotificationsArea1.PerformLayout()
        Me.StatusBarPane2.ResumeLayout(False)
        Me.StatusBarPane2.PerformLayout()
        Me.StatusBarPaneProgressBar.ResumeLayout(False)
        Me.StatusBarPaneProgressBar.PerformLayout()
        Me.StatusBarControlsArea1.ResumeLayout(False)
        Me.StatusBarControlsArea1.PerformLayout()
        Me.StatusBarPaneRegistro.ResumeLayout(False)
        Me.StatusBarPaneRegistro.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents formFrameSkinner As Elegant.Ui.FormFrameSkinner
#End Region

    Private Sub Inicio()
        AddHandler _indicatorUpdateTimer.Tick, AddressOf IndicatorTimer_Tick
        AddHandler ApplicationCommands.cmSalir.Executed, AddressOf Me.Close
        AddHandler ApplicationCommands.cmdBautismo.Executed, AddressOf Pestaña
        AddHandler ApplicationCommands.cmdConfirmacion.Executed, AddressOf Pestaña
        AddHandler ApplicationCommands.cmdMatrimonio.Executed, AddressOf Pestaña
        AddHandler ApplicationCommands.cmdCerrarFormulario.Executed, AddressOf CierraLibro


        AddHandler ApplicationCommands.cmdCertificado.Executed, AddressOf Certificado

        ' formShadow = New FormFrameShadow(formFrameSkinner)
        SetStyle(ControlStyles.UserPaint, True)
        SetStyle(ControlStyles.ResizeRedraw, True)
        If SystemFonts.MenuFont.FontFamily.Name = "Segoe UI" Then Font = SystemFonts.MenuFont
        tpRegistros.Enabled = False
        CINTA.CurrentTabPage = tpInicio
        tpInicio.Enabled = True

    End Sub

    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        Dim arg() : arg = Environment.GetCommandLineArgs()
        Dim File As String
        Try
            Inicio()
            MyBase.OnLoad(e)
            If arg.Length > 1 Then
                File = arg(1)
                'Abre(File)
                '     If MsgBox("Desea abrir el archivo " & vbCrLf & File, vbYesNo, "Abrir Archivo") = vbYes Then Abre(File)
            End If

        Catch ex As InvalidOperationException ' WindowsFormsApplicationBase can cause the InvalidOperationException sometimes when trying to hide splash screen
            Debug.WriteLine(ex.Message)
        End Try
        _indicatorUpdateTimer.Start()
        ' formShadow.ShowShadow()
    End Sub

    Private Sub Alerta(ByVal info As String, Optional ver As Boolean = False)
        lbInfo.Text = info
        StatusBarPaneProgressBar.Visible = ver
        Application.DoEvents()
    End Sub

    Private Sub Listo()
        lbInfo.Text = "listo"
        StatusBarPaneProgressBar.Visible = False
        Application.DoEvents()
    End Sub

    Dim rCertificdo As Object
    Private Sub Certificado()

        Select Case REGISTRO
            Case TipoRegistro.BAUTISMO
                Dim Certificado As frmCertificadoBautismo = New frmCertificadoBautismo
                Certificado.Registro(DirectCast(Enlace.Current, DataRowView).Row)
                Certificado.ShowDialog()

            Case TipoRegistro.CONFIRMACION
                Dim Certificado As frmCertificadoConfirmacion = New frmCertificadoConfirmacion
                Certificado.Registro(DirectCast(Enlace.Current, DataRowView).Row)
                Certificado.ShowDialog()

            Case TipoRegistro.MATRIMONIO
                Dim Certificado As frmCertificadoMatrimonio = New frmCertificadoMatrimonio
                Certificado.Registro(DirectCast(Enlace.Current, DataRowView).Row)
                Certificado.ShowDialog()

        End Select
    End Sub

    '' ******************** PESTAÑAS ********************

    Dim LibroBautismo As frmLibroBautismo
    Dim LibroConfirmacion As frmLibroConfirmacion
    Dim LibroMatrimonio As frmLibroMatrimonio

    Dim WithEvents BuscarBautismo As frmBuscarBautismo

    Friend WithEvents Enlace As BindingSource

    Private Sub Pestaña(sender As Object, e As Elegant.Ui.CommandExecutedEventArgs)
        Alerta("Cargando datos ...", True)
        Enlace = New BindingSource
        Select Case DirectCast(sender, Elegant.Ui.Command).Name
            Case "cmdBautismo"
                REGISTRO = TipoRegistro.BAUTISMO
                LibroBautismo = New frmLibroBautismo
                Enlace = LibroBautismo.BindingSource
                LibroBautismo.MdiParent = Me
            Case "cmdConfirmacion"
                REGISTRO = TipoRegistro.CONFIRMACION
                LibroConfirmacion = New frmLibroConfirmacion
                Enlace = LibroConfirmacion.BindingSource
                LibroConfirmacion.MdiParent = Me
            Case "cmdMatrimonio"
                REGISTRO = TipoRegistro.MATRIMONIO
                LibroMatrimonio = New frmLibroMatrimonio
                Enlace = LibroMatrimonio.BindingSource
                LibroMatrimonio.MdiParent = Me
        End Select

        tpRegistros.Text = Pestana(REGISTRO)
        tpRegistros.Enabled = True
        tpInicio.Enabled = False

        Select Case REGISTRO
            Case TipoRegistro.BAUTISMO
                LibroBautismo.Show()
            Case TipoRegistro.CONFIRMACION
                LibroConfirmacion.Show()
            Case TipoRegistro.MATRIMONIO
                LibroMatrimonio.Show()
        End Select

        StatusBarPaneRegistro.Visible = True
        Enlace.MoveFirst()
        txtRegistro.Text = 1
        lbRegistros.Text = "  de  " & Enlace.Count & "  del Libro de  " & LCase(Pestana(REGISTRO))
        CINTA.CurrentTabPage = tpRegistros
        tpRegistros.Show()

        Listo()

    End Sub

    Public Sub CierraLibro()
        Select Case REGISTRO
            Case TipoRegistro.BAUTISMO
                LibroBautismo.Close()
            Case TipoRegistro.CONFIRMACION
                LibroConfirmacion.Close()
            Case TipoRegistro.MATRIMONIO
                LibroMatrimonio.Close()
        End Select

        Try
            tpRegistros.Text = "REGISTROS"
            tpRegistros.Enabled = False

            CINTA.CurrentTabPage = tpInicio
            tpInicio.Enabled = True

        Catch ex As Exception
            MyBase.Dispose(Disposing)

        End Try
        StatusBarPaneRegistro.Visible = False
        Listo()

    End Sub

    Private Sub Enlace_PositionChanged(sender As Object, e As EventArgs) Handles Enlace.PositionChanged
        txtRegistro.Text = Enlace.Position + 1
        bSiguiente.Enabled = Enlace.Position < Enlace.Count
        bAnterior.Enabled = Enlace.Position > 0
    End Sub

    Private Sub bUltimo_Click(sender As Object, e As EventArgs) Handles bUltimo.Click
        Enlace.MoveLast()
    End Sub

    Private Sub bSiguiente_Click(sender As Object, e As EventArgs) Handles bSiguiente.Click
        Enlace.MoveNext()
    End Sub

    Private Sub bAnterior_Click(sender As Object, e As EventArgs) Handles bAnterior.Click
        Enlace.MovePrevious()
    End Sub

    Private Sub bPrimer_Click(sender As Object, e As EventArgs) Handles bPrimer.Click
        Enlace.MoveFirst()
    End Sub

    Private Sub bNuevo_Click(sender As Object, e As EventArgs) Handles bNuevo.Click
        Enlace.AddNew()
    End Sub

    Private Sub bActualizar_Click(sender As Object, e As EventArgs) Handles bActualizar.Click
        Select Case REGISTRO
            Case TipoRegistro.BAUTISMO
                LibroBautismo.Grabar()
            Case TipoRegistro.CONFIRMACION
                LibroConfirmacion.Grabar()
            Case TipoRegistro.MATRIMONIO
                LibroMatrimonio.Grabar()
        End Select
    End Sub

    Private Sub bBorrar_Click(sender As Object, e As EventArgs) Handles bBorrar.Click
        Select Case REGISTRO
            Case TipoRegistro.BAUTISMO
                LibroBautismo.Borrar()
            Case TipoRegistro.CONFIRMACION
                LibroConfirmacion.Borrar()
            Case TipoRegistro.MATRIMONIO
                LibroMatrimonio.Borrar()
        End Select
    End Sub

    Private Sub tbTabla_StateChanged(sender As Object, e As ControlStateChangedEventArgs) Handles tbTabla.StateChanged
        Select Case REGISTRO
            Case TipoRegistro.BAUTISMO
                LibroBautismo.VerTabla(tbTabla.Pressed)
            Case TipoRegistro.CONFIRMACION
                LibroConfirmacion.VerTabla(tbTabla.Pressed)
            Case TipoRegistro.MATRIMONIO
                LibroMatrimonio.VerTabla(tbTabla.Pressed)
        End Select

    End Sub

    Private Sub txtRegistro_TextChanged(sender As Object, e As EventArgs) Handles txtRegistro.TextChanged
        Try
            Dim p As Integer = CInt(txtRegistro.Text) - 1
            If p >= 0 And p <= Enlace.Count Then Enlace.Position = p
        Catch ex As Exception

        End Try
    End Sub

    Private Sub bCerBautismo_Click(sender As Object, e As EventArgs) Handles bCerBautismo.Click
        BuscarBautismo = New frmBuscarBautismo
        Enlace = BuscarBautismo.BindingSourceBautismo
        BuscarBautismo.MdiParent = Me
        REGISTRO = TipoRegistro.BAUTISMO
        StatusBarPaneRegistro.Visible = True
        Enlace.MoveFirst()
        txtRegistro.Text = 1
        Listo()
        BuscarBautismo.Show()
        lbRegistros.Text = "  de  " & Enlace.Count & "  del Libro de  " & LCase(Pestana(REGISTRO))
    End Sub

    Private Sub BuscarBautismo_Disposed(sender As Object, e As EventArgs) Handles BuscarBautismo.Disposed
        StatusBarPaneRegistro.Visible = False
    End Sub
End Class

