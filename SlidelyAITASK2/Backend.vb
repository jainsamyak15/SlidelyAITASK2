﻿Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property PhoneNum As String
    Public Property GithubLink As String
    Public Property StopwatchTime As String
End Class

Public Module Backend
    Public Submissions As New List(Of Submission)
End Module
