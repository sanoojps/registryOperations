﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

using Microsoft.Win32; 

namespace registryOperations
{
    class Program
    {
        static void Main(string[] args)
        {


            registryOPs rOPs = new registryOPs();
            string regKeyValueReturned = string.Empty;
            uint status;
            regKeyValueReturned = rOPs.keyRead(
@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Uninstall\Dropbox",
"andro",
out status
);

            Console.WriteLine(regKeyValueReturned + "\n" + status);

//             //Console.WriteLine(Registry.GetValue(
//             //   @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Uninstall\New Key #1",
//             //   "",
//             //   "blah").ToString());

            //Microsoft.Win32.RegistryKey key;
            //key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Names");

            //Console.WriteLine(key.GetValue(null));
            ////key.GetValue("Name");

            //key.Close();

            
            Console.ReadLine();
        }
    }
}
