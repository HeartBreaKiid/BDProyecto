'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class TipoSucursal
    Public Property ID As Integer
    Public Property Tipo As String

    Public Overridable Property Sucursal As ICollection(Of Sucursal) = New HashSet(Of Sucursal)

End Class
