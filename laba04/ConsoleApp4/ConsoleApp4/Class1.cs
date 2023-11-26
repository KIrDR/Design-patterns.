using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public interface ILogger
    {
        void start(string title);
        void log(string message);
        void stop();
    }
    public partial class Logger : ILogger
    {
        private Logger () { }


        static int LogNum = 0;
        static string LogConnection = "";
        public string LogFileName = string.Format(DateTime.Now.ToString("yyyy-MM-dd/HH:mm:ss"));
        public static ILogger create()
        {
            LogNum++;
            string LogFileName
            = string.Format($"{LogNum} - " + @"{0}", DateTime.Now.ToString("yyyy-MM-dd/HH:mm:ss"));
            Console.WriteLine($"{LogFileName}" + "-INIT");
            return new Logger();
        }

        public void CWStart()
        {
            Console.WriteLine($"{LogNum} - {LogFileName}-STRT {LogConnection} ");
        }
        public void CWStop()
        {
            Console.WriteLine($"{LogNum} - {LogFileName}-STOP {LogConnection} ");
        }
        public void log(string message)
        {
            LogNum++;
            Console.WriteLine($"{LogNum} - {LogFileName}-INFO {LogConnection} {message}");
        }

        public void start(string title)
        {

            LogNum++;
            LogConnection = $"{LogConnection}:{title}";
            CWStart();
        }
        public string deleteConnection(string input)
        {
            int index = input.LastIndexOf(':');
            if (index != -1) { 
            string output = input.Substring(0, index );
            return output;
            }
            else
            {
                return input;   
            }
        }
        public void stop()
        {
            LogNum++;
            LogConnection = deleteConnection(LogConnection);
            CWStop();
        }
    }
}
