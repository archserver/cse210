public class Rectangle: Shape
{
    private double _sidea;
    private double _sideb;

    
    
    public override double GetArea()
    {
        _sidea = GetNumber("Enter the first side of the rectangle:");
        _sideb = GetNumber("Enter the second side of the rectangle:");
        return _sidea * _sideb;
    }
}
