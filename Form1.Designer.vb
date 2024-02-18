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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        cmd_inicio = New Button()
        cmd_sair = New Button()
        cmd_alegre = New Button()
        cmd_triste = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        chkAlegre = New CheckBox()
        chkTriste = New CheckBox()
        cmd_modoNoturno = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmd_inicio
        ' 
        cmd_inicio.Location = New Point(193, 23)
        cmd_inicio.Name = "cmd_inicio"
        cmd_inicio.Size = New Size(109, 46)
        cmd_inicio.TabIndex = 0
        cmd_inicio.Text = "Inicio"
        cmd_inicio.UseVisualStyleBackColor = True
        ' 
        ' cmd_sair
        ' 
        cmd_sair.Location = New Point(207, 346)
        cmd_sair.Name = "cmd_sair"
        cmd_sair.Size = New Size(117, 53)
        cmd_sair.TabIndex = 1
        cmd_sair.Text = "Sair"
        cmd_sair.UseVisualStyleBackColor = True
        ' 
        ' cmd_alegre
        ' 
        cmd_alegre.Location = New Point(70, 312)
        cmd_alegre.Name = "cmd_alegre"
        cmd_alegre.Size = New Size(94, 29)
        cmd_alegre.TabIndex = 2
        cmd_alegre.Text = "Alegre"
        cmd_alegre.UseVisualStyleBackColor = True
        cmd_alegre.Visible = False
        ' 
        ' cmd_triste
        ' 
        cmd_triste.Location = New Point(349, 308)
        cmd_triste.Name = "cmd_triste"
        cmd_triste.Size = New Size(94, 29)
        cmd_triste.TabIndex = 3
        cmd_triste.Text = "Triste"
        cmd_triste.UseVisualStyleBackColor = True
        cmd_triste.Visible = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(39, 118)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(149, 149)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        PictureBox1.Visible = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(309, 118)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(164, 149)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        PictureBox2.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(85, 93)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 20)
        Label1.TabIndex = 6
        Label1.Text = "Alegre"
        Label1.Visible = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(366, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 20)
        Label2.TabIndex = 7
        Label2.Text = "Triste"
        Label2.Visible = False
        ' 
        ' chkAlegre
        ' 
        chkAlegre.AutoSize = True
        chkAlegre.Location = New Point(86, 278)
        chkAlegre.Name = "chkAlegre"
        chkAlegre.Size = New Size(75, 24)
        chkAlegre.TabIndex = 8
        chkAlegre.Text = "Alegre"
        chkAlegre.UseVisualStyleBackColor = True
        chkAlegre.Visible = False
        ' 
        ' chkTriste
        ' 
        chkTriste.AutoSize = True
        chkTriste.Location = New Point(358, 279)
        chkTriste.Name = "chkTriste"
        chkTriste.Size = New Size(66, 24)
        chkTriste.TabIndex = 9
        chkTriste.Text = "Triste"
        chkTriste.UseVisualStyleBackColor = True
        chkTriste.Visible = False
        ' 
        ' cmd_modoNoturno
        ' 
        cmd_modoNoturno.Location = New Point(434, 12)
        cmd_modoNoturno.Name = "cmd_modoNoturno"
        cmd_modoNoturno.Size = New Size(73, 54)
        cmd_modoNoturno.TabIndex = 10
        cmd_modoNoturno.Text = "Modo Noturno"
        cmd_modoNoturno.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(519, 421)
        Controls.Add(cmd_modoNoturno)
        Controls.Add(chkTriste)
        Controls.Add(chkAlegre)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(cmd_triste)
        Controls.Add(cmd_alegre)
        Controls.Add(cmd_sair)
        Controls.Add(cmd_inicio)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmd_inicio As Button
    Friend WithEvents cmd_sair As Button
    Friend WithEvents cmd_alegre As Button
    Friend WithEvents cmd_triste As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents chkAlegre As CheckBox
    Friend WithEvents chkTriste As CheckBox
    Friend WithEvents cmd_modoNoturno As Button
End Class
