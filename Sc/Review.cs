using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Data.SqlClient;
//using Microsoft.VisualBasic;
using System.IO;
using System.Data;

namespace GUI
{
    class Review
    {
        GSDatabase gs = new GSDatabase();
        
        string model, userName, comment;
        public Review()
        {
            //gs = new GSDatabase();
        }
        public Review(string model, string userName, string comment)
        {
            this.model = model;
            this.userName = userName;
            this.comment = comment;
        }
        public void addComment()
        {
            gs.Review(model, userName, comment);
        }
        public ArrayList showComment(string s)
        {
            return gs.CommentShow(s);
        }
        public ArrayList showName(string u)
        {
            return gs.NameShow(u);
        }


        public void deleteComment(int id)
        {
            gs.DeleteComment(id);
        }
        public DataTable getComment() {
            return gs.GetComment();     
        }


    }
}
