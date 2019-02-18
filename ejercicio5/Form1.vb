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
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents mnFichero As System.Windows.Forms.MenuItem
    Friend WithEvents mnNuevo As System.Windows.Forms.MenuItem
    Friend WithEvents mnAbrir As System.Windows.Forms.MenuItem
    Friend WithEvents mnGuardar As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents mnAcercaDe As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents mnSalir As System.Windows.Forms.MenuItem
    Friend WithEvents pPizarra As System.Windows.Forms.PictureBox
    Friend WithEvents hsTamano As System.Windows.Forms.HScrollBar
    Friend WithEvents lTamano As System.Windows.Forms.Label
    Friend WithEvents lNumero As System.Windows.Forms.Label
    Friend WithEvents lRelleno As System.Windows.Forms.Label
    Friend WithEvents lHerramientas As System.Windows.Forms.Label
    Friend WithEvents lstHerramientas As System.Windows.Forms.ListBox
    Friend WithEvents pColor As System.Windows.Forms.PictureBox
    Friend WithEvents dAbrir As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dGuardar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents lTextoMuestra As System.Windows.Forms.Label
    Friend WithEvents lMuestra As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.mnFichero = New System.Windows.Forms.MenuItem
        Me.mnNuevo = New System.Windows.Forms.MenuItem
        Me.mnAbrir = New System.Windows.Forms.MenuItem
        Me.mnGuardar = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.mnAcercaDe = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.mnSalir = New System.Windows.Forms.MenuItem
        Me.pPizarra = New System.Windows.Forms.PictureBox
        Me.lTamano = New System.Windows.Forms.Label
        Me.lNumero = New System.Windows.Forms.Label
        Me.hsTamano = New System.Windows.Forms.HScrollBar
        Me.lRelleno = New System.Windows.Forms.Label
        Me.lTextoMuestra = New System.Windows.Forms.Label
        Me.lMuestra = New System.Windows.Forms.Label
        Me.lHerramientas = New System.Windows.Forms.Label
        Me.lstHerramientas = New System.Windows.Forms.ListBox
        Me.pColor = New System.Windows.Forms.PictureBox
        Me.dAbrir = New System.Windows.Forms.OpenFileDialog
        Me.dGuardar = New System.Windows.Forms.SaveFileDialog
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnFichero})
        '
        'mnFichero
        '
        Me.mnFichero.Index = 0
        Me.mnFichero.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnNuevo, Me.mnAbrir, Me.mnGuardar, Me.MenuItem5, Me.mnAcercaDe, Me.MenuItem7, Me.mnSalir})
        Me.mnFichero.Text = "&Fichero"
        '
        'mnNuevo
        '
        Me.mnNuevo.Index = 0
        Me.mnNuevo.Text = "&Nuevo"
        '
        'mnAbrir
        '
        Me.mnAbrir.Index = 1
        Me.mnAbrir.Text = "&Abrir"
        '
        'mnGuardar
        '
        Me.mnGuardar.Index = 2
        Me.mnGuardar.Text = "&Guardar"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 3
        Me.MenuItem5.Text = "-"
        '
        'mnAcercaDe
        '
        Me.mnAcercaDe.Index = 4
        Me.mnAcercaDe.Text = "Acerca &de"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 5
        Me.MenuItem7.Text = "-"
        '
        'mnSalir
        '
        Me.mnSalir.Index = 6
        Me.mnSalir.Shortcut = System.Windows.Forms.Shortcut.CtrlS
        Me.mnSalir.Text = "&Salir"
        '
        'pPizarra
        '
        Me.pPizarra.BackColor = System.Drawing.Color.Gray
        Me.pPizarra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pPizarra.Location = New System.Drawing.Point(8, 8)
        Me.pPizarra.Name = "pPizarra"
        Me.pPizarra.Size = New System.Drawing.Size(328, 328)
        Me.pPizarra.TabIndex = 0
        Me.pPizarra.TabStop = False
        '
        'lTamano
        '
        Me.lTamano.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTamano.Location = New System.Drawing.Point(352, 14)
        Me.lTamano.Name = "lTamano"
        Me.lTamano.Size = New System.Drawing.Size(104, 24)
        Me.lTamano.TabIndex = 8
        Me.lTamano.Text = "Tamaño del pincel"
        '
        'lNumero
        '
        Me.lNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNumero.Location = New System.Drawing.Point(464, 10)
        Me.lNumero.Name = "lNumero"
        Me.lNumero.Size = New System.Drawing.Size(32, 24)
        Me.lNumero.TabIndex = 9
        Me.lNumero.Text = "4"
        Me.lNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hsTamano
        '
        Me.hsTamano.LargeChange = 1
        Me.hsTamano.Location = New System.Drawing.Point(360, 32)
        Me.hsTamano.Maximum = 26
        Me.hsTamano.Minimum = 1
        Me.hsTamano.Name = "hsTamano"
        Me.hsTamano.Size = New System.Drawing.Size(136, 16)
        Me.hsTamano.TabIndex = 7
        Me.hsTamano.Value = 4
        '
        'lRelleno
        '
        Me.lRelleno.Location = New System.Drawing.Point(355, 64)
        Me.lRelleno.Name = "lRelleno"
        Me.lRelleno.Size = New System.Drawing.Size(181, 24)
        Me.lRelleno.TabIndex = 2
        Me.lRelleno.Text = "Pulsa para elegir el color de relleno"
        '
        'lTextoMuestra
        '
        Me.lTextoMuestra.Location = New System.Drawing.Point(360, 168)
        Me.lTextoMuestra.Name = "lTextoMuestra"
        Me.lTextoMuestra.Size = New System.Drawing.Size(160, 24)
        Me.lTextoMuestra.TabIndex = 6
        Me.lTextoMuestra.Text = "Muestra"
        '
        'lMuestra
        '
        Me.lMuestra.BackColor = System.Drawing.Color.Black
        Me.lMuestra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lMuestra.ForeColor = System.Drawing.Color.White
        Me.lMuestra.Location = New System.Drawing.Point(360, 184)
        Me.lMuestra.Name = "lMuestra"
        Me.lMuestra.Size = New System.Drawing.Size(144, 32)
        Me.lMuestra.TabIndex = 5
        '
        'lHerramientas
        '
        Me.lHerramientas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lHerramientas.ForeColor = System.Drawing.Color.Blue
        Me.lHerramientas.Location = New System.Drawing.Point(368, 224)
        Me.lHerramientas.Name = "lHerramientas"
        Me.lHerramientas.Size = New System.Drawing.Size(96, 24)
        Me.lHerramientas.TabIndex = 4
        Me.lHerramientas.Text = "Herramientas"
        '
        'lstHerramientas
        '
        Me.lstHerramientas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstHerramientas.ItemHeight = 16
        Me.lstHerramientas.Items.AddRange(New Object() {"Pincel", "Círculo", "Rellenar", "Capturar color", "Limpiar pizarra"})
        Me.lstHerramientas.Location = New System.Drawing.Point(368, 248)
        Me.lstHerramientas.Name = "lstHerramientas"
        Me.lstHerramientas.Size = New System.Drawing.Size(112, 84)
        Me.lstHerramientas.TabIndex = 3
        '
        'pColor
        '
        Me.pColor.Image = CType(resources.GetObject("pColor.Image"), System.Drawing.Image)
        Me.pColor.Location = New System.Drawing.Point(360, 80)
        Me.pColor.Name = "pColor"
        Me.pColor.Size = New System.Drawing.Size(142, 74)
        Me.pColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pColor.TabIndex = 10
        Me.pColor.TabStop = False
        '
        'dAbrir
        '
        Me.dAbrir.Filter = "Ficheros de mapa de bits bmp|*.bmp|Fichero jpg|*.jpg|Todos los archivos|*.*"
        Me.dAbrir.InitialDirectory = "..\"
        Me.dAbrir.Title = "Abrir fichero de imagen"
        '
        'dGuardar
        '
        Me.dGuardar.Filter = "Ficheros de mapa de bits bmp|*.bmp|Fichero jpg|*.jpg|Todos los archivos|*.*"
        Me.dGuardar.InitialDirectory = "..\"
        Me.dGuardar.Title = "Guardar fichero de imagen"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(584, 353)
        Me.Controls.Add(Me.pColor)
        Me.Controls.Add(Me.lstHerramientas)
        Me.Controls.Add(Me.lHerramientas)
        Me.Controls.Add(Me.lMuestra)
        Me.Controls.Add(Me.lTextoMuestra)
        Me.Controls.Add(Me.lRelleno)
        Me.Controls.Add(Me.hsTamano)
        Me.Controls.Add(Me.lNumero)
        Me.Controls.Add(Me.lTamano)
        Me.Controls.Add(Me.pPizarra)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.MainMenu1
        Me.Name = "Form1"
        Me.Text = "Programa de dibujo"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim herramienta As Integer = 0
    Dim radio As Integer = 0
    Dim radio_pincel As Integer = 4
    Dim imagen_degradado As Bitmap
    Dim imagen_pizarra As Bitmap
    Dim graficos_pizarra As Graphics
    Dim graficos_pizarra_temp As Graphics
    Dim presionado_pizarra As Boolean = False
    Dim presionado_color As Boolean = False
    Dim lupa As New Cursor("..\LUPA.ICO")
    Dim pincel As New Cursor("..\PINCEL.ICO")
    Dim relleno As New Cursor("..\RELLENO.ICO")

    Private Sub hsTamano_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles hsTamano.Scroll
        lNumero.Text = hsTamano.Value
        radio_pincel = hsTamano.Value
    End Sub

    Private Sub pPizarra_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pPizarra.MouseDown
        Select Case herramienta
            Case 0 ' Pincel
                presionado_pizarra = True
                Dim color_relleno As New System.Drawing.SolidBrush(lMuestra.BackColor)
                graficos_pizarra.FillEllipse(color_relleno, e.X - radio_pincel, e.Y - radio_pincel, radio_pincel, radio_pincel)
                graficos_pizarra_temp.FillEllipse(color_relleno, e.X - radio_pincel, e.Y - radio_pincel, radio_pincel, radio_pincel)
                color_relleno.Dispose()
            Case 1 ' Circulo
                Dim circulo As New System.Drawing.Pen(lMuestra.BackColor)
                circulo.Width = hsTamano.Value
                graficos_pizarra.DrawEllipse(circulo, e.X - radio_pincel, e.Y - radio_pincel, radio * 2, radio * 2)
                graficos_pizarra_temp.DrawEllipse(circulo, e.X - radio_pincel, e.Y - radio_pincel, radio * 2, radio * 2)
                circulo.Dispose()
            Case 2 ' Rellenar
                Dim color_relleno As New System.Drawing.SolidBrush(lMuestra.BackColor)
                graficos_pizarra_temp.FillRectangle(color_relleno, 0, 0, imagen_pizarra.Width, imagen_pizarra.Height)
                pPizarra.Image = imagen_pizarra
                color_relleno.Dispose()
            Case 3 ' Capturar color
                presionado_pizarra = True
                On Error Resume Next
                lMuestra.BackColor = imagen_pizarra.GetPixel(e.X, e.Y)
            Case 4 ' Limpiar pizarra
                Dim color_relleno As New System.Drawing.SolidBrush(Color.White)
                graficos_pizarra_temp.FillRectangle(color_relleno, 0, 0, imagen_pizarra.Width, imagen_pizarra.Height)
                pPizarra.Image = imagen_pizarra
                color_relleno.Dispose()
        End Select
    End Sub

    Private Sub pPizarra_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pPizarra.MouseMove
        If presionado_pizarra Then
            Select Case herramienta
                Case 0 ' Pincel
                    Dim color_relleno As New System.Drawing.SolidBrush(lMuestra.BackColor)
                    graficos_pizarra.FillEllipse(color_relleno, e.X - radio_pincel, e.Y - radio_pincel, radio_pincel, radio_pincel)
                    graficos_pizarra_temp.FillEllipse(color_relleno, e.X - radio_pincel, e.Y - radio_pincel, radio_pincel, radio_pincel)
                    color_relleno.Dispose()
                Case 3 ' Capturar color
                    On Error Resume Next
                    lMuestra.BackColor = imagen_pizarra.GetPixel(e.X, e.Y)
            End Select
        End If
    End Sub

    Private Sub pPizarra_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pPizarra.MouseUp
        presionado_pizarra = False
        pPizarra.Image = imagen_pizarra
    End Sub

    Private Sub lstHerramientas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstHerramientas.SelectedIndexChanged
        herramienta = lstHerramientas.SelectedIndex
        Select Case herramienta
            Case 0 ' Pincel
                pPizarra.Cursor = pincel
            Case 1 ' Circulo
                pPizarra.Cursor = lupa
                Try
                    radio = CInt(InputBox("Introduzca el valor del radio del círculo en pixels", "Radio del círculo"))
                Catch
                    lstHerramientas.SelectedIndex = 0
                End Try
            Case 2 ' Rellenar
                pPizarra.Cursor = relleno
            Case 3 ' Capturar color
                pPizarra.Cursor = lupa
            Case 4 ' Limpiar pizarra
                pPizarra.Cursor = relleno
        End Select
    End Sub

    Private Sub pColor_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pColor.MouseDown
        presionado_color = True
        lMuestra.BackColor = imagen_degradado.GetPixel(e.X, e.Y)
    End Sub

    Private Sub pColor_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pColor.MouseUp
        presionado_color = False
    End Sub

    Private Sub pColor_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pColor.MouseMove
        If presionado_color Then
            On Error Resume Next
            lMuestra.BackColor = imagen_degradado.GetPixel(e.X, e.Y)
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstHerramientas.SelectedIndex = 0
        pColor.Cursor = lupa
        pPizarra.Cursor = pincel
        imagen_degradado = pColor.Image
        graficos_pizarra = Graphics.FromHwnd(pPizarra.Handle)
        imagen_pizarra = New Bitmap(pPizarra.Width, pPizarra.Height)
        graficos_pizarra_temp = Graphics.FromImage(imagen_pizarra)
        Dim color_relleno As New System.Drawing.SolidBrush(Color.White)
        pPizarra.CreateGraphics.Clear(Color.Gray)
        graficos_pizarra_temp.FillRectangle(color_relleno, 0, 0, pPizarra.Width, pPizarra.Height)
        pPizarra.Image = imagen_pizarra
        color_relleno.Dispose()
    End Sub

    Private Sub mnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnNuevo.Click
        imagen_pizarra.Dispose()
        imagen_pizarra = New Bitmap(pPizarra.Width, pPizarra.Height)
        graficos_pizarra_temp = Graphics.FromImage(imagen_pizarra)
        Dim color_relleno As New System.Drawing.SolidBrush(Color.White)
        pPizarra.CreateGraphics.Clear(Color.Gray)
        graficos_pizarra_temp.FillRectangle(color_relleno, 0, 0, pPizarra.Width, pPizarra.Height)
        pPizarra.Image = imagen_pizarra
        color_relleno.Dispose()
    End Sub

    Private Sub mnAbrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnAbrir.Click
        dAbrir.ShowDialog()
        If dAbrir.FileName <> "" Then
            imagen_pizarra.Dispose()
            imagen_pizarra = New Bitmap(dAbrir.FileName)
            graficos_pizarra_temp = Graphics.FromImage(imagen_pizarra)
            pPizarra.Image = imagen_pizarra
        End If
    End Sub

    Private Sub mnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnGuardar.Click
        dGuardar.ShowDialog()
        If dGuardar.FileName <> "" Then
            pPizarra.Image = imagen_pizarra
            pPizarra.Image.Save(dGuardar.FileName)
        End If
    End Sub

    Private Sub mnAcercaDe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnAcercaDe.Click
        Dim frm As New frmAbout
        frm.ShowDialog(Me)
        frm.Dispose()
    End Sub

    Private Sub mnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnSalir.Click
        End
    End Sub
End Class
