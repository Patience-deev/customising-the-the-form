Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "My first VB2022 App"
        Me.BackColor = Color.Blue
        Me.MaximizeBox = True
        Me.MinimizeBox = True
        Me.Size = New Size(800, 400)
        Me.Opacity = 0.85
        Me.CenterToParent()

    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()

    End Sub
    Private Sub button1_Click(Sender As Object, e As EventArgs) Handles btnPatienceSedibeng.Click
        MsgBox("This is Patience")
    End Sub
End Class
