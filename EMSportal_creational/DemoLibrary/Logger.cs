using System;
using System.Xml.Linq;

namespace DemoLibrary
{
    public class Logger
    {
        private static Logger instance;
        private string logFilePath;

        private Logger()
        {
 
            logFilePath = "default.log";
        }

        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }

        public void SetLogFilePath(string path)
        {
            logFilePath = path;
        }

        public string LogFilePath
        {
            get { return logFilePath; }
        }

        public void Log()
        {
            Console.WriteLine("Information is being logged to " + LogFilePath);
        }
    }

}

