using PersonsInfo;
using System;
using System.Collections.Generic;
using System.Linq;
public class StartUp
{
    public static void Main()
    {
        //Zadacha1();
        //Zadacha2();
        int peopleCount = int.Parse(Console.ReadLine());

        List<Person> people = new List<Person>();
        Team team = new Team("Pikachu");

        for (int i = 0; i < peopleCount; i++)
        {
            string[] commandInfo = Console.ReadLine().Split();
            Person person = new Person(commandInfo[0], commandInfo[1], int.Parse(commandInfo[2]), decimal.Parse(commandInfo[3]));

            people.Add(person);
            team.AddPlayer(person);
        }

        Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
        Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");



        //var parcentage = decimal.Parse(Console.ReadLine());
        //persons.ForEach(p => p.IncreaseSalary(parcentage));
        //team.ForEach(p => Console.WriteLine(p.ToString()));

    }

    private static void Zadacha2()
    {
        var lines = int.Parse(Console.ReadLine());
        var persons = new List<Person>();
        for (int i = 0; i < lines; i++)
        {
            var cmdArgs = Console.ReadLine().Split();
            var person = new Person(cmdArgs[0],
                                    cmdArgs[1],
                                    int.Parse(cmdArgs[2]),
                                    decimal.Parse(cmdArgs[3]));

            persons.Add(person);
        }
        var parcentage = decimal.Parse(Console.ReadLine());
        persons.ForEach(p => p.IncreaseSalary(parcentage));
        persons.ForEach(p => Console.WriteLine(p.ToString()));
    }

    //private static void Zadacha1()
    //{
    //    var lines = int.Parse(Console.ReadLine());
    //    var persons = new List<Person>();
    //    for (int i = 0; i < lines; i++)
    //    {
    //        var cmdArgs = Console.ReadLine().Split();
    //        var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
    //        persons.Add(person);
    //    }

    //    persons.OrderBy(p => p.FirstName)
    //           .ThenBy(p => p.Age)
    //           .ToList()
    //           .ForEach(p => Console.WriteLine(p.ToString()));
    //}
}
