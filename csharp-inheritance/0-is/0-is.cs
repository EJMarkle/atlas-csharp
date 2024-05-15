using System;

/// <summary>
/// object class 
/// </summary>
class Obj {
    /// <summary>
    /// Checks if object is an int.
    /// </summary>
    /// <param name="obj"></param>
    /// <returns>True or False</returns>
    public static bool IsOfTypeInt(object obj) {
        return obj is int;
    }
}
