using System.ComponentModel.DataAnnotations.Schema;

namespace jeudontonestleheors.Core.Data.Models
{

    [Table("Aventure")]
    public class Aventure
    {
        public int Id { get; set; }

        public string Titre { get; set; }
    }
}
