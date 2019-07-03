using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace TestRegistryConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\OurSettings");
            key.SetValue("Setting1", "This is our setting 1");
            key.SetValue("Setting2", "This is our setting 2");
            key.Close();
            RegistryKey key1 = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\OurSettings");

            //if it does exist, retrieve the stored values  
            if (key1 != null)
            {
                Console.WriteLine(key1.GetValue("Setting1"));
                Console.WriteLine(key1.GetValue("Setting2"));
                key1.Close();
            }

            Console.ReadKey();
        }
    }
}
