using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementv2.Entities
{
    internal class BookIssue
    {
        public int IssueId { get; set; }
        public DateTime DateOfIsuue { get; set; }
        public DateTime ReturnDate { get; set; }
        public bool IsReturned { get; set; }
        public User UserId { get; set; }
        public Book BookId { get; set; }
        public BookIssue(DateTime dateOfIssue,DateTime returnDate,bool isReturned,User userId,Book bookId)
        {
            
            DateOfIsuue = dateOfIssue;
            ReturnDate = returnDate;
            IsReturned = isReturned;
            UserId = userId;
            BookId = bookId;

        }
    }
}
