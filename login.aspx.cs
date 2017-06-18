using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Configuration;

namespace Foro
{
    public partial class login : System.Web.UI.Page
    {
        string conexion = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnx;
            SqlCommand query;
            Object res;

            cnx = new SqlConnection(conexion);
            cnx.Open();
            
            query = new SqlCommand();
            query.CommandType = CommandType.Text;
            query.CommandText = "INSERT INTO tb_user(user_name,user_pass)VALUES('" + TextBox1.Text + "','" + TextBox2.Text + "')";
            query.Connection = cnx;
            
            res = new Object();
            res = query.ExecuteScalar();
            
            if (!(res is DBNull))
            {
                Response.Write("<script languaje=javascript>");
                Response.Write("alert('Usuario Registrado con exito')");
                Response.Write("</script>");
            }

            cnx.Close();




        }
    }
}