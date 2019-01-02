Imports System.IO
Imports System.Text
Module variables
    Public strnombre, strapellidos As String
    Public intgenero As Short
    Public NProducto, NPersona, NTipo_Usuario, NVentas, NVentas_Detalle As Long
    Public intIdPersona As Long

    Public MMenu As New FMenu
    Public ConsultasVentas As New FConsultasVentas
    Public ConsultasPlatillos As New FConsultasPlatillos
    Public AgregarUsuarios As New FAgregarUsuarios

    Public Function cargarindices(ByVal strRuta As String) As Long
        Dim strindice As String
        If System.IO.File.Exists("c:\TacosTime\" & strRuta & ".txt") = True Then
            Dim objReader As New System.IO.StreamReader("c:\TacosTime\" & strRuta & ".txt")
            strindice = objReader.ReadToEnd
            objReader.Close()
        Else
            MsgBox("Ocurrio un error al cargar el indice del archivo")
            Randomize()
            strindice = CStr(CLng((100000 * Rnd()) + 1))
        End If

        Return CLng(strindice)
    End Function

    Public Sub archivos(ByVal nombre As String, ByVal dato As String)
        Dim path As String = "c:\TacosTime\" & nombre & ".txt"

        ' Create or overwrite the file. 
        Dim fs As FileStream = File.Create(path)

        ' Add text to the file. 
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(dato)
        fs.Write(info, 0, info.Length)
        fs.Close()
    End Sub
End Module
