using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCRUD.Models;

namespace MVCCRUD.Controllers
{
    public class ProductController : Controller


    {

        ServicesContex db = new ServicesContex();
        // GET: Product
        public ActionResult Index()
        {
            var data=db.Products.ToList();
            return View(data); 
        }
        public ActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Create(Product pr) 
        
        {
            db.Products.Add(pr);
           int a= db.SaveChanges();
            if(a>0)
            {
                ViewBag.CreatMessage =( "<script>alert('Data saved')</script>");
            return RedirectToAction("Index");
             }
            else
            {
                ViewBag.CreatMessage = ("<script>alert('Data not saved')</script>");

            }
            return View();

        
        }
        public ActionResult Edit(int id) 
        
        { 
            var row=db.Products.Where(model=>model.ProductId==id).ToList();
            return View(row);
        
        }
    }
}