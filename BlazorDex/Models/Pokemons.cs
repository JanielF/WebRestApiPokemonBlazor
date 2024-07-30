using System.Drawing;
using System.Xml.Linq;

namespace BlazorDex.Models
{
    public class Pokemons
    {
        public int id { get; set; } = 0;
        public string name { get; set; } = "";
        public int height { get; set; } = 0;
        public int weight { get; set; } = 0;
        public Sprites sprites { get; set; } = new Sprites();
        public List<Stat> stats { get; set; } = new List<Stat> { };
        public List<Type> types { get; set; } = new List<Type> { };

    }
}
