<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculadora
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
        Me.txtbx2 = New System.Windows.Forms.TextBox()
        Me.txtbx1 = New System.Windows.Forms.TextBox()
        Me.txtbx3 = New System.Windows.Forms.TextBox()
        Me.btnSuma = New System.Windows.Forms.Button()
        Me.lbl = New System.Windows.Forms.Label()
        Me.btnResta = New System.Windows.Forms.Button()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.btnMulti = New System.Windows.Forms.Button()
        Me.btnSal = New System.Windows.Forms.Button()
        Me.btnLimp = New System.Windows.Forms.Button()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtbx2
        '
        Me.txtbx2.Location = New System.Drawing.Point(68, 62)
        Me.txtbx2.Name = "txtbx2"
        Me.txtbx2.Size = New System.Drawing.Size(100, 20)
        Me.txtbx2.TabIndex = 0
        '
        'txtbx1
        '
        Me.txtbx1.Location = New System.Drawing.Point(68, 27)
        Me.txtbx1.Name = "txtbx1"
        Me.txtbx1.Size = New System.Drawing.Size(100, 20)
        Me.txtbx1.TabIndex = 18
        '
        'txtbx3
        '
        Me.txtbx3.Location = New System.Drawing.Point(68, 99)
        Me.txtbx3.Name = "txtbx3"
        Me.txtbx3.Size = New System.Drawing.Size(100, 20)
        Me.txtbx3.TabIndex = 19
        '
        'btnSuma
        '
        Me.btnSuma.Location = New System.Drawing.Point(17, 159)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(75, 23)
        Me.btnSuma.TabIndex = 20
        Me.btnSuma.Text = "+"
        Me.btnSuma.UseVisualStyleBackColor = True
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(6, 34)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(53, 13)
        Me.lbl.TabIndex = 21
        Me.lbl.Text = "Numero 1"
        '
        'btnResta
        '
        Me.btnResta.Location = New System.Drawing.Point(98, 159)
        Me.btnResta.Name = "btnResta"
        Me.btnResta.Size = New System.Drawing.Size(75, 23)
        Me.btnResta.TabIndex = 22
        Me.btnResta.Text = "-"
        Me.btnResta.UseVisualStyleBackColor = True
        '
        'btnDiv
        '
        Me.btnDiv.Location = New System.Drawing.Point(179, 158)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(75, 25)
        Me.btnDiv.TabIndex = 23
        Me.btnDiv.Text = "/"
        Me.btnDiv.UseVisualStyleBackColor = True
        '
        'btnMulti
        '
        Me.btnMulti.Location = New System.Drawing.Point(260, 157)
        Me.btnMulti.Name = "btnMulti"
        Me.btnMulti.Size = New System.Drawing.Size(75, 23)
        Me.btnMulti.TabIndex = 24
        Me.btnMulti.Text = "*"
        Me.btnMulti.UseVisualStyleBackColor = True
        '
        'btnSal
        '
        Me.btnSal.Location = New System.Drawing.Point(260, 232)
        Me.btnSal.Name = "btnSal"
        Me.btnSal.Size = New System.Drawing.Size(75, 23)
        Me.btnSal.TabIndex = 26
        Me.btnSal.Text = "Salir"
        Me.btnSal.UseVisualStyleBackColor = True
        '
        'btnLimp
        '
        Me.btnLimp.Location = New System.Drawing.Point(68, 234)
        Me.btnLimp.Name = "btnLimp"
        Me.btnLimp.Size = New System.Drawing.Size(75, 23)
        Me.btnLimp.TabIndex = 27
        Me.btnLimp.Text = "Limpiar"
        Me.btnLimp.UseVisualStyleBackColor = True
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(6, 65)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(53, 13)
        Me.lbl2.TabIndex = 28
        Me.lbl2.Text = "Numero 2"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(6, 102)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(55, 13)
        Me.lbl3.TabIndex = 29
        Me.lbl3.Text = "Resultado"
        '
        'Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 269)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.btnLimp)
        Me.Controls.Add(Me.btnSal)
        Me.Controls.Add(Me.btnMulti)
        Me.Controls.Add(Me.btnDiv)
        Me.Controls.Add(Me.btnResta)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.btnSuma)
        Me.Controls.Add(Me.txtbx3)
        Me.Controls.Add(Me.txtbx1)
        Me.Controls.Add(Me.txtbx2)
        Me.Name = "Calculadora"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtbx2 As System.Windows.Forms.TextBox
    Friend WithEvents txtbx1 As System.Windows.Forms.TextBox
    Friend WithEvents txtbx3 As System.Windows.Forms.TextBox
    Friend WithEvents btnSuma As System.Windows.Forms.Button
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents btnResta As System.Windows.Forms.Button
    Friend WithEvents btnDiv As System.Windows.Forms.Button
    Friend WithEvents btnMulti As System.Windows.Forms.Button
    Friend WithEvents btnSal As System.Windows.Forms.Button
    Friend WithEvents btnLimp As System.Windows.Forms.Button
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label

End Class
