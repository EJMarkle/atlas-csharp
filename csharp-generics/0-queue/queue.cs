using System;

/// <summary>
/// Queue class
/// </summary>
class Queue<T>
{
    /// <summary>
    /// Get type
    /// </summary>
    public string CheckType()
    {
        return typeof(T).FullName;
    }
}