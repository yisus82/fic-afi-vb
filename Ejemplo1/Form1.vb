Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Name = "Form1"
        Me.Text = "Form1"

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Temp_Fh, Temp_Cent As Single
        Dim Temp_Cadena As String
        Do
            Temp_Cadena = InputBox("Escriba una temperatura en Grados Fahrenheit", "Fahrenheit a Centígrados")
            If Temp_Cadena <> "" Then
                Temp_Fh = CSng(Temp_Cadena)
                Temp_Cent = Int((Temp_Fh + 40) * 5 / 9 - 40)
                MsgBox(Temp_Cent, , "Temperatura en Grados Centígrados")
            End If
        Loop Until Temp_Cadena = ""
        End
    End Sub
End Class
