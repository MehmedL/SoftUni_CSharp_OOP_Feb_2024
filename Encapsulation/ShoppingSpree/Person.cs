using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    public class Person
    {
		private  string name;
		private decimal money;
		private List<Product> bagOfProducts;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
			bagOfProducts = new List<Product>();
        }

		public List<Product> Bag => bagOfProducts;

        public string Name
		{
			get { return name; }
			private set 
			{ 
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentNullException("Name cannot be empty");
				}
				name = value; 
			}
		}

		public decimal Money
		{
			get { return money; }
			private set 
			{
				if (value < 0)
				{
					throw new ArgumentException("Money cannot be negative");
				}
				money = value;
			}
		}

		public void AddProduct(Product product)
		{
			if(product.Cost > this.Money)
			{
				throw new ArgumentException($"{this.Name} can't afford {product.Name}");
			}
			this.bagOfProducts.Add(product);
			this.Money -= product.Cost;
		}

	}
}
