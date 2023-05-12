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
    public partial class RootLightWaterForm : UserControl
    {
        public RootLightWaterForm()
        {
            InitializeComponent();
            this.roomTableAdapter.Fill(this.database2DataSet.Room);
            this.studentTableTableAdapter.Fill(this.database2DataSet.StudentTable);
        }

        private void repairBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.repairBindingSource.EndEdit();

        }

        private void RootLightWaterForm_Load(object sender, EventArgs e)
        {
            this.rootPasswordTableAdapter.Fill(this.database2DataSet.RootPassword);
        }
    }
}
