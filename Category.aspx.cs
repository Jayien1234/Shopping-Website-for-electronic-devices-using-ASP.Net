using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ConCls b = new ConCls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label5.Visible = true;
            string p = "~/cat/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));

            string s = "insert into CTP values('" + TextBox1.Text + "','" + p + "','" + TextBox2.Text + "','" + TextBox3.Text + "')";
            int i = b.Fn_Nonquery(s);
        }
    }
}