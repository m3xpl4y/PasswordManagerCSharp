using System;
using System.IO;

namespace PasswordManager
{
    class EnvironmentPath
    {
        private static string fileName = "data.txt";
        private static string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), fileName);
        
        public static string FilePath
        {
            get { return filePath; }
        }
        public static string FileName
        {
            set { fileName = value; }
        }
    }
}
