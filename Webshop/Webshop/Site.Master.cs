using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webshop
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //KOPIERA IN I LINKDBUTTON CLICK-EVENT
            //SEDAN SÅ SKAPAR JAG EN KNAPP I DYNAMIC HTML SOM SKA HA KODEN UNDER STRECKET PÅ DENNA.

            //StringBuilder table = new StringBuilder();
            //SqlConnection con = new SqlConnection("Data source = DESKTOP-DJIU07K\SQLEXPRESS;Database = Webbshop; Integrated Security = true;");
            ////string query = "Select * from [tblProduct";
            //if (!IsPostBack)
            //{
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.CommandText = ("Select * from [tblProduct]");
            //    cmd.Connection = con;
            //    //startar läsaren
            //    SqlDataReader rd = cmd.ExecuteReader();
            //    //Sätter till en border.
            //    table.Append("<table border = '2'");
            //    //Manuellt in kodat självaste utseendet. Sedan är allt hur man vill att det ska se ut
            //    table.Append("<tr><th>Picture</th></tr>");
            //    table.Append("<tr><th>ProductID </th><th>ProductName</th>");
            //    table.Append("<tr><th>Description</th></tr>");

            //    table.Append("</tr>");
            //    //kollar ifall rader finns sedan går den in i loopen
            //    if (rd.HasRows)
            //    {
            //        //ifall det finns något att läsa så loopar den tills att det inte finns några rader kvar att läsa
            //        while (rd.Read())
            //        {
            //            table.Append("<tr>");
            //            //För varje rad så ut eftersom att den sätter till en sträng så sätter den också till det faktiska mommentet som är 
            //            //ett index för att säga till datorn vart och hur platsen ska visas.
            //            table.Append("<td>" + rd[0] + "</td>");
            //            table.Append("<td>" + rd[1] + "</td>");
            //            table.Append("</tr>");
            //        }
            //    }
            //    table.Append("</table>");
            //    //lägger till en literal som är statisk, som ska ha text
            //    plcInfo.Controls.Add(new Literal { Text = table.ToString() });
            //    //lägger till en literal som är knapp
            //    plcInfo.Controls.Add(new Button { Text = "Put in ShoppingBasket" });
            //    //stänger datareadern
            //    rd.Close();
            //}
        }
    }
}