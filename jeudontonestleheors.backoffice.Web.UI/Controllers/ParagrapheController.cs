using jeudontonestleheors.Core.Data;
using jeudontonestleheors.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;

namespace jeudontonestleheors.backoffice.Web.UI.Controllers
{
    public class ParagrapheController : Controller
    {
        #region paragraphe provisoire pour l'entité
        //List<Paragraphe> _maListParagraphe = new List<Paragraphe>()
        //{
        //    new Paragraphe { Id = 1,Numero=10,Titre="Titre 1" },
        //    new Paragraphe {Id = 2,Numero=14,Titre="Titre 2"},
        //    new Paragraphe {Id=3,Numero=32,Titre="Titre3"}
        //};
        #endregion

        #region Champs Privés
        private DefaultContext _context = null;
        #endregion

        #region Constructors
        public ParagrapheController(DefaultContext context)
        {
            this._context = context;     
        }

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
            this._context.Add(paragraphe);
            this._context.SaveChanges();
            return this.View();
        }
        public IActionResult Edit(int Id)
        {
            Paragraphe paragraphe = null;
           //paragraphe= _maListParagraphe.First(item=>item.Id == Id);
           paragraphe=this._context.Paragraphes.FirstOrDefault(x => x.Id == Id);


            return this.View(paragraphe);
        }
        [HttpPost]
        public IActionResult Edit(Paragraphe paragraphe)
        {
            //this._context.Update(paragraphe);

            this._context.Attach<Paragraphe>(paragraphe);
            this._context.Entry(paragraphe).Property(item => item.Titre).IsModified = true;

            this._context.SaveChanges();
            return this.View(paragraphe);
        }
      


    }
}
