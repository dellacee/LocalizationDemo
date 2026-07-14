Public Class Form1
    ' Khởi tạo Repository
    Private ReadOnly _repository As New ServiceRepository()
    Private Const DEFAULT_LANGUAGE As String = "en"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtLanguage.Text = DEFAULT_LANGUAGE
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Try
            Dim lang As String = GetValidLanguage(txtLanguage.Text)

            Dim services As List(Of ServiceType) = _repository.GetServices(lang)

            dgvServices.DataSource = Nothing
            dgvServices.DataSource = services

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetValidLanguage(userInput As String) As String
        Dim input As String = If(String.IsNullOrWhiteSpace(userInput), "", userInput.Trim())

        If input = "en" OrElse input = "da-DK" Then
            Return input
        End If

        Return DEFAULT_LANGUAGE
    End Function
End Class
