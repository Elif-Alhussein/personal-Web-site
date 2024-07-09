using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using KisiselWebSite.Models.Siniflar;

namespace KisiselWebSite.Views.Shared.Components.Ikonlar
{
    public class IkonlarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("Default");
        }
    }
}

