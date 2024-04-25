using System.ComponentModel.DataAnnotations.Schema;

namespace jeudontonestleheors.Core.Data.Models
{

    [Table("Aventure")]
    public class Aventure
    {
        #region Propriétés
        /// <summary>
        /// C'est l'id de chaque aventure
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// C'est le titre de chaque aventure
        /// </summary>
        public string Titre { get; set; }
        #endregion
    }
}
