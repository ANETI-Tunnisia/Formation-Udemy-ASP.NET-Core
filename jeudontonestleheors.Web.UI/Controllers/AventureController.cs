using jeudontonestleheors.Core.Data;
using jeudontonestleheors.Core.Data.Models;
using jeudontonestleheors.Web.UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace jeudontonestleheors.Web.UI.Controllers
{
    public class AventureController : Controller
    {

        //private readonly DefaultContext _context=null;

        //public AventureController(DefaultContext context)
        //{
        //    this._context=context;
                
        //}
        public IActionResult Index([FromServices]DefaultContext context)
        {
            this.ViewBag.MonTitre = "Aventure";

            var query = from item in context.Aventures
                        select item;

            return View(query.ToList());
        }
    }
}
