using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace windows_programing_curriculum_design
{
    public partial class StudentOtherForm : UserControl
    {
        public StudentOtherForm(int roomId)
        {
            InitializeComponent();
            _roomId = roomId;
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

            //搜索该宿舍的人员，填写单选按钮
            this._members = database2Entities2.StudentTable.Where(x=>x.RoomId == roomId).ToList();
            
            //设定每一个单选钮
            if(this._members.Count <5)memberRaadioButton5.Enabled = false; else memberRaadioButton5.Text = _members[4].Name;
            if (this._members.Count <4)memberRaadioButton4.Enabled = false; else memberRaadioButton4.Text = _members[3].Name;
            if (this._members.Count <3)memberRaadioButton3.Enabled = false; else memberRaadioButton3.Text = _members[2].Name;
            if (this._members.Count <2)memberRaadioButton2.Enabled = false; else memberRaadioButton2.Text = _members[1].Name;
            if (this._members.Count < 1) memberRaadioButton1.Enabled = false; else memberRaadioButton1.Text=_members[0].Name;

            //填写成员变量
            this._students = _members.Count == 0 ? null : _members[0];

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
            if(_students==null)
            {
                MessageBox.Show("请选中申请的人员");
                return;
            }
            string s = _students.Name;
            if(radioButton1.Checked)
            {
                s += "退宿 ";
            }else
            {
                s += "换宿 ";
            }

            string msg = Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(s+textBox1.Text));
            transfe.Reason = msg;
            
            database2Entities2.Transfe.Add(transfe);
            //对saveChange的返回值进行检查
            try
            {
                database2Entities2.SaveChanges();
            }
            catch (Exception )
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
                System.Diagnostics.Debug.WriteLine("");

            }
        }

        private void memberRaadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //选中第一个学生
            _students = _members[0];
        }

        private void memberRaadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //选中第2个学生
            _students = _members[1];
        }

        private void memberRaadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //选中第3个学生
            _students = _members[2];
        }

        private void memberRaadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //选中第4个学生
            _students = _members[3];

        }

        private void memberRaadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            //选中第5个学生
            _students = _members[4];
        }
    }
}
