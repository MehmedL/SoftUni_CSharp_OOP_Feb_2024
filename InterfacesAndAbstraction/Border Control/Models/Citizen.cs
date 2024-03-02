using Border_Control.Models.Interfaces;

namespace Border_Control.Models
{
    public class Citizen : BaseEntity
    {
        public Citizen(string id, int age, string name)
        {
            Id = id;
            Age = age;
            Name = name;
        }

        
        public int Age { get; private set; }
        public string Name { get; init; }

    }
}
