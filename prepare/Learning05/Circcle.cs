public class Circle : Shape
{
    private double _radius;

    
    
    public override double GetArea()
    {
        _radius = GetNumber("Enter the radius of the circle:");
        return Math.PI*Math.Pow(_radius,2);
    }

}