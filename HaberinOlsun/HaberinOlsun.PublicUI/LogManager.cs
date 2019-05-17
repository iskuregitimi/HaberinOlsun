using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace HaberinOlsun.PublicUI
{
    public static class LogManager
    {
        public static void Write(string msg)
        {
            Debug.WriteLine($"{msg}");
        }
        public static void Information(string msg)
        {
            Write($"INFORMATION: {msg}");
        }

        public static void Error(string msg)
        {
            Write($"ERROR: {msg}");
        }
        public static void Fatal(string msg)
        {
            Write($"FATAL: {msg}");
        }
        public static void Warning(string msg)
        {
            Write($"WARNING: {msg}");
        }

    }
}