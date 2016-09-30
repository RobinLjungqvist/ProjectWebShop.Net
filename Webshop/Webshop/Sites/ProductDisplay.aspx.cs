using BLL.Models;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webshop.Sites
{
    public partial class ProductDisplay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var productToDisplay = new Product();
            var bll = new BLLProduct();

            productToDisplay.productID = 7; // Eller det vi skickar till sidan.

            var productList = bll.SearchProduct(productToDisplay);

            productToDisplay = productList.FirstOrDefault();

            ProductContainer.InnerHtml = $"<div class=\"product\">" +
                                          $"<label>{productToDisplay.name}</label>" + 
                "<div>";

            //var productToCart = productList[index];
        }
    }
}