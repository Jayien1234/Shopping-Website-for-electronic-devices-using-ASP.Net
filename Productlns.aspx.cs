using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_1
{
    public partial class ProductIns : System.Web.UI.Page
    {
        ConCls d = new ConCls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label8.Visible = true;
            string k = DropDownList1.SelectedItem.Value;

            string p = "~/p/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));

            string ins = "insert into PRP values('" + k + "','" + TextBox1.Text + "','" + p + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')";
            int i = d.Fn_Nonquery(ins);
        }
    }
}