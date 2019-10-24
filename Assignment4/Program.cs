using System;
using System.Linq;
using Assignment4;
using DatabaseService;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //using var db = new NorthwindContex();

            //var nextId = db.Categories.Max(x => x.Id) + 1;

            // Create 
            //var cat = new Category
            //{
            //    Id = nextId,
            //    Name = "Testing",
            //    Description = "blah blah ..."
            //};

            //db.Categories.Add(cat);

            // update
            //var cat = db.Categories.Find(9);

            //cat.Name = "Updating name";

            //var cat = db.Categories.Find(9);
            //db.Categories.Remove(cat);

            //db.SaveChanges();

            var ds = new DataService();


            foreach (var category in ds.GetCategories())
            {
                Console.WriteLine($"{category.Id} {category.Name}");
            }
        }
    }
}