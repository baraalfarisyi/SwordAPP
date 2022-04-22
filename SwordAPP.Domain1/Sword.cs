using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordAPP.Domain1
{
    public class Sword
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Years { get; set; }
        public int Weight { get; set; }
        public Samurai Samurai { get; set; }
        public int SamuraiId { get; set; }
        public List<Elemen> Elemens { get; set; } = new List<Elemen>();
    }
}
