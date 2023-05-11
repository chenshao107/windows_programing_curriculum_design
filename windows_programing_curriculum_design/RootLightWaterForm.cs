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
        }

        private void repairBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.repairBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database2DataSet);

        }
    }
}
