using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class _Default : System.Web.UI.Page
{
    DbCon d;

    protected void Page_Load(object sender, EventArgs e)
    {
        d = new DbCon();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String enroll_id,name,email,mobile,password,qry;
        enroll_id = TextBox1.Text;
        name = TextBox2.Text;
        email = TextBox3.Text;
        mobile = TextBox4.Text;
        password = TextBox5.Text;

        d.cmd.CommandText = "select * from table2 where name='" + name + "'";
        d.dr = d.cmd.ExecuteReader();
        if (d.dr.Read())
        {
            Response.Write("<script LANGUAGE='JavaScript' >alert('Already exists')</script>");
            
            d.dr.Close();
        }
        else
        {
            d.dr.Close();

            qry = "insert into table2(name,enroll_id,email,mobile,password) values( '" + name + "', '" + enroll_id + "','" + email + "','" + mobile + "','" + password + "')";
            d.cmd.CommandText = qry;
            d.cmd.ExecuteNonQuery();
            String path2 = "D:\\St_Locker\\" + enroll_id;
            Directory.CreateDirectory(path2);
            Directory.CreateDirectory(path2 + "\\aadhar");
            Directory.CreateDirectory(path2 + "\\marksheet_10");
            Directory.CreateDirectory(path2 + "\\marksheet_12");
           // Response.Write("<script LANGUAGE='JavaScript' >alert('Sucessfull')</script>");

            ScriptManager.RegisterStartupScript(this, this.GetType(),
              "alert",
             "alert('Register sucessfully');window.location ='Login.aspx';", true);


        }

    }
}