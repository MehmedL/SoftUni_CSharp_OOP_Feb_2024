
using System;

namespace Animals
{
    public abstract class Animal
    {
		private string name;
		private int age;
		private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
			this.Age = age;
			this.Gender = gender;
        }
        public string Name
		{
			get { return name; }
			set 
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentException("iNVALID INPUT!");
				}
				name = value;
			}
		}
		public int Age
		{
			get { return age; }
			set 
			{
				if (value < 0)
				{
					throw new ArgumentException("invalid input!");
				}
				age = value; 
			}
		}
		public string Gender

		{
			get { return gender; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("iNVALID INPUT!");
                }
                gender = value;
            }
        }
        public override string ToString()
        {
			return $"{Name} {Age} {Gender}";
        }
        public abstract string ProduceSound();

    }
}
