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
    Friend WithEvents lNumero1 As System.Windows.Forms.Label
    Friend WithEvents lNumero2 As System.Windows.Forms.Label
    Friend WithEvents lNumero3 As System.Windows.Forms.Label
    Friend WithEvents lMensaje As System.Windows.Forms.Label
    Friend WithEvents bJugar As System.Windows.Forms.Button
    Friend WithEvents bTerminar As System.Windows.Forms.Button
    Friend WithEvents pImagen As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.lNumero1 = New System.Windows.Forms.Label
        Me.lNumero2 = New System.Windows.Forms.Label
        Me.lNumero3 = New System.Windows.Forms.Label
        Me.lMensaje = New System.Windows.Forms.Label
        Me.bJugar = New System.Windows.Forms.Button
        Me.bTerminar = New System.Windows.Forms.Button
        Me.pImagen = New System.Windows.Forms.PictureBox
        Me.SuspendLayout()
        '
        'lNumero1
        '
        Me.lNumero1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lNumero1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNumero1.Location = New System.Drawing.Point(24, 24)
        Me.lNumero1.Name = "lNumero1"
        Me.lNumero1.Size = New System.Drawing.Size(88, 64)
        Me.lNumero1.TabIndex = 2
        Me.lNumero1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lNumero2
        '
        Me.lNumero2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lNumero2.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNumero2.Location = New System.Drawing.Point(128, 24)
        Me.lNumero2.Name = "lNumero2"
        Me.lNumero2.Size = New System.Drawing.Size(88, 64)
        Me.lNumero2.TabIndex = 3
        Me.lNumero2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lNumero3
        '
        Me.lNumero3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lNumero3.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNumero3.Location = New System.Drawing.Point(232, 24)
        Me.lNumero3.Name = "lNumero3"
        Me.lNumero3.Size = New System.Drawing.Size(88, 64)
        Me.lNumero3.TabIndex = 4
        Me.lNumero3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lMensaje
        '
        Me.lMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lMensaje.ForeColor = System.Drawing.Color.Red
        Me.lMensaje.Location = New System.Drawing.Point(40, 112)
        Me.lMensaje.Name = "lMensaje"
        Me.lMensaje.Size = New System.Drawing.Size(256, 24)
        Me.lMensaje.TabIndex = 6
        Me.lMensaje.Text = "Siete Afortunado"
        Me.lMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bJugar
        '
        Me.bJugar.Location = New System.Drawing.Point(40, 152)
        Me.bJugar.Name = "bJugar"
        Me.bJugar.Size = New System.Drawing.Size(88, 32)
        Me.bJugar.TabIndex = 0
        Me.bJugar.Text = "&Jugar"
        '
        'bTerminar
        '
        Me.bTerminar.Location = New System.Drawing.Point(192, 152)
        Me.bTerminar.Name = "bTerminar"
        Me.bTerminar.Size = New System.Drawing.Size(88, 32)
        Me.bTerminar.TabIndex = 1
        Me.bTerminar.Text = "&Terminar"
        '
        'pImagen
        '
        Me.pImagen.Image = CType(resources.GetObject("pImagen.Image"), System.Drawing.Image)
        Me.pImagen.Location = New System.Drawing.Point(336, 0)
        Me.pImagen.Name = "pImagen"
        Me.pImagen.Size = New System.Drawing.Size(168, 200)
        Me.pImagen.TabIndex = 6
        Me.pImagen.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(536, 230)
        Me.Controls.Add(Me.pImagen)
        Me.Controls.Add(Me.bTerminar)
        Me.Controls.Add(Me.bJugar)
        Me.Controls.Add(Me.lMensaje)
        Me.Controls.Add(Me.lNumero3)
        Me.Controls.Add(Me.lNumero2)
        Me.Controls.Add(Me.lNumero1)
        Me.Name = "Form1"
        Me.Text = "Juego del Siete Afortunado"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub bTerminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bTerminar.Click
        End
    End Sub

    Private Sub bJugar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bJugar.Click
        pImagen.Visible = False
        lNumero1.Text = CStr(Int(Rnd() * 10))
        lNumero2.Text = CStr(Int(Rnd() * 10))
        lNumero3.Text = CStr(Int(Rnd() * 10))
        If (lNumero1.Text = "7") Or (lNumero2.Text = "7") Or (lNumero3.Text = "7") Then
            pImagen.Visible = True
            Dim SoundInst As New SoundClass
            SoundInst.PlaySoundFile("APPLAUSE.WAV")
        End If
    End Sub
End Class
