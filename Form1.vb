Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim resposta = MessageBox.Show("Welcome to the Proj1 da Erika", "vb.NET",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Sub ModoNoturno() 'ATIVA MODO NOTURNO

        If cmd_modoNoturno.Enabled Then
            Inicio()
            Me.BackColor = Color.Black
            Label1.ForeColor = Color.White
            Label2.ForeColor = Color.White
            chkAlegre.ForeColor = Color.White
            chkTriste.ForeColor = Color.White

        ElseIf cmd_modoNoturno.Enabled = False Then
            Me.BackColor = Color.White
            Label1.ForeColor = Color.Black
            Label2.ForeColor = Color.Black
            chkAlegre.ForeColor = Color.Black
            chkTriste.ForeColor = Color.Black
        End If
    End Sub


    Sub Alegre()
        PictureBox1.Show()
        Label1.Show()

        PictureBox2.Hide()
        Label2.Hide()

        cmd_alegre.Enabled = False
        cmd_triste.Enabled = True

        chkAlegre.Checked = True
        chkTriste.Checked = False
    End Sub


    Sub Triste()
        PictureBox2.Show()
        Label2.Show()

        PictureBox1.Hide()
        Label1.Hide()

        cmd_triste.Enabled = False
        cmd_alegre.Enabled = True

        chkAlegre.Checked = False
        chkTriste.Checked = True
    End Sub


    Sub Inicio()
        cmd_alegre.Show()
        PictureBox1.Show()
        chkAlegre.Show()
        Label1.Show()

        cmd_triste.Show()
        PictureBox2.Show()
        chkTriste.Show()
        Label2.Show()

        cmd_modoNoturno.Show()

        cmd_triste.Enabled = False
        PictureBox2.Enabled = False
        chkTriste.Enabled = True
        Label2.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmd_inicio.Click
        Inicio()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles cmd_alegre.Click
        Alegre()
        Me.BackColor = Color.YellowGreen
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkAlegre.CheckedChanged
        If chkAlegre.Checked = True Then
            Alegre()
        Else
            Triste()
        End If
    End Sub

    Private Sub cmd_sair_Click(sender As Object, e As EventArgs) Handles cmd_sair.Click
        'cmd_inicio.Show()
        'me.close()
        End
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub cmd_triste_Click(sender As Object, e As EventArgs) Handles cmd_triste.Click
        Triste()
        Me.BackColor = Color.DarkRed
    End Sub

    Private Sub chkTriste_CheckedChanged(sender As Object, e As EventArgs) Handles chkTriste.CheckedChanged
        If chkTriste.Checked = True Then
            Triste()
        Else
            Alegre()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles cmd_modoNoturno.Click
        ModoNoturno()
    End Sub
End Class
