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
    /// <summary> Durability property indicating the strength of the object </summary>
    int durability { get; set; }

    /// <summary> Method for breaking the object </summary>
    void Break();
}

/// <summary>
/// Interface for collectable objects
/// </summary>
interface ICollectable
{
    /// <summary> Indicates whether the object has been collected </summary>
    bool isCollected { get; set; }

    /// <summary> Method for collecting the object </summary>
    void Collect();
}

/// <summary>
/// Represents a door, inheriting from Base and implementing the IInteractive interface
/// </summary>
class Door : Base, IInteractive
{
    /// <summary> Constructor for the Door class </summary>
    public Door()
    {
        this.name = "Door";
    }

    /// <summary> Constructor for the Door class with an optional parameter for the name </summary>
    public Door(string Name)
    {
        this.name = Name;
    }

    /// <summary> Implementation of the Interact method for the Door class </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {this.name}. It's locked.");
    }
}

/// <summary>
/// Represents a decoration, inheriting from Base and implementing the IInteractive and IBreakable interfaces
/// </summary>
class Decoration : Base, IInteractive, IBreakable
{
    /// <summary> Indicates whether the decoration is a quest item </summary>
    public bool isQuestItem;

    /// <summary> Durability property indicating the strength of the decoration </summary>
    public int durability { get; set; }

    /// <summary>
    /// Constructor for the Decoration class
    /// </summary>
    /// <param name="name">The name of the decoration</param>
    /// <param name="durability">The durability of the decoration</param>
    /// <param name="isQuestItem">Whether the decoration is a quest item or not</param>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
        {
            throw new Exception("Durability must be greater than 0");
        }
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    /// <summary>
    /// Implementation of the Interact method for the Decoration class
    /// </summary>
    public void Interact()
    {
        if (this.durability <= 0)
        {
            Console.WriteLine($"The {this.name} has been broken.");
        }
        else if (isQuestItem)
        {
            Console.WriteLine($"You look at the {this.name}. There's a key inside.");
        }
        else if (!isQuestItem)
        {
            Console.WriteLine($"You look at the {this.name}. Not much to see here.");
        }
    }

    /// <summary>
    /// Implementation of the Break method for the Decoration class
    /// </summary>
    public void Break()
    {
        this.durability--;
        if (this.durability > 0)
        {
            Console.WriteLine($"You hit the {this.name}. It cracks.");
        }
        else if (this.durability == 0)
        {
            Console.WriteLine($"You smash the {this.name}. What a mess.");
        }
        else if (this.durability < 0)
        {
            Console.WriteLine($"The {this.name} is already broken.");
        }
    }
}
