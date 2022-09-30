using System;
using System.Linq;
using System.Transactions;

List<string> GamesList = new List<string>()
{
    "Super Mario Kart",
    "Mario Kart 64",
    "Mario Kart: Super Circuit",
    "Mario Kart: Double Dash",
    "Mario Kart Arcade",
    "Mario Kart DS",
    "Mario Kart Wii",
    "Mario Kart 7",
    "Mario Kart 8"
};

GamesList.OrderBy(x => x.Length)
         .ThenBy(x => x)
         .ToList()
         .ForEach(x => Console.WriteLine(x));