using jeudontonestleheors.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace jeudontonestleheors.backoffice.Web.UI.Controllers
{
    public class ParagrapheController : Controller
    {
        #region paragraphe provisoire pour l'entité
        List<Paragraphe> _maListParagraphe = new List<Paragraphe>()
        {
            new Paragraphe { Id = 1,Numero=10,Titre="Titre 1" },
            new Paragraphe {Id = 2,Numero=14,Titre="Titre 2"},
            new Paragraphe {Id=3,Numero=32,Titre="Titre3"}
        };
        #endregion
        public IActionResult Index(int Id)
        {
            this.ViewBag.MonSuperId = Id;
            return this.View();
        }
        public IActionResult Create()
        {
            return this.View();
        }
        [HttpPost]  
        public IActionResult Create(Paragraphe paragraphe )
        {
            return this.View();
        }
        public IActionResult Edit(int Id)
        {
            Paragraphe paragraphe = null;
           paragraphe= _maListParagraphe.First(item=>item.Id == Id);
            return this.View(paragraphe);
        }
    }
}
