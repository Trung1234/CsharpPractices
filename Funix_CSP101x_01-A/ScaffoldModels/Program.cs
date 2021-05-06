using System;
using System.Linq;
using ScaffoldModels.Models;

namespace ScaffoldModels
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new sakilaContext();
            var actors = dbContext.Actor.ToList();
            foreach (var a in actors) {
                System.Console.WriteLine($"ID:{a.ActorId} Name:{a.FirstName} {a.LastName}");
            }
        }
    }
}
