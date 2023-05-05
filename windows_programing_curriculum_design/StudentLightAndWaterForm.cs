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
    public partial class StudentLightAndWaterForm : UserControl
    {
        public StudentLightAndWaterForm()
        {
            InitializeComponent();
        }

        private void StudentLightAndWaterForm_SizeChanged(object sender, EventArgs e)
        {
            tableLayoutPanel1.Size = this.Size;
        }
    }
}
