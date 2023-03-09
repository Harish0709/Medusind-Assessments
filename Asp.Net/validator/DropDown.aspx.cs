using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Assignment_1
{
    public partial class DropDown : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetItem("All");
            }
            else
            {
                Response.Cache.SetExpires(DateTime.Now.AddSeconds(30));
                Response.Cache.VaryByParams["None"] = true;
                Response.Cache.SetCacheability(HttpCacheability.ServerAndPrivate);
            }

        }

        protected void GetItem(string ProductName)
        {
            string connectionString = "Data Source=LAPTOP-MEGS7690; initial catalog=master;integrated security = true;";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("GetFruitProducts", con);
            command.CommandType = CommandType.StoredProcedure;

            con.Open();

            SqlDataReader reader = command.ExecuteReader();
            command.CommandType = CommandType.StoredProcedure;
            con.Close();

            // Create a data adapter and fill a DataTable with the data returned by the stored procedure
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            

            
            
        }



        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Image1.ImageUrl = "~/images/" + DropDownList1.SelectedValue + ".jpg";
            GetItem(DropDownList1.SelectedValue);
           
            Label1.Text = this.GridView1.Rows[0].Cells[2].Text;
            


        }
    }
}
