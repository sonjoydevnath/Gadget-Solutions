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
    
    class Product
    {
        GSDatabase gs;
        Admin ad;
       
         byte[] arr;
        
        string Model, Brand, Os,SSize,cam,bat,body,memo,feat,cpu,rdate,lprice,ImgPath;

        public Product() {
            gs = new GSDatabase();
        }
        public Product(string Brand,string Model,string Os,string SSize,string cam,string bat,string body,string memo,string feat,string cpu,string rdate,string lprice,string ImgPath)
        {//TModelNo.Text, TBrand.Text, TOs.Text,TSize.Text,TCam.Text,TBat.Text,TBody.Text,TMemory.Text,TFeat.Text,TCpu.Text,TRDate.Text,TLPrice.Text,arr
            this.Model = Model;
            this.Brand = Brand;
            this.Os = Os;
            //this.arr=arr;
            this.SSize = SSize;
            this.cam = cam;
            this.bat = bat;
            this.body = body;
            this.memo = memo;
            this.feat = feat;
            this.cpu = cpu;
            this.rdate = rdate;
            this.lprice = lprice;
            this.ImgPath = ImgPath;
            gs = new GSDatabase();
            ad=new Admin();

        }
        public void ProductAdd()
        {
            gs.AddProduct(Brand, Model, Os,SSize,cam,bat,body,memo,feat,cpu,rdate,lprice,ImgPath);
        }
       public ArrayList ShowProduct(string n)
        {
             return gs.ProductShow(n);
           
        }
       public ArrayList ProductDetailsShow(string m)
        {

            return gs.ProductDetails(m);

        }

       public void update(string Os, string SSize, string Camera, string Battery, string Body, string Memory, string Features, string Cpu, string RDate, string Price, int id)
       {
           gs.updateTable(Os,SSize,Camera,Battery,Body,Memory,Features,Cpu,RDate,Price,id);
        
       }
       public void deleteProduct(int id) {
           gs.DeleteProduct(id);
       
       }

       public DataTable getPhone() {
           return gs.GetPhone();
       
       }


       public int ModelValidation(string name) {
           return gs.modelValidation(name);
           
       }
        
  

    }
}
