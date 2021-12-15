using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobileInformation
{
    class mobile : abstarctMobile


    {
        // add new method 1
        public override void info()
        {
            // for description
            Console.Clear();
            Console.WriteLine("Mobile Info database");
            Console.WriteLine("");
            Console.WriteLine("This is a C# application. It displays information about mobiles. When user choose option 1 then they can add some information about the mobile, like name of mobile, company name, color, price(in Rs.), launched date of mobile, version. When user choose option 2 then this application shows information about entered data about mobiles, if user would like to exit then they select option 3. As well as, if user cannot enter valid number while choosing option at that time It shows error, such as please choose valid option. finally, any data did not store in this application then it shows error, like you did not enter any mobile information yet.");
            Console.WriteLine("");
            Console.WriteLine("");
        } // method 1 close

        // add new method 2
        public override void menu_list()
        {

            Console.WriteLine("please choose one of the following");
            Console.WriteLine("");
            Console.WriteLine("1. Add a new mobile information");
            Console.WriteLine("2. Current List all of mobiles:");
            Console.WriteLine("3. Exit");
             //Console.WriteLine("4. List all of mobiles:");
            Console.WriteLine("");
        } // method 2 close

        // add new method 3
        public override void invalidOption()
        {

            Console.WriteLine("Please choose correct option.......");
            
        } // method 3 close

    }// class mobile closed
}// namespace closed
