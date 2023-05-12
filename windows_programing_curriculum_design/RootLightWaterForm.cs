using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_programing_curriculum_design
{
    public partial class RootLightWaterForm : UserControl
    {
        public RootLightWaterForm()
        {
            InitializeComponent();
            //填写宿舍表
            this.roomTableAdapter.Fill(this.database2DataSet.Room);
            //填写宿舍学生表
            this.studentTableTableAdapter.Fill(this.database2DataSet.StudentTable);
        }

        private void repairBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.repairBindingSource.EndEdit();

        }

        private void RootLightWaterForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //将dataGrepView中的数据保存到数据库中
                roomTableAdapter.Update(database2DataSet.Room);
                studentTableTableAdapter.Update(database2DataSet.StudentTable);
            }
            catch (Exception ) {
                MessageBox.Show("保存失败");
                return;
            }
            MessageBox.Show("保存成功");


        }
    }
}
