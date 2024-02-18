using jeudontonestleheors.Core.Data.Models;
using jeudontonestleheors.Web.UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace jeudontonestleheors.Web.UI.Controllers
{
    public class AventureController : Controller
    {
        public IActionResult Index()
        {
            //this.ViewBag.MonTableau = new int[] { 1, 2, 3, 4, 5 };
            List<Aventure> maListe=new List<Aventure>();
            maListe.Add(new Aventure()
            {
                Id = 1,
                Titre="ma première Card"
            });
            maListe.Add(new Aventure()
            {
                Id=2,
                Titre="ma deuxième Card"
            });
            return View(maListe);
        }
    }
}
