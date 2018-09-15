<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioNO = New System.Windows.Forms.RadioButton()
        Me.RadioSI = New System.Windows.Forms.RadioButton()
        Me.texAula = New System.Windows.Forms.TextBox()
        Me.texPiso = New System.Windows.Forms.TextBox()
        Me.texPabellon = New System.Windows.Forms.TextBox()
        Me.texLocaldevotacion = New System.Windows.Forms.TextBox()
        Me.texOrdendemesa = New System.Windows.Forms.TextBox()
        Me.texMesadesufragio = New System.Windows.Forms.TextBox()
        Me.texDireccion = New System.Windows.Forms.TextBox()
        Me.texCelular = New System.Windows.Forms.TextBox()
        Me.texApellidos = New System.Windows.Forms.TextBox()
        Me.texNombres = New System.Windows.Forms.TextBox()
        Me.texDNI = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.btNuevo = New System.Windows.Forms.Button()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioNO)
        Me.GroupBox1.Controls.Add(Me.RadioSI)
        Me.GroupBox1.Controls.Add(Me.texAula)
        Me.GroupBox1.Controls.Add(Me.texPiso)
        Me.GroupBox1.Controls.Add(Me.texPabellon)
        Me.GroupBox1.Controls.Add(Me.texLocaldevotacion)
        Me.GroupBox1.Controls.Add(Me.texOrdendemesa)
        Me.GroupBox1.Controls.Add(Me.texMesadesufragio)
        Me.GroupBox1.Controls.Add(Me.texDireccion)
        Me.GroupBox1.Controls.Add(Me.texCelular)
        Me.GroupBox1.Controls.Add(Me.texApellidos)
        Me.GroupBox1.Controls.Add(Me.texNombres)
        Me.GroupBox1.Controls.Add(Me.texDNI)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(22, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(485, 411)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "REGISTRO PERSONERO"
        '
        'RadioNO
        '
        Me.RadioNO.AutoSize = True
        Me.RadioNO.ForeColor = System.Drawing.Color.White
        Me.RadioNO.Location = New System.Drawing.Point(324, 184)
        Me.RadioNO.Name = "RadioNO"
        Me.RadioNO.Size = New System.Drawing.Size(43, 19)
        Me.RadioNO.TabIndex = 7
        Me.RadioNO.TabStop = True
        Me.RadioNO.Text = "NO"
        Me.RadioNO.UseVisualStyleBackColor = True
        '
        'RadioSI
        '
        Me.RadioSI.AutoSize = True
        Me.RadioSI.ForeColor = System.Drawing.Color.White
        Me.RadioSI.Location = New System.Drawing.Point(190, 184)
        Me.RadioSI.Name = "RadioSI"
        Me.RadioSI.Size = New System.Drawing.Size(37, 19)
        Me.RadioSI.TabIndex = 6
        Me.RadioSI.TabStop = True
        Me.RadioSI.Text = "SI"
        Me.RadioSI.UseVisualStyleBackColor = True
        '
        'texAula
        '
        Me.texAula.Location = New System.Drawing.Point(190, 356)
        Me.texAula.Name = "texAula"
        Me.texAula.Size = New System.Drawing.Size(95, 23)
        Me.texAula.TabIndex = 13
        '
        'texPiso
        '
        Me.texPiso.Location = New System.Drawing.Point(190, 328)
        Me.texPiso.Name = "texPiso"
        Me.texPiso.Size = New System.Drawing.Size(95, 23)
        Me.texPiso.TabIndex = 12
        '
        'texPabellon
        '
        Me.texPabellon.Location = New System.Drawing.Point(190, 300)
        Me.texPabellon.Name = "texPabellon"
        Me.texPabellon.Size = New System.Drawing.Size(95, 23)
        Me.texPabellon.TabIndex = 11
        '
        'texLocaldevotacion
        '
        Me.texLocaldevotacion.Location = New System.Drawing.Point(190, 272)
        Me.texLocaldevotacion.Name = "texLocaldevotacion"
        Me.texLocaldevotacion.Size = New System.Drawing.Size(278, 23)
        Me.texLocaldevotacion.TabIndex = 10
        '
        'texOrdendemesa
        '
        Me.texOrdendemesa.Location = New System.Drawing.Point(190, 244)
        Me.texOrdendemesa.Name = "texOrdendemesa"
        Me.texOrdendemesa.Size = New System.Drawing.Size(95, 23)
        Me.texOrdendemesa.TabIndex = 9
        '
        'texMesadesufragio
        '
        Me.texMesadesufragio.Location = New System.Drawing.Point(190, 216)
        Me.texMesadesufragio.Name = "texMesadesufragio"
        Me.texMesadesufragio.Size = New System.Drawing.Size(95, 23)
        Me.texMesadesufragio.TabIndex = 8
        '
        'texDireccion
        '
        Me.texDireccion.Location = New System.Drawing.Point(190, 155)
        Me.texDireccion.Name = "texDireccion"
        Me.texDireccion.Size = New System.Drawing.Size(278, 23)
        Me.texDireccion.TabIndex = 5
        '
        'texCelular
        '
        Me.texCelular.Location = New System.Drawing.Point(190, 123)
        Me.texCelular.MaxLength = 9
        Me.texCelular.Name = "texCelular"
        Me.texCelular.Size = New System.Drawing.Size(95, 23)
        Me.texCelular.TabIndex = 4
        '
        'texApellidos
        '
        Me.texApellidos.Location = New System.Drawing.Point(190, 91)
        Me.texApellidos.Name = "texApellidos"
        Me.texApellidos.Size = New System.Drawing.Size(278, 23)
        Me.texApellidos.TabIndex = 3
        '
        'texNombres
        '
        Me.texNombres.Location = New System.Drawing.Point(190, 59)
        Me.texNombres.Name = "texNombres"
        Me.texNombres.Size = New System.Drawing.Size(278, 23)
        Me.texNombres.TabIndex = 2
        '
        'texDNI
        '
        Me.texDNI.Location = New System.Drawing.Point(190, 27)
        Me.texDNI.MaxLength = 8
        Me.texDNI.Name = "texDNI"
        Me.texDNI.Size = New System.Drawing.Size(95, 23)
        Me.texDNI.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(27, 359)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 15)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Aula"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(27, 331)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 15)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Piso"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(26, 303)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 15)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "N° pabellón"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(26, 275)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 15)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Local de votación"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(26, 247)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 15)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "N° orden de mesa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(26, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Mesa de sufragio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(26, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Miembro de mesa"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(26, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Dirección"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(26, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "N° Celular"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(26, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellidos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(26, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombres"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(26, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Tag = ""
        Me.Label1.Text = "N° DNI"
        '
        'btGuardar
        '
        Me.btGuardar.BackColor = System.Drawing.Color.Red
        Me.btGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btGuardar.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGuardar.ForeColor = System.Drawing.Color.White
        Me.btGuardar.Location = New System.Drawing.Point(556, 40)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(102, 38)
        Me.btGuardar.TabIndex = 1
        Me.btGuardar.Text = "Guardar"
        Me.btGuardar.UseVisualStyleBackColor = False
        '
        'btNuevo
        '
        Me.btNuevo.BackColor = System.Drawing.Color.Red
        Me.btNuevo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btNuevo.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNuevo.ForeColor = System.Drawing.Color.White
        Me.btNuevo.Location = New System.Drawing.Point(556, 87)
        Me.btNuevo.Name = "btNuevo"
        Me.btNuevo.Size = New System.Drawing.Size(102, 38)
        Me.btNuevo.TabIndex = 2
        Me.btNuevo.Text = "Nuevo"
        Me.btNuevo.UseVisualStyleBackColor = False
        '
        'btSalir
        '
        Me.btSalir.BackColor = System.Drawing.Color.Red
        Me.btSalir.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSalir.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalir.ForeColor = System.Drawing.Color.White
        Me.btSalir.Location = New System.Drawing.Point(556, 137)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(102, 38)
        Me.btSalir.TabIndex = 3
        Me.btSalir.Text = "Salir"
        Me.btSalir.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(531, 270)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 139)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(674, 436)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btSalir)
        Me.Controls.Add(Me.btNuevo)
        Me.Controls.Add(Me.btGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inscripción de Personeros Elecciones Venegas 2018"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents texAula As System.Windows.Forms.TextBox
    Friend WithEvents texPiso As System.Windows.Forms.TextBox
    Friend WithEvents texPabellon As System.Windows.Forms.TextBox
    Friend WithEvents texLocaldevotacion As System.Windows.Forms.TextBox
    Friend WithEvents texOrdendemesa As System.Windows.Forms.TextBox
    Friend WithEvents texMesadesufragio As System.Windows.Forms.TextBox
    Friend WithEvents texDireccion As System.Windows.Forms.TextBox
    Friend WithEvents texCelular As System.Windows.Forms.TextBox
    Friend WithEvents texApellidos As System.Windows.Forms.TextBox
    Friend WithEvents texNombres As System.Windows.Forms.TextBox
    Friend WithEvents texDNI As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btGuardar As System.Windows.Forms.Button
    Friend WithEvents btNuevo As System.Windows.Forms.Button
    Friend WithEvents btSalir As System.Windows.Forms.Button
    Friend WithEvents RadioNO As System.Windows.Forms.RadioButton
    Friend WithEvents RadioSI As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As PictureBox
End Class
