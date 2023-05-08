using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
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
            Database2Entities2 db = new Database2Entities2();

            //如果账号是root说明是管理员登录
            if (account=="root")
            {
                //生成数据库实例
                IEnumerable<string> iter = db.RootPassword.Select(x => x.Password);
                foreach (string s in iter)
                {
                    System.Diagnostics.Debug.WriteLine($"管理员密码：{s}");
                    //验证
                    if (s == password)
                        return new User(0);
                }
                //验证错误，返回空
                return null;

            }else//账号不是root，那就是学生账号
            {
                //linq查询
                //var temp = from s in db.Room
                //           where s.RoomId == Convert.ToInt32(account)
                //           select s;


                //foreach (var s in temp)
                //{
                //    if (s.Password == password) ;
                //    return new User(1);
                //}

                //查询对应房间号记录
                //将房号转为int类型
                int roomId;
                //将账号转int的语句放于try catch中，因为可能会失败，捕捉异常
                try
                {
                    roomId = Convert.ToInt32(account);

                }catch (Exception ex)
                {
                    return null;
                }
                var temp=db.Room.Where(x=>x.RoomId==roomId).First();
                System.Diagnostics.Debug.WriteLine(temp.ToString());  
                //判断密码是否正确
                if(temp.Password==password)
                    return new User(1);
                else
                    return null;
            }
        }

    }

    class User
    {
        //A为权限，0为管理员，1为学生
        public int A { get;}
        public User(int x) 
        {
            A = x;
        }


    }


}
