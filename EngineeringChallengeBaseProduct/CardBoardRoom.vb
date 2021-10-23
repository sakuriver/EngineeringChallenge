Public Class CardBoardRoom
    Dim SetMesage As String
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim dialog As New DamboleDetail()
        SetFirstMessage()
        dialog.Message = SetMesage
        dialog.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim dialog As New DamboleDetail()
        SetSecondMessage()
        dialog.Message = SetMesage
        dialog.Show()
    End Sub

    Private Sub SetFirstMessage()
        SetMesage = "箱番号: 1 " + Environment.NewLine
        SetMesage += "合計ダンボール個数 3 " + Environment.NewLine
        SetMesage += "1個目のメロンId 4 " + Environment.NewLine
        SetMesage += "2個目のメロンId 7 " + Environment.NewLine
        SetMesage += "3個目のメロンId 18 " + Environment.NewLine
        SetMesage += "合計重量 5.728kg " + Environment.NewLine
        SetMesage += "販売価格 4600円 " + Environment.NewLine
    End Sub

    Private Sub SetSecondMessage()
        SetMesage = "箱番号: 2 " + Environment.NewLine
        SetMesage += "合計ダンボール個数 2 " + Environment.NewLine
        SetMesage += "1個目のメロンId 26 " + Environment.NewLine
        SetMesage += "2個目のメロンId 29 " + Environment.NewLine
        SetMesage += "合計重量 5.434kg " + Environment.NewLine
        SetMesage += "販売価格 4350円 " + Environment.NewLine
    End Sub


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim dialog As New DamboleDetail()
        SetFirstMessage()
        dialog.Message = SetMesage
        dialog.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim dialog As New DamboleDetail()
        SetSecondMessage()
        dialog.Message = SetMesage
        dialog.Show()
    End Sub
End Class