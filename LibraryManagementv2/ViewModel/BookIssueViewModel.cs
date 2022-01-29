using LibraryManagementv2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementv2.ViewModel
{
    
        public class BookIssueViewModel 
        {
        
        static List<BookIssue> bookIssues = new List<BookIssue>();

        public void Add(DateTime dateOfIsuue, DateTime returnDate, bool isReturned, object obj1,object obj2)
        {

            User user = (User)obj1;
            
            
            Book book = (Book)obj2;
            
             
            BookIssue bookIssue = new BookIssue(dateOfIsuue, returnDate,isReturned,user,book);
            bookIssue.IssueId = bookIssues.Count() + 1;
            bookIssues.Add(bookIssue);
            Console.WriteLine("Issued successfully");





        }
        public bool IsInIndex(int index)
        {
            bool temp = false;
            for (int i = 0; i < bookIssues.Count(); i++)
            {
                
                if(bookIssues[i].IssueId == index)
                {
                    temp = true;
                    break;
                }
                
            }
            return temp;
        }
        public void Returned(int index1,int index2)
        {
            for (int i = 0; i < bookIssues.Count(); i++)
            {
                if(bookIssues[i].BookId.BookId == index1 && bookIssues[i].UserId.UserId==index2 )
                {
                    bookIssues[i].IsReturned = true;
                    DateTime cdate = DateTime.Now;
                   
                    ReturnDate(cdate, bookIssues[i].ReturnDate);
                    
                }
                
            }
        }
        public void ReturnDate(DateTime currentDate,DateTime returnDate)
        {
            if(currentDate > returnDate)
            {
                Console.WriteLine("you have to pay 10 rupees for late return");

            }
            else
            {
                Console.WriteLine("you returned book on time");
            }
        }
        public string IssuedOnHandBooks(int res)
        {
            string str = "";
            for (int i = 0; i < bookIssues.Count(); i++)
            {
                if(bookIssues[i].UserId.UserId == res && !bookIssues[i].IsReturned)
                {
                    str = str +$"User : {bookIssues[i].UserId.FullName} has book called: {bookIssues[i].BookId.Title} by {bookIssues[i].BookId.Author}  \n";
                }
            }
            return str;
        }
        public string IssuedBook(int index)
        {
            string str = "";
            foreach (BookIssue bookIssue in bookIssues)
            { 
                if(bookIssue.UserId.UserId == index)
                {
                    str = str + $"Issued id :{bookIssue.IssueId} User : {bookIssue.UserId.FullName} Book Name : {bookIssue.BookId.Title} by {bookIssue.BookId.Author} IsReturn:{bookIssue.IsReturned} \n";
                }
               
            }
            return str;
        }
        public void View()
        {
            foreach (BookIssue bookIssue in bookIssues)
            {
                Console.Write($"user name : {bookIssue.UserId.FullName} book name : {bookIssue.BookId.Title} ");
            }
        }
        public void BookIssueView()
        {
            string str = "";
            foreach(BookIssue bookIssue in bookIssues)
            {
                str = str + $"issued id: {bookIssue.IssueId} user name : {bookIssue.UserId.FullName} book title : {bookIssue.BookId.Title} by {bookIssue.BookId.Author} \n";
            }

        }
        public string CurrentIssuedBook(int res)
        {
            string str = "";
            for (int i = 0; i < bookIssues.Count(); i++)
            {
                if (bookIssues[i].BookId.BookId == res && !bookIssues[i].IsReturned)
                {
                    str = str + $"Book Name : {bookIssues[i].BookId.Title} Author:{bookIssues[i].BookId.Author} is Issued to: {bookIssues[i].UserId.FullName}   \n";
                }
            }
            return str;
        }
        public string ReturnedBookHistory(int index)
        {
            string str = "";

            foreach(BookIssue bookIssue in bookIssues)
            {
                if (bookIssue.IsReturned && bookIssue.BookId.BookId == index)
                {
                    str = str + $"Book Name :{bookIssue.BookId.Title} Author:{bookIssue.BookId.Author} returned by {bookIssue.UserId.FullName}   \n";
                }
            }
            return str;
        }
        public void IssuedList()
        {
            string str = "";
            foreach (BookIssue bookIssue in bookIssues)
            {
                
                    str = str + $"issued book id: {bookIssue.IssueId} name of user : {bookIssue.UserId.FullName} book name : {bookIssue.BookId.Title} written by {bookIssue.BookId.Author} IsReturned:{bookIssue.IsReturned}\n";
               
            }
            Console.WriteLine(str);
        }

        public void IssuedBookList()
        {
            Console.WriteLine($"Issued book id: {bookIssues[bookIssues.Count() - 1].IssueId} User Name : {bookIssues[bookIssues.Count() - 1].UserId.FullName} Book Name : {bookIssues[bookIssues.Count() - 1].BookId.Title} Written by {bookIssues[bookIssues.Count() - 1].BookId.Author} is issued");
        }
        public bool IsIssuedBookNull()
        {
            bool temp = true;
            if(bookIssues.Count != 0)
            {
                temp = false;
            }
            return temp;

        }
        public bool IsUserId(int index)
        {
            bool temp = false;
            for (int i = 0; i < bookIssues.Count(); i++)
            {
                if (bookIssues[i].UserId.UserId == index)
                {
                    temp = true;
                    break;
                }
                
            }
            return temp;
        }
        public bool IsBookId(int index)
        {
            bool temp = false;
            for (int i = 0; i < bookIssues.Count(); i++)
            {
                if (bookIssues[i].BookId.BookId == index)
                {
                    temp = true;
                    break;
                }
                
            }
            return temp;
        }
        public bool IsReturned(int index1,int index2)
        {
            bool temp = false;
            for(int i = 0;i < bookIssues.Count(); i++)
            {
                if(bookIssues[i].UserId.UserId==index2&& bookIssues[i].BookId.BookId == index1&& bookIssues[i].IsReturned == true)
                {
                   
                        temp =true;
                        break;
                    
                }
                
            }
            return temp;
        }
        public bool isDeletableBook(int index)
        {
            bool temp = false;
            for (int i = 0; i <bookIssues.Count(); i++)
            {
                if (bookIssues[i].BookId.BookId == index )
                {
                    if (!bookIssues[i].IsReturned)
                    {
                        temp =false;
                        break;
                    }
                    else
                    {
                        temp=true;
                    }
                    
                }
                
            }
            return temp;
        }
        
        public bool BookinBookIssue(int index)
        {
            bool temp = false;
            for (int i = 0; i < bookIssues.Count(); i++)
            {
                if (bookIssues[i].BookId.BookId == index)
                {
                    temp = true;
                    break;
                }
            }
            return temp;
        }

        public bool isDeletableUser(int index)
        {
            bool temp = false;
            for (int i = 0; i < bookIssues.Count(); i++)
            {
                if (bookIssues[i].UserId.UserId == index )
                {
                    if (!bookIssues[i].IsReturned)
                    {
                        temp = false;
                        break;
                    }
                    else
                    {
                        temp = true;
                    }
                    
                }
            }
            return temp;
        }

        public bool UserinBookIssue(int index)
        {
            bool temp = false;
            for (int i = 0; i < bookIssues.Count(); i++)
            {
                if (bookIssues[i].UserId.UserId == index)
                {
                    temp = true;
                    break;
                }
            }
            return temp;
        }
        public bool UserBookCheck(int index1,int index2)
        {
            bool temp = false;
            for (int i = 0; i < bookIssues.Count(); i++)
            {
                if(bookIssues[i].UserId.UserId == index1 && bookIssues[i].BookId.BookId == index2)
                {
                    temp= true;
                    break;
                }
            }
            return temp;
        }
    }



    
}
