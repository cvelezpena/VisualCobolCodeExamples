      $SET ILUSING"Demo.Net"
      $SET ILUSING"Demo.Cobol.Interfaces"

       program-id. Program1 as "CobolProgram.Program1".

       data division.
       working-storage section.
       01 logger type ICobolLogger.
       01 guid string.
       01 msg string.

       procedure division.
           set logger to new NetLogger.
           set logger::UserId to "testuser".

           invoke logger::Warning("Warning from COBOL").

           set guid to logger::GetGuid().
           set msg to string::Format("Test error {0}" guid).
           invoke logger::Error(msg).

           set logger::UserId to "anotheruser".

           invoke logger::Warning("Another warning").
           invoke logger::Error("And another error").

           invoke type Console::ReadKey().

           goback.
           
       end program Program1.

