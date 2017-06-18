using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace Foro
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cadena = "Data Source=LAPTOP-M57N9BJ9\\SQLEXPRESS;Initial Catalog=db_foro;Persist Security Info=True;User ID=sa;Password=admin";
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM tb_user", conexion);
            DataSet datos = new DataSet();
            adp.Fill(datos,"tb_user");

            GridView1.DataSource=datos;
            GridView1.DataBind();
            conexion.Close();



         }
      
    }
}