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
            
            while (true)
            {
                // call info and menu_list methods from class mobile
                mb.info();
                mb.menu_list();

                // for input
                Console.Write("Please enter your choice: ");
                int.TryParse(Console.ReadLine(), out var choice);

                // if .... else if.... for choice selection options
                if (choice == 1)
                {
                    mb.info();
                    mb.menu_list();
                    // call Menu_options from addDetail class
                    adm.Menu_options();

                    //adm.txtlist();
                 }
                else if(choice == 2)
                {
                    mb.info();
                    mb.menu_list();
                    // call view_mobile from addDetail class
                    adm.view_mobile();
                    
                }
                else if (choice == 3)
                {

                    exit_list el = new exit_list();
                    // call exitList from exit_list class
                    el.exitList();
                    break;
                }
                //I tried this is for option 4 to view all mobile list but it will work in my pc because I set path in my pc.
                /*
                else if (choice == 4)
                {

                    mb.info();
                    mb.menu_list();
                    adm.txtviewlist();
                    adm.view_mobile();
                }
                */
                else
                {
                    // call invalidOption from mobile class
                    mb.invalidOption();
                    // call anykey from addMobile class
                    adm.anykey();
                }
               
            
            } // while
        } // method
    } // class
} // namespace