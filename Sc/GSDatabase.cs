using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace GUI
{
    class GSDatabase
    {
        MySqlConnection con;
        DBerror er;
        Device ds;
        Product pr;
        Admin ad;
        
        string conString;
        
        string value;


        public GSDatabase()
        {
            er = new DBerror();
            conString=(@"server=31.187.71.248;user id=ugiclan_aviproj;database=ugiclan_aviproj;password=RP7TDWvU");
            Connection();

        }

        public void Connection() {
            try
            {
                con = new MySqlConnection();
                con.ConnectionString = conString;
                con.Open();
                er.CatchError("");
            }
            catch (MySqlException ex)
            {
                er.CatchError(ex.Message);
                
            }
            

        }

        public DataTable GetPhone() {
            string q = "select * from Phone";
            MySqlCommand comm1 = new MySqlCommand(q,con);
            MySqlDataAdapter da1 = new MySqlDataAdapter(comm1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            return dt1;

        
        }

        public DataTable GetComment()
        {
            string q = "select * from Review";
            MySqlCommand comm1 = new MySqlCommand(q, con);
            MySqlDataAdapter da1 = new MySqlDataAdapter(comm1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            return dt1;
            

        }
        public void AddProduct(string Brand, string Model, string Os, string SSize, string cam, string bat, string body, string memo, string feat, string cpu, string rdate, string lprice,string ImgPath)
        {
            string q = "Insert into Phone (Brand,Model,Os,SSize,Camera,Battery,Body,Memory,Features,Cpu,RDate,Price,Image) Values ('" + Brand + "','" + Model + "','" + Os + "','" + SSize + "','" + cam + "','" + bat + "','" + body + "','" + memo + "','" + feat + "','" + cpu + "','" + rdate + "','" + lprice + "','" + ImgPath + "');";
            MySqlCommand comm = new MySqlCommand(q, con);

            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MessageBox.Show("Uploaded Successfully");

        }

        public DataTable UserInfos()
        {
            string q = ("select * from User where UserId='" + User.id + "'");
            MySqlCommand comm = new MySqlCommand(q, con);
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int ChangePass(string op, string np)
        {
            string q = ("select * from User where UserId='" + User.id + "'");
            MySqlCommand comm = new MySqlCommand(q, con);
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0]["Password"].ToString() != op)
                return 3;
            else if (dt.Rows[0]["Password"].ToString() == op)
            {
                string q1 = ("update User set Password ='" + np + "' where UserId ='" + User.id + "'");
                MySqlCommand comm1 = new MySqlCommand(q1, con);
                MySqlDataAdapter da1 = new MySqlDataAdapter(comm1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                return 0;
            }
            else
                return 4;

        }

        public int ChangeInfo(string fn, string email, string cn, string ad, string credit)
        {
            string q1 = ("update User set FullName ='" + fn + "',Email='" + email + "',ContactNo='" + cn + "',Address='" + ad + "',CardNo='" + credit + "' where UserId ='" + User.id + "'");
            MySqlCommand comm1 = new MySqlCommand(q1, con);
            MySqlDataAdapter da1 = new MySqlDataAdapter(comm1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            return 0;

        }

        public ArrayList ProductShow(string name)
        {
            ArrayList nameList=new ArrayList();
            string qwl = ("select * from Phone where Brand='"+name+"'");
            MySqlCommand comm2 = new MySqlCommand(qwl, con);
            MySqlDataAdapter da2 = new MySqlDataAdapter(comm2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
             for (int i = 0; i <dt2.Rows.Count; i++)
                {

                    

                    nameList.Add(dt2.Rows[i]["Model"].ToString());
                    
                    
                }

            return nameList;
            
        }
        /* public string Show(int pId,string cl)
           {
               string qwl = ("select * from Phone where ProductId='"+pId+"'");
               MySqlCommand comm2 = new MySqlCommand(qwl, con);
               MySqlDataAdapter da2 = new MySqlDataAdapter(comm2);
               DataTable dt2 = new DataTable();
               da2.Fill(dt2);
               ds = new Device();
               if (dt2.Rows.Count == 1)
               {
                   for (int i = 0; i<dt2.Rows.Count; i++)
                   {
                       value = dt2.Rows[i][cl].ToString();
                   }
               }
               return value;
               
          
           }
          */
        public ArrayList ProductDetails(string Mod)
          {
              ArrayList detailsList=new ArrayList();
              string qwl = ("select * from Phone where Model='"+ Mod+ "'");
              MySqlCommand comm2 = new MySqlCommand(qwl, con);
              MySqlDataAdapter da2 = new MySqlDataAdapter(comm2);
              DataTable dt2 = new DataTable();
              da2.Fill(dt2);
            string[] column=new string[]{"Model","Brand","Os","SSize","Camera","Battery","Body","Memory","Features","Cpu","RDate","Price","image"};
              
            for (int i = 0; i < dt2.Rows.Count; i++)
                  {
                  for(int j=0;j<column.Length;j++)
                     {

                      detailsList.Add(dt2.Rows[i][column[j]].ToString());
                     }
                  }
              
              return detailsList;


           }
        
      
       
        public int AddUser(string fn,string un,string p,string add,string em,string cnt,string crd,string type){
            string q=("select * from User where UserName='"+un+"'");
            MySqlCommand comm = new MySqlCommand(q, con);
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >0) {
                    return 3;
                }
                else
            {
                string q1=("select * from User where Email='"+em+"'");
                MySqlCommand comm1 = new MySqlCommand(q1, con);
                MySqlDataAdapter da1 = new MySqlDataAdapter(comm);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                if (dt1.Rows.Count > 0)
                {
                    return 4;
                }
                else {
                    string q2 = "Insert into User (FullName,UserName,Password,Email,ContactNo,CardNo,Address,UserType) Values ('" + fn + "','" + un + "','" + p + "','" + em + "','" + cnt + "','" + crd + "','" + add + "','" + type + "');";
                    MySqlCommand comm2 = new MySqlCommand(q2, con);
                    MySqlDataAdapter da2 = new MySqlDataAdapter(comm2);
                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);

                    return 5;


                }
            }
        }

        public int Login(string un, string p)
        {
            string q = ("select * from User where username='" + un + "'and password='" + p + "'");
            MySqlCommand comm = new MySqlCommand(q, con);
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                string type;
                type = dt.Rows[0]["UserType"].ToString();
                User.id = (int)dt.Rows[0]["UserId"];
                if (type == "Admin")
                    return 1;
                else
                    return 2;
            }

            else
                return 0;

        }
        public void Review(string Model, string UserName, string Comment)
        {
            string q = "Insert into Review (Model,UserName,Comment) Values ('" + Model + "','" + UserName + "','" + Comment + "');";
            MySqlCommand comm = new MySqlCommand(q, con);

            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MessageBox.Show("Comment Successful!");
        }
        

        public ArrayList NameShow(string name)
        {
            ArrayList nameList = new ArrayList();
            string qwl = ("select * from Review where Model='" + name + "'");
            MySqlCommand comm2 = new MySqlCommand(qwl, con);
            MySqlDataAdapter da2 = new MySqlDataAdapter(comm2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            for (int i = 0; i < dt2.Rows.Count; i++)
            {



                nameList.Add(dt2.Rows[i]["UserName"].ToString());


            }

            return nameList;

        }
        public ArrayList CommentShow(string comment)
        {
            ArrayList commentList = new ArrayList();
            string qwl = ("select * from Review where Model='" + comment + "'");
            MySqlCommand comm2 = new MySqlCommand(qwl, con);
            MySqlDataAdapter da2 = new MySqlDataAdapter(comm2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            for (int i = 0; i < dt2.Rows.Count; i++)
            {



                commentList.Add(dt2.Rows[i]["Comment"].ToString());


            }

            return commentList;

        }

        public void updateTable(string Os,string SSize,string Camera,string Battery,string Body,string Memory,string Features,string Cpu,string RDate,string Price,int id) {
            string q = ("update Phone set Os='"+Os+"',SSize='"+SSize+"',Camera='"+Camera+"',Battery='"+Battery+"',Body='"+Body+"',Memory='"+Memory+"',Features='"+Features+"',Cpu='"+Cpu+"',RDate='"+RDate+"',Price='"+Price+"' where ProductId='"+id+"'");
            MySqlCommand comm = new MySqlCommand(q, con);
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            DataTable dt = new DataTable();
            da.Fill(dt);
                
        }


        public void DeleteProduct(int id) {
            string q=("delete from Phone where ProductId='"+id+"'");
            MySqlCommand comm = new MySqlCommand(q, con);
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            DataTable dt = new DataTable();
            da.Fill(dt);
        
        }

        public void DeleteComment(int id) {
            string q = ("delete from Review where CmtId='" + id + "'");
            MySqlCommand comm = new MySqlCommand(q, con);
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            DataTable dt = new DataTable();
            da.Fill(dt);
      
        }

        public int modelValidation(string name) {
            string q = ("select * from Phone where Model ='"+name+"'");
            MySqlCommand comm = new MySqlCommand(q, con);
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
                return 0;
            else
                return 1;
        }
    }
}