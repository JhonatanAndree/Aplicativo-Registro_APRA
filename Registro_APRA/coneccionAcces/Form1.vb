Public Class Form1
    'vamos a conectar la base de datos access'
    Public conex As New OleDb.OleDbConnection("Provider=microsoft.ace.oledb.12.0;Data source= C:\MyData\Elecciones2018.accdb")
    'objeto comando , por medio el cual se estara mandando datos'
    Public com As New OleDb.OleDbCommand
    'al cargar la aplicacion intentara conectarse a la base de datos'


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            'trato de abrir la conexion'
            conex.Open()
            'inicializo el objeto comand'
            com.Connection = conex
            com.CommandType = CommandType.Text

        Catch ex As Exception
            If Err.Number = 5 Then
                MsgBox("No se pudo accesar")
                End
            Else
                MsgBox(Err.Description)
            End If
        End Try

    End Sub

    Public Sub SoloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub





    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Close()
    End Sub

    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        texDNI.Clear()
        texNombres.Clear()
        texApellidos.Clear()
        texCelular.Clear()
        texDireccion.Clear()

        RadioSI.Checked = False
        RadioNO.Checked = False

        texMesadesufragio.Clear()
        texOrdendemesa.Clear()
        texLocaldevotacion.Clear()
        texPabellon.Clear()
        texPiso.Clear()
        texAula.Clear()
        texDNI.Focus()
    End Sub

    'funcion que se encarga de insertar los datos del libro a la tabla'
    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        Dim miembro_mesa As String
        miembro_mesa = " "
        'verifico que haya escritorio el  isbn - se deberia verificar todos'
        'If txtISBN.Text = "" Then
        '-si no lo escribio, mando mensaje de error-
        'MsgBox("debe  incluir un numero ISBN del libro")

        If texDNI.Text = "" Or texNombres.Text = "" Or texDNI.Text = "" Or texNombres.Text = "" Or texApellidos.Text = "" Or texCelular.Text = "" Or texDireccion.Text = "" Or texMesadesufragio.Text = "" Or texOrdendemesa.Text = "" Or texLocaldevotacion.Text = "" Or texPabellon.Text = "" Or texPiso.Text = "" Or texAula.Text = "" Then
            MsgBox("Debe completar inscripción")
        Else
            If RadioSI.Checked = False And RadioNO.Checked = False Then
                MsgBox("Seleccione:  'SI'  o 'NO'")
            Else
                If RadioSI.Checked = True Then
                    miembro_mesa = "SI"
                Else
                    miembro_mesa = "NO"
                End If
                'declaro una variable para armar la instruccion sql
                Dim sql As String

                sql = "INSERT INTO Datos_Personeros2018(idDNI,Nombre,Apellido,N_Celular,Direccion,Miembro_Mesa,Mesa_Sufragio,N_Orden_Mesa,Local_Votacion,N_Pabellon,Piso,Aula) VALUES ('" & texDNI.Text & "','" & texNombres.Text & "','" & texApellidos.Text & "','" & texCelular.Text & "','" & texDireccion.Text & "','" & miembro_mesa & "','" & texMesadesufragio.Text & "','" & texOrdendemesa.Text & "','" & texLocaldevotacion.Text & "','" & texPabellon.Text & "','" & texPiso.Text & "','" & texAula.Text & "')"
                MsgBox(sql)

                'asigno la instruccion SQL que se va ejecutar
                com.CommandText = sql

                Try
                    com.ExecuteNonQuery()
                Catch ex As Exception
                    'MsgBox(ex.ToString)
                    MsgBox(Err.Number & " - " & Err.Description)
                End Try
            End If
        End If
    End Sub

    Private Sub texDNI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles texDNI.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub texCelular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles texCelular.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub texMesadesufragio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles texMesadesufragio.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub texOrdendemesa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles texOrdendemesa.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub texPabellon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles texPabellon.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub texPiso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles texPiso.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub texAula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles texAula.KeyPress
        SoloNumeros(e)
    End Sub


End Class
