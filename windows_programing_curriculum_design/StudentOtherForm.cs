using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_programing_curriculum_design
{
    public partial class StudentOtherForm : UserControl
    {
        public StudentOtherForm(int roomId)
        {
            InitializeComponent();
            _roomId = roomId;
        }

        private void StudentOtherForm_Load(object sender, EventArgs e)
        {
            radioButton1.Checked=true;
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
            Transfe  transfe = new Transfe();
            //填入房号
            transfe.RoomId = _roomId;
            //填入退宿/换宿
            string s;
            if(radioButton1.Checked)
            {
                s = "[退宿]";
            }else
            {
                s = "[换宿]";
            }
            transfe.Reason = s+textBox1.Text;
            database2Entities2.Transfe.Add(transfe);
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
            var tmp = database2Entities2.Transfe;
            foreach(var item in tmp)
            {
                System.Diagnostics.Debug.WriteLine(item.RoomId);
                System.Diagnostics.Debug.WriteLine(item.Reason);
                System.Diagnostics.Debug.WriteLine(666666666666);

            }
        }
    }
}
