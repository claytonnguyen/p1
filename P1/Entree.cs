using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    public class Entree
    {
        private string _name { get; set; }
        private string[] _ingredients;
        private uint[] _nutritionStats;
        private readonly DateTime expiration;
        private readonly bool refrigeration;
        private readonly bool refrigerated;
        private readonly bool power;

        public Entree()
        {
            expiration = DateTime.Now.AddDays(7);
            refrigeration = true;
            refrigerated = true;
            power = true;
        }

        public Entree(string name, string[] ingredients, uint[] nutritionStats)
        {
            _name = name;
            _ingredients = ingredients;
            _nutritionStats = nutritionStats;
            expiration = DateTime.Now.AddDays(7);
            refrigeration = true;
            refrigerated = true;
            power = true;
        }

        public bool IsExpired()
        {
            return expiration <= DateTime.Now;
        }

        public bool IsSpoiled()
        {
            return (expiration <= DateTime.Now) && refrigerated && power;
        }

        public bool Contains(string ingredient)
        {
            foreach (string x in _ingredients)
            {
                return ingredient.Contains(x);
            }
            return false;
        } 

        public void GetNutrition()
        {
            foreach (uint x in _nutritionStats)
            {
                Console.WriteLine("NumberOfServings: " + x);
                Console.WriteLine("Calories: " + x);
                Console.WriteLine("TotalFat(g): " + x);
                Console.WriteLine("SatFat(g): " + x);
                Console.WriteLine("TransFat(g): " + x);
                Console.WriteLine("Cholest(mg): " + x);
                Console.WriteLine("Sodium(mg): " + x);
                Console.WriteLine("TotCarb(g): " + x);
                Console.WriteLine("Fiber(g): " + x);
                Console.WriteLine("TotSugars(g): " + x);
                Console.WriteLine("Protein(g): " + x);
                Console.WriteLine("NumberOfServings: " + x);
            }
        }
    }
}
