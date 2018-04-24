Namespace IExternalAppointmentCompareSample
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim timeRuler1 As New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler2 As New DevExpress.XtraScheduler.TimeRuler()
            Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
            Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.carsDBDataSet_Renamed = New IExternalAppointmentCompareSample.CarsDBDataSet()
            Me.carSchedulingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.carSchedulingTableAdapter = New IExternalAppointmentCompareSample.CarsDBDataSetTableAdapters.CarSchedulingTableAdapter()
            CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.carsDBDataSet_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.carSchedulingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' schedulerControl1
            ' 
            Me.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Timeline
            Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl1.Location = New System.Drawing.Point(0, 0)
            Me.schedulerControl1.Name = "schedulerControl1"
            Me.schedulerControl1.Size = New System.Drawing.Size(693, 364)
            Me.schedulerControl1.Start = New Date(2010, 7, 5, 0, 0, 0, 0)
            Me.schedulerControl1.Storage = Me.schedulerStorage1
            Me.schedulerControl1.TabIndex = 0
            Me.schedulerControl1.Text = "schedulerControl1"
            Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
            Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
            ' 
            ' schedulerStorage1
            ' 
            Me.schedulerStorage1.Appointments.DataSource = Me.carSchedulingBindingSource
            Me.schedulerStorage1.Appointments.Mappings.AllDay = "AllDay"
            Me.schedulerStorage1.Appointments.Mappings.Description = "Description"
            Me.schedulerStorage1.Appointments.Mappings.End = "EndTime"
            Me.schedulerStorage1.Appointments.Mappings.Label = "Label"
            Me.schedulerStorage1.Appointments.Mappings.Location = "Location"
            Me.schedulerStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo"
            Me.schedulerStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo"
            Me.schedulerStorage1.Appointments.Mappings.Start = "StartTime"
            Me.schedulerStorage1.Appointments.Mappings.Status = "Status"
            Me.schedulerStorage1.Appointments.Mappings.Subject = "Subject"
            Me.schedulerStorage1.Appointments.Mappings.Type = "EventType"
            ' 
            ' carsDBDataSet
            ' 
            Me.carsDBDataSet_Renamed.DataSetName = "CarsDBDataSet"
            Me.carsDBDataSet_Renamed.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' carSchedulingBindingSource
            ' 
            Me.carSchedulingBindingSource.DataMember = "CarScheduling"
            Me.carSchedulingBindingSource.DataSource = Me.carsDBDataSet_Renamed
            ' 
            ' carSchedulingTableAdapter
            ' 
            Me.carSchedulingTableAdapter.ClearBeforeFill = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(693, 364)
            Me.Controls.Add(Me.schedulerControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.carsDBDataSet_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.carSchedulingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
        Private schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage

        Private carsDBDataSet_Renamed As CarsDBDataSet
        Private carSchedulingBindingSource As System.Windows.Forms.BindingSource
        Private carSchedulingTableAdapter As CarsDBDataSetTableAdapters.CarSchedulingTableAdapter
    End Class
End Namespace

