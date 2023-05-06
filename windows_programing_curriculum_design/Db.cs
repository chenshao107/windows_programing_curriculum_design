using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//该类是连接数据库与软件的中间层，如果想要更换数据库，只需改写该类
//目前对接的是本地SQLlite数据库
namespace data
{
    public class Db
    {
        //利用.NET4特性，实现单例模式（懒汉模式）
        private static readonly Lazy<Db> lazy = new Lazy<Db>(() => new Db());
        public static Db Instance { get { return lazy.Value; } }

        //数据库实例构造函数
        private Db() 
        {
            try
            {
                //throw new NotImplementedException();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库打开异常"+"\n"+ex.Message.ToString());
                throw ex;
            }
        }

        //测试函数
        public void Nothing()
        {
            int a = 0;
            return;
        }

        internal static User verify(string account, string password)
        {
            //暂时这么实现，以后连接数据库
            if(account=="root")
            {
                return new User(0);

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
