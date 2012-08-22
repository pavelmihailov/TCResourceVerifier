using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TCResourceVerifier;
using TCResourceVerifier.Entities;
using TCResourceVerifier.Interfaces;

namespace TCResourceVerifierConsole
{
  class Program
  {
    private static string path;
    private static WidgetVerifier widgetVerifier = new WidgetVerifier();

    static void Main(string[] args)
    {
      if (args.Length == 0)
      {
        Console.WriteLine("You must specify path");
        Console.ReadKey();
        return;
      }

      path = args[0].ToString();

      var problems = widgetVerifier.VerifyWidgets(path);

      Console.WriteLine(GetAllProblems(problems));
    }

    private static string GetAllProblems(Dictionary<IWidgetFile, Dictionary<string, MissingResourceInfo>> problems)
    {
      var sb = new StringBuilder();
      if (problems.Count == 0)
        return "No Problems founded in " + path;

      foreach (var problem in problems)
        sb.AppendLine(GetWidgetFileProblems(problem.Key, problem.Value));
      return sb.ToString();
    }

    private static string GetWidgetFileProblems(IWidgetFile wfile, Dictionary<string, MissingResourceInfo> problems)
    {
      var sb = new StringBuilder();
      sb.AppendLine("---------------------------------------");
      sb.AppendLine(string.Format("Problems for {0}:", wfile.FileName));

      foreach (var problem in problems)
      {
        var val = problem.Value;
        sb.AppendLine(string.Format("key={0}, FileName={1}, LanguageName={2}, ResourceName={3}",
          problem.Key, val.FileName, val.LanguageName, val.ResourceName));
      }
      return sb.ToString();
    }
  }
}
