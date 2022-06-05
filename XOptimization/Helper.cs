using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace XOptimization
{
    public class Helper
    {
        public static String GetCurrentDirectory()
        {
            // This will get the current WORKING directory (i.e. \bin\Debug)
            string workingDirectory = Environment.CurrentDirectory;
            // or: Directory.GetCurrentDirectory() gives the same result
            // This will get the current PROJECT bin directory (ie ../bin/)
            //string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;

            return workingDirectory;
        }
        public static List<string> GetDirectories(string path, string searchPattern = "*", SearchOption searchOption = SearchOption.AllDirectories)
        {
            if (searchOption == SearchOption.TopDirectoryOnly)
                return Directory.GetDirectories(path, searchPattern).ToList();

            var directories = new List<string>(GetDirectories(path, searchPattern));

            for (var i = 0; i < directories.Count; i++)
                directories.AddRange(GetDirectories(directories[i], searchPattern));

            return directories;
        }

        private static List<string> GetDirectories(string path, string searchPattern)
        {
            try
            {
                return Directory.GetDirectories(path, searchPattern).ToList();
            }
            catch (UnauthorizedAccessException)
            {
                return new List<string>();
            }
        }
        public static List<string> GetSubDirectories(string path, string searchPattern = "*")
        {
            try
            {
                return Directory.GetDirectories(path, searchPattern).ToList();
            }
            catch (UnauthorizedAccessException)
            {
                return new List<string>();
            }
        }
        public static void WriteText(string path, string str)
        {
            FileInfo fileInfo = new FileInfo(path);
            fileInfo.Delete();
            StreamWriter streamWriter = new StreamWriter(path, true);
            streamWriter.WriteLine(str);
            streamWriter.Close();
        }

        public static int GetRandomNumberInRange(double minNumber, double maxNumber)
        {
            double number = new Random().NextDouble() * (maxNumber - minNumber) + minNumber;

            return Convert.ToInt32(number);
        }

        public static List<string> GetLinksFromText(string message)
        {
            List<string> list = new List<string>();
            Regex urlRx = new
            Regex(@"(http|ftp|https)://([\w+?\.\w+])+([a-zA-Z0-9\~\!\@\#\$\%\^\&\*\(\)_\-\=\+\\\/\?\.\:\;\'\,]*)?",
            RegexOptions.IgnoreCase);

            MatchCollection matches = urlRx.Matches(message);
            foreach (Match match in matches)
            {
                list.Add(match.Value);
            }
            return list;
        }


        public static string CreateRandomText(int length)
        {

            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append("abcdefghijklmnopqrstuvwxyz1234567890"[rnd.Next("abcdefghijklmnopqrstuvwxyz1234567890".Length)]);
            }
            return res.ToString();
        }

        public static string CreatePassword(int length)
        {
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()"[rnd.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()".Length)]);
            }
            return res.ToString();
        }

        public static string[] ReadTxt(string path)
        {
            string[] st = null;

            if (File.Exists(path))
            {
                st = File.ReadAllLines(path);

            }

            return st;
        }
        public static string AddQuotesIfRequired(string path)
        {
            return !string.IsNullOrWhiteSpace(path) ?
                path.Contains(" ") && (!path.StartsWith("\"") && !path.EndsWith("\"")) ?
                    "\"" + path + "\"" : path :
                    string.Empty;
        }


        public static string GetIP()
        {
            string result;
            try
            {
                string input = RunCMD("nslookup myip.opendns.com. resolver1.opendns.com");
                MatchCollection matchCollection = Regex.Matches(input, "\\b(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\b");
                result = matchCollection[1].Value;
                goto IL_39;
            }
            catch (Exception ex)
            {
            }
            result = "";
        IL_39:
            return result;
        }




        public static string RunCMD(string cmd)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/c " + cmd;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            string text = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            string result;
            if (!string.IsNullOrEmpty(text))
            {
                result = text;
            }
            else
            {
                result = "";
            }
            return result;
        }


        public static string RunCMD(string cmd, string _directory)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.WorkingDirectory = _directory;
            process.StartInfo.Arguments = "/c " + cmd;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            string text = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            string result;
            if (!string.IsNullOrEmpty(text))
            {
                result = text;
            }
            else
            {
                result = "";
            }
            return result;
        }


        public static string RunCMDCurl(string finalCommand)
        {

            string text2 = "";

            using (var process = new Process
            {
                StartInfo = new ProcessStartInfo(@"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe",
                finalCommand)
                {
                    WorkingDirectory = Environment.CurrentDirectory,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
            })
            {
                process.Start();

                StreamReader standardOutput = process.StandardOutput;
                text2 = standardOutput.ReadToEnd();

                process.WaitForExit();

                return text2;
            }

        }


        //////////////////////// SPIN ////////////////////
        ///
        public static string Spin(ref string value)
        {
            return Regex.Replace(value, "{.*?}", new MatchEvaluator(SpinEvaluator));
        }

        public static string SpinEvaluator(Match match)
        {
            string text = match.ToString();
            string result;
            if (!text.Contains("{"))
            {
                result = text;
            }
            else
            {
                string[] array = text.Split(new char[]
                {
                '|'
                });
                string text2 = array[RandomNumber(array.Length, 0)].Replace("{", "").Replace("}", "");
                result = text2;
            }
            return result;
        }

        public static int RandomNumber(int MaxNumber, int MinNumber = 0)
        {
            Random random = new Random();
            if (MinNumber > MaxNumber)
            {
                int num = MinNumber;
                MinNumber = MaxNumber;
                MaxNumber = num;
            }
            return random.Next(MinNumber, MaxNumber);
        }
    }
}


