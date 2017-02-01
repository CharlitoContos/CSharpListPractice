using System;
using System.Collections.Generic;
using System.Linq;


namespace listpractice
{
    public class App
    {
        public static void Main()
        {
            MainMenu.displayMenu();

            //create brain object
            ListManagerBrain brain = new ListManagerBrain();
            string userAction;

            do
            {
                userAction = Console.ReadLine();

                switch (userAction)
                {
                    case "1":
                        brain.AddItemToList();
                        //ListManagerBrain.AddItemToList();
                        //brain.ListItemChangeNotification();
                        //MainMenu.displayMenu();
                        break;
                    case "2":
                        brain.RemoveItemFromList();
                        //ListManagerBrain.RemoveItemFromList();
                        //brain.ListItemChangeNotification();
                        //MainMenu.displayMenu();
                        break;
                    case "3":
                        brain.ClearList();
                        //MainMenu.displayMenu();
                        break;
                    case "4":
                        brain.ViewList();
                        break;
                    case "5":
                        //close app and pass exit code of 0. If we were closing because of an error then pass -1                    
                        Environment.Exit(0);
                        break;
                    default:
                        MainMenu.displayMenu();
                        break;
                }
            }
            while (userAction != "5");
        }
    }

    //public static void Main_old() {

    //string userAction = Console.ReadLine();
    //MainMenu.displayMenu();

    //while (userAction != "5") 
    //{
    //  MainMenu.displayMenu();

    //  if (Console.ReadLine() == "1")
    //  { 
    //  ListManagerBrain.AddItemToList();
    //  ListManagerBrain.ListItemChangeNotification();
    //  MainMenu.displayMenu();
    //  }


    //else if (Console.ReadLine() == "2") 
    //{
    //   ListManagerBrain.RemoveItemFromList(); 
    //   ListManagerBrain.ListItemChangeNotification();
    //   MainMenu.displayMenu();
    //}

    //else if (Console.ReadLine() == "3") 
    //{
    //  ListManagerBrain.ClearList();
    //  MainMenu.displayMenu();  
    //}

    //else if (Console.ReadLine() == "4")
    //{
    // ListManagerBrain.ViewList();   
    //}

    //    }
    //}    
}
