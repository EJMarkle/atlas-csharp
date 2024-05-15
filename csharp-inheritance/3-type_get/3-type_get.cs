using System;
using System.Reflection;
using System.Collections.Generic;
/// <summary>
/// Object class
/// </summary>
class Obj {
    /// <summary>
    /// Prints the names of the available properties and methods of an object
    /// </summary>
    /// <param name="myObj"></param>
    public static void Print(object myObj) {
        Type objType = myObj.GetType();
        PropertyInfo[] properties = objType.GetProperties();
        MethodInfo[] methods = objType.GetMethods();

        Console.WriteLine("{0} Properties:", objType.Name);
        foreach (PropertyInfo property in properties) {
            Console.WriteLine(property.Name);
        }

        Console.WriteLine("{0} Methods:", objType.Name);
        foreach (MethodInfo method in methods) {
            Console.WriteLine(method.Name);
        }
    }
}
