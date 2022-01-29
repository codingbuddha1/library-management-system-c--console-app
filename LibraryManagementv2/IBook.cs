using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementv2
{
        interface IBook
        {
        void IssuedBooks(string str);
        void ReturnBookHistory(string str);
        }
    
}
