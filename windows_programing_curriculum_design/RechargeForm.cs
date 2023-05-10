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
    public partial class RechargeForm : Form
    {

        public RechargeForm(int roomId)//自定义构造函数，传入房号
        {
            InitializeComponent();
            _roomId = roomId;
        }

        private void AddBalance(int addBalence)
        {
            //定义数据库实体
            Database2Entities2 database2Entities2;
            try { 
                database2Entities2 = new Database2Entities2();
            }catch(Exception ex)
            {
                MessageBox.Show("数据库连接异常");
                throw ex;
            }
            var roomData = database2Entities2.Room.Where(x => x.RoomId == _roomId).First();
            roomData.Balance += addBalence;
            //对余额进行修改
            database2Entities2.Entry<Room>(roomData).Property(x => x.Balance).IsModified=true; 
            //对saveChange的返回值进行检查，1表示成功
            try
            {
                database2Entities2.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show("充值失败！");
                this.Close();
                return;
            }
            MessageBox.Show("充值成功！");

            //关闭充值窗口
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //充值50
            this.AddBalance(50);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //充值100

            AddBalance(100);
        }
    }
}
