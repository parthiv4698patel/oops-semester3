using System;

namespace mobileInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Created object of class mobile
            mobile mb = new mobile();
            addDetail adm = new addDetail();
                                                                                                                                
            //viewMobile vmb = new viewMobile();
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
                    adm.Menu_options();


                }
                else if(choice == 2)
                {
                    mb.info();
                    mb.menu_list();
                    adm.view_mobile();
                }
                else if (choice == 3)
                {
                    exit_list el = new exit_list();
                    el.exitList();
                    break;
                    
                }
            
            }
        }
    }
}