using System;

namespace mobileInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Created object of class mobile
            mobile mb = new mobile();
            addMobile amb = new addMobile();
            viewMobile vmb = new viewMobile();
            // Declared two methods to print decription and menu
            while (true)
            {

                mb.info();
                mb.menu_list();

                Console.Write("Choice: ");
                int.TryParse(Console.ReadLine(), out var choice);


                if (choice == 1)
                {
                    mb.info();
                    mb.menu_list();
                    amb.Menu_options();
                 
                }
                else if(choice == 2)
                {
                    mb.info();
                    mb.menu_list();
                    vmb.view_mobile();
                }
            
            }
        }
    }
}