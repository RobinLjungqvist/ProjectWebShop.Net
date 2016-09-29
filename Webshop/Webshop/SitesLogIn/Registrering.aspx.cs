using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webshop.SitesLogIn
{
    public partial class Registrering : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReg_Click(object sender, EventArgs e)
        {
           
            //FÖR ATT REGISTRERA SIG PÅ SIDAN MED STORED PROCEDURE
            //Create procedure [dbo].[tblUser]
            //@Username Nvarchar(20),
            //@Password Nvarchar (20),
            //AS
            //Begin
            //Set NoCount ON;
            //IF exists (Select Userid From tblUser where Username = @Username)
            //Begin 
            //Select -1
            //END
            //else
            // begin 
            //inster into
            //[tbl user]
            //([Username],[Password])
            //Values
            //(@Username,@Password)
            //Select Scope_IDENTITY
            //End
            //End
            
        }
    }
}