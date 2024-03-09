using jeudontonestleheors.Core.Data;
using jeudontonestleheors.Core.Data.Models;
using jeudontonestleheors.Web.UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace jeudontonestleheors.Web.UI.Controllers
{
    public class AventureController : Controller
    {

        private readonly DefaultContext _context = null;

        public AventureController(DefaultContext context)
        {
            this._context = context;

        }
        //public IActionResult Index([FromServices]DefaultContext context)
            public IActionResult Index()
        {
            this.ViewBag.MonTitre = "Aventure";

            var query = from item in this._context.Aventures
                        select item;

            return View(query.ToList());
        }
        public IActionResult Create()
        {
            return this.View();
        }
        [HttpPost]
        public IActionResult Create(Aventure aventure)
        {
            this._context.Add(aventure);
            this._context.SaveChanges();
            return this.View();
        }
    }
}
