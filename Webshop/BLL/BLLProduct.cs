using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop.Models;
using DAL;

namespace BLL
{
    class BLLProduct
    {
        public List<Product> GetProducts(Product SearchObject)
        {
            var dal = new DALProduct();

            var SearchResult = dal.SearchProduct(SearchObject);

            return SearchResult;

        }
    }
}
