using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialViewResult_sample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult homepage()
        {
            return View();
        }

        public PartialViewResult GetCategoriesPartial()  //bu ise 2.yol PartialView kullanımında 
        {
            return PartialView("_CategoriesPartialPage");
        }

        public PartialViewResult GetCategoriesPartial_2()  //bu ise 2.yol PartialView kullanımında 
        {

            List<string> categories = new List<string>() // bu ise 2.yolun model kullanılarak yapılan versiyonu 3.yol
            {
                "technology",
                "Warfare",
                "Auto",
                "Food",
                "Cleaning",
                "Plane"
            };



            return PartialView("_CategoriesPartialPage_2", categories);
        }
    }
}
// Peki Neden 2.Yolu kullanalim?
//Çünkü 1.yolda eğer veriler static ise yani önceden hesaplanmayacaksa önceden bir işlem yapman gerekmiyorsa Controller tarafında mesela kullandığımız Category 
//bilgilerini veritabanında çekecek olabililriz o zman "return PartialView("_CategoriesPartialPage");" demenden önce gerekli database işlemlerini yaparsın ve sonucu
// PartialView 'e gönderirsin yani önceden Controller tarafında Action kullanmana gerek olacak işlemlerde direkt PartialViewResult Action'ı ile olayı çözebilirsin.