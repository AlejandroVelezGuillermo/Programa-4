<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnCrearEmpleado = New Button()
        txtNombre = New TextBox()
        txtSalario = New TextBox()
        btnCrearGerente = New Button()
        txtDepartamento = New TextBox()
        SuspendLayout()
        ' 
        ' btnCrearEmpleado
        ' 
        btnCrearEmpleado.Location = New Point(258, 127)
        btnCrearEmpleado.Name = "btnCrearEmpleado"
        btnCrearEmpleado.Size = New Size(199, 29)
        btnCrearEmpleado.TabIndex = 0
        btnCrearEmpleado.Text = "Crear Empleo"
        btnCrearEmpleado.UseVisualStyleBackColor = True
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(292, 51)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(125, 27)
        txtNombre.TabIndex = 1
        ' 
        ' txtSalario
        ' 
        txtSalario.Location = New Point(292, 84)
        txtSalario.Name = "txtSalario"
        txtSalario.Size = New Size(125, 27)
        txtSalario.TabIndex = 2
        ' 
        ' btnCrearGerente
        ' 
        btnCrearGerente.Location = New Point(258, 201)
        btnCrearGerente.Name = "btnCrearGerente"
        btnCrearGerente.Size = New Size(199, 29)
        btnCrearGerente.TabIndex = 3
        btnCrearGerente.Text = "Crear Gerente"
        btnCrearGerente.UseVisualStyleBackColor = True
        ' 
        ' txtDepartamento
        ' 
        txtDepartamento.Location = New Point(292, 255)
        txtDepartamento.Name = "txtDepartamento"
        txtDepartamento.Size = New Size(125, 27)
        txtDepartamento.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtDepartamento)
        Controls.Add(btnCrearGerente)
        Controls.Add(txtSalario)
        Controls.Add(txtNombre)
        Controls.Add(btnCrearEmpleado)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCrearEmpleado As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtSalario As TextBox
    Friend WithEvents btnCrearGerente As Button
    Friend WithEvents txtDepartamento As TextBox
End Class
