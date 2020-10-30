using CodeFirstPractice.Models;
using System;

namespace CodeFirstPractice
{
    class Program
    {
        static void Main(string[] args)
        {
           ShelfContext context = new ShelfContext();

            string input;
            Console.WriteLine("Please Enter Shelf Name:");
            input = Console.ReadLine().Trim();

            context.Shelves.Add(new Shelf()
            {
                Name = input

            });

            context.SaveChanges();
        }
    }
}
