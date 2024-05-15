using System;

/// <summary>
/// Shape class representing a geometric shape
/// </summary>
class Shape
{
    /// <summary>
    /// Area method to calculate the area of the shape
    /// </summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>
/// Rectangle class representing a rectangle shape
/// </summary>
class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary>
    /// Width property of the rectangle
    /// </summary>
    public int Width
    {
        get { return this.width; }
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
    /// Height property of the rectangle
    /// </summary>
    public int Height
    {
        get { return this.height; }
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

    /// <summary>
    /// Calculates the area of the rectangle
    /// </summary>
    /// <returns>The area of the rectangle</returns>
    public new int Area()
    {
        return width * height;
    }

    /// <summary>
    /// Returns a string representation of the rectangle
    /// </summary>
    /// <returns>String representation of the rectangle</returns>
    public override string ToString()
    {
        return $"[Rectangle] {width} / {height}";
    }
}