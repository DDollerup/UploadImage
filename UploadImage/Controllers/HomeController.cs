using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UploadImage.Factories;
using UploadImage.Models.BaseModels;

namespace UploadImage.Controllers
{
    public class HomeController : Controller
    {
        ShoeFactory shoeFac = new ShoeFactory();

        // GET: Home
        public ActionResult Index()
        {
            List<Shoe> allShoes = shoeFac.GetAll();
            return View(allShoes);
        }
        
        [HttpPost]
        public ActionResult AddShoeSubmit(Shoe shoe, HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                shoe.Image = file.FileName;
                string appPath = Request.PhysicalApplicationPath;
                file.SaveAs(appPath + @"\Content\Images\Shoes\" + file.FileName);
            }

            shoeFac.Add(shoe);
            return RedirectToAction("Index");
        }
    }
}