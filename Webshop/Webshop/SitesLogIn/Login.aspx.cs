using System;
using BLL.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Webshop.SitesLogIn
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnreg_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Registrering");
        }

        protected void btnlog_Click(object sender, EventArgs e)
        {
            

                //try
                //{

                //    var comm = new SqlCommand("select * from tblUser where username = @username and password = @password", con);
                //    comm.Parameters.AddWithValue("@username", User.Username);
                //    comm.Parameters.AddWithValue("@username", User.Password);
                //    con.open();
                //    var rd = comm.ExecuteReader();
                //    bool Admin = false;
                //    if (rd.HasRows)
                //    {
                //        while (rd.Read())
                //        {
                //            Session["Username"] = rd["username"].ToString();
                //            switch (Admin)
                //            {
                //                case true:
                //                    Response.Redirect("AdminTools.aspx");
                //                    break;
                //                case false:
                //                    Response.Redirect("~/MinaSidor");
                //                    break;
                //            }
                //        }
                //    }
                //    else
                //    {
                //        //Failuretxt är enbart en lbl som är skapad som blir synlig ifall detta fält blir använt
                //        User.failuretext = "Woops there was a problem";
                //    }
                //}
                //catch (Exception ex)
                //{
                //    //STACKTRACE:

                //    // Summary:
                //    //     Gets a string representation of the immediate frames on the call stack.
                //    //
                //    // Returns:
                //    //     A string that describes the immediate frames of the call stack.

                //    Response.Redirect(ex.StackTrace);
                //}
        }
    }
}