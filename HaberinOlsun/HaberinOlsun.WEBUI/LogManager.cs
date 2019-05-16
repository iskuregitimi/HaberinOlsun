using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace HaberinOlsun.WEBUI
{
	public static class LogManager
	{
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

		public static void warning(string msg)
		{
			Write($"WARNING: {msg}");
		}

		public static void Write(string msg)
		{
			Debug.WriteLine($"{msg}");
		}
	}
}