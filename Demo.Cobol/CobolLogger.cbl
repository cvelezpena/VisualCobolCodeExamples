      $SET ILUSING"Demo.Net.Interfaces"

       class-id Demo.Cobol.CobolLogger implements type INetLogger.

       working-storage section.
       01 error-counter binary-long.

       01 UserId string property.

       method-id New.
           move 0 to error-counter.
           goback.
       end method.

       method-id GetGuid() returning guid as string.
           set guid to type Guid::NewGuid()::ToString().
           goback.
       end method.

       method-id Warning(msg as string).
       working-storage section.
           01 uid string.
       procedure division.
           set uid to UserId.
           invoke type Console::WriteLine("WARN  {0}({1}): {2}" error-counter uid msg).
           goback.
       end method.
       
       method-id Error.
       linkage section.
       01 msg string.
       procedure division using by value msg.
           add 1 to error-counter.
           invoke type Console::WriteLine("ERROR {0}({1}): {2}" error-counter UserId msg).
           goback.
       end method.

       end class.
