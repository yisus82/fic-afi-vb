Public Class fFormulario
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
    Friend WithEvents bEditar As System.Windows.Forms.Button
    Friend WithEvents eNombre As System.Windows.Forms.TextBox
    Friend WithEvents eApellidos As System.Windows.Forms.TextBox
    Friend WithEvents eDireccion As System.Windows.Forms.TextBox
    Friend WithEvents lNombre As System.Windows.Forms.Label
    Friend WithEvents lApellidos As System.Windows.Forms.Label
    Friend WithEvents lDireccion As System.Windows.Forms.Label
    Friend WithEvents bCancelar As System.Windows.Forms.Button
    Friend WithEvents bAceptar As System.Windows.Forms.Button
    Friend WithEvents bCerrar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.bEditar = New System.Windows.Forms.Button
        Me.eNombre = New System.Windows.Forms.TextBox
        Me.eApellidos = New System.Windows.Forms.TextBox
        Me.eDireccion = New System.Windows.Forms.TextBox
        Me.lNombre = New System.Windows.Forms.Label
        Me.lApellidos = New System.Windows.Forms.Label
        Me.lDireccion = New System.Windows.Forms.Label
        Me.bCancelar = New System.Windows.Forms.Button
        Me.bAceptar = New System.Windows.Forms.Button
        Me.bCerrar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'bEditar
        '
        Me.bEditar.Location = New System.Drawing.Point(136, 152)
        Me.bEditar.Name = "bEditar"
        Me.bEditar.Size = New System.Drawing.Size(81, 41)
        Me.bEditar.TabIndex = 8
        Me.bEditar.Text = "&Editar"
        '
        'eNombre
        '
        Me.eNombre.AutoSize = False
        Me.eNombre.Location = New System.Drawing.Point(8, 40)
        Me.eNombre.Name = "eNombre"
        Me.eNombre.ReadOnly = True
        Me.eNombre.Size = New System.Drawing.Size(177, 25)
        Me.eNombre.TabIndex = 3
        Me.eNombre.Text = ""
        '
        'eApellidos
        '
        Me.eApellidos.AutoSize = False
        Me.eApellidos.Location = New System.Drawing.Point(208, 40)
        Me.eApellidos.MaxLength = 0
        Me.eApellidos.Name = "eApellidos"
        Me.eApellidos.ReadOnly = True
        Me.eApellidos.Size = New System.Drawing.Size(297, 25)
        Me.eApellidos.TabIndex = 4
        Me.eApellidos.Text = ""
        '
        'eDireccion
        '
        Me.eDireccion.AcceptsReturn = True
        Me.eDireccion.AutoSize = False
        Me.eDireccion.Location = New System.Drawing.Point(8, 112)
        Me.eDireccion.MaxLength = 0
        Me.eDireccion.Name = "eDireccion"
        Me.eDireccion.ReadOnly = True
        Me.eDireccion.Size = New System.Drawing.Size(497, 25)
        Me.eDireccion.TabIndex = 5
        Me.eDireccion.Text = ""
        '
        'lNombre
        '
        Me.lNombre.Location = New System.Drawing.Point(16, 8)
        Me.lNombre.Name = "lNombre"
        Me.lNombre.Size = New System.Drawing.Size(113, 25)
        Me.lNombre.TabIndex = 0
        Me.lNombre.Text = "Nombre"
        '
        'lApellidos
        '
        Me.lApellidos.Location = New System.Drawing.Point(216, 8)
        Me.lApellidos.Name = "lApellidos"
        Me.lApellidos.Size = New System.Drawing.Size(113, 25)
        Me.lApellidos.TabIndex = 1
        Me.lApellidos.Text = "Apellidos"
        '
        'lDireccion
        '
        Me.lDireccion.Location = New System.Drawing.Point(16, 80)
        Me.lDireccion.Name = "lDireccion"
        Me.lDireccion.Size = New System.Drawing.Size(113, 25)
        Me.lDireccion.TabIndex = 2
        Me.lDireccion.Text = "Dirección"
        '
        'bCancelar
        '
        Me.bCancelar.Enabled = False
        Me.bCancelar.Location = New System.Drawing.Point(224, 152)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(81, 41)
        Me.bCancelar.TabIndex = 7
        Me.bCancelar.Text = "&Cancelar"
        '
        'bAceptar
        '
        Me.bAceptar.Enabled = False
        Me.bAceptar.Location = New System.Drawing.Point(312, 152)
        Me.bAceptar.Name = "bAceptar"
        Me.bAceptar.Size = New System.Drawing.Size(81, 41)
        Me.bAceptar.TabIndex = 6
        Me.bAceptar.Text = "&Aceptar"
        '
        'bCerrar
        '
        Me.bCerrar.Location = New System.Drawing.Point(424, 152)
        Me.bCerrar.Name = "bCerrar"
        Me.bCerrar.Size = New System.Drawing.Size(81, 41)
        Me.bCerrar.TabIndex = 9
        Me.bCerrar.Text = "Ce&rrar"
        '
        'fFormulario
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(520, 206)
        Me.Controls.Add(Me.bCerrar)
        Me.Controls.Add(Me.bAceptar)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.lDireccion)
        Me.Controls.Add(Me.lApellidos)
        Me.Controls.Add(Me.lNombre)
        Me.Controls.Add(Me.eDireccion)
        Me.Controls.Add(Me.eApellidos)
        Me.Controls.Add(Me.eNombre)
        Me.Controls.Add(Me.bEditar)
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "fFormulario"
        Me.Text = "Ejercicio 3"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim sNombre As String
    Dim sApellidos As String
    Dim sDireccion As String

    Sub datos_modificados()
        bAceptar.Enabled = Not bEditar.Enabled
    End Sub

    Private Sub bCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCerrar.Click
        End
    End Sub

    Private Sub bEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bEditar.Click
        bEditar.Enabled = False
        bCancelar.Enabled = True
        bAceptar.Enabled = False

        eNombre.Text = sNombre
        eApellidos.Text = sApellidos
        eDireccion.Text = sDireccion

        eNombre.Focus()

        eNombre.ReadOnly = bEditar.Enabled
        eApellidos.ReadOnly = bEditar.Enabled
        eDireccion.ReadOnly = bEditar.Enabled
    End Sub

    Private Sub bCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCancelar.Click
        bEditar.Enabled = True
        bCancelar.Enabled = False
        bAceptar.Enabled = False

        eNombre.Text = sNombre
        eApellidos.Text = sApellidos
        eDireccion.Text = sDireccion

        eNombre.ReadOnly = bEditar.Enabled
        eApellidos.ReadOnly = bEditar.Enabled
        eDireccion.ReadOnly = bEditar.Enabled
    End Sub

    Private Sub bAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAceptar.Click
        bEditar.Enabled = True
        bCancelar.Enabled = False
        bAceptar.Enabled = False

        sNombre = eNombre.Text
        sApellidos = eApellidos.Text
        sDireccion = eDireccion.Text

        eNombre.ReadOnly = bEditar.Enabled
        eApellidos.ReadOnly = bEditar.Enabled
        eDireccion.ReadOnly = bEditar.Enabled
    End Sub

    Private Sub eNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eNombre.TextChanged
        Call datos_modificados()
    End Sub

    Private Sub eApellidos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eApellidos.TextChanged
        Call datos_modificados()
    End Sub

    Private Sub eDireccion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eDireccion.TextChanged
        Call datos_modificados()
    End Sub
End Class
