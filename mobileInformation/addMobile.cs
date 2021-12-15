using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobileInformation
{
    class addMobile
    {
       
            // constructor
            public addMobile(string name, string cname, string color, double price, DateTime year, string version)
            {
                Name = name;
                Cname = cname;
                Color = color;
                Price = price;
                Year = year;
                Version = version;
            } 

        // getter setter methods
            public string Name { get; set; }
            public string Cname { get; set; }
            public string Color { get; set; }
            public double Price { get; set; }
            public DateTime Year { get; set; }
            public string Version { get; set; }

       

    } // class
} // namespace