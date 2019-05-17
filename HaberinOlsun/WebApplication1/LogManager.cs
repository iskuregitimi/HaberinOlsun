using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public static class LogManager
    {
        public static void Information(string msg)
        {
            Write($"Information:(msg)");
        }
        public static void Error(string msg)
        {
            Write($"Error:(msg)");
        }
        public static void FATAL(string msg)
        {
            Write($"FATAL:(msg)");
        }
        public static void WARNING(string msg)
        {
            Write($"WARNING:(msg)");
        }

        public static void Write(string msg)
        {
            Debug.WriteLine($"{msg}");

        }

    }
}