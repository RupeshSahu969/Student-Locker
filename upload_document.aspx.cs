using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class upload_document : System.Web.UI.Page
{
    DbCon d;

    protected void Page_Load(object sender, EventArgs e)
    {
        d = new DbCon();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        

        String aadhar_no, aadhar_img, marksheet_10, marksheet_12, qry;

        String enroll_id = "";


        enroll_id = Session["enroll_id"].ToString();

        //enroll_id = txtEnroll.Text;
        aadhar_no = TextBox1.Text;
        aadhar_img = FileUpload1.FileName;
        marksheet_10 = FileUpload2.FileName;
        marksheet_12 = FileUpload3.FileName;
        


        if (FileUpload1.HasFile)
        {
            aadhar_img = FileUpload1.FileName;
            //FileUpload1.SaveAs(Server.MapPath("~/Aadhar img/") + aadhar_img);
            FileUpload1.SaveAs("D:\\St_Locker\\" + enroll_id + "\\aadhar\\" + aadhar_img);

           // Response.Write("<script LANGUAGE='JavaScript' >alert('Aadhat Image Upload')</script>");

        }
        if (FileUpload2.HasFile)
        {
            marksheet_10 = FileUpload2.FileName;
           // FileUpload2.SaveAs(Server.MapPath("~/10 marksheet/") + marksheet_10);
            FileUpload1.SaveAs("D:\\St_Locker\\" + enroll_id + "\\marksheet_10\\" + marksheet_10);

          //  Response.Write("<script LANGUAGE='JavaScript' >alert('10th marksheet Image Upload')</script>");

        }
        if (FileUpload3.HasFile)
        {
            marksheet_12 = FileUpload3.FileName;
           // FileUpload3.SaveAs(Server.MapPath("~/12 marksheet/") + marksheet_12);
            FileUpload1.SaveAs("D:\\St_Locker\\" + enroll_id + "\\marksheet_12\\" + marksheet_12);

          //  Response.Write("<script LANGUAGE='JavaScript' >alert('12th marksheet Upload')</script>");

        }

        qry = "insert into table3(aadhar_no, aadhar_img, marksheet_10, marksheet_12) values( '" + aadhar_no + "','" + aadhar_img + "','" + marksheet_10 + "','" + marksheet_12 + "')";
      
        d.cmd.CommandText = qry;
        d.cmd.ExecuteNonQuery();

       // Response.Write("<script LANGUAGE='JavaScript' >alert('Insert Sucessfull')</script>");

        ScriptManager.RegisterStartupScript(this, this.GetType(),
        "alert",
        "alert('User Upload sucessfully');window.location ='index.aspx';",true);

        
    }
}