Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraScheduler.Services.Internal
Imports DevExpress.XtraScheduler
Imports System.Reflection

Namespace IExternalAppointmentCompareSample
    Public Class MyAppointmentComparerService
        Implements IExternalAppointmentCompareService

        Public Sub New(ByVal propertyName As String)
            Me.propertyName = propertyName
        End Sub

        Private propertyName As String

        #Region "IExternalAppointmentCompareService Members"

        Public ReadOnly Property Comparer() As IComparer(Of DevExpress.XtraScheduler.Appointment)
            Get
                Return New MyAppointmentComparer(propertyName)
            End Get
        End Property

        #End Region
    End Class

    Public Class MyAppointmentComparer
        Implements IComparer(Of Appointment)

        Public Sub New(ByVal propertyName As String)
            Me.propertyName = propertyName
        End Sub

        Private propertyName As String

        Public Function Compare(ByVal x As Appointment, ByVal y As Appointment) As Integer Implements IComparer(Of Appointment).Compare
            Dim a As IComparable = DirectCast(GetObject(x, propertyName), IComparable)
            Dim b As IComparable = DirectCast(GetObject(y, propertyName), IComparable)

            Return a.CompareTo(b)
        End Function

        Private Function GetObject(ByVal obj As Object, ByVal propertyName As String) As Object
            Dim t As Type = obj.GetType()
            Dim p As PropertyInfo = t.GetProperty(propertyName)
            Return p.GetValue(obj, Nothing)
        End Function
    End Class
End Namespace
