// See https://aka.ms/new-console-template for more information

// Define arrow class
// with arrowhead, fletching, length (use enumerations)

// arrow = 10, wood = 3, obsidian = 5
// fletching: plastic= 10, turkey feathers = 5, goose = 3;
// shaft: 0.05g per centimeter

// allow user to pick arrowhead, fletching, length and create new arrow instances

// add getCost method, returns cost as float based on numbers

// -User experience-

// Input arrowhead
// Input fletching
// Input length
// Return entire type with price: 

// -I need-
// User creates a class instance
// Creator creates class parameters 

using System.Runtime.InteropServices;

Arrow arrow = new Arrow(); // Create a new instance whose type is arrow, and to store it 
class Arrow {
    public ArrowHeadType _arrowheadType; // Create values into existence
    public FletchingType _fletchingType;
    public float _length;

    public Arrow(ArrowHeadType arrowHeadType, FletchingType fletchingType, float length)  // Assign values
    {
        _arrowheadType = arrowHeadType;
        _fletchingType = fletchingType;
        _length = length;
    }

    public Arrow() // Define default values
    {
        _arrowheadType = ArrowHeadType.Steel;
        _fletchingType = FletchingType.GooseFeather;
        _length = 75;
    }
}

enum ArrowHeadType { Steel, Wood, Obsidian }
enum FletchingType { Plastic, TurkeyFeather, GooseFeather }