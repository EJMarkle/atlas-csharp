using System;
/// <summary>
/// object class
/// </summary>
class Obj {
    /// <summary>
    /// Checks if the object is an instance of, or if the object is an instance of a class that inherited from, Array
    /// </summary>
    /// <param name="obj"></param>
    /// <returns>True or False</returns>
    public static bool IsInstanceOfArray(object obj) {
        return obj is Array;
    }
}
