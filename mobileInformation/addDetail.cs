using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace mobileInformation
{
    class addDetail : mobile
    {
         List<addMobile> mobilein = new List<addMobile>();
        public void Menu_options()
        {


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
            
            mobilein.Add(new addMobile(name, cname, color, price, year, version));

            Console.WriteLine("");
            Console.WriteLine("Press any key to continue..");
            Console.ReadLine();


        }

        public void view_mobile()
        {


            Console.WriteLine("List all of the mobiles:");
            Console.WriteLine("");

            if (mobilein.Count > 0)
            {
                foreach (var mobile in mobilein)
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
    }// class

}// namespace
