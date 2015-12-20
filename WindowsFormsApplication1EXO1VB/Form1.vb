'Daniel  asdf
Public Class Form1

    Dim Reduction1 As Integer = 0
    Dim Reduction2 As Integer = 0



    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Reduction1 = 20
        showReduction()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Reduction1 = 15
        showReduction()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Reduction1 = 0
        showReduction()
    End Sub

    Private Sub showReduction() Handles RadioButton3.CheckedChanged
        Label2.Text = Reduction1 + Reduction2 & "%"

    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' La ligne de commande en dessous permet d'afficher une valeur par défault dans la combobox.
        ' ComboBox1.Text = ComboBox1.Items(0)
        ComboBox1.SelectedIndex = 0
    End Sub



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        Dim contenu As String = ComboBox1.Text
        Dim position As Integer = ComboBox1.SelectedIndex

        'Cela permet d'afficher les 

        If contenu = "1" Then
            Reduction2 = 10
        Else
            Reduction2 = 0

        End If

        ' Le select case permet de choisir les "items" par leur position dans la combobox.

        Select Case position
            Case 0
                Reduction2 = 10
            Case 1
                Reduction2 = 15
            Case 2
                Reduction2 = 20
            Case Else
                Reduction2 = 0
        End Select

        Debug.WriteLine(ComboBox1.Text)
        Debug.WriteLine(ComboBox1.SelectedIndex)

        showReduction()

    End Sub
End Class
