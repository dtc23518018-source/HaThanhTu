using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace HaThanhTu.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private static int viewCount = 0;
        public IActionResult Welcome(String name,int id = 1, int numTime = 1 )
        {
            //int visitCount = HttpContext.Session.GetInt32("VisitCount") ?? 0;
           // viewCount++;        
            //HttpContext.Session.SetInt32("VisitCount", visitCount + 1);
           // if (visitCount == 0)
          //  {
            //    ViewData["message"] = $"Welcome to my website {name}";
            //}
         //   else
          //  {
             //   ViewData["message"] = $"Welcome back {name}! You have visited this page {visitCount} times.";
          //  }

            //ViewData["name"] = name;
            ViewBag.Message = $"Hello"+ name;
            ViewBag.id = "id cua ban la" + id;
            ViewBag.numtime = numTime;
            return View();
        }
      
    }
}
