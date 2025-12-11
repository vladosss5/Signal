using System;

namespace Signal.Desktop.Exceptions;

public class HubOperationException : Exception
{
    public HubOperationException(string message) : base(message) { }
    public HubOperationException(string message, Exception innerException) 
        : base(message, innerException) { }
}