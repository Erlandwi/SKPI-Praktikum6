Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.GridLines = True
        ListView1.View = View.Details
        ListView1.Columns.Add("NIM")
        ListView1.Columns.Add("NAMA", 115)
        ListView1.Columns.Add("PRODI", 115)
        Txtnim.Text = 1
        Txtnama.Focus()
    End Sub

    Private Sub Btambah_Click(sender As Object, e As EventArgs) Handles Btambah.Click
        Dim ARR(2) As String
        ARR(0) = Txtnim.Text
        ARR(1) = Txtnama.Text
        ARR(2) = Txtprodi.Text

        Dim listitem As ListViewItem
        listitem = New ListViewItem
        listitem = ListView1.Items.Add(ARR(0))
        listitem.SubItems.Add(ARR(1))
        listitem.SubItems.Add(ARR(2))

        Txtnim.Text = Txtnim.Text + 1
        Txtnama.Clear()
        Txtprodi.Clear()
        Txtnama.Focus()
    End Sub
End Class
