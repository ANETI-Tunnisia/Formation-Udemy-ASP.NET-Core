using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeudontonestleheors.Core.Data.Models
{
    [Table("Question")]
    public class Question
    {
        #region Propriétés
        /// <summary>
        /// Id de l'instance
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Titre de la question
        /// </summary>
        public string Titre { get; set; }

        public int ParagrapheId { get; set; }

        /// <summary>
        /// Liste des réponses possibles
        /// </summary>
        public List<Reponse> MesReponses { get; set; }
        #endregion
    }
}
