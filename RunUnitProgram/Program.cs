using System;
using Demo.Cobol;
using MicroFocus.COBOL.RuntimeServices;

namespace RunUnitProgram
{
    internal static class Program
    {
        internal static void Main(string[] args)
        {
            // Create a new isolated COBOL runtime
            using (var runUnit = new RunUnit())
            {
                // Instantiate the COBOL class to use in the runtime
                var logger = new CobolLogger
                {
                    UserId = "testuser"
                };

                // Add it to the runtime
                runUnit.Add(logger);

                // All calls to methods in the COBOL class now executes in this runtime
                logger.Warning("Warning from .NET");
                logger.Error(string.Format("Test error {0}", logger.GetGuid()));

                logger.UserId = "anotheruser";

                logger.Warning("Another warning");
                logger.Error("And another error");

                Console.ReadKey();

                // Clean up runtime resources
                runUnit.StopRun();
            }
        }
    }
}