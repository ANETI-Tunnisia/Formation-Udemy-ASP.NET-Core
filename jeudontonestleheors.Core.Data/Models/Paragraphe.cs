﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeudontonestleheors.Core.Data.Models
{
    [Table("Paragraphe")]
    public class Paragraphe
    {
        #region Propriétés
        /// <summary>
        /// Id venant de la base
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Numéro à afficher pour le jeu
        /// </summary>
        public int Numero { get; set; }

        /// <summary>
        /// C'est le titre du paragraphe
        /// </summary>
        public string Titre { get; set; }

        /// <summary>
        /// Description du paragraphe
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Question du paragraphe
        /// </summary>
        public Question MaQuestion { get; set; }
        #endregion
    }
}
