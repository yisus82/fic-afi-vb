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
    Friend WithEvents gbCategorias As System.Windows.Forms.GroupBox
    Friend WithEvents lRegistro As System.Windows.Forms.Label
    Friend WithEvents lDescripcion As System.Windows.Forms.Label
    Friend WithEvents lNombre As System.Windows.Forms.Label
    Friend WithEvents eNombre As System.Windows.Forms.TextBox
    Friend WithEvents eDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents lPresupuesto As System.Windows.Forms.Label
    Friend WithEvents ePresupuesto As System.Windows.Forms.TextBox
    Friend WithEvents lEuro As System.Windows.Forms.Label
    Friend WithEvents cbAceptado As System.Windows.Forms.CheckBox
    Friend WithEvents gbDatos As System.Windows.Forms.GroupBox
    Friend WithEvents dgDatos As System.Windows.Forms.DataGrid
    Friend WithEvents bPrimero As System.Windows.Forms.Button
    Friend WithEvents bAnterior As System.Windows.Forms.Button
    Friend WithEvents bSiguiente As System.Windows.Forms.Button
    Friend WithEvents bUltimo As System.Windows.Forms.Button
    Friend WithEvents bBorrarProducto As System.Windows.Forms.Button
    Friend WithEvents bBorrar As System.Windows.Forms.Button
    Friend WithEvents bBuscar As System.Windows.Forms.Button
    Friend WithEvents bSalir As System.Windows.Forms.Button
    Friend WithEvents Mensaje As System.Windows.Forms.ToolTip
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.gbCategorias = New System.Windows.Forms.GroupBox
        Me.bSalir = New System.Windows.Forms.Button
        Me.bBuscar = New System.Windows.Forms.Button
        Me.bBorrar = New System.Windows.Forms.Button
        Me.bBorrarProducto = New System.Windows.Forms.Button
        Me.bUltimo = New System.Windows.Forms.Button
        Me.bSiguiente = New System.Windows.Forms.Button
        Me.bAnterior = New System.Windows.Forms.Button
        Me.bPrimero = New System.Windows.Forms.Button
        Me.cbAceptado = New System.Windows.Forms.CheckBox
        Me.lEuro = New System.Windows.Forms.Label
        Me.ePresupuesto = New System.Windows.Forms.TextBox
        Me.lPresupuesto = New System.Windows.Forms.Label
        Me.eDescripcion = New System.Windows.Forms.TextBox
        Me.eNombre = New System.Windows.Forms.TextBox
        Me.lDescripcion = New System.Windows.Forms.Label
        Me.lRegistro = New System.Windows.Forms.Label
        Me.lNombre = New System.Windows.Forms.Label
        Me.gbDatos = New System.Windows.Forms.GroupBox
        Me.dgDatos = New System.Windows.Forms.DataGrid
        Me.Mensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbCategorias.SuspendLayout()
        Me.gbDatos.SuspendLayout()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbCategorias
        '
        Me.gbCategorias.Controls.Add(Me.bSalir)
        Me.gbCategorias.Controls.Add(Me.bBuscar)
        Me.gbCategorias.Controls.Add(Me.bBorrar)
        Me.gbCategorias.Controls.Add(Me.bBorrarProducto)
        Me.gbCategorias.Controls.Add(Me.bUltimo)
        Me.gbCategorias.Controls.Add(Me.bSiguiente)
        Me.gbCategorias.Controls.Add(Me.bAnterior)
        Me.gbCategorias.Controls.Add(Me.bPrimero)
        Me.gbCategorias.Controls.Add(Me.cbAceptado)
        Me.gbCategorias.Controls.Add(Me.lEuro)
        Me.gbCategorias.Controls.Add(Me.ePresupuesto)
        Me.gbCategorias.Controls.Add(Me.lPresupuesto)
        Me.gbCategorias.Controls.Add(Me.eDescripcion)
        Me.gbCategorias.Controls.Add(Me.eNombre)
        Me.gbCategorias.Controls.Add(Me.lDescripcion)
        Me.gbCategorias.Controls.Add(Me.lRegistro)
        Me.gbCategorias.Controls.Add(Me.lNombre)
        Me.gbCategorias.ForeColor = System.Drawing.Color.Green
        Me.gbCategorias.Location = New System.Drawing.Point(8, 13)
        Me.gbCategorias.Name = "gbCategorias"
        Me.gbCategorias.Size = New System.Drawing.Size(576, 160)
        Me.gbCategorias.TabIndex = 8
        Me.gbCategorias.TabStop = False
        Me.gbCategorias.Text = "Categorías"
        '
        'bSalir
        '
        Me.bSalir.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSalir.ForeColor = System.Drawing.Color.Blue
        Me.bSalir.Location = New System.Drawing.Point(208, 120)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(64, 32)
        Me.bSalir.TabIndex = 22
        Me.bSalir.Text = "Sa&lir"
        Me.Mensaje.SetToolTip(Me.bSalir, "Salir del programa")
        '
        'bBuscar
        '
        Me.bBuscar.ForeColor = System.Drawing.Color.Black
        Me.bBuscar.Location = New System.Drawing.Point(144, 120)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(64, 32)
        Me.bBuscar.TabIndex = 23
        Me.bBuscar.Text = "&Buscar"
        Me.Mensaje.SetToolTip(Me.bBuscar, "Buscar una categoría")
        '
        'bBorrar
        '
        Me.bBorrar.ForeColor = System.Drawing.Color.Red
        Me.bBorrar.Location = New System.Drawing.Point(80, 120)
        Me.bBorrar.Name = "bBorrar"
        Me.bBorrar.Size = New System.Drawing.Size(64, 32)
        Me.bBorrar.TabIndex = 24
        Me.bBorrar.Text = "Bo&rrar"
        Me.Mensaje.SetToolTip(Me.bBorrar, "Borrar de la categoría")
        '
        'bBorrarProducto
        '
        Me.bBorrarProducto.ForeColor = System.Drawing.Color.Red
        Me.bBorrarProducto.Location = New System.Drawing.Point(16, 120)
        Me.bBorrarProducto.Name = "bBorrarProducto"
        Me.bBorrarProducto.Size = New System.Drawing.Size(64, 32)
        Me.bBorrarProducto.TabIndex = 25
        Me.bBorrarProducto.Text = "B. Prod"
        Me.Mensaje.SetToolTip(Me.bBorrarProducto, "Borrar todos los productos de la categoría")
        '
        'bUltimo
        '
        Me.bUltimo.ForeColor = System.Drawing.Color.Black
        Me.bUltimo.Location = New System.Drawing.Point(208, 88)
        Me.bUltimo.Name = "bUltimo"
        Me.bUltimo.Size = New System.Drawing.Size(64, 32)
        Me.bUltimo.TabIndex = 21
        Me.bUltimo.Text = "&Último"
        Me.Mensaje.SetToolTip(Me.bUltimo, "Ir al último registro")
        '
        'bSiguiente
        '
        Me.bSiguiente.ForeColor = System.Drawing.Color.Black
        Me.bSiguiente.Location = New System.Drawing.Point(144, 88)
        Me.bSiguiente.Name = "bSiguiente"
        Me.bSiguiente.Size = New System.Drawing.Size(64, 32)
        Me.bSiguiente.TabIndex = 19
        Me.bSiguiente.Text = "&Siguiente"
        Me.Mensaje.SetToolTip(Me.bSiguiente, "Ir al siguiente registro")
        '
        'bAnterior
        '
        Me.bAnterior.ForeColor = System.Drawing.Color.Black
        Me.bAnterior.Location = New System.Drawing.Point(80, 88)
        Me.bAnterior.Name = "bAnterior"
        Me.bAnterior.Size = New System.Drawing.Size(64, 32)
        Me.bAnterior.TabIndex = 18
        Me.bAnterior.Text = "&Anterior"
        Me.Mensaje.SetToolTip(Me.bAnterior, "Ir al anterior registro")
        '
        'bPrimero
        '
        Me.bPrimero.ForeColor = System.Drawing.Color.Black
        Me.bPrimero.Location = New System.Drawing.Point(16, 88)
        Me.bPrimero.Name = "bPrimero"
        Me.bPrimero.Size = New System.Drawing.Size(64, 32)
        Me.bPrimero.TabIndex = 20
        Me.bPrimero.Text = "&Primero"
        Me.Mensaje.SetToolTip(Me.bPrimero, "Ir al primer registro")
        '
        'cbAceptado
        '
        Me.cbAceptado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cbAceptado.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAceptado.ForeColor = System.Drawing.Color.Red
        Me.cbAceptado.Location = New System.Drawing.Point(288, 128)
        Me.cbAceptado.Name = "cbAceptado"
        Me.cbAceptado.Size = New System.Drawing.Size(224, 24)
        Me.cbAceptado.TabIndex = 31
        Me.cbAceptado.Text = "Presupuesto aceptado"
        Me.cbAceptado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lEuro
        '
        Me.lEuro.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lEuro.ForeColor = System.Drawing.Color.Black
        Me.lEuro.Location = New System.Drawing.Point(544, 96)
        Me.lEuro.Name = "lEuro"
        Me.lEuro.Size = New System.Drawing.Size(24, 24)
        Me.lEuro.TabIndex = 30
        Me.lEuro.Text = "€"
        Me.lEuro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ePresupuesto
        '
        Me.ePresupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ePresupuesto.ForeColor = System.Drawing.Color.Red
        Me.ePresupuesto.Location = New System.Drawing.Point(432, 92)
        Me.ePresupuesto.Name = "ePresupuesto"
        Me.ePresupuesto.Size = New System.Drawing.Size(104, 31)
        Me.ePresupuesto.TabIndex = 29
        Me.ePresupuesto.Text = "0"
        Me.ePresupuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Mensaje.SetToolTip(Me.ePresupuesto, "Presupuesto para gastar en productos de la categoría")
        '
        'lPresupuesto
        '
        Me.lPresupuesto.ForeColor = System.Drawing.Color.Black
        Me.lPresupuesto.Location = New System.Drawing.Point(288, 95)
        Me.lPresupuesto.Name = "lPresupuesto"
        Me.lPresupuesto.Size = New System.Drawing.Size(152, 32)
        Me.lPresupuesto.TabIndex = 28
        Me.lPresupuesto.Text = "Presupuesto para gastar en productos de la categoría"
        '
        'eDescripcion
        '
        Me.eDescripcion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eDescripcion.Location = New System.Drawing.Point(280, 39)
        Me.eDescripcion.Multiline = True
        Me.eDescripcion.Name = "eDescripcion"
        Me.eDescripcion.Size = New System.Drawing.Size(288, 48)
        Me.eDescripcion.TabIndex = 15
        Me.eDescripcion.Text = ""
        Me.Mensaje.SetToolTip(Me.eDescripcion, "Descripción de la categoría")
        '
        'eNombre
        '
        Me.eNombre.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eNombre.Location = New System.Drawing.Point(16, 39)
        Me.eNombre.Name = "eNombre"
        Me.eNombre.Size = New System.Drawing.Size(256, 30)
        Me.eNombre.TabIndex = 8
        Me.eNombre.Text = ""
        Me.Mensaje.SetToolTip(Me.eNombre, "Nombre de la categoría")
        '
        'lDescripcion
        '
        Me.lDescripcion.ForeColor = System.Drawing.Color.Black
        Me.lDescripcion.Location = New System.Drawing.Point(280, 20)
        Me.lDescripcion.Name = "lDescripcion"
        Me.lDescripcion.Size = New System.Drawing.Size(184, 24)
        Me.lDescripcion.TabIndex = 27
        Me.lDescripcion.Text = "Descripción de la categoría"
        '
        'lRegistro
        '
        Me.lRegistro.Location = New System.Drawing.Point(160, 21)
        Me.lRegistro.Name = "lRegistro"
        Me.lRegistro.Size = New System.Drawing.Size(112, 16)
        Me.lRegistro.TabIndex = 16
        Me.lRegistro.Text = "Registro"
        Me.lRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lNombre
        '
        Me.lNombre.ForeColor = System.Drawing.Color.Black
        Me.lNombre.Location = New System.Drawing.Point(16, 20)
        Me.lNombre.Name = "lNombre"
        Me.lNombre.Size = New System.Drawing.Size(128, 24)
        Me.lNombre.TabIndex = 26
        Me.lNombre.Text = "Nombre de la categoría"
        '
        'gbDatos
        '
        Me.gbDatos.Controls.Add(Me.dgDatos)
        Me.gbDatos.Location = New System.Drawing.Point(8, 176)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(576, 200)
        Me.gbDatos.TabIndex = 11
        Me.gbDatos.TabStop = False
        '
        'dgDatos
        '
        Me.dgDatos.AllowSorting = False
        Me.dgDatos.CaptionBackColor = System.Drawing.Color.Maroon
        Me.dgDatos.CaptionFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.dgDatos.CaptionText = "Productos relacionados"
        Me.dgDatos.DataMember = ""
        Me.dgDatos.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgDatos.Location = New System.Drawing.Point(8, 16)
        Me.dgDatos.Name = "dgDatos"
        Me.dgDatos.Size = New System.Drawing.Size(560, 176)
        Me.dgDatos.TabIndex = 11
        Me.Mensaje.SetToolTip(Me.dgDatos, "Productos relacionados con la categoría")
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(600, 422)
        Me.Controls.Add(Me.gbDatos)
        Me.Controls.Add(Me.gbCategorias)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Base de Datos de Categorías de Alimentos"
        Me.gbCategorias.ResumeLayout(False)
        Me.gbDatos.ResumeLayout(False)
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim dbDataSet_DATOS As Data.DataSet
    Dim Filtro_del_Dataset As DataView

    Private Sub cargar_datos()
        Dim registros, actual As Integer
        registros = Me.BindingContext(dbDataSet_DATOS, "Tabla_Categorias").Count
        actual = Me.BindingContext(dbDataSet_DATOS, "Tabla_Categorias").Position + 1
        lRegistro.Text = "Registro " & actual.ToString & " de " & registros.ToString
        If registros > 1 Then
            Filtro_del_Dataset.Sort = "NombreProducto"
            Filtro_del_Dataset.RowFilter = "IDCategoria= " & CStr(dbDataSet_DATOS.Tables("Tabla_Categorias").Rows(BindingContext(dbDataSet_DATOS, "Tabla_Categorias").Position).Item("IDCategoria"))
        End If
        If actual = 0 Then ' No hay registros en la BD
            bPrimero.Enabled = False
            bAnterior.Enabled = False
            bSiguiente.Enabled = False
            bUltimo.Enabled = False
            bBorrar.Enabled = False
            bBorrarProducto.Enabled = False
            Filtro_del_Dataset.RowStateFilter = DataViewRowState.None
        Else
            bBorrar.Enabled = True
            bBorrarProducto.Enabled = True
            If actual = 1 Then ' Estamos en el primer registro
                bPrimero.Enabled = True
                bAnterior.Enabled = True
                bSiguiente.Enabled = False
                bUltimo.Enabled = False
            Else
                If actual = registros Then  ' Estamos en el ultimo registro
                    bPrimero.Enabled = False
                    bAnterior.Enabled = False
                    bSiguiente.Enabled = True
                    bUltimo.Enabled = True
                Else ' Estamos por el medio de la tabla
                    bPrimero.Enabled = True
                    bAnterior.Enabled = True
                    bSiguiente.Enabled = True
                    bUltimo.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim CadenaConexion As String
        Dim CadenaSelect As String
        Dim ArchivoDatos As String

        Dim dbConnection As Data.OleDb.OleDbConnection
        Dim dbDataAdapter_Categorias As Data.OleDb.OleDbDataAdapter
        Dim dbDataAdapter_Productos As Data.OleDb.OleDbDataAdapter
        ArchivoDatos = System.Environment.CurrentDirectory & "\EJERCICIO7.MDB"
        CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & ArchivoDatos

        Try
            dbConnection = New Data.OleDb.OleDbConnection(CadenaConexion)
            dbConnection.Open()

            dbDataSet_DATOS = New Data.DataSet
            CadenaSelect = "SELECT * FROM categorias"
            dbDataAdapter_Categorias = New Data.OleDb.OleDbDataAdapter(CadenaSelect, dbConnection)
            CadenaSelect = "SELECT IDCategoria, NombreProducto, UnidadesEnExistencia, UnidadesEnPedido, CantidadPorUnidad, PrecioUnidad FROM productos"
            dbDataAdapter_Productos = New Data.OleDb.OleDbDataAdapter(CadenaSelect, dbConnection)
            dbDataAdapter_Categorias.Fill(dbDataSet_DATOS, "Tabla_Categorias")
            dbDataAdapter_Productos.Fill(dbDataSet_DATOS, "Tabla_Productos")
        Catch ex As Exception
            MsgBox("Error al crear una conexión con la BD: " & vbCrLf & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, "ERROR")
            End
        End Try

        dbDataAdapter_Categorias.Dispose()
        dbDataAdapter_Productos.Dispose()
        dbConnection.Dispose()

        Dim oBind As Binding
        oBind = New Binding("Text", dbDataSet_DATOS, "Tabla_Categorias.NombreCategoria")
        eNombre.DataBindings.Add(oBind)
        oBind = Nothing

        oBind = New Binding("Text", dbDataSet_DATOS, "Tabla_Categorias.Descripcion")
        eDescripcion.DataBindings.Add(oBind)
        oBind = Nothing

        oBind = New Binding("Text", dbDataSet_DATOS, "Tabla_Categorias.Presupuesto")
        ePresupuesto.DataBindings.Add(oBind)
        oBind = Nothing

        oBind = New Binding("Checked", dbDataSet_DATOS, "Tabla_Categorias.disponibilidad")
        cbAceptado.DataBindings.Add(oBind)
        oBind = Nothing

        Filtro_del_Dataset = New DataView(dbDataSet_DATOS.Tables("Tabla_Productos"))
        dgDatos.DataSource = Filtro_del_Dataset

        Dim oEstiloGrid As New DataGridTableStyle
        oEstiloGrid.MappingName = "Tabla_Productos"

        Dim oColGrid As New DataGridTextBoxColumn
        oColGrid = New DataGridTextBoxColumn
        oColGrid.HeaderText = "Nombre del Producto"
        oColGrid.MappingName = "NombreProducto"
        oColGrid.Width = 200
        oEstiloGrid.GridColumnStyles.Add(oColGrid)
        oColGrid = Nothing

        oColGrid = New DataGridTextBoxColumn
        oColGrid.HeaderText = "Cant. - Unidad"
        oColGrid.MappingName = "CantidadPorUnidad"
        oColGrid.Width = 100
        oEstiloGrid.GridColumnStyles.Add(oColGrid)
        oColGrid = Nothing

        oColGrid = New DataGridTextBoxColumn
        oColGrid.HeaderText = "Precio"
        oColGrid.MappingName = "PrecioUnidad"
        oColGrid.Alignment = HorizontalAlignment.Center
        oColGrid.Width = 75
        oEstiloGrid.GridColumnStyles.Add(oColGrid)
        oColGrid = Nothing

        oColGrid = New DataGridTextBoxColumn
        oColGrid.HeaderText = "Existencia"
        oColGrid.MappingName = "UnidadesEnExistencia"
        oColGrid.Alignment = HorizontalAlignment.Center
        oColGrid.Width = 75
        oEstiloGrid.GridColumnStyles.Add(oColGrid)
        oColGrid = Nothing

        oColGrid = New DataGridTextBoxColumn
        oColGrid.HeaderText = "Pedido"
        oColGrid.MappingName = "UnidadesEnPedido"
        oColGrid.Alignment = HorizontalAlignment.Center
        oColGrid.Width = 50
        oEstiloGrid.GridColumnStyles.Add(oColGrid)
        oColGrid = Nothing

        dgDatos.TableStyles.Add(oEstiloGrid)

        cargar_datos()
    End Sub

    Private Sub bPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bPrimero.Click
        Me.BindingContext(dbDataSet_DATOS, "Tabla_Categorias").Position = 0
        cargar_datos()
    End Sub

    Private Sub bAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAnterior.Click
        Me.BindingContext(dbDataSet_DATOS, "Tabla_Categorias").Position -= 1
        cargar_datos()
    End Sub

    Private Sub bSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSiguiente.Click
        Me.BindingContext(dbDataSet_DATOS, "Tabla_Categorias").Position += 1
        cargar_datos()
    End Sub

    Private Sub bUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bUltimo.Click
        Me.BindingContext(dbDataSet_DATOS, "Tabla_Categorias").Position = Me.BindingContext(dbDataSet_DATOS, "Tabla_Categorias").Count - 1
        cargar_datos()
    End Sub

    Private Sub bSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSalir.Click
        End
    End Sub

    Private Sub bBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bBuscar.Click
        Dim registros, cont As Integer
        Dim cadena_buscar As String
        cadena_buscar = InputBox("Introduzca el nombre de la categoría que quiere buscar :", "Buscar categoría")

        If cadena_buscar <> "" Then
            registros = Me.BindingContext(dbDataSet_DATOS, "Tabla_Categorias").Count
            For cont = 1 To registros
                If cadena_buscar = (dbDataSet_DATOS.Tables("Tabla_Categorias").Rows(cont - 1).Item("NombreCategoria")) Then
                    Me.BindingContext(dbDataSet_DATOS, "Tabla_Categorias").Position = cont - 1
                    cargar_datos()
                    Exit Sub
                End If
            Next cont
            MsgBox("No se ha encontrado la categoría " & cadena_buscar, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "No encontrado")
        End If
    End Sub

    Private Sub bBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bBorrar.Click
        Dim nomb_cat As String
        Dim ID_cat As String
        Dim cont, registros As Integer

        nomb_cat = dbDataSet_DATOS.Tables("Tabla_Categorias").Rows(Me.BindingContext(dbDataSet_DATOS, "Tabla_Categorias").Position).Item("NombreCategoria")
        ID_cat = dbDataSet_DATOS.Tables("Tabla_Categorias").Rows(Me.BindingContext(dbDataSet_DATOS, "Tabla_Categorias").Position).Item("IDCategoria")

        If MsgBox(" ¿Desea borrar TODOS los datos de la categoría " & nomb_cat & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Eliminar productos") = MsgBoxResult.Yes Then
            registros = Filtro_del_Dataset.Count
            Filtro_del_Dataset.AllowDelete() = True
            For cont = 1 To registros
                Filtro_del_Dataset.Item(0).Delete()
            Next
            cargar_datos()
        End If
    End Sub

    Private Sub ePresupuesto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ePresupuesto.TextChanged
        ePresupuesto.Text = Format(CInt(ePresupuesto.Text), "0.00")
    End Sub
End Class
