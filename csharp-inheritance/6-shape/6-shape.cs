using System;

/// <summary>
/// Base class representing a shape
/// </summary>
class Shape {
    /// <summary>
    /// Calculates the area of the shape (to be overridden by derived classes)
    /// </summary>
    /// <returns>The area of the shape</returns>
    public virtual int Area() {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>
/// Rectangle class representing a rectangle shape
/// </summary>
class Rectangle : Shape {
    private int width;
    private int height;

    /// <summary>
    /// Width property of the rectangle
    /// </summary>
    public int Width {
        get { return width; }
        set {
            if (value < 0) {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            width = value;
        }
    }

    /// <summary>
    /// Height property of the rectangle
    /// </summary>
    public int Height {
        get { return height; }
        set {
            if (value < 0) {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            height = value;
        }
    }

    /// <summary>
    /// Calculates the area of the rectangle
    /// </summary>
    /// <returns>The area of the rectangle</returns>
    public override int Area() {
        return width * height;
    }
}
