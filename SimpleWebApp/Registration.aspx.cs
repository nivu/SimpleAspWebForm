using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registration : System.Web.UI.Page
{
    MySql.Data.MySqlClient.MySqlConnection conn;
    MySql.Data.MySqlClient.MySqlCommand cmd;

    String queryStr;


    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void RegisterUser(object sender, EventArgs e)
    {
        registerUser();
    }

    public void registerUser()
    {
        String conStr = System.Configuration.ConfigurationManager.ConnectionStrings["constr"].ToString();

        conn = new MySql.Data.MySqlClient.MySqlConnection(conStr);
        conn.Open();
        queryStr = "";

        queryStr = "INSERT INTO simple_asp_form.user (first_name, mobile, email) VALUES ('" +
            txtFirstName.Text + "','" + txtMobile.Text + "','" + txtEmail.Text + "')"; 

        cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);

        cmd.ExecuteReader();

        conn.Close();
        Response.Redirect("Default.aspx");

    }
}