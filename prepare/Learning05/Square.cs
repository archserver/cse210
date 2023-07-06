public class Square : Shape
{
    private double _side;
    
    public override double GetArea()
    {
        _side = GetNumber("Enter one side of the square:");
        return Math.Pow(_side,2);
    }
}