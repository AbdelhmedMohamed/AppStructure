using Microsoft.AspNetCore.Mvc;

namespace AppStructure.Controllers
{
    public class MovieController :Controller
    {

        public IActionResult GetMovie(int id)
        {
            return Content($"Movie id ={id}" , "txt/html");

        }

        public IActionResult Index()
        {
            return Redirect("https://localhost:44364/");
        }

        public IActionResult Hamadaaaaaa() { 
        

            return View();
        }




    }

}
