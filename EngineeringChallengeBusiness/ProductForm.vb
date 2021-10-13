Public Class ProductForm
    Private Sub ProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim LegalCheckForm As New LegalCheckForm()
        LegalCheckForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ProductApplyForm As New ProductApplyForm()
        ProductApplyForm.Show()
    End Sub
End Class
