using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobileInformation
{
    class viewMobile 
    {
        public class Mobile
        {
            // constructor
            public Mobile(string name, string cname, string color, double price, DateTime year, string version)
            {
                Name = name;
                Cname = cname;
                Color = color;
                Price = price;
                Year = year;
                Version = version;
            } // constructor close

            // getter setter
            public string Name { get; set; }
            public string Cname { get; set; }
            public string Color { get; set; }
            public double Price { get; set; }
            public DateTime Year { get; set; }
            public string Version { get; set; }


        }
        
        public void view_mobile()
        {
            var mobiles = new List<Mobile>();
            Console.WriteLine("List all of the mobiles:");
            Console.WriteLine("");

            if (mobiles.Count > 0)
            {
                foreach (var mobile in mobiles)
                {
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine($"Name: { mobile.Name}");
                    Console.WriteLine($"Company name: { mobile.Cname}");
                    Console.WriteLine($"Color: { mobile.Color}");
                    Console.WriteLine($"Price: { mobile.Price}");
                    Console.WriteLine($"Date of launched: { mobile.Year}");
                    Console.WriteLine($"Version: { mobile.Version}");
                } // foreach close
            } // if close
            else
            {
                Console.WriteLine("Sorry, you did not enter any mobile information yet.");
            }// else close
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue..");
            Console.ReadLine();
        }
    }
}