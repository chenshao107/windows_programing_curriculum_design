using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.Common;

namespace windows_programing_curriculum_design
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            //m_dbConnection.Open();
            //string sql = "select * from highscores order by score desc";
            //SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            //SQLiteDataReader reader = command.ExecuteReader();
            //while (reader.Read())
            //    this.textBox1.AppendText("Name: " + reader["name"] + "\tScore: " + reader["score"]+"\n");
            data.Db.Instance.Nothing();
        }
    }
}
