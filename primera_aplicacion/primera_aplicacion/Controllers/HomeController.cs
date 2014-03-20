using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using primera_aplicacion.Models;

public class HomeController : Controller
{
    //
    // GET: /Home/

    public ViewResult index()
    {
        return View();
    }

    public ViewResult AutoProperty()
    {
        //creando un nuevo objeto
        //de la clase producto
        Product MyProduct = new Product

       ////Establece el valor de la propiedad
        //MyProduct.ProductID = 12;
        //MyProduct.Name = "Kayak";
        //MyProduct.Description = "Kiosteca blue";
        //MyProduct.Category = "Sport";
        //MyProduct.Price = 12.5f;

        {
            ProductID = 12,
            Name = "kayak",
            Description = "Kiosteca blue",
            Category = "sports",
            Price = 12.5f

        };

        string salida =
            String.Format("{0}-{1}-{2}-{3}-{4:C0}",
            MyProduct.ProductID,
            MyProduct.Name,
            MyProduct.Description,
            MyProduct.Category,
            MyProduct.Price
            );

        //obtiene la propiedad
        // string productName = MyProduct.Name;

        //Genera la vista
        return View("Results",
            //(object)String.Format("Nombre del producto:{0}",productName));
            (object)salida);

    }
    public ViewResult CreateCollection()
    {
        string[] stringArray = { "manzanaa", "naranja", "lima" };

        List<int> intList = new List<int> { 10, 20, 30, 40 };

        Dictionary<string, int> myDict = new Dictionary<string, int>{
                {"Manzana",10},
                {"Naranja", 20},
                {"Lima",30}

        };
        return View("Results", (object)myDict["Lima"].ToString());
    }


    public ViewResult UseExtension()
    {
        ShoppingCart cart = new ShoppingCart
        {
            Products = new List<Product>
        {
        new Product{Name = "Kayak", Price = 3250.0f},
         new Product{Name = "Lentes", Price = 1500.0f},
          new Product{Name = "Balon footbaill", Price = 50.0f},
           new Product{Name = "Kayak", Price = 130.0f},
        }
        };

        double total = cart.TotalPrices();
        return View("Results",
            (object)String.Format("Total: {0:c}", total));


    }
}

