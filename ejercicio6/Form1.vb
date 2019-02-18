Public Class Formulario_Padre
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Shared Formulario_Padre_Ref As Formulario_Padre

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        Formulario_Padre_Ref = Me

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
    Friend WithEvents mnMenuPrincipal As System.Windows.Forms.MainMenu
    Friend WithEvents mnFichero As System.Windows.Forms.MenuItem
    Friend WithEvents mnEdicion As System.Windows.Forms.MenuItem
    Friend WithEvents mnFormato As System.Windows.Forms.MenuItem
    Friend WithEvents mnVentana As System.Windows.Forms.MenuItem
    Friend WithEvents mnAyuda As System.Windows.Forms.MenuItem
    Friend WithEvents mnNuevo As System.Windows.Forms.MenuItem
    Friend WithEvents mnAbrir As System.Windows.Forms.MenuItem
    Friend WithEvents mnGuardar As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents mnSalir As System.Windows.Forms.MenuItem
    Friend WithEvents mnCopiar As System.Windows.Forms.MenuItem
    Friend WithEvents mnPegar As System.Windows.Forms.MenuItem
    Friend WithEvents mnCortar As System.Windows.Forms.MenuItem
    Friend WithEvents mnAlineacion As System.Windows.Forms.MenuItem
    Friend WithEvents mnIzquierda As System.Windows.Forms.MenuItem
    Friend WithEvents mnDerecha As System.Windows.Forms.MenuItem
    Friend WithEvents mnCentrada As System.Windows.Forms.MenuItem
    Friend WithEvents mnFuente As System.Windows.Forms.MenuItem
    Friend WithEvents mnColorFondo As System.Windows.Forms.MenuItem
    Friend WithEvents mnColorFuente As System.Windows.Forms.MenuItem
    Friend WithEvents mnMosaicoHorizontal As System.Windows.Forms.MenuItem
    Friend WithEvents mnMosaicoVertical As System.Windows.Forms.MenuItem
    Friend WithEvents mnCascada As System.Windows.Forms.MenuItem
    Friend WithEvents mnOrganizarIconos As System.Windows.Forms.MenuItem
    Friend WithEvents dAbrir As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dGuardar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents dColor As System.Windows.Forms.ColorDialog
    Friend WithEvents dFuente As System.Windows.Forms.FontDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.mnMenuPrincipal = New System.Windows.Forms.MainMenu
        Me.mnFichero = New System.Windows.Forms.MenuItem
        Me.mnNuevo = New System.Windows.Forms.MenuItem
        Me.mnAbrir = New System.Windows.Forms.MenuItem
        Me.mnGuardar = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.mnSalir = New System.Windows.Forms.MenuItem
        Me.mnEdicion = New System.Windows.Forms.MenuItem
        Me.mnCortar = New System.Windows.Forms.MenuItem
        Me.mnCopiar = New System.Windows.Forms.MenuItem
        Me.mnPegar = New System.Windows.Forms.MenuItem
        Me.mnFormato = New System.Windows.Forms.MenuItem
        Me.mnAlineacion = New System.Windows.Forms.MenuItem
        Me.mnIzquierda = New System.Windows.Forms.MenuItem
        Me.mnDerecha = New System.Windows.Forms.MenuItem
        Me.mnCentrada = New System.Windows.Forms.MenuItem
        Me.mnFuente = New System.Windows.Forms.MenuItem
        Me.mnColorFondo = New System.Windows.Forms.MenuItem
        Me.mnColorFuente = New System.Windows.Forms.MenuItem
        Me.mnVentana = New System.Windows.Forms.MenuItem
        Me.mnMosaicoHorizontal = New System.Windows.Forms.MenuItem
        Me.mnMosaicoVertical = New System.Windows.Forms.MenuItem
        Me.mnCascada = New System.Windows.Forms.MenuItem
        Me.mnOrganizarIconos = New System.Windows.Forms.MenuItem
        Me.mnAyuda = New System.Windows.Forms.MenuItem
        Me.dAbrir = New System.Windows.Forms.OpenFileDialog
        Me.dGuardar = New System.Windows.Forms.SaveFileDialog
        Me.dColor = New System.Windows.Forms.ColorDialog
        Me.dFuente = New System.Windows.Forms.FontDialog
        '
        'mnMenuPrincipal
        '
        Me.mnMenuPrincipal.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnFichero, Me.mnEdicion, Me.mnFormato, Me.mnVentana, Me.mnAyuda})
        '
        'mnFichero
        '
        Me.mnFichero.Index = 0
        Me.mnFichero.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnNuevo, Me.mnAbrir, Me.mnGuardar, Me.MenuItem3, Me.mnSalir})
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
        'MenuItem3
        '
        Me.MenuItem3.Index = 3
        Me.MenuItem3.Text = "-"
        '
        'mnSalir
        '
        Me.mnSalir.Index = 4
        Me.mnSalir.Text = "&Salir"
        '
        'mnEdicion
        '
        Me.mnEdicion.Index = 1
        Me.mnEdicion.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnCortar, Me.mnCopiar, Me.mnPegar})
        Me.mnEdicion.Text = "&Edición"
        '
        'mnCortar
        '
        Me.mnCortar.Index = 0
        Me.mnCortar.Text = "&Cortar"
        '
        'mnCopiar
        '
        Me.mnCopiar.Index = 1
        Me.mnCopiar.Text = "Co&piar"
        '
        'mnPegar
        '
        Me.mnPegar.Index = 2
        Me.mnPegar.Text = "&Pegar"
        '
        'mnFormato
        '
        Me.mnFormato.Index = 2
        Me.mnFormato.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnAlineacion, Me.mnFuente, Me.mnColorFondo, Me.mnColorFuente})
        Me.mnFormato.Text = "F&ormato"
        '
        'mnAlineacion
        '
        Me.mnAlineacion.Index = 0
        Me.mnAlineacion.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnIzquierda, Me.mnDerecha, Me.mnCentrada})
        Me.mnAlineacion.Text = "&Alineación"
        '
        'mnIzquierda
        '
        Me.mnIzquierda.Checked = True
        Me.mnIzquierda.Index = 0
        Me.mnIzquierda.Text = "&Izquierda"
        '
        'mnDerecha
        '
        Me.mnDerecha.Index = 1
        Me.mnDerecha.Text = "&Derecha"
        '
        'mnCentrada
        '
        Me.mnCentrada.Index = 2
        Me.mnCentrada.Text = "&Centrada"
        '
        'mnFuente
        '
        Me.mnFuente.Index = 1
        Me.mnFuente.Text = "&Fuente"
        '
        'mnColorFondo
        '
        Me.mnColorFondo.Index = 2
        Me.mnColorFondo.Text = "&Color de fondo"
        '
        'mnColorFuente
        '
        Me.mnColorFuente.Index = 3
        Me.mnColorFuente.Text = "C&olor de fuente"
        '
        'mnVentana
        '
        Me.mnVentana.Index = 3
        Me.mnVentana.MdiList = True
        Me.mnVentana.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnMosaicoHorizontal, Me.mnMosaicoVertical, Me.mnCascada, Me.mnOrganizarIconos})
        Me.mnVentana.Text = "&Ventana"
        '
        'mnMosaicoHorizontal
        '
        Me.mnMosaicoHorizontal.Index = 0
        Me.mnMosaicoHorizontal.Text = "&Mosaico Horizontal"
        '
        'mnMosaicoVertical
        '
        Me.mnMosaicoVertical.Index = 1
        Me.mnMosaicoVertical.Text = "M&osaico Vertical"
        '
        'mnCascada
        '
        Me.mnCascada.Index = 2
        Me.mnCascada.Text = "&Cascada"
        '
        'mnOrganizarIconos
        '
        Me.mnOrganizarIconos.Index = 3
        Me.mnOrganizarIconos.Text = "&Organizar iconos"
        '
        'mnAyuda
        '
        Me.mnAyuda.Index = 4
        Me.mnAyuda.Text = "&Ayuda"
        '
        'dAbrir
        '
        Me.dAbrir.Filter = "Texto|*.txt|Texto enriquecido|*.rtf|Todos los archivos|*.*"
        Me.dAbrir.Title = "Abrir documento"
        '
        'dGuardar
        '
        Me.dGuardar.Filter = "Texto|*.txt|Texto enriquecido|*.rtf|Todos los archivos|*.*"
        Me.dGuardar.Title = "Guardar documento"
        '
        'Formulario_Padre
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(480, 306)
        Me.IsMdiContainer = True
        Me.Menu = Me.mnMenuPrincipal
        Me.Name = "Formulario_Padre"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editor de texto"

    End Sub

