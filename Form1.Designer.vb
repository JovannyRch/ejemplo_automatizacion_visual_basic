<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbxTipoUva = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxTipoVino = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCantidadVino = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdTemperatura3 = New System.Windows.Forms.RadioButton()
        Me.rdTemperatura2 = New System.Windows.Forms.RadioButton()
        Me.rdTemperatura1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbPresion3 = New System.Windows.Forms.RadioButton()
        Me.rbPresion2 = New System.Windows.Forms.RadioButton()
        Me.rbPresion1 = New System.Windows.Forms.RadioButton()
        Me.cslProceso = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PRIMERA ETAPA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(256, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SEGUNDA ETAPA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 304)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "TERCERA ETAPA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(256, 304)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "PROPIEDADES DEL PROCESO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Ingrese tipo de uva a utilizar"
        '
        'cbxTipoUva
        '
        Me.cbxTipoUva.AutoCompleteCustomSource.AddRange(New String() {"Sauvignon", "Cariñena ", "Carménère", "Garnacha ", "Malbec", "Merlot", "Nebbiolo", "Pinot Noir"})
        Me.cbxTipoUva.FormattingEnabled = True
        Me.cbxTipoUva.Items.AddRange(New Object() {"Cabernet Sauvignon", "Carignan", "Carménère", "Garnacha", "Malbec", "Merlot", "Nebbiolo", "Pinot Noir"})
        Me.cbxTipoUva.Location = New System.Drawing.Point(24, 80)
        Me.cbxTipoUva.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxTipoUva.Name = "cbxTipoUva"
        Me.cbxTipoUva.Size = New System.Drawing.Size(173, 23)
        Me.cbxTipoUva.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Ingrese tipo de vino a producir"
        '
        'cbxTipoVino
        '
        Me.cbxTipoVino.FormattingEnabled = True
        Me.cbxTipoVino.Items.AddRange(New Object() {"Blanco", "Rosado", "Tinto", "Clarete"})
        Me.cbxTipoVino.Location = New System.Drawing.Point(24, 143)
        Me.cbxTipoVino.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxTipoVino.Name = "cbxTipoVino"
        Me.cbxTipoVino.Size = New System.Drawing.Size(173, 23)
        Me.cbxTipoVino.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(183, 15)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Cantidad de litros vino a producir"
        '
        'txtCantidadVino
        '
        Me.txtCantidadVino.Location = New System.Drawing.Point(25, 211)
        Me.txtCantidadVino.Name = "txtCantidadVino"
        Me.txtCantidadVino.Size = New System.Drawing.Size(172, 23)
        Me.txtCantidadVino.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdTemperatura3)
        Me.GroupBox1.Controls.Add(Me.rdTemperatura2)
        Me.GroupBox1.Controls.Add(Me.rdTemperatura1)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 346)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(175, 142)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Temperatura fermentación"
        '
        'rdTemperatura3
        '
        Me.rdTemperatura3.AutoSize = True
        Me.rdTemperatura3.Location = New System.Drawing.Point(7, 111)
        Me.rdTemperatura3.Name = "rdTemperatura3"
        Me.rdTemperatura3.Size = New System.Drawing.Size(50, 19)
        Me.rdTemperatura3.TabIndex = 2
        Me.rdTemperatura3.TabStop = True
        Me.rdTemperatura3.Text = "30°C"
        Me.rdTemperatura3.UseVisualStyleBackColor = True
        '
        'rdTemperatura2
        '
        Me.rdTemperatura2.AutoSize = True
        Me.rdTemperatura2.Location = New System.Drawing.Point(7, 74)
        Me.rdTemperatura2.Name = "rdTemperatura2"
        Me.rdTemperatura2.Size = New System.Drawing.Size(50, 19)
        Me.rdTemperatura2.TabIndex = 1
        Me.rdTemperatura2.TabStop = True
        Me.rdTemperatura2.Text = "25°C"
        Me.rdTemperatura2.UseVisualStyleBackColor = True
        '
        'rdTemperatura1
        '
        Me.rdTemperatura1.AutoSize = True
        Me.rdTemperatura1.Location = New System.Drawing.Point(6, 35)
        Me.rdTemperatura1.Name = "rdTemperatura1"
        Me.rdTemperatura1.Size = New System.Drawing.Size(50, 19)
        Me.rdTemperatura1.TabIndex = 0
        Me.rdTemperatura1.TabStop = True
        Me.rdTemperatura1.Text = "18°C"
        Me.rdTemperatura1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbPresion3)
        Me.GroupBox2.Controls.Add(Me.rbPresion2)
        Me.GroupBox2.Controls.Add(Me.rbPresion1)
        Me.GroupBox2.Location = New System.Drawing.Point(256, 42)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(164, 157)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Presión de la prensa"
        '
        'rbPresion3
        '
        Me.rbPresion3.AutoSize = True
        Me.rbPresion3.Location = New System.Drawing.Point(15, 108)
        Me.rbPresion3.Name = "rbPresion3"
        Me.rbPresion3.Size = New System.Drawing.Size(85, 19)
        Me.rbPresion3.TabIndex = 2
        Me.rbPresion3.TabStop = True
        Me.rbPresion3.Text = "3.5 Kg/cm2"
        Me.rbPresion3.UseVisualStyleBackColor = True
        '
        'rbPresion2
        '
        Me.rbPresion2.AutoSize = True
        Me.rbPresion2.Location = New System.Drawing.Point(15, 72)
        Me.rbPresion2.Name = "rbPresion2"
        Me.rbPresion2.Size = New System.Drawing.Size(76, 19)
        Me.rbPresion2.TabIndex = 1
        Me.rbPresion2.TabStop = True
        Me.rbPresion2.Text = "3 Kg/cm2"
        Me.rbPresion2.UseVisualStyleBackColor = True
        '
        'rbPresion1
        '
        Me.rbPresion1.AutoSize = True
        Me.rbPresion1.Location = New System.Drawing.Point(15, 36)
        Me.rbPresion1.Name = "rbPresion1"
        Me.rbPresion1.Size = New System.Drawing.Size(85, 19)
        Me.rbPresion1.TabIndex = 0
        Me.rbPresion1.TabStop = True
        Me.rbPresion1.Text = "2.5 Kg/cm2"
        Me.rbPresion1.UseVisualStyleBackColor = True
        '
        'cslProceso
        '
        Me.cslProceso.Location = New System.Drawing.Point(263, 346)
        Me.cslProceso.Multiline = True
        Me.cslProceso.Name = "cslProceso"
        Me.cslProceso.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.cslProceso.Size = New System.Drawing.Size(168, 157)
        Me.cslProceso.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(157, 552)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Iniciar Proceso"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 605)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cslProceso)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtCantidadVino)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbxTipoVino)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbxTipoUva)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Proceso elaboración Vino"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbxTipoUva As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbxTipoVino As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCantidadVino As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdTemperatura3 As RadioButton
    Friend WithEvents rdTemperatura2 As RadioButton
    Friend WithEvents rdTemperatura1 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbPresion3 As RadioButton
    Friend WithEvents rbPresion2 As RadioButton
    Friend WithEvents rbPresion1 As RadioButton
    Friend WithEvents cslProceso As TextBox
    Friend WithEvents Button1 As Button
End Class
