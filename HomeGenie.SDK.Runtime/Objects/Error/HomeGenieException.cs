using System;

namespace HomeGenie.SDK.Objects.Error
{
    public class HomeGenieException : Exception
    {
        public string ExceptionSource { get; set; }

        public HomeGenieException(string message, string exceptionSource)
            :base(message)
        {
            ExceptionSource = exceptionSource;
        }
    }
}