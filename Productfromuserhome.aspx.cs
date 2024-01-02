using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace Project_1
{
    public partial class Productfromuserhome : System.Web.UI.Page
    {
        ConCls v = new ConCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string s ="select * from PRP" ;
                DataSet ds = v.Fn_DataAdapter(s);
                DataList1.DataSource = ds;
                DataList1.DataBind();
            }

        }

        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {
            int pdtid = Convert.ToInt32(e.CommandArgument);
            Session["PR_Id"] = pdtid;
            Response.Redirect("Productdetails.aspx");


        }
    }
}