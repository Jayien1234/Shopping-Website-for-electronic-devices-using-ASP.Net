using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_1
{
    public partial class AdminJ : System.Web.UI.Page
    {
        ConCls ob = new ConCls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select max(US_Id)from LGP";
            string regid = ob.Fn_Scalar(sel);
            int US_Id = 0;
            if (regid == "")
            {
                US_Id = 1;
            }
            else
            {
                int newregid = Convert.ToInt32(regid);
                US_Id = newregid + 1;
            }
            string s1 = "insert into ADP values(" + US_Id + ",'" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')";
            int i = ob.Fn_Nonquery(s1);
            string s2 = "insert into LGP values(" + US_Id + ",'" + TextBox4.Text + "','" + TextBox5.Text + "','admin','active')";
            int j = ob.Fn_Nonquery(s2);
            Response.Redirect("login.aspx");
        }
    }
    }
