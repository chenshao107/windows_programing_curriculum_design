using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using windows_programing_curriculum_design;


//该类是连接数据库与软件的中间层，如果想要更换数据库，只需改写该类
//目前对接localdb
namespace data
{
    public class Db
    {

        //数据库实例构造函数
        private Db()
        {
            //throw new NotImplementedException();
            


        }



        internal static User verify(string account, string password)
        {
            
            if (account=="root")
            {
                Database2Entities2 db = new Database2Entities2();
                IEnumerable<string> iter = db.RootPassword.Select(x => x.Password);
                foreach (string s in iter)
                {
                    System.Diagnostics.Debug.WriteLine($"管理员密码：{s}");
                    if (s == password)
                        return new User(0);
                }
                return null;

            }else
            {
                return new User(1);
            }
        }

    }

    class User
    {
        //A为权限，0为管理员，1为学生
        private int A { get;}
        public User(int x) 
        {
            A = x;
        }
        public Form GetForm()
        {
            if(A == 0)
            {
                //运行管理员界面
                return new windows_programing_curriculum_design.RootForm();
                
            }else
            {
                //运行学生界面
                return new windows_programing_curriculum_design.StudentForm();
            }
        }


    }


}
