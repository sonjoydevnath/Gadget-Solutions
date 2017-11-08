using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace GUI
{

    class User
    {
        public static int id;
        string FullName;
        string UserName;
        string Password;
        string CPassword;
        string address, email, contc, credit;
        GSDatabase gs;
        public User()
        {

            gs = new GSDatabase();
        }

        public int add(string fn, string un, string p, string cp, string add, string em, string cnt, string crd)
        {
            this.FullName = fn;
            this.UserName = un;
            this.Password = p;
            this.CPassword = cp;
            this.address = add;
            this.email = em;
            this.contc = cnt;
            this.credit = crd;

            if (CPassword != Password)
            {
                return 1;
            }
            else if (FullName == "" || UserName == "" || Password == "" || address == "" || email == "" || contc == "" || credit == "")
            {
                return 2;
            }
            else
                return gs.AddUser(FullName, UserName, Password, address, email, contc, credit, "User");

        }

        public int getUser(string un, string p)
        {
            return gs.Login(un, p);
        }


        public DataTable getUserTable()
        {
            return gs.UserInfos();
        }

        public int ChangePassword(string op,string np,string cnp){
            if (np == "")
            {
                return 1;
            }
            else if (np != cnp)
            {
                return 2;
            }
            else
                return gs.ChangePass(op,np);
        
        }

        public int ChangeInfo(string fn, string e, string cn, string ad, string credit) {
            return gs.ChangeInfo(fn,e,cn,ad,credit);
        }

        

    }
}
