using ShoppingSpree;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        char[] arr = new[] { ';', '=' };
        List<Person> people = new List<Person>();
        List<Product> products = new List<Product>();

        var peopleData = Console.ReadLine()
            .Split(arr, StringSplitOptions.RemoveEmptyEntries);

        var productData = Console.ReadLine()
            .Split(arr, StringSplitOptions.RemoveEmptyEntries);

        try
        {
            for (int i = 0; i < peopleData.Length; i += 2)
            {
                people.Add(new Person(peopleData[i], int.Parse(peopleData[i+1])));
            }
            for (int i = 0; i < productData.Length; i+=2)
            {
                products.Add(new Product(productData[i], int.Parse(productData[i + 1])));
            }
        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex.Message);
            return;
        }
        string comand;
        while ((comand = Console.ReadLine()) != "END")
        {
            var token  = comand.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var person = people.Find(p => p.Name == token[0]);
            var product = products.Find(p => p.Name == token[1]);

            try
            {
                if (person is not null && product is not null)
                {

                    person.AddProduct(product);
                    Console.WriteLine($"{person.Name} bought {product.Name}");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            

        }

        foreach (var person in people) {

            Console.Write($"{person.Name} - ");
            if (person.Bag.Count == 0)
            {
                Console.WriteLine("Nothing bought");
                break;
            }
            Console.WriteLine(string.Join(", ",person.Bag.Select(item=>item.Name)));
        }
    }
}