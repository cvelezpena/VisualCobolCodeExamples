      $SET ILNAMESPACE"Demo.Cobol.Interfaces"

       interface-id ICobolLogger.
       
       property-id UserId string.
           getter.
           setter.
       end property.

       method-id GetGuid() returning guid as string.
       end method.

       method-id Warning(msg as string).
       end method.
       
       method-id Error.
       linkage section.
       01 msg string.
       procedure division using by value msg.
       end method.

       end interface.

