using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebWork.Pages
{
    public class DBConnection
    {
        public string DbString()
        {
            string dbString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DatabaseWeb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            return dbString;        
        }
    }
}
