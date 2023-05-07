using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using data;

namespace windows_programing_curriculum_design
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //m_dbConnection.Open();
            //string sql = "select * from highscores order by score desc";
            //SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            //SQLiteDataReader reader = command.ExecuteReader();
            //while (reader.Read())
            //    this.textBox1.AppendText("Name: " + reader["name"] + "\tScore: " + reader["score"]+"\n");
            data.Db.Instance.Nothing();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Console.WriteLine(e.X.ToString()+e.Y.ToString());
            System.Diagnostics.Debug.WriteLine(e.X.ToString()+"," + e.Y.ToString());

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            //该函数将鼠标移动事件修改偏移量后向背景传递
            MouseEventArgs ee = new MouseEventArgs(e.Button,e.Clicks
                ,e.X
                ,e.Y
                ,e.Delta);
            this.Form1_MouseMove(this,ee);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //登录按钮，校验账号和密码
            User a =Db.verify(accountTextBox.Text,passwordTextBox.Text);
            if (a != null)
            {
                //隐藏登录界面
                this.Hide();
                //获得 用户/管理员 界面，因为两个界面都是Form子类，所以可以用Form类型接收
                Form f = a.GetForm();
                //阻塞运行窗口，直到关闭
                f.ShowDialog();
                System.Diagnostics.Debug.WriteLine("before show");
                //重新显示登录窗口
                this.Show();

            }
            else
            {
                tipLinkLabel.Text="账号或者密码错误！";
            }


        }


    }
}
