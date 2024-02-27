using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Models;

namespace shopapp.webui.Controllers
{
    //localhost:5000/Product
    public class ProductController:Controller
    {   
        public IActionResult Index (){
            var product2 = new Product(){
                Name = "Iphone x",
                Price = 10000,
                Description= "Denemelik telefon"
            }; 

            //ViewData
            ViewData["Product"] = product2;
            ViewData["Category"] = "Telefon";

            //ViewBag
            ViewBag.Product = product2;
            ViewBag.Category = "Telefon"; 
            
            //Model
            return View(product2);
        }

        //localhost:5000/product/list
        public IActionResult list (){
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

        //localhost:5000/product/details
        public IActionResult Details (){
            
            var product = new Product();
            product.Name = "Samsung S6";
            product.Price = 6000;
            product.Description = "Eazy Telefon";

            return View(product);
        }
    }
}