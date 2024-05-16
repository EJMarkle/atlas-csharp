using System;

/// <summary>
/// Abstract base class
/// </summary>
abstract class Base
{
    /// <summary>
    /// Name property
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// ToString override
    /// </summary>
    public override string ToString()
    {
        return $"{name} is a {this.GetType().Name}";
    }
}
