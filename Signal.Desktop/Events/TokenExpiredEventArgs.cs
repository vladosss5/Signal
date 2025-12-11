using System;

namespace Signal.Desktop.Events;

public class TokenExpiredEventArgs : EventArgs
{
    public bool RefreshAttempted { get; set; }
    public string? Reason { get; set; }
}