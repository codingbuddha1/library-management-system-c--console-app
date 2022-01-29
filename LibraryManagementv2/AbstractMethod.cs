using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementv2
{
    //AbstractMethod
    public abstract class AbstractMethod
    {

        public abstract void Add(object obj);

        public abstract void Edit(int index, object obj);

        public abstract void Delete(int index);

        public abstract bool ReturnToMainMenu();

        public abstract void Search(string search);
    }

}
