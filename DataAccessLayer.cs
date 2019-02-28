using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace TopStarWebApplication01
{
    public class DataAccessLayer
    {
        public SqlConnection connection = null;
        String connectionString = null;
       

        public void AddPanelIems(string logo, string companyName, string img1, string img2, string img3, int navid, string address, string phoneNo)
        {
            connectionString = ConfigurationManager.ConnectionStrings["dbtopstarConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            connection.Open();

            String getNavid = "select n.navId from tbnavigation n , tbPanel p where n.panelid = p.panelId ";
            SqlCommand cmd = new SqlCommand(getNavid, connection);
            int navigationId = Convert.ToInt32(cmd.ExecuteScalar());


            String query = "insert into tbPanel values ('" + img1 + "','" + img2 + "','" + img3 + "','" + logo + "','" + navigationId + "','" + companyName + "','" + address+ "')";

            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();



        }
    }
}