'Imports System.ComponentModel
Imports System.IO
Imports System.Text
Module variables_y_demas
    Public strnombre, strapellidos As String
    Public intgenero As Short
    Public NProducto, NPersona, NTipo_Usuario, NVentas, NVentas_Detalle As Long
    'Public arrFVentas(5) As New Form()
    Public arrFVentas1, arrFVentas2, arrFVentas3, arrFVentas4, arrFVentas5 As New FVentas
    'Public Cobrar As New FCobrar
    Public intIndicedeFVentas As Short = 0
    Public dbTotal As Double = 0
    Public intIdPersona As Long
    Public intIndicedeVentas As Integer = 0

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

    Public Sub guardarventa()
        Dim i As Integer
        cambios("INSERT INTO Ventas Values(" & NVentas & ", '" & Now & "', " & dbTotal & ", " & intIdPersona & ")")
        For i = 0 To intIndicedeVentas - 1
            cambios("INSERT INTO Ventas_Detalle Values(" & NVentas_Detalle & ", " & NVentas & ", " & arrFVentas1.dgvVentas.Rows(i).Cells(2).Value & "," & arrFVentas1.dgvVentas.Rows(i).Cells(1).Value & ")")
            NVentas_Detalle += 1
        Next
        NVentas += 1
        archivos("Ventas_Detalle", CStr(NVentas_Detalle))
        archivos("Ventas", CStr(NVentas))
    End Sub

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
