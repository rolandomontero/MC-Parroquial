﻿Imports System.Collections.Generic
Module modulo

    Public _indicatorUpdateTimer As New Timer
    Public PositionItem As String
    Public CountItem As String



#Region "ByPass Here"
    Public Sub IndicatorTimer_Tick()
        Dim f As New System.Windows.Forms.Form

        For Each frm As Form In My.Application.OpenForms
            If frm.Text = "Elegant UI" Then
                f = frm 'frm.Hide()
            End If
        Next
        f.Close()
    End Sub
#End Region


End Module


