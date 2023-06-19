// Fraction class contains two intigers gets information from the user for the fracton reference and then converts it into a decimal value

public class Fraction
{
    private int _numerator, _denominator;

    public Fraction()
    {
        SetTop(1);
        SetBottom(1);
    }

    public Fraction(int WholeNumber)
    {
        SetTop(WholeNumber);
        SetBottom(1);

    }

    public Fraction(int top, int bottem)
    {
        SetTop(top);
        SetBottom(bottem);

    }

    public int GetTop()
    {
        return _numerator;
    }

    public void SetTop(int top)
    {
        _numerator = top;
    }

    public int GetBottom()
    {
        return _denominator;
    }

    public void SetBottom(int bottem)
    {
        _denominator = bottem;
    }

    public string GetFractionString()
    {
/*        string rtval; 
        if (_numerator > _denominator)
        {
            int whole = _numerator / _denominator;
            int remaining = _numerator % _denominator;
            if (remaining == 0)
            {
                rtval = whole.ToString();
            }
            else
            {
                if ((_numerator%_denominator)%remaining == 0)
                {
                    rtval = whole.ToString()+ " " + 1 +"/" + (_denominator/remaining).ToString();
                }
                else
                {
                    rtval = whole.ToString()+ " " + (_numerator%_denominator).ToString() +"/" + _denominator.ToString();
                }
            }

        }
        else
        {
            rtval = _numerator.ToString()+"/"+_denominator.ToString();
        }

        return rtval;*/
        return _numerator.ToString()+"/"+_denominator.ToString();
    }

    public double GetDecimalValue()
    {
        return (double)_numerator/(double)_denominator;
    }
}