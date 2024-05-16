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
    protected int width;
    protected int height;

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
    public override int Area()
    {
        return width * height;
    }
}

/// <summary>
/// Square class representing a square shape
/// </summary>
class Square : Rectangle
{
    private int size;

    /// <summary>
    /// Size property of the square
    /// </summary>
    public int Size
    {
        get { return this.size; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Size must be greater than or equal to 0");
            }
            else
            {
                this.size = value;
                this.width = value;
                this.height = value;
            }
        }
    }
}
