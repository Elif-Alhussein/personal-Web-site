using KisiselWebSite.Models.Siniflar;
using Microsoft.AspNetCore.Mvc;

namespace KisiselWebSite.Controllers
{
    public class AnaSayfaController1 : Controller
    {
        Context c = new Context();

        public IActionResult Index()
        {
            var anaSayfaModel = c.AnaSayfas.ToList();
            var ikonlarModel = c.ikonlars.ToList();
            ViewBag.Ikonlar = ikonlarModel;
            return View(anaSayfaModel);
        }

        public PartialViewResult Ikonlar()
        {
            var ikonlarModel = c.ikonlars.ToList();
            return PartialView(ikonlarModel);
        }
    }
}
