Module Modulo

    Public Documento(256) As Formulario_Hijo
    Public contador_documentos As Integer = 0
    Public contador_nuevos As Integer = 0

    Public Sub Actualizar_Menu()
        If contador_documentos > 1 Then
            Formulario_Padre.Formulario_Padre_Ref.mnVentana.Enabled = True
        Else
            Formulario_Padre.Formulario_Padre_Ref.mnVentana.Enabled = False
        End If

        If contador_documentos <> 0 Then
            Formulario_Padre.Formulario_Padre_Ref.mnEdicion.Visible = True
            Formulario_Padre.Formulario_Padre_Ref.mnVentana.Visible = True
            Formulario_Padre.Formulario_Padre_Ref.mnFormato.Visible = True
            Formulario_Padre.Formulario_Padre_Ref.mnGuardar.Enabled = True
        Else
            Formulario_Padre.Formulario_Padre_Ref.mnEdicion.Visible = False
            Formulario_Padre.Formulario_Padre_Ref.mnVentana.Visible = False
            Formulario_Padre.Formulario_Padre_Ref.mnFormato.Visible = False
            Formulario_Padre.Formulario_Padre_Ref.mnGuardar.Enabled = False
        End If
    End Sub

End Module
