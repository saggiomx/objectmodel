using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectModel;

namespace Movies
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of a movie with properties
            var movie = new Movie 
            {
                MovieName="Star Wars"
            };
            
            // instance a new Object Model Context
            var db = new ObjectModelContext();
            // insert movie aqnd actors
            db.Movies.Add(movie);
            
            //save changes
            db.SaveChanges();

            // Display all Movies from the database 
            var query = from b in db.Movies
                        orderby b.MovieName
                        select b;

            Console.WriteLine("All Movies in the database:");
            foreach (var item in query)
            {
                Console.WriteLine(item.MovieName);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(); 
        }
    }
}
