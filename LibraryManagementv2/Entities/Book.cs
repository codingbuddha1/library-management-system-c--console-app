using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementv2.Entities
{
    internal class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int NoOfAvailableCopies { get; set; }
        public bool IsActive { get; set; }
        public Book(int bookId, string tittle, string author, int noOfAvailableCopies,bool isActive)
        {
           BookId = bookId;
            Title = tittle;
            Author = author;
            NoOfAvailableCopies = noOfAvailableCopies;
            IsActive = isActive;
           
        }

    }
}
