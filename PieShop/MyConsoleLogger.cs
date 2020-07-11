using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop
{
    public class MyConsoleLogger : ILog
    {
        public void Info(string str)
        {
            Console.WriteLine(str);
        }
    }
}
