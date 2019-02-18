Public Class Formulario_Hijo
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
    Friend WithEvents eEditor As System.Windows.Forms.RichTextBox
    Friend WithEvents mnContexto As System.Windows.Forms.ContextMenu
    Friend WithEvents mnCortar As System.Windows.Forms.MenuItem
    Friend WithEvents mnCopiar As System.Windows.Forms.MenuItem
    Friend WithEvents mnPegar As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.eEditor = New System.Windows.Forms.RichTextBox
        Me.mnContexto = New System.Windows.Forms.ContextMenu
        Me.mnCortar = New System.Windows.Forms.MenuItem
        Me.mnCopiar = New System.Windows.Forms.MenuItem
        Me.mnPegar = New System.Windows.Forms.MenuItem
        Me.SuspendLayout()
        '
        'eEditor
        '
        Me.eEditor.AcceptsTab = True
        Me.eEditor.ContextMenu = Me.mnContexto
        Me.eEditor.Location = New System.Drawing.Point(0, 0)
        Me.eEditor.Name = "eEditor"
        Me.eEditor.ShowSelectionMargin = True
        Me.eEditor.Size = New System.Drawing.Size(256, 232)
        Me.eEditor.TabIndex = 0
        Me.eEditor.Text = ""
        '
        'mnContexto
        '
        Me.mnContexto.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnCortar, Me.mnCopiar, Me.mnPegar})
        '
        'mnCortar
        '
        Me.mnCortar.Index = 0
        Me.mnCortar.Shortcut = System.Windows.Forms.Shortcut.CtrlX
        Me.mnCortar.Text = "&Cortar"
        '
        'mnCopiar
        '
        Me.mnCopiar.Index = 1
        Me.mnCopiar.Shortcut = System.Windows.Forms.Shortcut.CtrlC
        Me.mnCopiar.Text = "Co&piar"
        '
        'mnPegar
        '
        Me.mnPegar.Index = 2
        Me.mnPegar.Shortcut = System.Windows.Forms.Shortcut.CtrlV
        Me.mnPegar.Text = "&Pegar"
        '
        'Formulario_Hijo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(256, 230)
        Me.Controls.Add(Me.eEditor)
        Me.Name = "Formulario_Hijo"
        Me.ShowInTaskbar = False
        Me.Text = "Nuevo Documento"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Formulario_Hijo_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        eEditor.Width = Me.Width - 8
        eEditor.Height = Me.Height - 32
    End Sub

    Private Sub Formulario_Hijo_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        contador_documentos = contador_documentos - 1
        Actualizar_Menu()
        Documento(Me.Tag).Dispose()
    End Sub

    Private Sub mnCopiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnCopiar.Click
        On Error Resume Next
        Clipboard.SetDataObject(Me.eEditor.SelectedRtf, True)
    End Sub

    Private Sub mnPegar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnPegar.Click
        Dim datos_en_portapapeles As IDataObject
        On Error Resume Next
        datos_en_portapapeles = Clipboard.GetDataObject()
        If datos_en_portapapeles.GetDataPresent(DataFormats.Text) Then
            Me.eEditor.SelectedRtf = datos_en_portapapeles.GetData(DataFormats.Text, True)
        End If
    End Sub

    Private Sub mnCortar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnCortar.Click
        On Error Resume Next
        Clipboard.SetDataObject(Me.eEditor.SelectedRtf, True)
        Me.eEditor.SelectedRtf = ""
    End Sub
End Class
