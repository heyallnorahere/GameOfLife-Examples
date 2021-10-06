using System;
using System.IO;

namespace GameOfLife.Examples.Launcher
{
    public class Program
    {
        private const string ExamplesDir = "Examples";
        public static void Main(string[] args)
        {
            if (!Directory.Exists(ExamplesDir))
            {
                throw new DirectoryNotFoundException($"A \"{ExamplesDir}\" directory must exist in the working directory!");
            }
            if (args.Length < 1)
            {
                throw new ArgumentException("Cannot find an example from an empty string!");
            }
            var newArgs = new string[args.Length + 1];
            newArgs[0] = "-c";
            string examplePath = Path.Join(ExamplesDir, $"{args[0]}.json");
            if (!File.Exists(examplePath))
            {
                throw new ArgumentException("The given example does not exist!");
            }
            newArgs[1] = examplePath;
            for (int i = 1; i < args.Length; i++)
            {
                newArgs[i + 1] = args[i];
            }
            GameOfLife.Program.Program.Main(newArgs);
        }
    }
}
