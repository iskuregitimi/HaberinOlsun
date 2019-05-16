using System;
using System.Activities.Statements;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace HaberinOlsun.PublicUI1
{
    public static class LogManager
    {

        public static void Information(string msg)
        {
            Write($"Information +{msg}");
        }
        public static void EROR(string msg)
        {
            Write($"EROR +{msg}");
        }

            public static void FATAL(string msg)
        {
            Write($"FATAL +{msg}");
        }    public static void WARNİNG(string msg)
        {
            Write($"WARNİNG +{msg}");
        }
        public static void Write(string msg)
        {
            Debug.WriteLine($"Information +{msg}");
        }
    }
}