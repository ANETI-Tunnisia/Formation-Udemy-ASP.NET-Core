using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeudontonestleheors.Core.Data.Models
{
    public class Paragraphe
    {
        public int Id { get; set; }
        public int Numero { get; set; }

        public string Titre { get; set; }

        public string Description { get; set; }


        public Question MaQuestion  { get; set; }
    }
}
