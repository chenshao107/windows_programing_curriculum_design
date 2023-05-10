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
            //提交报修信息

        }
    }
}
