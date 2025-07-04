using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Management
{
    internal class DatabaseHelper
    {
        internal static string GetConnectionString()
        {
            // Replace with your actual database connection string
            return "Data Source=localhost;Initial Catalog=Restaurant_Menu;Integrated Security=True";
        }
    }
}
