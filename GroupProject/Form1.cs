using GroupProject.Algorithms;
using GroupProject.Sernsors;
using System;
using System.Windows;
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
        //data for chart


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            chart1.ChartAreas[0].AxisY.Maximum = 30;
            chart1.ChartAreas[0].AxisY.Minimum = -30;

            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "H:mm:ss";
            chart1.Series[0].XValueType = ChartValueType.DateTime;
            chart1.Series[1].XValueType = ChartValueType.DateTime;

            chart1.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
            chart1.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();

            chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            chart1.ChartAreas[0].AxisX.Interval = 5;
        }

        void FillChart()
        {
            chart1.Series["Series1"].XValueMember = "SensorValue";
            chart1.Series["Series1"].YValueMembers = "Time";
            chart1.Titles.Add("SensorsDisplay");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime timeNow = DateTime.Now;
            int value = Convert.ToInt32(numeric.Value);

            //display data on every timer tick

            chart1.Series[0].Points.AddXY(timeNow, value);
            chart1.Series[1].Points.AddXY(timeNow, value+5);

            //

            _coutSeconds++;
            //if chart if full clear it and start again
            if (_coutSeconds == 60)
            {
                _coutSeconds = 0;

                chart1.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
                chart1.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();

            }
        }

        private SaveData getXYFromsensor(IAlgorithm algorithm)
        {
            //SaveData xy = algorithm.getAlgorithmResult;





            return xy;
        }


        private void radionButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Humiditu";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Temperature";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Brightness";
        }
    }
}
