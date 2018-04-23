using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Services.Internal;

namespace IExternalAppointmentCompareSample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            AddCustomppointmentComparer(schedulerControl1);
            this.carSchedulingTableAdapter.Fill(this.carsDBDataSet.CarScheduling);
        }

        void AddCustomppointmentComparer(SchedulerControl serviceProvider) {
            MyAppointmentComparerService comparer = new MyAppointmentComparerService("Subject");
            serviceProvider.Services.AddService(typeof(IExternalAppointmentCompareService), comparer);
        }
    }
}
