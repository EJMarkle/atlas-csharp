using System;

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
/// Door class representing a door object
/// </summary>
class Door : Base, IInteractive
{
    /// <summary>
    /// Constructor for the Door class
    /// </summary>
    /// <param name="name">The name of the door</param>
    public Door(string name = "Door")
    {
        this.name = name;
    }

    /// <summary>
    /// Implementation of the Interact method for the Door class
    /// </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {this.name}. It's locked.");
    }
}