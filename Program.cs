using Microsoft.Win32;

namespace SP_HW_23_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string keyPath = @"Software\MyApp";
            DateTime lastAcessTime = LoadLastTimeVisit(keyPath);
            if(lastAcessTime == DateTime.MinValue)
            {
                Console.WriteLine("Welcome to ConsoleApp");
            }
            else
            {
                Console.WriteLine("Last access time: " + lastAcessTime);
            }
            SaveLastTimeVisit(keyPath, DateTime.Now);
        }
        static DateTime LoadLastTimeVisit(string keyPath)
        {
            using(RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPath))
            {
                if(key != null)
                {
                    object value = key.GetValue("LastAccessTime");
                    if(value != null) 
                    {
                        return Convert.ToDateTime(value);
                    }

                }
            }
            return DateTime.MinValue;
        }

        static void SaveLastTimeVisit(string keyPath,  DateTime lastAccessTime)
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(keyPath))
            {
                key.SetValue("LastAccessTime", lastAccessTime.ToString());
            }
        }
    }
}
