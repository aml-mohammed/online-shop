using AmlShop.datacontext;
using AmlShop.Models;
using AmlShop.Repository;
using AmlShop.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace AmlShop.Controllers
{
    public class AdminController : Controller
    {
        private readonly IHostingEnvironment _hosting;
        public GenericUnitOfWork<Category> _category;
        public GenericUnitOfWork<Product> _product;
        public List<SelectListItem> GetCategory()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            var cat = _category.GetRepositoryInstance.GetAllRecords();
            foreach (var item in cat)
            {
                list.Add(new SelectListItem { Value = item.CatId.ToString(), Text = item.CatName });

            }
            return list;
        }
        public AdminController(GenericUnitOfWork<Category> category, GenericUnitOfWork<Product> product, IHostingEnvironment hosting)
        {
            _hosting = hosting;
            _category = category;
            _product = product;
        }
        public IActionResult Dashboard()
        {
            return View();
        }


        public ActionResult Product()
        {
            return View(_product.GetRepositoryInstance.GetProduct());
        }
        public ActionResult ProductEdit( int productId)
        {
            ViewBag.CategoryList = GetCategory();
            return View(_product.GetRepositoryInstance.GetFirstOrDefault(productId));
        }
        [HttpPost]
        public ActionResult ProductEdit(Product p)
        {
            p.ModefiedDate = DateTime.Now;
            _product.GetRepositoryInstance.Update(p);


            return RedirectToAction("Product");
        }


        public ActionResult CategoryEdit(int CatId)
        {
          
            return View(_category.GetRepositoryInstance.GetFirstOrDefault(CatId));
        }
        [HttpPost]
        public ActionResult CategoryEdit(Category c)
        {
           
            _category.GetRepositoryInstance.Update(c);


            return RedirectToAction("Categories");
        }





        public ActionResult ProductAdd(int productId)
        {
            ViewBag.CategoryList = GetCategory();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ProductAdd(ProductViewModel model,Product pro)
        {

            //if (ModelState.IsValid)
            //{
           string uploads = null;
                if (model.file != null)
                {



                uploads = Path.Combine(_hosting.WebRootPath, @"images");
                string fullPath = Path.Combine(uploads, model.file.FileName);
                model.file.CopyTo(new FileStream(fullPath, FileMode.Create));

                //string uploads = Path.Combine(_hosting.WebRootPath, "images");
                //uniquefilename = Guid.NewGuid().ToString() + "_" + model.file.FileName;
                //string filepath = Path.Combine(uploads,uniquefilename);
                //model.file.CopyTo(new FileStream(filepath, FileMode.Create));

            }

            //Product pro = new Product
            //{

            //    CreatedDate = DateTime.Now,
            //    ProductName = model.ProductName,
            //    ProductImage = model.file.FileName

            //};
            pro.ProductImage = uploads;
            pro.CreatedDate = DateTime.Now;
            pro.Description = model.Description;




            _product.GetRepositoryInstance.Add(pro);
                _product.Save();

               // return RedirectToAction("Product");
          // }




           // pro.CreatedDate = DateTime.Now;
          //  _product.GetRepositoryInstance.Add(pro);
            
            return RedirectToAction("Product");
        }
        public IActionResult Categories()
        {
            List<Category> AllCtegories = _category.GetRepositoryInstance.GetAllRecordsQuerably().Where(i=>i.IsDelete==false).ToList();
            return View(AllCtegories);
        }
        public IActionResult AddCategory()
        {
            return UpdateCategory(0);
        }
        public IActionResult UpdateCategory(int CategoryId)
        {
            Category cat;
            if (CategoryId != null)
            {
                cat = JsonConvert.DeserializeObject<Category>(JsonConvert.SerializeObject(_category.GetRepositoryInstance.GetFirstOrDefault(CategoryId)));

            }
            else
            {
                cat = new Category();
            }
            return View("UpdateCategory",cat);
        }
    }
}
