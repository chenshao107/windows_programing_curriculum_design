using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace windows_programing_curriculum_design
{
    public partial class MaintainForm : UserControl
    {
        public MaintainForm(int roomId)
        {
            InitializeComponent();
            _roomId = roomId;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MaintainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //定义数据库实体
            Database2Entities2 database2Entities2;
            try
            {
                database2Entities2 = new Database2Entities2();
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库连接异常");
                throw ex;
            }
            //将各种信息填入该结构体
            Repair repair = new Repair();
            repair.AppointmentDate = dateTimePicker1.Value;
            repair.RoomId = _roomId;
            repair.Problem = textBox1.Text;
            database2Entities2.Repair.Add(repair);
            //对saveChange的返回值进行检查
            try
            {
                database2Entities2.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("提交失败！可能您已经有待处理的问题，请勿重复提交！");
                return;
            }
            MessageBox.Show("提交成功！");

            //打印出表中所有记录，检验
            var tmp = database2Entities2.Repair;
            foreach (var item in tmp)
            {
                System.Diagnostics.Debug.WriteLine(item.RoomId+"\t"+item.Problem+"t"
                    + item.AppointmentDate.ToString());

            }
        }
    }
}
