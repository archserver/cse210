public class Shape
{
    // set Variables for the Activity Classes
    private string _shapeColor = "Black";
        
    public Shape()
    {
    }

    public void SetColor()
    {
        Console.Write("Enter the Shape Color: ");
        string col = Console.ReadLine();
        _shapeColor = col;
        return;
    }
    public string GetColor()
    {

        return _shapeColor; 
        
    }

    public virtual double GetArea()
    {
        return 0;
    }



    public double GetNumber(string question)
    {
        double returnNumber;

        Console.Write($"{question} ");
        if(double.TryParse(Console.ReadLine(), out returnNumber))
        {
            return returnNumber;
        }
        else
        {
            return 0;
        }
    }
}