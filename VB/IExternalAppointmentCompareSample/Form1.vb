Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Services.Internal

Namespace IExternalAppointmentCompareSample
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            AddCustomppointmentComparer(schedulerControl1)
			Me.carSchedulingTableAdapter.Fill(Me.carsDBDataSet.CarScheduling)
		End Sub

		Private Sub AddCustomppointmentComparer(ByVal serviceProvider As SchedulerControl)
			Dim comparer As New MyAppointmentComparerService("Subject")
			serviceProvider.Services.AddService(GetType(IExternalAppointmentCompareService), comparer)
		End Sub
	End Class
End Namespace
