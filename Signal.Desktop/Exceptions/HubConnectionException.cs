using System;

namespace Signal.Desktop.Exceptions;

public class HubConnectionException : Exception
{
    public HubConnectionException(string message) : base(message) { }
    public HubConnectionException(string message, Exception innerException) 
        : base(message, innerException) { }
}