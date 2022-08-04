public interface ICalculator
{
    int Add(int x, int y);
}
public class ConcreteCalculator : ICalculator
{
    public int Add(int x, int y)
    {

        var addition = x + y;
        return addition;
    }
}

public class Printer : ICalculator
{
    private ICalculator _calculator;
    public Printer(ICalculator calculator)
    {
        _calculator = calculator;
    }

    public int Add(int x, int y)
    {
        int value =  _calculator.Add(x, y);
        Print("result ={0}", value);
        return value;
    }

    private void Print(string statement, int value) { }
}
