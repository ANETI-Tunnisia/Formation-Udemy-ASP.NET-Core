using jeudontonestleheors.Core.Data;
using jeudontonestleheors.Core.Data.Models;
using jeudontonestleheors.Web.UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace jeudontonestleheors.Web.UI.Controllers
{
    public class AventureController : Controller
    {

        private readonly DefaultContext _context=null;

        public AventureController(DefaultContext context)
        {
            this._context=context;
                
        }
        public IActionResult Index()
        {
            this.ViewBag.MonTitre = "Aventure";
            //this.ViewBag.MonTableau = new int[] { 1, 2, 3, 4, 5 };
            //List<Aventure> maListe=new List<Aventure>();
            //maListe.Add(new Aventure()
            //{
            //    Id = 1,
            //    Titre="ma première Card"
            //});
            //maListe.Add(new Aventure()
            //{
            //    Id=2,
            //    Titre="ma deuxième Card"
            //});
            var query = from item in this._context.Aventures
                        select item;

            return View(query.ToList());
        }
    }
}
