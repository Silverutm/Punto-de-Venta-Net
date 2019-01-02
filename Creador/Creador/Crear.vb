Public Class Crear
    Private Sub Crear_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Crear el directorio
        Try
            My.Computer.FileSystem.CreateDirectory("C:\TacosTime")
        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar crear el directorio" & Chr(13) + Chr(10) _
                   & "Contacte al administrador para mas informacion", MsgBoxStyle.Critical, "Error")
            MsgBox(ex.Message)
            End
        End Try


        'Crear la Base de Datos
        Try
            Dim bd As TacosTime = New TacosTime("c:\TacosTime\TacosTime.mdf")
            If bd.DatabaseExists() Then 'Verificar si existe
                Dim k As MsgBoxResult
                k = MsgBox("La base de datos, ya existe, si continua se creara una nueva y perdera sus datos anteriores, desea continuar?:" _
                         , MsgBoxStyle.YesNo, "Atencion")
                If k = MsgBoxResult.Yes Then
                    bd.DeleteDatabase()
                Else
                    End
                End If
            End If
            bd.CreateDatabase()
        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar crear la base de datos, pongase en contacto con el administrador", MsgBoxStyle.Critical, "Error")
            MsgBox(ex.Message)
        End Try

        'Agregar Datos iniciales
        cambios("INSERT INTO Tipo_Usuario VALUES (" & 1 & ",'Administrador')")
        cambios("INSERT INTO Tipo_Usuario VALUES (" & 2 & ",'Vendedor')")

        cambios("INSERT INTO Producto VALUES (" & 1 & ",'Platillo1', 'Sabe rico', 55.00, 0, 1)")
        cambios("INSERT INTO Producto VALUES (" & 2 & ",'Platillo2', 'Es comida', 40.00, 0, 1)")

        cambios("INSERT INTO Persona VALUES (" & 1 & ",'Yo', 'Me llamo', 'Asi','08-15-1998', 'ejemplo@ejemplo'," &
                "1,'55555', 'calle', 'mi barrio pesado', 'municipio', '27000', 'usuario', 'password',1)")

        'Crear archivos
        archivos("Producto", "3")
        archivos("Persona", "2")
        archivos("Tipo_Usuario", "3")
        archivos("Ventas_Detalle", "1")
        archivos("Ventas", "1")

        MsgBox("La creacion de archivos ha sido un exito")
        End
    End Sub
End Class
