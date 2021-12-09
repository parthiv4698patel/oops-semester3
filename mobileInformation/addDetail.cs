using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace mobileInformation
{
    class addDetail
    {
        public List<mobileInformation.addMobile> mobiles = new List<mobileInformation.addMobile>();

        public List<mobileInformation.addMobile> getMyMobile()
        {
            return this.mobiles;
        }

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
            mobileInformation.addMobile addmb = new mobileInformation.addMobile(name, cname, color, price, year, version);
            mobiles.Add(addmb);

            Console.WriteLine("");
            Console.WriteLine("Press any key to continue..");
            Console.ReadLine();


        }
    
      

       


    }// class
}// namespace
