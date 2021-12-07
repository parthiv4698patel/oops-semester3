﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobileInformation
{
    class addMobile
    {
        class Mobile
        {
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
        public void Menu_options()
        {
            var mobiles = new List<Mobile>();

          
            Console.WriteLine("Add a new mobile");
            Console.WriteLine("");

            Console.Write("Name: ");
            var name = Console.ReadLine();

            Console.Write("Company Name: ");
            var cname = Console.ReadLine();

            Console.Write("Color: ");
            var color = Console.ReadLine();

            Console.Write("Price: ");
            var price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Date of launched: ");
            var year = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Version: ");
            var version = Console.ReadLine();

            mobiles.Add(new Mobile(name, cname, color, price, year, version));
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue..");
            Console.ReadLine();
        }
    }
}