using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baglantıkurma2
{
    class Tools
    {
        public static string ConnectionString
        {
            get
            {
                return @"Data Source = WISSEN\MSSQLSRV; Initial Catalog = Northwind; User ID = sa; Password = 12345srv; Integrated Security = False";

            }
        }
    }
}
