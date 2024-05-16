using System;
using System.Reflection;

/// <summary>
/// Abstract base class representing a base object
/// </summary>
abstract class Base
{
    /// <summary> Name property of the object </summary>
    public string name { get; set; }

    /// <summary> Overrides the ToString method to provide a custom string representation of the object </summary>
    public override string ToString()
    {
        return $"{this.name} is a {this.GetType().Name}";
    }
}

/// <summary>
/// Interface for interactive objects
/// </summary>
interface IInteractive
{
    /// <summary> Method for interacting with the object </summary>
    void Interact();
}

/// <summary>
/// Interface for breakable objects
/// </summary>
interface IBreakable
{
    /// <summary> Property indicating the durability/strength of the object </summary>
    int durability { get; set; }

    /// <summary> Method for breaking the object </summary>
    void Break();
}

/// <summary>
/// Interface for collectable objects
/// </summary>
interface ICollectable
{
    /// <summary> Property indicating whether the object has been collected </summary>
    bool isCollected { get; set; }

    /// <summary> Method for collecting the object </summary>
    void Collect();
}

/// <summary>
/// TestObject class representing an object that inherits from Base and implements all three interfaces
/// </summary>
class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    /// <summary> Durability property indicating the strength of the object </summary>
    public int durability { get; set; }

    /// <summary> Property indicating whether the object has been collected </summary>
    public bool isCollected { get; set; }

    /// <summary> Method for interacting with the object </summary>
    public void Interact()
    {
        // Implementation for Interact method
    }

    /// <summary> Method for breaking the object </summary>
    public void Break()
    {
        // Implementation for Break method
    }

    /// <summary> Method for collecting the object </summary>
    public void Collect()
    {
        // Implementation for Collect method
    }
}
