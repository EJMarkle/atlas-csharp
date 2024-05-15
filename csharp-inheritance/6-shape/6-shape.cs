using System;

/// <summary>
/// Shape class
/// </summary>
class Shape
{
    /// <summary>
    /// Area method
    /// </summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>
/// Rectangle class
/// </summary>
class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary>
    /// Width property
    /// </summary>
    public int Width
    {
        get {return this.width;}
        set 
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            else
            {
                this.width = value;
            }
        }
    }

    /// <summary>
    /// Height propety 
    /// </summary>
    public int Height
    {
        get {return this.height;}
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            else
            {
                this.height = value;
            }
        }
    }
}