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
    Friend WithEvents tReloj As System.Timers.Timer
    Friend WithEvents bArrancar As System.Windows.Forms.Button
    Friend WithEvents bParar As System.Windows.Forms.Button
    Friend WithEvents lDisplay As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.tReloj = New System.Timers.Timer
        Me.bArrancar = New System.Windows.Forms.Button
        Me.bParar = New System.Windows.Forms.Button
        Me.lDisplay = New System.Windows.Forms.Label
        CType(Me.tReloj, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tReloj
        '
        Me.tReloj.Enabled = True
        Me.tReloj.Interval = 1000
        Me.tReloj.SynchronizingObject = Me
        '
        'bArrancar
        '
        Me.bArrancar.Location = New System.Drawing.Point(256, 16)
        Me.bArrancar.Name = "bArrancar"
        Me.bArrancar.Size = New System.Drawing.Size(89, 33)
        Me.bArrancar.TabIndex = 1
        Me.bArrancar.Text = "&Arrancar"
        '
        'bParar
        '
        Me.bParar.Enabled = False
        Me.bParar.Location = New System.Drawing.Point(256, 56)
        Me.bParar.Name = "bParar"
        Me.bParar.Size = New System.Drawing.Size(89, 33)
        Me.bParar.TabIndex = 2
        Me.bParar.Text = "&Parar"
        '
        'lDisplay
        '
        Me.lDisplay.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lDisplay.Location = New System.Drawing.Point(16, 24)
        Me.lDisplay.Name = "lDisplay"
        Me.lDisplay.Size = New System.Drawing.Size(224, 57)
        Me.lDisplay.TabIndex = 0
        '
        'fFormulario
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(352, 110)
        Me.Controls.Add(Me.lDisplay)
        Me.Controls.Add(Me.bParar)
        Me.Controls.Add(Me.bArrancar)
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "fFormulario"
        Me.Text = "Reloj"
        CType(Me.tReloj, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub bArrancar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bArrancar.Click
        bArrancar.Enabled = False
        bParar.Enabled = True
    End Sub

    Private Sub bParar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bParar.Click
        bArrancar.Enabled = True
        bParar.Enabled = False
    End Sub

    Private Sub fFormulario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lDisplay.Text = CStr(TimeOfDay)
        Me.Text = "Reloj - [" + CStr(TimeOfDay) + "]"
    End Sub

    Private Sub tReloj_Tick(ByVal sender As System.Object, ByVal e As System.Timers.ElapsedEventArgs) Handles tReloj.Elapsed
        If bParar.Enabled Then
            lDisplay.Text = CStr(TimeOfDay)
        End If
        Me.Text = "Reloj - [" + CStr(TimeOfDay) + "]"
    End Sub
End Class
