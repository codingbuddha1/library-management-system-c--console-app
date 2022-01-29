using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementv2
{
    
        interface IUser
        {
            void OnHandBooks( string str);
            void IssuedBooksHistory(string str);
        
        }
    
}
