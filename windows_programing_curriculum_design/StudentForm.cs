using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace windows_programing_curriculum_design
{
    public partial class StudentForm : Form
    {
        private void FlashChartData()
        {
            Database2Entities2 database2Entities2 = new Database2Entities2();
            var studentDate = database2Entities2.Room.Where(x => x.RoomId == _roomId).First();
            Series series = new Series();
            series.Name = "水电费用详情";
            series.AxisLabel = "元";
            List<string> xData = new List<string>() { "电费","水费"};
            List<decimal> yData = new List<decimal>() { studentDate.LastMonthLight.Value, studentDate.LastMonthWater.Value };
            chart1.Series[0].Points.DataBindXY(xData,yData);
            yData = new List<decimal>() { studentDate.Light.Value, studentDate.Water.Value };
            chart1.Series[1].Points.DataBindY(yData);
            

        }

        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

            //加载char1表格数据
            FlashChartData();

            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
