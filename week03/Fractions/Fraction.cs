public class Fraction

{
    private int _numerador;
    private int _denominador;

    public Fraction()
    {
        // Default to 1/1
        _numerador = 1;
        _denominador = 1;
    }

    public Fraction(int wholeNumber)
    {
        _numerador = wholeNumber;
        _denominador = 1;
    }

    public Fraction(int top, int bottom)
    {
        _numerador = top;
        _denominador = bottom;
    }

    public string GetFractionString()
    {
        // Notice that this is not stored as a member variable.
        // Is is just a temporary, local variable that will be recomputed each time this is called.
        string text = $"{_numerador}/{_denominador}";
        return text;
    }

    public double GetDecimalValue()
    {
        // Notice that this is not stored as a member variable.
        // Is will be recomputed each time this is called.
        return (double)_numerador / (double)_denominador;
    }
}