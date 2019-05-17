using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace HaberinOlsun.WEBUI
{
    public static class LogManager
    {
        public static void Information (string msg)
        {
            Write($"INFORMATION: {msg}");
        }

        public static void Error(string msg)
        {
            Write($"INFORMATION: {msg}");
        }

        public static void FATAL(string msg)
        {
            Write($"INFORMATION: {msg}");
        }

        public static void WARNING(string msg)
        {
            Write($"INFORMATION: {msg}");
        }

        public static void Write(string msg)
        {
            Debug.WriteLine($" {msg}");
        }
    }
}