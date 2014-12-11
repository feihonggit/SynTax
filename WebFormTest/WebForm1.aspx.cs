using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormTest
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string path = FileUpload1.PostedFile.FileName;              //获取上传文件的路径
            string Name = path.Substring(path.LastIndexOf("\\") + 1);   //获取文件名 
            string Size = Convert.ToString(FileUpload1.PostedFile.ContentLength);      //获取文件大小
            string Extend = path.Substring(path.LastIndexOf(".") + 1);  //获取文件扩展名
            string Type = FileUpload1.PostedFile.ContentType;           //获取文件类型
            string serverPath = Server.MapPath(@"\Images\") + Name;    //保存服务器的路径
            FileUpload1.PostedFile.SaveAs(serverPath);                  //确定上传
        }
    }
}