using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace mobileInformation
{
    // derived class : base class
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

            anykey();


        }

        //I tried this is for option 4 to view all mobile list but it will work in my pc because I set path in my pc.
        /*
        public void txtlist()
        {

            String path = @"D:\Cambrian\Semester 3\IOT 1030\oops-semester3\mbinformation.txt";
            StreamWriter sw = File.AppendText(path);

            sw.WriteLine("This is a List of Mobile Information");
            if (mobilein.Count > 0)
            {
                foreach (var mobiles in mobilein)
                {
                    sw.WriteLine("\n");
                    sw.WriteLine("-----------------------------------------------------------------");
                    sw.WriteLine("Mobile Name: " + mobiles.Name);
                    sw.WriteLine("Company Name: " + mobiles.Cname);
                    sw.WriteLine("Color: " + mobiles.Color);
                    sw.WriteLine("Price: " + mobiles.Price);
                    sw.WriteLine("Date of launched: " + mobiles.Year);
                    sw.WriteLine("Version: " + mobiles.Version);
                    sw.WriteLine("-----------------------------------------------------------------");

                    sw.Close();
                }
            }

        }

        public void txtviewlist()
        {
            string text = System.IO.File.ReadAllText(@"D:\Cambrian\Semester 3\IOT 1030\oops-semester3\mbinformation.txt");
            System.Console.WriteLine(text);
        }
        
        */
        public void anykey()
        {
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
