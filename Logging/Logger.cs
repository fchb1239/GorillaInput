using System;

namespace GorillaInput.Logging
{
    class Logger
    {
        public static void Log(string input)
        {
            Console.WriteLine($"GorillaInput: {input} - {DateTime.Now}");
        }
    }
}
