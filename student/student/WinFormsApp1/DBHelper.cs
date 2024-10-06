using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Student
{
    class DBHelper
    {
        public static string connString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

    }
}