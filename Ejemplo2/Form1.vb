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
    Friend WithEvents lContador As System.Windows.Forms.Label
    Friend WithEvents bSumar1 As System.Windows.Forms.Button
    Friend WithEvents bForm2 As System.Windows.Forms.Button
    Friend WithEvents bModal As System.Windows.Forms.Button
    Friend WithEvents bCursiva As System.Windows.Forms.Button
    Friend WithEvents bCerrar1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lContador = New System.Windows.Forms.Label
        Me.bSumar1 = New System.Windows.Forms.Button
        Me.bForm2 = New System.Windows.Forms.Button
        Me.bModal = New System.Windows.Forms.Button
        Me.bCerrar1 = New System.Windows.Forms.Button
        Me.bCursiva = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lContador
        '
        Me.lContador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lContador.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lContador.ForeColor = System.Drawing.Color.Red
        Me.lContador.Location = New System.Drawing.Point(64, 24)
        Me.lContador.Name = "lContador"
        Me.lContador.Size = New System.Drawing.Size(112, 40)
        Me.lContador.TabIndex = 0
        Me.lContador.Text = "0"
        Me.lContador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bSumar1
        '
        Me.bSumar1.Location = New System.Drawing.Point(32, 96)
        Me.bSumar1.Name = "bSumar1"
        Me.bSumar1.Size = New System.Drawing.Size(208, 23)
        Me.bSumar1.TabIndex = 1
        Me.bSumar1.Text = "Sumar 1"
        '
        'bForm2
        '
        Me.bForm2.Location = New System.Drawing.Point(16, 144)
        Me.bForm2.Name = "bForm2"
        Me.bForm2.Size = New System.Drawing.Size(120, 23)
        Me.bForm2.TabIndex = 2
        Me.bForm2.Text = "Mostar Formulario 2"
        '
        'bModal
        '
        Me.bModal.Location = New System.Drawing.Point(160, 144)
        Me.bModal.Name = "bModal"
        Me.bModal.Size = New System.Drawing.Size(96, 23)
        Me.bModal.TabIndex = 3
        Me.bModal.Text = "Mostrar Modal"
        '
        'bCerrar1
        '
        Me.bCerrar1.Location = New System.Drawing.Point(80, 192)
        Me.bCerrar1.Name = "bCerrar1"
        Me.bCerrar1.Size = New System.Drawing.Size(112, 32)
        Me.bCerrar1.TabIndex = 4
        Me.bCerrar1.Text = "Cerrar Aplicación"
        '
        'bCursiva
        '
        Me.bCursiva.Location = New System.Drawing.Point(200, 48)
        Me.bCursiva.Name = "bCursiva"
        Me.bCursiva.TabIndex = 5
        Me.bCursiva.Text = "Cursiva"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.bCursiva)
        Me.Controls.Add(Me.bCerrar1)
        Me.Controls.Add(Me.bModal)
        Me.Controls.Add(Me.bForm2)
        Me.Controls.Add(Me.bSumar1)
        Me.Controls.Add(Me.lContador)
        Me.Name = "Form1"
        Me.Text = "Formulario 1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub bCerrar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCerrar1.Click
        End
    End Sub

    Private Sub bSumar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSumar1.Click
        lContador.Text = lContador.Text + 1
    End Sub

    Private Sub bCursiva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCursiva.Click
        Dim fuente As Font
        Dim estilo As FontStyle
        Static click As Boolean
        fuente = lContador.Font
        If Not click Then
            bCursiva.Text = "Normal"
            lContador.Font = New Font(fuente, FontStyle.Italic)
        Else : bCursiva.Text = "Cursiva"
            lContador.Font = New Font(fuente, FontStyle.Regular)
        End If
        click = Not click
    End Sub

    Private Sub bForm2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bForm2.Click
        Dim form2 As New Form2
        form2.Show()
    End Sub

    Private Sub bModal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bModal.Click
        Dim form2 As New Form2
        form2.ShowDialog()
    End Sub

End Class
