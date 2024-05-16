using System;
using System.Collections.Generic;

/// <summary>
/// Class representing a room with various objects
/// </summary>
class RoomObjects
{
    /// <summary>
    /// Method to iterate through a list of objects and execute actions based on their interfaces
    /// </summary>
    /// <param name="roomObjects">List of objects in the room</param>
    /// <param name="type">Type of interface to execute actions for</param>
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        foreach (var obj in roomObjects)
        {
            // Check if the object implements the specified interface type
            if (type.IsAssignableFrom(obj.GetType()))
            {
                // Execute actions based on the interface type
                if (type == typeof(IInteractive))
                {
                    // If the object is interactive, call the Interact() method
                    ((IInteractive)obj).Interact();
                }
                else if (type == typeof(IBreakable))
                {
                    // If the object is breakable, call the Break() method
                    ((IBreakable)obj).Break();
                }
                else if (type == typeof(ICollectable))
                {
                    // If the object is collectable, call the Collect() method
                    ((ICollectable)obj).Collect();
                }
            }
        }
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
    /// Method for breaking the object
    /// </summary>
    void Break();
}

/// <summary>
/// Represents a door, inheriting from Base and implementing the IInteractive interface
/// </summary>
class Door : Base, IInteractive
{
    public Door(string name) : base(name) { }

    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}

/// <summary>
/// Represents a decoration, inheriting from Base and implementing the IInteractive and IBreakable interfaces
/// </summary>
class Decoration : Base, IInteractive, IBreakable
{
    private bool isBroken;

    public Decoration(string name) : base(name)
    {
        this.isBroken = false;
    }

    public void Interact()
    {
        Console.WriteLine($"You look at the {name}. Not much to see here.");
    }

    public void Break()
    {
        if (!isBroken)
        {
            Console.WriteLine($"You smash the {name}. What a mess.");
            isBroken = true;
        }
        else
        {
            Console.WriteLine($"The {name} is already broken.");
        }
    }
}
