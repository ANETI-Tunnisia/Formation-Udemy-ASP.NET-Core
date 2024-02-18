using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeudontonestleheors.Core.Data.Models
{
    public class Reponse
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public List<Reponse> MesReponses { get; set; }
    }
}
