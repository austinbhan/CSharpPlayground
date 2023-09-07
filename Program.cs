// See https://aka.ms/new-console-template for more information

// Information Hiding

class Rectangle 
{
    public float _width;
    public float _height;
    public float _area;

    public Rectangle(float width, float height, float area) // Even without constructor, one will be written behind the scenes
    {
        _width = width;
        _height = height;
        _area = area;
    }
}