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
/// Decoration class representing a decoration object
/// </summary>
class Decoration : Base, IInteractive, IBreakable
{
    /// <summary> Indicates whether the object is a quest item </summary>
    public bool isQuestItem { get; set; }

    /// <summary>
    /// Constructor for the Decoration class
    /// </summary>
    /// <param name="name">The name of the decoration</param>
    /// <param name="durability">The durability of the decoration</param>
    /// <param name="isQuestItem">Whether the decoration is a quest item or not</param>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;

        if (durability <= 0)
        {
            throw new ArgumentException("Durability must be greater than 0");
        }
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
        else if (this.isQuestItem)
        {
            Console.WriteLine($"You look at the {this.name}. There's a key inside.");
        }
        else
        {
            Console.WriteLine($"You look at the {this.name}. Not much to see here.");
        }
    }

    /// <summary>
    /// Implementation of the Break method for the Decoration class
    /// </summary>
    public void Break()
    {
        if (this.durability > 0)
        {
            Console.WriteLine($"You hit the {this.name}. It cracks.");
            this.durability--;

            if (this.durability == 0)
            {
                Console.WriteLine($"You smash the {this.name}. What a mess.");
            }
        }
        else
        {
            Console.WriteLine($"The {this.name} is already broken.");
        }
    }
}