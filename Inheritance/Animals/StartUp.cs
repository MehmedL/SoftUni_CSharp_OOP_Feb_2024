using System;
using System.Collections.Generic;
using System.Linq;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Animal> list = new();

            string animalType = Console.ReadLine();

            while (animalType != "Beast!")
            {
                string[] animalData = Console.ReadLine().
                Split(" ", StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    if (animalType == "Dog")
                    {
                        var doggy = new Dog(animalData[0], int.Parse(animalData[1]), animalData[2]);
                        Console.WriteLine(doggy.GetType().Name);
                        Console.WriteLine(doggy);
                        Console.WriteLine(doggy.ProduceSound());
                    }
                    if (animalType == "Cat")
                    {
                        var kotka = new Cat(animalData[0], int.Parse(animalData[1]), animalData[2]);
                        Console.WriteLine(kotka.GetType().Name);
                        Console.WriteLine(kotka);
                        Console.WriteLine(kotka.ProduceSound());
                    }
                    if (animalType == "Frog")
                    {
                        var froggy = new Frog(animalData[0], int.Parse(animalData[1]), animalData[2]);
                        Console.WriteLine(froggy.GetType().Name);
                        Console.WriteLine(froggy);
                        Console.WriteLine(froggy.ProduceSound());
                    }
                    if (animalType == "Kitten")
                    {
                        var kitten = new Kitten(animalData[0], int.Parse(animalData[1]));
                        Console.WriteLine(kitten.GetType().Name);
                        Console.WriteLine(kitten);
                        Console.WriteLine(kitten.ProduceSound());
                    }
                    if (animalType == "Tomcat")
                    {
                        var mujkakotka = new Tomcat(animalData[0], int.Parse(animalData[1]));
                        Console.WriteLine(mujkakotka.GetType().Name);
                        Console.WriteLine(mujkakotka);
                        Console.WriteLine(mujkakotka.ProduceSound());
                    }
                }

                catch (ArgumentException ae)
                {

                    Console.WriteLine(ae.Message);
                }
                animalType = Console.ReadLine();
            }
        }
    }
}
