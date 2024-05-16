using System;

/// <summary>
/// Abstract base class representing a base object
/// </summary>
abstract class Base
{
    /// <summary>
    /// Name property of the object
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// Overrides the ToString method to provide a custom string representation of the object
    /// </summary>
    public override string ToString()
    {
        return $"{this.name} is a {this.GetType().Name}";
    }
}

/// <summary>
/// Interface for collectable objects
/// </summary>
interface ICollectable
{
    /// <summary>
    /// Indicates whether the object has been collected
    /// </summary>
    bool isCollected { get; set; }

    /// <summary>
    /// Method for collecting the object
    /// </summary>
    void Collect();
}

/// <summary>
/// Represents a key, inheriting from Base and implementing the ICollectable interface
/// </summary>
class Key : Base, ICollectable
{
    /// <summary>
    /// Indicates whether the key has been collected
    /// </summary>
    public bool isCollected { get; set; }

    /// <summary>
    /// Constructor for the Key class
    /// </summary>
    /// <param name="name">The name of the key</param>
    /// <param name="isCollected">Whether the key has been collected or not</param>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary>
    /// Implementation of the Collect method for the Key class
    /// </summary>
    public void Collect()
    {
        if (!isCollected)
        {
            Console.WriteLine($"You pick up the {this.name}.");
            isCollected = true;
        }
        else
        {
            Console.WriteLine($"You have already picked up the {this.name}.");
        }
    }
}