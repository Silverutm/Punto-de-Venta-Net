Imports System.Data.Linq
Imports System.Data.Linq.Mapping

Module BasedeDatos
    Public Class TacosTime
        Inherits DataContext
        Public Tipo_Usuario As Table(Of TipoUsuario)
        Public Persona As Table(Of People)
        Public Producto As Table(Of Product)
        Public Ventas As Table(Of Sales)
        Public Ventas_Detalle As Table(Of Sales_Detail)
        Public Sub New(ByVal Ruta As String)
            MyBase.New(Ruta)
        End Sub
    End Class

    <Table(Name:="Tipo_Usuario")>
    Public Class TipoUsuario
        <Column(IsPrimaryKey:=True)>
        Public id_tipo_usuario As Long
        <Column()>
        Public tipo_usuario As String
    End Class

    <Table(Name:="Persona")>
    Public Class People
        <Column(IsPrimaryKey:=True)>
        Public id_persona As Long
        <Column()>
        Public nombres_persona As String
        <Column()>
        Public apellido_paterno_persona As String
        <Column()>
        Public apellido_materno_persona As String
        <Column()>
        Public fecha_nacimiento_persona As Date
        <Column()>
        Public correo_electronico As String
        <Column()>
        Public genero As Short
        <Column()>
        Public telefono As String
        <Column()>
        Public calle_numero As String
        <Column()>
        Public colonia As String
        <Column()>
        Public municipio As String
        <Column()>
        Public codigo_postal As String
        <Column()>
        Public usuario As String
        <Column()>
        Public contraseña As String
        <Column()>
        Public id_tipo_usuario_P As String
    End Class

    <Table(Name:="Producto")>
    Public Class Product
        <Column(IsPrimaryKey:=True)>
        Public id_producto As Long
        <Column()>
        Public nombre_producto As String
        <Column()>
        Public caracteristica As String
        <Column()>
        Public precio_producto As Double
        <Column()>
        Public cantidad As Long
        <Column()>
        Public enventa As Short
    End Class

    <Table(Name:="Ventas")>
    Public Class Sales
        <Column(IsPrimaryKey:=True)>
        Public id_venta As Long
        <Column()>
        Public fecha As DateTime
        <Column()>
        Public total As Double
        <Column()>
        Public id_persona_V As Long

    End Class

    <Table(Name:="Ventas_Detalle")>
    Public Class Sales_Detail
        <Column(IsPrimaryKey:=True)>
        Public id_detalle As Long
        <Column()>
        Public id_venta_D As Long
        <Column()>
        Public id_producto_D As Long
        <Column()>
        Public precio As Double
    End Class
End Module
