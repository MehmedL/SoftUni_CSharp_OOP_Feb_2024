

namespace Animals
{
    public class Kitten : Cat
    {
        private const string kittenGenedr = "Female";
        public Kitten(string name, int age) : base(name, age, kittenGenedr)
        {
        }
        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
