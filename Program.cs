namespace G_NET_7_MVC02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region mvc
            /*
             * What is MVC in Backend .NET?

            MVC stands for:

            M → Model
            V → View
            C → Controller


            1. Model

            The Model represents:

            Database tables
            Business logic
            Data operations

              public class Product
            {
                public int Id { get; set; }

                public string Name { get; set; }

                public double Price { get; set; }
            }

                Model Responsibilities
            Store data
            Validate data
            Communicate with database using EF Core
             * 
             * 
             * 2. View

            The View is the UI shown to the user.

            Usually written using:

            HTML
            CSS
            JavaScript
            Razor Syntax (.cshtml)

              <h1>@Model.Name</h1>
            <p>@Model.Price</p>

              3. Controller

            The Controller receives requests from users and connects Model with View.

               public class ProductController : Controller
            {
                public IActionResult Index()
                {
                    return View();
                }
            }


               public IActionResult Index()
                {
                    return View();
                }

                 Project
                │
                ├── Controllers
                │     └── ProductController.cs
                │
                ├── Models
                │     └── Product.cs
                │
                ├── Views
                │     └── Product
                │            └── Index.cshtml
                │
                ├── wwwroot
                │
                └── Program.cs

             public class ProductController : Controller
            {
                public IActionResult Index()
                {
                    List<Product> products = new List<Product>()
                    {
                        new Product(){ Id = 1, Name = "Laptop"},
                        new Product(){ Id = 2, Name = "Phone"}
                    };

                    return View(products);
                }
            }
              */

            #endregion
        }
    }
}
