Imports System.Configuration
Imports System.Data.SqlClient
Imports Microsoft.IdentityModel.Protocols

Public Class ServiceRepository
    Private ReadOnly _connectionString As String =
        ConfigurationManager.ConnectionStrings("MyDbConnection").ConnectionString

    Public Function GetServices(languageCode As String) As List(Of ServiceType)
        Dim result As New List(Of ServiceType)

        Dim sql As String = "
            SELECT st.id, 
                   ISNULL(loc.localized_name, st.name) AS Name 
            FROM service_type st
            LEFT JOIN service_type_localization loc ON st.id = loc.service_type_id 
            AND loc.language_code = @LanguageCode"

        Try
            Using conn As New SqlConnection(_connectionString)
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
        Catch ex As SqlException
            Throw New Exception("Data query error: " & ex.Message)
        End Try

        Return result
    End Function
End Class
