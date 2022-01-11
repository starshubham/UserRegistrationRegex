using System;

namespace UserRegistrationRegex
{
    public class CustomException : Exception
    {
        public ExceptionType type;

        public enum ExceptionType
        {
            NUll_Type_Exception,
            Empty_Type_Exception,
            Class_Not_Found,
            Argument_Null_Exception
        }
        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
