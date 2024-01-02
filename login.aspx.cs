using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_1
{
    public partial class login : System.Web.UI.Page
    {
        ConCls ob2 = new ConCls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select count(US_Id)from LGP where US_Name='" + TextBox1.Text + "'and Log_Password='" + TextBox2.Text + "'";
            string cid = ob2.Fn_Scalar(sel);
            int cid1 = Convert.ToInt32(cid);
            if (cid1 == 1)
            {
                string str = "select US_Id from LGP where US_Name='" + TextBox1.Text + "'and Log_Password='" + TextBox2.Text + "'";
                string regid = ob2.Fn_Scalar(str);
                Session["userid"] = regid;
                string str1 = "select Log_Type from LGP where US_Name='" + TextBox1.Text + "'and  Log_Password='" + TextBox2.Text + "'";
                string logtype = ob2.Fn_Scalar(str1);
                if (logtype == "admin")
                {
                    Response.Redirect("AdminHome.aspx");
                }
                else if (logtype == "user")
                {
                    Response.Redirect("UserHome.aspx");

                }
            }
            else
            {
                Label3.Visible = true;
                Label3.Text = "Invalid username and password";
            }

        }

        }
    }
