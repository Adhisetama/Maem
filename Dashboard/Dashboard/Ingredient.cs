using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard
{
    internal class Ingredient
    {
        public Ingredient(string description, string amount, int nutritionApiID)
        {
            this.description = description;
            this.amount = amount;
            this.nutritionApiID = nutritionApiID;
        }
        public string description;
        public string amount;
        public int nutritionApiID;
    }
}
