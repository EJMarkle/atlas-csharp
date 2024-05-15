using System;
/// <summary>
/// object class
/// </summary>
class Obj {
    /// <summary>
    /// Checks if the object is an instance of a class that inherits from the specified class
    /// </summary>
    /// <param name="derivedType"></param>
    /// <param name="baseType"></param>
    /// <returns>True or False</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType) {
        return baseType.IsAssignableFrom(derivedType) && derivedType != baseType;
    }
}
