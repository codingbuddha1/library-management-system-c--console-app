using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementv2.ViewModel
{
    internal class OtherMethods
    {
        public void MainMenuInterface()
        {
            Console.WriteLine("*********************************");
            Console.WriteLine("*       LIBRARY MANAGER         *");
            Console.WriteLine("*********************************");
            Console.WriteLine();
            Console.WriteLine("========================");
            Console.WriteLine("       MAIN MENU");
            Console.WriteLine("========================");
            Console.WriteLine("1. Users Management");
            Console.WriteLine("2. Books Management");
            Console.WriteLine("3. Search Users");
            Console.WriteLine("4. Search Books");
            Console.WriteLine("5. Issue / Return Books");
            Console.WriteLine("6. Exit");
        }
        public void UserInterface()
        {
            Console.WriteLine("========================");
            Console.WriteLine("       USER MENU");
            Console.WriteLine("========================");
            Console.WriteLine("1. Add User");
            Console.WriteLine("2. Edit User");
            Console.WriteLine("3. Delete User");
            Console.WriteLine("4. OnHand Books");
            Console.WriteLine("5. Issued Books History");
            Console.WriteLine("6. Return to Main Menu");
            
        }
        public void Bookinterface()
        {

            Console.WriteLine("========================");
            Console.WriteLine("       Book MENU");
            Console.WriteLine("========================");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Edit Book");
            Console.WriteLine("3. Delete Book");
            Console.WriteLine("4. Issued Books");
            Console.WriteLine("5. Returned Book History");
            Console.WriteLine("6. Return to Main Menu");
        }
        public int Input(string input)
        {
            
           int res=0;
            bool inputLoop = true;
            while (inputLoop)
            {
                Console.Write(input);
                try
                {
                    res = Convert.ToInt32(Console.ReadLine());
                   
                    inputLoop = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("please enter in valid format");
                }
                
            }

            return res;
            
        }
        public string StringInput(string input)
        {
            string res = "";
            bool inputLoop = true;
            while (inputLoop)
            {
                Console.Write(input);
                res = Console.ReadLine();
                if(!string.IsNullOrWhiteSpace(res))
                {
                    inputLoop = false;
                }
                else
                {
                    Console.WriteLine("input cannot be empty");
                }

            }
            return res;
        }
        
        public bool LeaveOrNot()
        {
            bool temp = false;
            string res = StringInput("Do you want to add another user y to add and any other key to leave : ");
            if(res == "y")
            {
                temp= true;
            }
            return temp;
        }
        public bool ActiveEdit(string input)
        {
            bool temp = true;
            string res = StringInput(input);
            if(res == "y")
            {
                temp = true;
            }
            else if(res == "n")
            {
                temp = false;
            }
            else
            {
                Console.WriteLine("responce is not valid it will be active by defult");
            }
            return temp;
        }
        public int NoNegativeInput(string input)
        {
            int res = 0;
            bool inputLoop = true;
            while (inputLoop)
            {
                Console.Write(input);
                try
                {
                    res = Convert.ToInt32(Console.ReadLine());
                    if(res > 0)
                    {
                        inputLoop = false;
                    }
                    else
                    {
                        Console.WriteLine("you cannot use negative values");
                    }
                    
                }
                catch (FormatException)
                {
                    Console.WriteLine("please enter in valid format");
                }

            }

            return res;
        }
       
    }
}
