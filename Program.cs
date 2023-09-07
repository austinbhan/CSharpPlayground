// See https://aka.ms/new-console-template for more information

// Information Hiding 
// Input width and height to receive area 

Rectangle rectangle = new Rectangle(2, 3); // Set the width and height
rectangle.SetWidth(4); // Overwrites width after initial values
Console.WriteLine(rectangle.GetArea());
class Rectangle 
{
    private float _width; // if private, then untouchable from the outside
    private float _height;
    private float _area;

    public Rectangle(float width, float height) // Even without constructor, one will be written behind the scenes
    {
        _width = width; 
        _height = height;
        _area = _width * _height;
    }
    
    // Provides controlled access to receive solutions, but not the data process
    public float GetWidth() => _width; // Retrieving values means Get naming 
    public float GetHeight() => _height;
    public float GetArea() => _area;

    // If outside world needs to change rectangle dimensions, use these methods

    public void SetWidth(float value) // Assigning values means Sign naming
    {
        _width = value;
        _area = _width * _height;
    }

    public void SetHeight(float value)
    {
        _height = value;
        _area = _width * _height;
    }
}