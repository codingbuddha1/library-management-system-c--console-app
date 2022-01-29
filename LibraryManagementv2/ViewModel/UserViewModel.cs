using LibraryManagementv2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementv2.ViewModel
{
    internal class UserViewModel : AbstractMethod, IUser
    {
        public static List<User> users = new List<User>
        {
            new User(1,"john", "carter", true),
            new User(2,"james", "johnson", true)

    };

       
        public override void Add(object obj)
        {
            User user = (User)obj;
            new User(user.UserId,user.FirstName,user.LastName,user.IsActive); 
            
            users.Add(user);
            view();
            
           
        }
       
        public override void Edit(int index, object obj)
        {
            User user = (User)obj;
            for(int i = 0; i < users.Count(); i++)
            {
                if(users[i].UserId == index)
                {
                    users[i].FirstName = user.FirstName;
                    users[i].LastName = user.LastName;
                    users[i].IsActive = user.IsActive;
                }
            }
           
            
            Console.WriteLine("edited successfully");

        }
        public bool IsInIndex(int index)
        {
            bool temp= false;
            for (int i = 0; i <users.Count(); i++)
            {
                if(users[i].UserId == index)
                {
                    temp =  true;
                    break;
                }
                
            }
            return temp;
        }
        public override void Delete(int index)
        {
            for (int i = 0; i < users.Count(); i++)
            {
                if(users[i].UserId  == index)
                {
                    users.Remove(users[i]);
                }
            }
          
            Console.WriteLine("deleted successfully");
        }


        public void OnHandBooks(string str)
        {
            Console.WriteLine(str);
        }

        public void IssuedBooksHistory(string str)
        {
            Console.WriteLine(str);
        }
        public override void Search(string search)
        {
            string ans = "";
            for (int i = 0; i < users.Count(); i++)
            {
                if (users[i].FirstName.Contains(search) || users[i].LastName.Contains(search) || (users[i].FirstName + " " + users[i].LastName).Contains(search))
                {
                    ans = ans + "userID: " + users[i].UserId + " " + "FirstName:" + users[i].FirstName + " " + "LastName: " + users[i].LastName + " " + "ISActive: " + users[i].IsActive + "\n";
                }

            }
            Console.WriteLine(ans);
        }
        public override bool ReturnToMainMenu()
        {
            return false;
        }
        public User GetUserID(int Id)
        {
            User user = null;
            for (int i= 0; i<users.Count(); i++)
            {
                if(users[i].UserId == Id)
                {
                    user = users[i];
                    break;
                }
            }
            return user;
        }
        public void view()
        {
            Console.WriteLine($"User Id :{users[users.Count() - 1].UserId} User name : {users[users.Count() - 1].FullName} is added");
        }
        public bool NotNullList()
        {
            bool temp = true;
            if(users.Count()== 0)
            {
                temp = false;
            }
            return temp;
        }
        public void ListOfUser()
        {
            foreach (User user in users)
            {
                Console.WriteLine($"User Id :{user.UserId} User name : {user.FullName} \n");
            }
        }
        public void FirstUsers()
        {
            


        }
    }


}

