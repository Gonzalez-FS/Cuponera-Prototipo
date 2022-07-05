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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_ingreso = New System.Windows.Forms.Button()
        Me.Btn_registro = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(338, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenido a la página de la tienda"
        '
        'Btn_ingreso
        '
        Me.Btn_ingreso.Location = New System.Drawing.Point(31, 459)
        Me.Btn_ingreso.Name = "Btn_ingreso"
        Me.Btn_ingreso.Size = New System.Drawing.Size(103, 43)
        Me.Btn_ingreso.TabIndex = 1
        Me.Btn_ingreso.Text = "Ingresar"
        Me.Btn_ingreso.UseVisualStyleBackColor = True
        '
        'Btn_registro
        '
        Me.Btn_registro.Location = New System.Drawing.Point(318, 459)
        Me.Btn_registro.Name = "Btn_registro"
        Me.Btn_registro.Size = New System.Drawing.Size(112, 43)
        Me.Btn_registro.TabIndex = 2
        Me.Btn_registro.Text = "Registrarse"
        Me.Btn_registro.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(194, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 42)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "😃"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(460, 551)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btn_registro)
        Me.Controls.Add(Me.Btn_ingreso)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_ingreso As Button
    Friend WithEvents Btn_registro As Button
    Friend WithEvents Label2 As Label
End Class
