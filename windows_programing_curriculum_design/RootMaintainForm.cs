using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_programing_curriculum_design
{
    public partial class RootMaintainForm : UserControl
    {
        public RootMaintainForm()
        {
            InitializeComponent();
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
            //获取报修表中所有数据
            var records = database2Entities2.Repair;
            foreach (var record in records)
            {
                //新建一行记录，显示上去
                var oneLine = new OneMaintain(record.RoomId, record.Problem+"  预约时间："+record.AppointmentDate);
                oneLine.Dock = DockStyle.Top;
                //将一个RemoveOneRecond函数绑定到该按钮；函数委托，绑定
                oneLine.button1.Click +=  delegate (object sender1, EventArgs e1) { RemoveOneRecond(sender1 , ref oneLine); };//匿名传参
                this.panel1.Controls.Add(oneLine);
            }
        }

        public void RemoveOneRecond(object sender,ref OneMaintain oneLine)
        {
            //传递引用，指定原来的控件
            //oneMaintain为发出信号的控件
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
            //新建一条记录
            Repair oneRecond=new Repair();
            //填入对应的房号
            oneRecond.RoomId = oneLine._roomId;
            //提交删除语句
            database2Entities2.Entry<Repair>(oneRecond).State = EntityState.Deleted;
            //保存设置
            int i = database2Entities2.SaveChanges();
            //从UI界面移除该控件
            panel1.Controls.Remove(oneLine);
        }

        private void RootMaintainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
