﻿using System;
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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“database2DataSet.tmp”中。您可以根据需要移动或移除它。
            this.tmpTableAdapter.Fill(this.database2DataSet.tmp);

        }


    }
}
