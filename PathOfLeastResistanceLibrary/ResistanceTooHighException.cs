using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace PathOfLeastResistanceLibrary
{
    public class ResistanceTooHighException : Exception
    {
        public ResistanceTooHighException()
            : base("ResistanceTooHighException")
        {

        }

        public ResistanceTooHighException(string message)
            : base("ResistanceTooHighException: " + message)
        {

        }

        public ResistanceTooHighException(string message, Exception innnerException)
            : base("ResistanceTooHighException: " + message, innnerException) 
        {

        }

        protected ResistanceTooHighException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            
        }
         

    }
}
