using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Search : System.Web.UI.Page
{
    DbCon d;

    protected void Page_Load(object sender, EventArgs e)
    {
        d = new DbCon();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String name = txtName.Text;

        d.cmd.CommandText = "select * from table2 where name='" + name + "'";
        d.dr = d.cmd.ExecuteReader();

        if (d.dr.Read())
        {
            txtEnroll.Text = d.dr["enroll_id"].ToString();
            txtEmail.Text = d.dr["email"].ToString();
            txtMobile.Text = d.dr["mobile"].ToString();
            

        }
        else
        {
            txtEnroll.Text = "";
            txtEmail.Text = "";
            txtMobile.Text = "";
           

            Response.Write("<script LANGUAGE='JavaScript' >alert('Enter Name')</script>");
        }
        d.dr.Close();


    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        String enroll_id = txtEnroll.Text;
        String name = txtName.Text;
        String email = txtEmail.Text;
        String mobile = txtMobile.Text;

        d.cmd.CommandText = "update table2 set enroll_id='" + enroll_id + "' ,email='" + email + "',mobile='" + mobile + "' where name='" + name + "'";

        d.dr = d.cmd.ExecuteReader();

        Response.Write("<script LANGUAGE='JavaScript' >alert('Update succesfully')</script>");

    }
    protected void Button3_Click(object sender, EventArgs e)
    {

        String enroll_id = txtEnroll.Text;
        String name = txtName.Text;
        String email = txtEmail.Text;
        String mobile = txtMobile.Text;


        d.cmd.CommandText = "delete from table2  where name='" + name + "'";
        d.cmd.ExecuteNonQuery();


        Response.Write("<script LANGUAGE='JavaScript' >alert('Delete succesfully')</script>");
    }
}