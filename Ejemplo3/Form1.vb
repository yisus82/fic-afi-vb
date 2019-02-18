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
    Friend WithEvents eNumero1 As System.Windows.Forms.TextBox
    Friend WithEvents eNumero2 As System.Windows.Forms.TextBox
    Friend WithEvents lNumero2 As System.Windows.Forms.Label
    Friend WithEvents lLinea As System.Windows.Forms.Label
    Friend WithEvents lResultado As System.Windows.Forms.Label
    Friend WithEvents eResultado As System.Windows.Forms.TextBox
    Friend WithEvents gbOperaciones As System.Windows.Forms.GroupBox
    Friend WithEvents rbPotencia As System.Windows.Forms.RadioButton
    Friend WithEvents rbDivision As System.Windows.Forms.RadioButton
    Friend WithEvents rbProducto As System.Windows.Forms.RadioButton
    Friend WithEvents rbResta As System.Windows.Forms.RadioButton
    Friend WithEvents rbSuma As System.Windows.Forms.RadioButton
    Friend WithEvents bCalcular As System.Windows.Forms.Button
    Friend WithEvents bLimpiarDatos As System.Windows.Forms.Button
    Friend WithEvents bSalir As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lNumero1 = New System.Windows.Forms.Label
        Me.eNumero1 = New System.Windows.Forms.TextBox
        Me.eNumero2 = New System.Windows.Forms.TextBox
        Me.lNumero2 = New System.Windows.Forms.Label
        Me.lLinea = New System.Windows.Forms.Label
        Me.lResultado = New System.Windows.Forms.Label
        Me.eResultado = New System.Windows.Forms.TextBox
        Me.gbOperaciones = New System.Windows.Forms.GroupBox
        Me.rbPotencia = New System.Windows.Forms.RadioButton
        Me.rbDivision = New System.Windows.Forms.RadioButton
        Me.rbProducto = New System.Windows.Forms.RadioButton
        Me.rbResta = New System.Windows.Forms.RadioButton
        Me.rbSuma = New System.Windows.Forms.RadioButton
        Me.bCalcular = New System.Windows.Forms.Button
        Me.bLimpiarDatos = New System.Windows.Forms.Button
        Me.bSalir = New System.Windows.Forms.Button
        Me.gbOperaciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'lNumero1
        '
        Me.lNumero1.Location = New System.Drawing.Point(32, 24)
        Me.lNumero1.Name = "lNumero1"
        Me.lNumero1.TabIndex = 0
        Me.lNumero1.Text = "Número 1"
        '
        'eNumero1
        '
        Me.eNumero1.Location = New System.Drawing.Point(32, 48)
        Me.eNumero1.Name = "eNumero1"
        Me.eNumero1.TabIndex = 1
        Me.eNumero1.Text = ""
        '
        'eNumero2
        '
        Me.eNumero2.Location = New System.Drawing.Point(32, 96)
        Me.eNumero2.Name = "eNumero2"
        Me.eNumero2.TabIndex = 3
        Me.eNumero2.Text = ""
        '
        'lNumero2
        '
        Me.lNumero2.Location = New System.Drawing.Point(32, 72)
        Me.lNumero2.Name = "lNumero2"
        Me.lNumero2.TabIndex = 4
        Me.lNumero2.Text = "Número 2"
        '
        'lLinea
        '
        Me.lLinea.BackColor = System.Drawing.Color.Black
        Me.lLinea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lLinea.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lLinea.Location = New System.Drawing.Point(16, 120)
        Me.lLinea.Name = "lLinea"
        Me.lLinea.Size = New System.Drawing.Size(128, 3)
        Me.lLinea.TabIndex = 5
        Me.lLinea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lResultado
        '
        Me.lResultado.Location = New System.Drawing.Point(32, 128)
        Me.lResultado.Name = "lResultado"
        Me.lResultado.TabIndex = 6
        Me.lResultado.Text = "Resultado"
        '
        'eResultado
        '
        Me.eResultado.Location = New System.Drawing.Point(32, 152)
        Me.eResultado.Name = "eResultado"
        Me.eResultado.TabIndex = 7
        Me.eResultado.Text = ""
        '
        'gbOperaciones
        '
        Me.gbOperaciones.Controls.Add(Me.rbPotencia)
        Me.gbOperaciones.Controls.Add(Me.rbDivision)
        Me.gbOperaciones.Controls.Add(Me.rbProducto)
        Me.gbOperaciones.Controls.Add(Me.rbResta)
        Me.gbOperaciones.Controls.Add(Me.rbSuma)
        Me.gbOperaciones.Location = New System.Drawing.Point(176, 24)
        Me.gbOperaciones.Name = "gbOperaciones"
        Me.gbOperaciones.Size = New System.Drawing.Size(120, 160)
        Me.gbOperaciones.TabIndex = 13
        Me.gbOperaciones.TabStop = False
        Me.gbOperaciones.Text = "Operaciones"
        '
        'rbPotencia
        '
        Me.rbPotencia.Location = New System.Drawing.Point(8, 120)
        Me.rbPotencia.Name = "rbPotencia"
        Me.rbPotencia.Size = New System.Drawing.Size(104, 20)
        Me.rbPotencia.TabIndex = 17
        Me.rbPotencia.Text = "Potencia"
        '
        'rbDivision
        '
        Me.rbDivision.Location = New System.Drawing.Point(8, 96)
        Me.rbDivision.Name = "rbDivision"
        Me.rbDivision.Size = New System.Drawing.Size(104, 20)
        Me.rbDivision.TabIndex = 16
        Me.rbDivision.Text = "División"
        '
        'rbProducto
        '
        Me.rbProducto.Location = New System.Drawing.Point(8, 72)
        Me.rbProducto.Name = "rbProducto"
        Me.rbProducto.Size = New System.Drawing.Size(104, 20)
        Me.rbProducto.TabIndex = 15
        Me.rbProducto.Text = "Producto"
        '
        'rbResta
        '
        Me.rbResta.Location = New System.Drawing.Point(8, 48)
        Me.rbResta.Name = "rbResta"
        Me.rbResta.Size = New System.Drawing.Size(104, 20)
        Me.rbResta.TabIndex = 14
        Me.rbResta.Text = "Resta"
        '
        'rbSuma
        '
        Me.rbSuma.Location = New System.Drawing.Point(8, 24)
        Me.rbSuma.Name = "rbSuma"
        Me.rbSuma.Size = New System.Drawing.Size(104, 20)
        Me.rbSuma.TabIndex = 13
        Me.rbSuma.Text = "Suma"
        '
        'bCalcular
        '
        Me.bCalcular.Location = New System.Drawing.Point(352, 24)
        Me.bCalcular.Name = "bCalcular"
        Me.bCalcular.Size = New System.Drawing.Size(96, 40)
        Me.bCalcular.TabIndex = 14
        Me.bCalcular.Text = "&Calcular"
        '
        'bLimpiarDatos
        '
        Me.bLimpiarDatos.Location = New System.Drawing.Point(352, 72)
        Me.bLimpiarDatos.Name = "bLimpiarDatos"
        Me.bLimpiarDatos.Size = New System.Drawing.Size(96, 40)
        Me.bLimpiarDatos.TabIndex = 15
        Me.bLimpiarDatos.Text = "&Limpiar Datos"
        '
        'bSalir
        '
        Me.bSalir.Location = New System.Drawing.Point(352, 136)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(96, 40)
        Me.bSalir.TabIndex = 16
        Me.bSalir.Text = "&Salir"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(480, 230)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.bLimpiarDatos)
        Me.Controls.Add(Me.bCalcular)
        Me.Controls.Add(Me.gbOperaciones)
        Me.Controls.Add(Me.eResultado)
        Me.Controls.Add(Me.lResultado)
        Me.Controls.Add(Me.lLinea)
        Me.Controls.Add(Me.lNumero2)
        Me.Controls.Add(Me.eNumero2)
        Me.Controls.Add(Me.eNumero1)
        Me.Controls.Add(Me.lNumero1)
        Me.Name = "Form1"
        Me.Text = "Calculadora"
        Me.gbOperaciones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub bSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSalir.Click
        End
    End Sub

    Private Sub bLimpiarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bLimpiarDatos.Click
        eNumero1.Text = ""
        eNumero2.Text = ""
        eResultado.Text = ""
    End Sub

    Private Sub bCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCalcular.Click
        Dim a, b, r As Double

        If (eNumero1.Text <> "") And (eNumero2.Text <> "") Then
            a = eNumero1.Text
            b = eNumero2.Text


            If rbSuma.Checked Then
                r = a + b
            End If

            If rbResta.Checked Then
                r = a - b
            End If

            If rbProducto.Checked Then
                r = a * b
            End If

            If rbDivision.Checked Then
                r = a / b
            End If

            If rbPotencia.Checked Then
                r = a ^ b
            End If

            eResultado.Text = r
        Else : MsgBox("Introduzca los dos operandos", MsgBoxStyle.Critical And MsgBoxStyle.OKOnly, "Error")
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rbSuma.Checked = True
    End Sub
End Class
