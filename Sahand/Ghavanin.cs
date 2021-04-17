using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; 

namespace Sahand
{
    interface Ghavanin
    {
        
        DataTable Selectall();
        DataTable Select_on();

        //bool Insert(string name, int number,byte[] im);

        bool update(string name, int number);

        bool Delete(int Id); 
        


    }
}
