Imports System
Imports System.IO
Imports System.Text
Module ids
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
