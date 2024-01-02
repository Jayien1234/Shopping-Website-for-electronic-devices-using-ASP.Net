using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace Project_1
{
    public partial class UserHome : System.Web.UI.Page
    {
        ConCls b = new ConCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string s = "select*from CTP";
                DataSet ds = b.Fn_DataAdapter(s);
                DataList1.DataSource = ds;
                DataList1.DataBind();
            }
        }

       

        protected void ImageButton1_Command1(object sender, CommandEventArgs e)
        { int catid = Convert.ToInt32(e.CommandArgument);
            Session["uid"] = catid;
            Response.Redirect("Productfromuserhome.aspx");

        }
    }
}