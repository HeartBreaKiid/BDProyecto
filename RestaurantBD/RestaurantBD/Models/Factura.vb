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

Partial Public Class Factura
    Public Property ID As Integer
    Public Property TotalAPagar As Decimal
    Public Property Efectivo As Integer
    Public Property Cambio As Integer
    Public Property Fecha As Date
    Public Property ClienteID As Integer
    Public Property TipoPagoID As Integer
    Public Property EmpleadoID As Integer

    Public Overridable Property Cliente As Cliente
    Public Overridable Property Empleado As Empleado
    Public Overridable Property TipoPago As TipoPago

End Class
