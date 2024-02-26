﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
		private string _name;

		private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public virtual int Age
		{
			get { return age; }
			set 
			{ 
				if (value < 0)
				{
					//age = 0;
					throw new ArgumentException("Age cannot be lower then 0");
				}
				
				age = value;
			}
		}

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

        public override string ToString()
        {
			return $"Name: {Name}, Age: {age}";
        }




    }
}