#End Region

    Private Sub mnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnNuevo.Click
        Documento(contador_documentos) = New Formulario_Hijo
        Documento(contador_documentos).MdiParent = Me
        Documento(contador_documentos).Tag = contador_documentos
        contador_nuevos = contador_nuevos + 1
        Documento(contador_documentos).Text = "Nuevo Documento " & CStr(contador_nuevos)
        Documento(contador_documentos).Show()
        contador_documentos = contador_documentos + 1
        Actualizar_Menu()
    End Sub

    Private Sub mnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnSalir.Click
        End
    End Sub

    Private Sub Formulario_Padre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Actualizar_Menu()
        dAbrir.InitialDirectory = System.Environment.CurrentDirectory
        dGuardar.InitialDirectory = System.Environment.CurrentDirectory
    End Sub

    Private Sub mnAbrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnAbrir.Click
        dAbrir.ShowDialog()
        If dAbrir.FileName <> "" Then
            Documento(contador_documentos) = New Formulario_Hijo
            Documento(contador_documentos).MdiParent = Me
            Documento(contador_documentos).Tag = contador_documentos
            Documento(contador_documentos).Text = dAbrir.FileName
            Try
                Documento(contador_documentos).eEditor.LoadFile(dAbrir.FileName)
                Documento(contador_documentos).Show()
                contador_documentos = contador_documentos + 1
                Actualizar_Menu()
            Catch
                Documento(contador_documentos).Dispose()
                MsgBox("Error al abrir el documento", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, "Error")
            End Try
        End If
    End Sub

    Private Sub mnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnGuardar.Click
        dGuardar.ShowDialog()
        If dGuardar.FileName <> "" Then
            Documento(ActiveMdiChild.Tag).eEditor.SaveFile(dGuardar.FileName)
        End If
    End Sub

    Private Sub mnMosaicoHorizontal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnMosaicoHorizontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub mnMosaicoVertical_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnMosaicoVertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub mnCascada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnCascada.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub mnOrganizarIconos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnOrganizarIconos.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub Formulario_Padre_Closing(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If MsgBox("¿Realmente quiere salir del editor de texto?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.SystemModal, "Cerrar aplicación") = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub mnIzquierda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnIzquierda.Click
        Documento(ActiveMdiChild.Tag).eEditor.SelectionAlignment = HorizontalAlignment.Left
        mnIzquierda.Checked = True
        mnDerecha.Checked = False
        mnCentrada.Checked = False
    End Sub

    Private Sub mnDerecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnDerecha.Click
        Documento(ActiveMdiChild.Tag).eEditor.SelectionAlignment = HorizontalAlignment.Right
        mnIzquierda.Checked = False
        mnDerecha.Checked = True
        mnCentrada.Checked = False
    End Sub

    Private Sub mnCentrada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnCentrada.Click
        Documento(ActiveMdiChild.Tag).eEditor.SelectionAlignment = HorizontalAlignment.Center
        mnIzquierda.Checked = False
        mnDerecha.Checked = False
        mnCentrada.Checked = True
    End Sub

    Private Sub mnFuente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnFuente.Click
        dFuente.ShowDialog()
        Documento(ActiveMdiChild.Tag).eEditor.SelectionFont = dFuente.Font
    End Sub

    Private Sub mnColorFondo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnColorFondo.Click
        dColor.ShowDialog()
        Documento(ActiveMdiChild.Tag).eEditor.BackColor = dColor.Color
    End Sub

    Private Sub mnColorFuente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnColorFuente.Click
        dColor.ShowDialog()
        Documento(ActiveMdiChild.Tag).eEditor.SelectionColor = dColor.Color
    End Sub

    Private Sub mnAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnAyuda.Click
        MsgBox("Ejercicio 6: Editor múltiple de texto enriquecido" & vbCrLf & "utilizando formularios MDI", MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "Acerca del editor de texto")
    End Sub

    Private Sub mnCopiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnCopiar.Click
        On Error Resume Next
        Clipboard.SetDataObject(Documento(ActiveMdiChild.Tag).eEditor.SelectedRtf, True)
    End Sub

    Private Sub mnPegar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnPegar.Click
        Dim datos_en_portapapeles As IDataObject
        On Error Resume Next
        datos_en_portapapeles = Clipboard.GetDataObject()
        If datos_en_portapapeles.GetDataPresent(DataFormats.Text) Then
            Documento(ActiveMdiChild.Tag).eEditor.SelectedRtf = datos_en_portapapeles.GetData(DataFormats.Text, True)
        End If
    End Sub

    Private Sub mnCortar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnCortar.Click
        On Error Resume Next
        Clipboard.SetDataObject(Documento(ActiveMdiChild.Tag).eEditor.SelectedRtf, True)
        Documento(ActiveMdiChild.Tag).eEditor.SelectedRtf = ""
    End Sub
End Class
