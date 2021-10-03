using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for DbCon
/// </summary>
public class DbCon
{
    public SqlConnection conn;
    public SqlCommand cmd;
    public SqlDataReader dr;
    
	public DbCon()
	{
		//
		// TODO: Add constructor logic here
		//
        conn = new SqlConnection();
        conn.ConnectionString = ConfigurationManager.ConnectionStrings["Student"].ToString();

        conn.Open();
        cmd = new SqlCommand();

        cmd.Connection = conn;
	}
}