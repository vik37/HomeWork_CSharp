using System;
using System.Collections.Generic;
using System.Text;

namespace AdminUsers.Exceptions
{
    public class AdmminException : Exception
    {
        public AdmminException(string message,Exception ex) :base(message, ex)
        {
            
        }
    }
}
