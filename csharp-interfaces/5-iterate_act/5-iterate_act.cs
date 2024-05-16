using System;
using System.Collections.Generic;

/// <summary>
/// Abstract base class representing an object
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
/// Interface for interactive objects
/// </summary>
interface IInteractive
{
    /// <summary>
    /// Method for interacting with the object
    /// </summary>
    void Interact();
}

/// <summary>
/// Interface for breakable objects
/// </summary>
interface IBreakable
{
    /// <summary>
    /// Represents the object's durability
    /// </summary>
    int durability { get; set; }

    /// <summary>
    /// Method for damaging the object
    /// </summary>
    void Break();
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
/// Represents a door, inheriting from Base and implementing the IInteractive interface
/// </summary>
class Door : Base, IInteractive
{
    /// <summary>
    /// Constructor for the Door class
    /// </summary>
    public Door()
    {
        this.name = "Door";
    }

    /// <summary>
    /// Constructor for the Door class with an optional parameter
    /// </summary>
    public Door(string Name)
    {
        this.name = Name;
    }

    /// <summary>
    /// Method for interacting with the door
    /// </summary>
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
    public bool isQuestItem;
    public int durability { get; set; }

    /// <summary>
    /// Constructor for the Decoration class
    /// </summary>
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
    /// Method for interacting with the decoration
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
    /// Method for damaging the decoration
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

/// <summary>
/// Represents a key, inheriting from Base and implementing the ICollectable interface
/// </summary>
class Key : Base, ICollectable
{
    public bool isCollected { get; set; }

    /// <summary>
    /// Constructor for the Key class
    /// </summary>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary>
    /// Method for collecting the key
    /// </summary>
    public void Collect()
    {
        if (!this.isCollected)
        {
            this.isCollected = true;
            Console.WriteLine($"You pick up the {this.name}.");
        }
        else if (this.isCollected)
        {
            Console.WriteLine($"You have already picked up the {this.name}.");
        }
    }
}

/// <summary>
/// Represents a room with various objects
/// </summary>
class RoomObjects
{
    /// <summary>
    /// Method to iterate through a list of objects and execute actions based on their interfaces
    /// </summary>
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        foreach (var obj in roomObjects)
        {
            if (type.IsAssignableFrom(obj.GetType()))
            {
                if (obj is IInteractive interactiveObj && type == typeof(IInteractive))
                {
                    interactiveObj.Interact();
                }
                else if (obj is IBreakable breakableObj && type == typeof(IBreakable))
                {
                    breakableObj.Break();
                }
                else if (obj is ICollectable collectableObj)
                {
                    collectableObj.Collect();
                }
            }
        }
    }
}
