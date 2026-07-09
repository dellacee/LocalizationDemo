Imports System.Data.SqlClient
Public Class Form1

    Private connectionString As String = "Server=(localdb)\MSSQLLocalDB;Database=LocalizationDemo;Trusted_Connection=True;"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cboLanguage.Items.Add("en")
        cboLanguage.Items.Add("da-DK")

        cboLanguage.SelectedIndex = 0

        Using conn As New SqlConnection(connectionString)
            conn.Open()
            MessageBox.Show("Connected")
        End Using

        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                MessageBox.Show("Connected Successfully")
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Function GetServiceTypes(languageCode As String) As List(Of ServiceType)

        If String.IsNullOrWhiteSpace(languageCode) Then
            languageCode = "en"
        End If
        Dim result As New List(Of ServiceType)
        Dim sql As String =
    "
SELECT
    st.id,
    CASE
        WHEN @LanguageCode = 'en'
            THEN st.name
        ELSE ISNULL(loc.localized_name, st.name)
    END AS DisplayName
FROM service_type st
LEFT JOIN service_type_localization loc
    ON st.id = loc.service_type_id
    AND loc.language_code = @LanguageCode
ORDER BY st.id
"

        Using conn As New SqlConnection(connectionString)

            conn.Open()

            Using cmd As New SqlCommand(sql, conn)

                cmd.Parameters.AddWithValue("@LanguageCode", languageCode)

                Using reader As SqlDataReader =
                    cmd.ExecuteReader()

                    While reader.Read()

                        result.Add(
                            New ServiceType With {
                                .Id = Convert.ToInt32(reader("id")),
                                .Name = reader("DisplayName").ToString()
                            })

                    End While

                End Using

            End Using

        End Using

        Return result

    End Function


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLanguage.SelectedIndexChanged

    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

        Dim services = GetServiceTypes(cboLanguage.Text)
        dgvServices.DataSource = services

    End Sub

End Class







