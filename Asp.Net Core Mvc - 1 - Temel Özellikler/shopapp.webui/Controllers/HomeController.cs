using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Models;

namespace shopapp.webui.Controllers
{
    //localhost:5000/home
    public class HomeController:Controller
    {
        //localhost:5000/home/index
        public IActionResult Index (){
            var products = new List<Product>(){
                new Product{Name="İphone 8", Price= 6000, Description="iyi telefon", IsApproved=false},
                new Product{Name="İphone x", Price= 7000, Description="iyi telefon", IsApproved=true},
                new Product{Name="İphone 11", Price= 8000, Description="iyi telefon", IsApproved=true},
                new Product{Name="İphone 12", Price= 9000, Description="çok iyi telefon"}
            };

            var productViewModel = new ProductViewModel(){
                Products = products
            };
            return View(productViewModel);
        }

        //localhost:5000/home/about
        public IActionResult About (){
            return View();
        }

        public IActionResult Contact (){
            return View("MyView");
        }
    }
}
