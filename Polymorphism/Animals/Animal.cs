using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    {
        protected Animal(string name, string favouritFood)
        {
            this.Name = name;
            this.FavouritFood = favouritFood;
        }

        public string Name { get; protected set; }
		public string FavouritFood { get; protected set; }



        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and my fovourite food is {this.FavouritFood}";
        }
		


    }
}
