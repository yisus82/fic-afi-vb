Public Class Form2
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
    Friend WithEvents bSumar2 As System.Windows.Forms.Button
    Friend WithEvents bCerrar2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.bSumar2 = New System.Windows.Forms.Button
        Me.bCerrar2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'bSumar2
        '
        Me.bSumar2.Location = New System.Drawing.Point(56, 48)
        Me.bSumar2.Name = "bSumar2"
        Me.bSumar2.Size = New System.Drawing.Size(75, 40)
        Me.bSumar2.TabIndex = 0
        Me.bSumar2.Text = "Sumar 2"
        '
        'bCerrar2
        '
        Me.bCerrar2.Location = New System.Drawing.Point(168, 48)
        Me.bCerrar2.Name = "bCerrar2"
        Me.bCerrar2.Size = New System.Drawing.Size(104, 40)
        Me.bCerrar2.TabIndex = 1
        Me.bCerrar2.Text = "Cerrar Formulario"
        '
        'Form2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 134)
        Me.Controls.Add(Me.bCerrar2)
        Me.Controls.Add(Me.bSumar2)
        Me.Name = "Form2"
        Me.Text = "Formulario 2"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub bSumar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSumar2.Click
        Dim form1 As Form1
        form1 = Module1.getForm1
        form1.lContador.Text = form1.lContador.Text + 2
    End Sub

    Private Sub bCerrar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCerrar2.Click
        Me.Close()
    End Sub
End Class
