

using Border_Control.Models;
using System;
using System.Linq;

BorderControl borderControl = new();

string input;

while ((input = Console.ReadLine()) != "End")
{
    string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    if (tokens.Length == 2)
    {
        Robot robot = new(tokens[1], tokens[0]);
        borderControl.AddEntityBorderCheck(robot);
    }
    else
    {
        Citizen citizen = new(tokens[2], int.Parse(tokens[1]), tokens[0]);
        borderControl.AddEntityBorderCheck(citizen);
    }
}

string fakeIdEndSeq = Console.ReadLine();
var detained = borderControl.EntityToBeChecked.Where(e => e.Id.EndsWith(fakeIdEndSeq));

foreach (var baseEntity in detained)
{
    Console.WriteLine(baseEntity.Id);
}