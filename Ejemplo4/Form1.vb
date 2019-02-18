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
    Friend WithEvents lColor As System.Windows.Forms.Label
    Friend WithEvents lRojo As System.Windows.Forms.Label
    Friend WithEvents lNumeroRojo As System.Windows.Forms.Label
    Friend WithEvents lNumeroVerde As System.Windows.Forms.Label
    Friend WithEvents lVerde As System.Windows.Forms.Label
    Friend WithEvents lNumeroAzul As System.Windows.Forms.Label
    Friend WithEvents lAzul As System.Windows.Forms.Label
    Friend WithEvents sbRojo As System.Windows.Forms.HScrollBar
    Friend WithEvents sbVerde As System.Windows.Forms.HScrollBar
    Friend WithEvents sbAzul As System.Windows.Forms.HScrollBar
    Friend WithEvents bCerrar As System.Windows.Forms.Button
    Friend WithEvents bPaleta As System.Windows.Forms.Button
    Friend WithEvents dColor As System.Windows.Forms.ColorDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lColor = New System.Windows.Forms.Label
        Me.lRojo = New System.Windows.Forms.Label
        Me.lNumeroRojo = New System.Windows.Forms.Label
        Me.lNumeroVerde = New System.Windows.Forms.Label
        Me.lVerde = New System.Windows.Forms.Label
        Me.lNumeroAzul = New System.Windows.Forms.Label
        Me.lAzul = New System.Windows.Forms.Label
        Me.sbRojo = New System.Windows.Forms.HScrollBar
        Me.sbVerde = New System.Windows.Forms.HScrollBar
        Me.sbAzul = New System.Windows.Forms.HScrollBar
        Me.bCerrar = New System.Windows.Forms.Button
        Me.bPaleta = New System.Windows.Forms.Button
        Me.dColor = New System.Windows.Forms.ColorDialog
        Me.SuspendLayout()
        '
        'lColor
        '
        Me.lColor.BackColor = System.Drawing.Color.Black
        Me.lColor.Location = New System.Drawing.Point(16, 16)
        Me.lColor.Name = "lColor"
        Me.lColor.Size = New System.Drawing.Size(232, 232)
        Me.lColor.TabIndex = 0
        '
        'lRojo
        '
        Me.lRojo.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lRojo.ForeColor = System.Drawing.Color.Red
        Me.lRojo.Location = New System.Drawing.Point(264, 24)
        Me.lRojo.Name = "lRojo"
        Me.lRojo.Size = New System.Drawing.Size(64, 23)
        Me.lRojo.TabIndex = 1
        Me.lRojo.Text = "Rojo"
        '
        'lNumeroRojo
        '
        Me.lNumeroRojo.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNumeroRojo.ForeColor = System.Drawing.Color.Red
        Me.lNumeroRojo.Location = New System.Drawing.Point(408, 24)
        Me.lNumeroRojo.Name = "lNumeroRojo"
        Me.lNumeroRojo.Size = New System.Drawing.Size(40, 23)
        Me.lNumeroRojo.TabIndex = 2
        Me.lNumeroRojo.Text = "0"
        '
        'lNumeroVerde
        '
        Me.lNumeroVerde.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNumeroVerde.ForeColor = System.Drawing.Color.Green
        Me.lNumeroVerde.Location = New System.Drawing.Point(408, 104)
        Me.lNumeroVerde.Name = "lNumeroVerde"
        Me.lNumeroVerde.Size = New System.Drawing.Size(40, 23)
        Me.lNumeroVerde.TabIndex = 4
        Me.lNumeroVerde.Text = "0"
        '
        'lVerde
        '
        Me.lVerde.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lVerde.ForeColor = System.Drawing.Color.Green
        Me.lVerde.Location = New System.Drawing.Point(264, 104)
        Me.lVerde.Name = "lVerde"
        Me.lVerde.Size = New System.Drawing.Size(64, 23)
        Me.lVerde.TabIndex = 3
        Me.lVerde.Text = "Verde"
        '
        'lNumeroAzul
        '
        Me.lNumeroAzul.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNumeroAzul.ForeColor = System.Drawing.Color.Blue
        Me.lNumeroAzul.Location = New System.Drawing.Point(408, 184)
        Me.lNumeroAzul.Name = "lNumeroAzul"
        Me.lNumeroAzul.Size = New System.Drawing.Size(40, 23)
        Me.lNumeroAzul.TabIndex = 6
        Me.lNumeroAzul.Text = "0"
        '
        'lAzul
        '
        Me.lAzul.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lAzul.ForeColor = System.Drawing.Color.Blue
        Me.lAzul.Location = New System.Drawing.Point(264, 184)
        Me.lAzul.Name = "lAzul"
        Me.lAzul.Size = New System.Drawing.Size(64, 23)
        Me.lAzul.TabIndex = 5
        Me.lAzul.Text = "Azul"
        '
        'sbRojo
        '
        Me.sbRojo.LargeChange = 1
        Me.sbRojo.Location = New System.Drawing.Point(264, 64)
        Me.sbRojo.Maximum = 255
        Me.sbRojo.Name = "sbRojo"
        Me.sbRojo.Size = New System.Drawing.Size(176, 17)
        Me.sbRojo.TabIndex = 7
        '
        'sbVerde
        '
        Me.sbVerde.LargeChange = 1
        Me.sbVerde.Location = New System.Drawing.Point(264, 144)
        Me.sbVerde.Maximum = 255
        Me.sbVerde.Name = "sbVerde"
        Me.sbVerde.Size = New System.Drawing.Size(176, 17)
        Me.sbVerde.TabIndex = 8
        '
        'sbAzul
        '
        Me.sbAzul.LargeChange = 1
        Me.sbAzul.Location = New System.Drawing.Point(264, 224)
        Me.sbAzul.Maximum = 255
        Me.sbAzul.Name = "sbAzul"
        Me.sbAzul.Size = New System.Drawing.Size(176, 17)
        Me.sbAzul.TabIndex = 9
        '
        'bCerrar
        '
        Me.bCerrar.Location = New System.Drawing.Point(64, 288)
        Me.bCerrar.Name = "bCerrar"
        Me.bCerrar.Size = New System.Drawing.Size(112, 23)
        Me.bCerrar.TabIndex = 10
        Me.bCerrar.Text = "&Cerrar"
        '
        'bPaleta
        '
        Me.bPaleta.Location = New System.Drawing.Point(224, 288)
        Me.bPaleta.Name = "bPaleta"
        Me.bPaleta.Size = New System.Drawing.Size(112, 23)
        Me.bPaleta.TabIndex = 11
        Me.bPaleta.Text = "&Paleta de Colores"
        '
        'dColor
        '
        Me.dColor.AnyColor = True
        Me.dColor.FullOpen = True
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(480, 334)
        Me.Controls.Add(Me.bPaleta)
        Me.Controls.Add(Me.bCerrar)
        Me.Controls.Add(Me.sbAzul)
        Me.Controls.Add(Me.sbVerde)
        Me.Controls.Add(Me.sbRojo)
        Me.Controls.Add(Me.lNumeroAzul)
        Me.Controls.Add(Me.lAzul)
        Me.Controls.Add(Me.lNumeroVerde)
        Me.Controls.Add(Me.lVerde)
        Me.Controls.Add(Me.lNumeroRojo)
        Me.Controls.Add(Me.lRojo)
        Me.Controls.Add(Me.lColor)
        Me.Name = "Form1"
        Me.Text = "Paleta de Colores"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub sbRojo_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles sbRojo.Scroll
        lNumeroRojo.Text = sbRojo.Value
        lColor.BackColor = System.Drawing.Color.FromArgb(sbRojo.Value, sbVerde.Value, sbAzul.Value)
    End Sub

    Private Sub sbVerde_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles sbVerde.Scroll
        lNumeroVerde.Text = sbVerde.Value
        lColor.BackColor = System.Drawing.Color.FromArgb(sbRojo.Value, sbVerde.Value, sbAzul.Value)
    End Sub

    Private Sub sbAzul_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles sbAzul.Scroll
        lNumeroAzul.Text = sbAzul.Value
        lColor.BackColor = System.Drawing.Color.FromArgb(sbRojo.Value, sbVerde.Value, sbAzul.Value)
    End Sub

    Private Sub bCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCerrar.Click
        End
    End Sub

    Private Sub bPaleta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bPaleta.Click
        If (dColor.ShowDialog() = DialogResult.OK) Then
            lColor.BackColor = dColor.Color
            lNumeroRojo.Text = dColor.Color.R
            sbRojo.Value = dColor.Color.R
            lNumeroVerde.Text = dColor.Color.G
            sbVerde.Value = dColor.Color.G
            lNumeroAzul.Text = dColor.Color.B
            sbAzul.Value = dColor.Color.B
        End If
    End Sub
End Class
