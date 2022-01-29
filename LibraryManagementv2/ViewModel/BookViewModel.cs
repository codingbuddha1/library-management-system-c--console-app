using LibraryManagementv2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementv2.ViewModel
{
    internal class BookViewModel : AbstractMethod,IBook
    {

        public static List<Book> books = new List<Book>
        {
            new Book(1,"the silent patient","alex michaelides", 4, true),
            new Book(2,"gone girl", "gillian flynn", 4, true),
            new Book(3,"sherlock holmes", "sir arthur conan doyle", 4, true)

        };

      
        public override void Add(object obj)
        {

            Book book = (Book)obj;
            new Book(book.BookId,book.Title,book.Author,book.NoOfAvailableCopies,book.IsActive);
            books.Add(book);
            Console.WriteLine("added successfully");


        }
        public bool IsInIndex(int index)
        {
            bool temp = false;
            for (int i = 0; i < books.Count(); i++)
            {
                if (books[i].BookId == index)
                {
                    temp = true;
                    break;
                }
                
            }
            return temp;
        }
        public override void Edit(int index, object obj)
        {
            Book book = (Book)obj; 
           for(int i = 0;i < books.Count(); i++)
            {
                if(books[i].BookId == index)
                {
                    books[i].Title = book.Title;
                    books[i].Author = book.Author;
                    books[i].IsActive = book.IsActive;
                   
                }
                
            }
            Console.WriteLine("edited successfully");

        }
        public override void Delete(int index)
        {
            for (int i = 0; i < books.Count(); i++)
            {
                if(books[i].BookId == index)
                {
                    books.Remove(books[i]);
                }
            }
            Console.WriteLine("deleted successfully");
        }

        public void IssuedBooks(string str)
        {
            
                Console.WriteLine(str);
            
            
        }

        public void ReturnBookHistory(string str)
        {
            Console.WriteLine(str);
        }

       
        public override void Search(string search)
        {
            string ans = "";
            for (int i = 0; i < books.Count(); i++)
            {
                if (books[i].Title.Contains(search) || books[i].Author.Contains(search))
                {
                    ans = ans + "BookID: " + books[i].BookId + " " + "Title : " + books[i].Title + " " + "Author: " + books[i].Author + " " + "NoOfCopiesAvailable : " + books[i].NoOfAvailableCopies + " " + "ISActive: " + books[i].IsActive + "\n";
                }

            }

            Console.WriteLine(ans);
        }
        public override bool ReturnToMainMenu()
        {
            return false;
        }
        public Book GetBookID(int Id)
        {
            Book book = null;
            for (int i = 0; i < books.Count(); i++)
            {
                if (books[i].BookId== Id)
                {
                    book = books[i];
                    break;
                }
            }
            return book;
        }
        public void view()
        {
            foreach (Book book in books)
            {
               Console.WriteLine($"book id: {book.BookId} book name :{book.Title} book author :{book.Author} book available : {book.NoOfAvailableCopies} \n");

            }
        }
        public void BookView()
        {
            Console.WriteLine($"book id: {books[books.Count() - 1].BookId} book name :{books[books.Count()-1].Title} book author :{books[books.Count() - 1].Author} book available : {books[books.Count() - 1].NoOfAvailableCopies} ");
        }
       public bool CheckNoOfBook(int index)
        {
            bool temp = false;
            for(int i = 0;i < books.Count(); i++)
            {
                if(books[i].BookId== index)
                {
                    if (books[i].NoOfAvailableCopies < 1)
                    {
                        Console.WriteLine("there is not books left for issue");
                        temp = true;
                        break;
                    }
                    else
                    {
                        temp = false;
                    }
                }
            }
            

            return temp;
        }
        public void ChangeInNoOfBook(int index)
        {
            for (int i = 0; i < books.Count(); i++)
            {
                if (books[i].BookId == index)
                {
                    books[i].NoOfAvailableCopies--;
                }
            }
            
        }
        public void ReturnedChange(int index)
        {
            for (int i = 0; i < books.Count(); i++)
            {
                if(books[i].BookId == index)
                {
                    books[i].NoOfAvailableCopies++;
                }
            }
            
        }
        public bool NotNullList()
        {
            bool temp = true;
            if (books.Count() == 0)
            {
                temp = false;
            }
            return temp;
        }
        

    }


}

