using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kings_BYOD_Helpdesk
{
    public partial class Ticket : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                string ticketID = Request.QueryString["ticketid"]; //read phone from querystring.

                string query;

                query = "SELECT schoolUsername AS [School Username], schoolPassword AS [School Password], deviceUsername AS [Device Username], devicePassword AS [Device Password] FROM deviceRegistration WHERE ticketID = " + ticketID;

                PlaceHolder1.Controls.Add(new Literal { Text = statusTable(query) });
                
            }
        }
        //Row count
        private int recordCount(string query)
        {
            DataTable dt = this.GetData(query);

            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                i++;
            }
            return i;
        }
        //Create each table based on passed query
        private string statusTable(string query)
        {
            //Populating a DataTable from database.
            DataTable dt = this.GetData(query);

            //Building an HTML string.
            StringBuilder html = new StringBuilder();

            //Table start.
            html.Append("<table border = '1' cellpadding='5'>");

            //Building the Header row.
            html.Append("<tr>");
            foreach (DataColumn column in dt.Columns)
            {
                html.Append("<th>");
                html.Append(column.ColumnName);
                html.Append("</th>");
            }
            html.Append("</tr>");

            //Building the Data rows.
            foreach (DataRow row in dt.Rows)
            {
                html.Append("<tr>");
                foreach (DataColumn column in dt.Columns)
                {
                    html.Append("<td>");
                    html.Append(row[column.ColumnName]);
                    html.Append("</td>");
                }
                html.Append("</tr>");
            }

            //Table end.
            html.Append("</table>");

            return html.ToString();
        }
        private DataTable GetData(string query)
        {
            string SQLConnection = ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(SQLConnection))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }
    }
}