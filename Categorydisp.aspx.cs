using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
namespace Project_1
{
    public partial class Categorydisp : System.Web.UI.Page
    {
        ConCls c = new ConCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string sel = "select*from CTP";
                DataSet ds = c.Fn_DataAdapter(sel);
                GridView1.DataSource = ds;
                GridView1.DataBind();

            }
        }
        public void gridbind()
        {
            string sel = "select*from CTP";
            DataSet ds = c.Fn_DataAdapter(sel);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int i = e.RowIndex;
            int getid = Convert.ToInt32(GridView1.DataKeys[i].Value);
            string del = "delete from PRP where CT_Id=" + getid + "";
            int j = c.Fn_Nonquery(del);
            gridbind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            gridbind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            gridbind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;
            int getid = Convert.ToInt32(GridView1.DataKeys[i].Value);
            TextBox txtname = (TextBox)GridView1.Rows[i].Cells[2].Controls[0];
            string str = "update CTP set CT_Name='" + txtname.Text + "' where CT_Id=" + getid + "";
            int j = c.Fn_Nonquery(str);
            gridbind();
        }
    }
    }
    
