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
    Friend WithEvents bBorrar As System.Windows.Forms.Button
    Friend WithEvents lbLista As System.Windows.Forms.ListBox
    Friend WithEvents eNuevoTexto As System.Windows.Forms.TextBox
    Friend WithEvents bAnadir As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lbLista = New System.Windows.Forms.ListBox
        Me.eNuevoTexto = New System.Windows.Forms.TextBox
        Me.bAnadir = New System.Windows.Forms.Button
        Me.bBorrar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lbLista
        '
        Me.lbLista.Location = New System.Drawing.Point(24, 56)
        Me.lbLista.Name = "lbLista"
        Me.lbLista.Size = New System.Drawing.Size(153, 134)
        Me.lbLista.TabIndex = 1
        '
        'eNuevoTexto
        '
        Me.eNuevoTexto.AcceptsReturn = True
        Me.eNuevoTexto.Location = New System.Drawing.Point(24, 16)
        Me.eNuevoTexto.Name = "eNuevoTexto"
        Me.eNuevoTexto.Size = New System.Drawing.Size(153, 20)
        Me.eNuevoTexto.TabIndex = 0
        Me.eNuevoTexto.Text = ""
        '
        'bAnadir
        '
        Me.bAnadir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAnadir.Location = New System.Drawing.Point(208, 16)
        Me.bAnadir.Name = "bAnadir"
        Me.bAnadir.Size = New System.Drawing.Size(89, 41)
        Me.bAnadir.TabIndex = 2
        Me.bAnadir.Text = "&Añadir"
        '
        'bBorrar
        '
        Me.bBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBorrar.Location = New System.Drawing.Point(208, 64)
        Me.bBorrar.Name = "bBorrar"
        Me.bBorrar.Size = New System.Drawing.Size(89, 41)
        Me.bBorrar.TabIndex = 3
        Me.bBorrar.Text = "&Borrar"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(328, 266)
        Me.Controls.Add(Me.bBorrar)
        Me.Controls.Add(Me.bAnadir)
        Me.Controls.Add(Me.eNuevoTexto)
        Me.Controls.Add(Me.lbLista)
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "Form1"
        Me.Text = "Programa1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub bAnadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAnadir.Click
        lbLista.Items.Add(eNuevoTexto.Text)
    End Sub

    Private Sub bBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bBorrar.Click
        If lbLista.SelectedIndex <> -1 Then
            lbLista.Items.RemoveAt(lbLista.SelectedIndex)
        End If
    End Sub
End Class
