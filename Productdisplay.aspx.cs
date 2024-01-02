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
    public partial class Productdisplay : System.Web.UI.Page
    {
        ConCls m = new ConCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string sel = "select*from PRP";
                DataSet ds = m.Fn_DataAdapter(sel);
                GridView1.DataSource = ds;
                GridView1.DataBind();

            }
        }
        public void gridbind()
        {
            string sel = "select*from PRP";
            DataSet ds = m.Fn_DataAdapter(sel);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int i = e.RowIndex;
            int getid = Convert.ToInt32(GridView1.DataKeys[i].Value);
            string del = "delete from PRP where PR_Id=" + getid + "";
            int j = m.Fn_Nonquery(del);
            gridbind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        { GridView1.EditIndex = e.NewEditIndex;
            gridbind();

        }

        

       

        protected void GridView1_RowUpdating1(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;
            int getid = Convert.ToInt32(GridView1.DataKeys[i].Value);
            TextBox txtname = (TextBox)GridView1.Rows[i].Cells[2].Controls[0];
            string str = "update PRP set PR_Name='" + txtname.Text + "' where PR_Id=" + getid + "";
            int j = m.Fn_Nonquery(str);
            gridbind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            gridbind();
        }
    }

   
    }


