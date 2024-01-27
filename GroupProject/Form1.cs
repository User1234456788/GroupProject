using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GroupProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private int _coutSeconds = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            chart1.ChartAreas[0].AxisY.Maximum = 30;
            chart1.ChartAreas[0].AxisY.Minimum = -30;

            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "H:mm:ss";
            chart1.Series[0].XValueType = ChartValueType.DateTime;

            chart1.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
            chart1.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();

            chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            chart1.ChartAreas[0].AxisX.Interval = 5;
        }

        void FillChart()
        {
            chart1.Series["Series1"].XValueMember = "Time";
            chart1.Series["Series1"].YValueMembers = "Temperature";
            chart1.Titles.Add("SensorsDisplay");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime timeNow = DateTime.Now;
            int value = Convert.ToInt32(numeric.Value);

            chart1.Series[0].Points.AddXY(timeNow, value);

            if (_coutSeconds >= 60)
            {
                

                chart1.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
                chart1.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();

                chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
                chart1.ChartAreas[0].AxisX.Interval = 5;
            }



        }
    }
}
