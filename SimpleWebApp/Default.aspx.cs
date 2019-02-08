using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{

    public List<Object> names = new List<Object>();

    MySql.Data.MySqlClient.MySqlConnection conn;
    MySql.Data.MySqlClient.MySqlCommand cmd;
    MySql.Data.MySqlClient.MySqlDataReader reader;

    String queryStr;
    protected void Page_Load(object sender, EventArgs e)
    {
        fetchUsers();
    }

    public void fetchUsers()
    {
        String conStr = System.Configuration.ConfigurationManager.ConnectionStrings["constr"].ToString();

        conn = new MySql.Data.MySqlClient.MySqlConnection(conStr);
        conn.Open();

        queryStr = "SELECT * FROM simple_asp_form.user";

        cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);

        reader = cmd.ExecuteReader();

        String name;
        String mobile;
        String email;

        while (reader.HasRows && reader.Read())
        {
            name = reader.GetString(reader.GetOrdinal("first_name"));
            mobile = reader.GetString(reader.GetOrdinal("mobile"));
            email = reader.GetString(reader.GetOrdinal("email"));

            TableRow row = new TableRow();
            TableCell cell1 = new TableCell();
            cell1.Text = name;
            TableCell cell2 = new TableCell();
            cell2.Text = mobile;
            TableCell cell3 = new TableCell();
            cell3.Text = email;
            row.Cells.Add(cell1);
            row.Cells.Add(cell2);
            row.Cells.Add(cell3);
            myTable.Rows.Add(row);
        }

        reader.Close();
        conn.Close();

    }
}