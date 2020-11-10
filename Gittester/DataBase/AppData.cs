using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gittester.DataBase
{
    class AppData
    {
        public static DataBaseEntities Context
        {
            get; set;
        } = new DataBaseEntities();
    }
}
