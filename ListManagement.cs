using System;
using System.Collections.Generic;
using System.Linq;


namespace listpractice
{
    public class ListManagerBrain
    {
        //constructor is called when the ListManagerBrain object is instantiated (created)
        public ListManagerBrain()
        {
            //create theList
            theList = new List<string>();
        }

        List<string> theList;

        public void AddItemToList()
        {
            Console.WriteLine("Enter List Item: ");
            theList.Add(Console.ReadLine());
            ListItemChangeNotification(1);
        }

        public void RemoveItemFromList(int input)
        {
            //this does not work correctly
            //Possibly have the user enter the list item index + 1
            //example: item 1, item 2, item 3
            theList.RemoveAt(input - 1);
            theList.Remove(Console.ReadLine());
            ListItemChangeNotification(4);
        }


        public void RemoveItemFromList()
        {
            //this does not work correctly. Look at the overload above as a possible solution            
            theList.Remove(Console.ReadLine());
            ListItemChangeNotification(4);
        }

        public void ClearList()
        {
            theList.Clear();
            ListItemChangeNotification(3);
        }

        public void ViewList()
        {
            if (theList.Count == 0)
            {
                Console.WriteLine("There are no items in the list");
                return;
            }

            foreach (var listItem in theList)
            {
                Console.WriteLine(listItem);
            }
        }

        public void ListItemChangeNotification(int input)
        {          
            string output = "";

            switch (input)
            {
                case 1:
                    output = "An item has been added to your list!";
                    break;
                case 3:
                    output = "Your list has been cleared!";
                    break;
                case 4:
                    output = "An item has been removed from your list!";
                    break;
            }

            Console.WriteLine(output);
        }


        public static void ListItemChangeNotification_OLD()
        {
            if (Console.ReadLine() == "1")
            {
                Console.WriteLine("An item has been added to your list!");
            }

            else if (Console.ReadLine() == "4")
            {
                Console.WriteLine("An item has been removed from your list!");
            }
            else if (Console.ReadLine() == "3")
            {
                Console.WriteLine("Your list has been cleared!");
            }

        }
    }
}

