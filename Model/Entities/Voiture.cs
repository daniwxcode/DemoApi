using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Voiture
    {
        public int Id { get; set; }
        public string NumChassis { get; set; }
        public string NumPlaque { get; set; }
        public string Marque { get; set; }
        public string Model { get; set; }
        public int Année { get; set; }
    }
}
