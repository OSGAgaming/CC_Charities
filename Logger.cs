using System;
using System.Collections.Generic;

namespace Charity
{
  public static class Logger
  {
     public static void Warn(string Error)
     {
       Console.WriteLine($"\n-{Error}!-\n");
     }

     public static void Header(string msg)
     {
       Console.WriteLine($"\n========== {msg} ==========\n");
     }

     public static void Title(string msg)
     {
       Console.WriteLine($"[{msg}]");
     }
     public static void Fatal(string Error)
     {
       throw new InvalidOperationException(Error);
     }
  }
}