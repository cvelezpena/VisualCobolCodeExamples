using System;
using Demo.Cobol;

namespace NetProgram
{
    internal static class Program
    {
        internal static void Main(string[] args)
        {
            var logger = new CobolLogger
            {
                UserId = "testuser"
            };

            logger.Warning("Warning from .NET");
            logger.Error(string.Format("Test error {0}", logger.GetGuid()));

            logger.UserId = "anotheruser";

            logger.Warning("Another warning");
            logger.Error("And another error");

            Console.ReadKey();
        }
    }
}

