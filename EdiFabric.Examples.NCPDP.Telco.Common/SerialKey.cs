using System;
using System.IO;

namespace EdiFabric.Examples.NCPDP.Telco.Common
{
    public class SerialKey
    {
        private static string _serialKey = null;
        static SerialKey()
        {
            var serialKeyPath = @"../../../../edifabric-trial/serial.key";

            var fullPath = Path.GetFullPath(serialKeyPath);
            Console.WriteLine("GetFullPath('{0}') returns '{1}'",
                serialKeyPath, fullPath);

            if (!File.Exists(serialKeyPath))
                throw new Exception("Set the path to the serial.key file in project EdiFabric.Examples.NCPDP.Telco.Common, file SerialKey.cs! " + fullPath);

            _serialKey = File.ReadAllText(serialKeyPath).Trim(new[] { ' ', '\r', '\n' });
        }

        public static string Get()
        {
            return _serialKey;
        }
    }
}
