Public Class ViewSubmissionsForm

    Private currentIndex As Integer = 0

    ' This is the single Load event handler
    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        LoadSubmission(currentIndex)
    End Sub

    Private Sub LoadSubmission(index As Integer)
        ' Logic to load submission data from the backend
        ' For example purposes, using dummy data
        txtName.Text = "John Doe"
        txtEmail.Text = "johndoe@gmail.com"
        txtPhoneNum.Text = "9876543210"
        txtGithubLink.Text = "https://github.com/john_doe/my_slidely_task/"
        txtStopwatchTime.Text = "00:01:19"
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            LoadSubmission(currentIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' Assuming we have a max of 10 submissions
        If currentIndex < 9 Then
            currentIndex += 1
            LoadSubmission(currentIndex)
        End If
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        End If
    End Sub

End Class
