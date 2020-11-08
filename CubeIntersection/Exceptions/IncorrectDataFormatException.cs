using System;
using System.Collections.Generic;
using System.Text;

namespace CubeIntersection.Exceptions
{
    public class IncorrectDataFormatException : Exception
    {
        public IncorrectDataFormatException()
        {
        }

        public IncorrectDataFormatException(string message) : base(message)
        {
        }
    }
}
