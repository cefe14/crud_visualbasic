<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnCerrarF2 = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.tbfnacim = New System.Windows.Forms.TextBox()
        Me.tbTelefono = New System.Windows.Forms.TextBox()
        Me.tbDireccion = New System.Windows.Forms.TextBox()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.lblfec = New System.Windows.Forms.Label()
        Me.lbltel = New System.Windows.Forms.Label()
        Me.lbldirec = New System.Windows.Forms.Label()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.tbciudad = New System.Windows.Forms.TextBox()
        Me.lblCiudad = New System.Windows.Forms.Label()
        Me.btnCiudad = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCerrarF2
        '
        Me.btnCerrarF2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCerrarF2.Location = New System.Drawing.Point(52, 305)
        Me.btnCerrarF2.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCerrarF2.Name = "btnCerrarF2"
        Me.btnCerrarF2.Size = New System.Drawing.Size(109, 39)
        Me.btnCerrarF2.TabIndex = 0
        Me.btnCerrarF2.Text = "CANCELAR"
        Me.btnCerrarF2.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Location = New System.Drawing.Point(288, 305)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(109, 39)
        Me.btnUpdate.TabIndex = 66
        Me.btnUpdate.Text = "ACTUALIZAR"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'tbfnacim
        '
        Me.tbfnacim.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbfnacim.Location = New System.Drawing.Point(288, 196)
        Me.tbfnacim.Margin = New System.Windows.Forms.Padding(4)
        Me.tbfnacim.Multiline = True
        Me.tbfnacim.Name = "tbfnacim"
        Me.tbfnacim.Size = New System.Drawing.Size(255, 32)
        Me.tbfnacim.TabIndex = 74
        '
        'tbTelefono
        '
        Me.tbTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTelefono.Location = New System.Drawing.Point(288, 82)
        Me.tbTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.tbTelefono.Multiline = True
        Me.tbTelefono.Name = "tbTelefono"
        Me.tbTelefono.Size = New System.Drawing.Size(255, 32)
        Me.tbTelefono.TabIndex = 72
        '
        'tbDireccion
        '
        Me.tbDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDireccion.Location = New System.Drawing.Point(288, 140)
        Me.tbDireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.tbDireccion.Multiline = True
        Me.tbDireccion.Name = "tbDireccion"
        Me.tbDireccion.Size = New System.Drawing.Size(255, 32)
        Me.tbDireccion.TabIndex = 73
        '
        'tbNombre
        '
        Me.tbNombre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombre.Location = New System.Drawing.Point(288, 25)
        Me.tbNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.tbNombre.Multiline = True
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbNombre.Size = New System.Drawing.Size(255, 32)
        Me.tbNombre.TabIndex = 71
        '
        'lblfec
        '
        Me.lblfec.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfec.Location = New System.Drawing.Point(53, 196)
        Me.lblfec.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblfec.Name = "lblfec"
        Me.lblfec.Size = New System.Drawing.Size(231, 30)
        Me.lblfec.TabIndex = 70
        Me.lblfec.Text = "Fecha de nacimiento"
        '
        'lbltel
        '
        Me.lbltel.AutoSize = True
        Me.lbltel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltel.Location = New System.Drawing.Point(49, 88)
        Me.lbltel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltel.Name = "lbltel"
        Me.lbltel.Size = New System.Drawing.Size(66, 18)
        Me.lbltel.TabIndex = 69
        Me.lbltel.Text = "Telefono"
        '
        'lbldirec
        '
        Me.lbldirec.AutoSize = True
        Me.lbldirec.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldirec.Location = New System.Drawing.Point(53, 146)
        Me.lbldirec.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldirec.Name = "lbldirec"
        Me.lbldirec.Size = New System.Drawing.Size(71, 18)
        Me.lbldirec.TabIndex = 68
        Me.lbldirec.Text = "Direccion"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.Location = New System.Drawing.Point(49, 31)
        Me.lblnombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(62, 18)
        Me.lblnombre.TabIndex = 67
        Me.lblnombre.Text = "Nombre"
        '
        'btnCrear
        '
        Me.btnCrear.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCrear.Location = New System.Drawing.Point(434, 305)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(109, 39)
        Me.btnCrear.TabIndex = 75
        Me.btnCrear.Text = "REGISTRO"
        Me.btnCrear.UseVisualStyleBackColor = False
        '
        'tbciudad
        '
        Me.tbciudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbciudad.Location = New System.Drawing.Point(288, 245)
        Me.tbciudad.Margin = New System.Windows.Forms.Padding(4)
        Me.tbciudad.Multiline = True
        Me.tbciudad.Name = "tbciudad"
        Me.tbciudad.Size = New System.Drawing.Size(255, 32)
        Me.tbciudad.TabIndex = 77
        Me.tbciudad.Text = "2"
        '
        'lblCiudad
        '
        Me.lblCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCiudad.Location = New System.Drawing.Point(53, 245)
        Me.lblCiudad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCiudad.Name = "lblCiudad"
        Me.lblCiudad.Size = New System.Drawing.Size(231, 30)
        Me.lblCiudad.TabIndex = 76
        Me.lblCiudad.Text = "Ciudad"
        '
        'btnCiudad
        '
        Me.btnCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCiudad.Location = New System.Drawing.Point(562, 245)
        Me.btnCiudad.Name = "btnCiudad"
        Me.btnCiudad.Size = New System.Drawing.Size(46, 32)
        Me.btnCiudad.TabIndex = 78
        Me.btnCiudad.Text = "🗺️"
        Me.btnCiudad.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCiudad.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(715, 380)
        Me.Controls.Add(Me.btnCiudad)
        Me.Controls.Add(Me.tbciudad)
        Me.Controls.Add(Me.lblCiudad)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.tbfnacim)
        Me.Controls.Add(Me.tbTelefono)
        Me.Controls.Add(Me.tbDireccion)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.lblfec)
        Me.Controls.Add(Me.lbltel)
        Me.Controls.Add(Me.lbldirec)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCerrarF2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar"
        Me.TransparencyKey = System.Drawing.Color.DimGray
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCerrarF2 As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents tbfnacim As TextBox
    Friend WithEvents tbTelefono As TextBox
    Friend WithEvents tbDireccion As TextBox
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents lblfec As Label
    Friend WithEvents lbltel As Label
    Friend WithEvents lbldirec As Label
    Friend WithEvents lblnombre As Label
    Friend WithEvents btnCrear As Button
    Friend WithEvents tbciudad As TextBox
    Friend WithEvents lblCiudad As Label
    Friend WithEvents btnCiudad As Button
End Class
