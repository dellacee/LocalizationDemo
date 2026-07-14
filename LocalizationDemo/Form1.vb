Imports System.Data.SqlClient

Public Class Form1

    Private connectionString As String =
        "Server=(localdb)\MSSQLLocalDB;Database=LocalizationDemo;Trusted_Connection=True;"

    Private Const DEFAULT_LANGUAGE As String = "en"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtLanguage.Text = DEFAULT_LANGUAGE

        Try

            Using conn As New SqlConnection(connectionString)

                conn.Open()

                MessageBox.Show("Connected Successfully")

            End Using

        Catch ex As Exception

            MessageBox.Show(
                "Database connection failed." &
                Environment.NewLine &
                ex.Message)

        End Try

    End Sub

    Private Function GetValidLanguage(userInput As String) As String

        If String.IsNullOrWhiteSpace(userInput) Then
            Return DEFAULT_LANGUAGE
        End If

        userInput = userInput.Trim()

        If userInput = "en" Then
            Return "en"
        End If

        If userInput = "da-DK" Then
            Return "da-DK"
        End If

        Return DEFAULT_LANGUAGE

    End Function

    Private Function GetServiceTypes(languageCode As String) As List(Of ServiceType)
        Dim result As New List(Of ServiceType)

        ' 1. Sửa SQL: Thêm điều kiện lọc ngôn ngữ và đặt alias khớp với class
        Dim sql As String = "
        SELECT st.id, 
               ISNULL(loc.localized_name, st.name) AS Name 
        FROM service_type st
        LEFT JOIN service_type_localization loc ON st.id = loc.service_type_id AND loc.language_code = @LanguageCode"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@LanguageCode", languageCode)
                conn.Open()

                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        result.Add(New ServiceType With {
                        .Id = Convert.ToInt32(reader("id")),
                        .Name = reader("Name").ToString()
                    })
                    End While
                End Using
            End Using
        End Using

        Return result
    End Function


    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

        Dim services As List(Of ServiceType)

        services = GetServiceTypes(txtLanguage.Text)

        dgvServices.DataSource = Nothing
        dgvServices.DataSource = services

    End Sub
End Class