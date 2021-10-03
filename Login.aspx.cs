using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    DbCon d;

    protected void Page_Load(object sender, EventArgs e)
    {
        d = new DbCon();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String enroll_id, password, qry;
        enroll_id = txtEnroll.Text;
        password = txtPassword.Text;



        d.cmd.CommandText = "select * from table2 where enroll_id='" + enroll_id + "' and password='" + password + "'";
        d.dr = d.cmd.ExecuteReader();

        if (d.dr.Read())
        {
            Session.Add("enroll_id", enroll_id);
            Session.Add("unm", d.dr["Name"]);


            
            //Response.Write("<script LANGUAGE='JavaScript' >alert('Login Sucessfull')</script>");
            //Response.Redirect("Default.aspx");

               ScriptManager.RegisterStartupScript(this, this.GetType(),
              "alert",
             "alert('Login sucessfully');window.location ='upload_document.aspx';", true);


        }
        else
        {
            Response.Write("<script LANGUAGE='JavaScript' >alert('Login Error')</script>");
        }

    }
}