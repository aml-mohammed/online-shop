using AmlShop.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmlShop.Models.Home
{
    public class HomeIndexViewModel
    {
        

        public IEnumerable<Product> ListOfProducts { get; set; }
        //public GenericUnitOfWork<Product> _product;
        //public HomeIndexViewModel CreateModel()
        //{
        //    return new HomeIndexViewModel
        //    {

        //        ListOfProducts = _product.GetRepositoryInstance.GetAllRecords()
        //    };
        //}
    }
    
}
