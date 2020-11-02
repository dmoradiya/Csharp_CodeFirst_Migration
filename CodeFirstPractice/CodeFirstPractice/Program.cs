using CodeFirstPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeFirstPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            string input;
            Console.WriteLine("please enter shelf material name:");
            input = Console.ReadLine().Trim();

            using (ShelfContext context = new ShelfContext())
            {
                try
                {
                    Shelf_Material shelf_Material = context.Shelf_Materials.Where(x => x.MaterialName.ToLower() == input.ToLower()).Single();
                    Console.WriteLine("The material exists in the 'Shelf_Material' table");
                }
                catch (Exception)
                {
                    Console.WriteLine("Name does not exist in the 'Shelf_Material' table");

                }
              
            }

        }
       
    }
}
