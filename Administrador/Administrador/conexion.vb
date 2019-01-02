Imports System.Data.SqlClient
Module conexion
    Public conPuntoVenta As New SqlConnection("Data Source=.\SQLEXPRESS;" &
                "AttachDbFilename=c:\TacosTime\TacosTime.mdf;" &
                "Integrated Security=True;" &
                "User Instance=True;" &
                "Connect Timeout=30")
    Public Function conectar() As Short
        'Se intenta la coneccion a la base de datos
        Try
            conPuntoVenta.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("No se pudo realizar la conexion")
            Return 1
        End Try
        Return 1
    End Function

    Public Sub consultas(ByRef dgv As DataGridView, strConsulta As String)
        If conectar() = 0 Then
            Exit Sub
        End If

        Dim cmdConsulta = New SqlCommand(strConsulta, conPuntoVenta)
        Dim adpPuntodeVenta As New SqlDataAdapter
        adpPuntodeVenta.SelectCommand = cmdConsulta

        Dim dstPuntodeVenta As New DataSet
        adpPuntodeVenta.Fill(dstPuntodeVenta, "Personas")

        If dstPuntodeVenta.Tables("Personas").Rows.Count = 0 Then
            MsgBox("No se encontraron datos que cumplieran sus criterios de busqueda")
        Else
            dgv.DataSource = dstPuntodeVenta.Tables("Personas")
        End If

        If conPuntoVenta.State = ConnectionState.Open Then
            conPuntoVenta.Close()
        End If
    End Sub

    Public Sub cambios(ByVal strConsulta As String)
        conectar()

        Try
            Dim cmdConsulta = New SqlCommand(strConsulta, conPuntoVenta)
            cmdConsulta.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar guardar los datos, contacte al administrador", MsgBoxStyle.Critical)
            MsgBox(ex.Message)
        End Try

        If conPuntoVenta.State = ConnectionState.Open Then
            conPuntoVenta.Close()
        End If
    End Sub
End Module
