interface IStrategy
{
    void Method();
}

class Strategy1 : IStrategy
{
    void IStrategy.Method() { }
}

class Strategy2 : IStrategy
{
    void IStrategy.Method() { }
}

class Strategy3 : IStrategy
{
    void IStrategy.Method() { }
}

class Strateger
{
    IStrategy _strategy;

    public void DoStrategy()
    {
        _strategy.Method();
    }

    public void SetStrategy(IStrategy strategy)
    {
        if (strategy != null)
        {
            _strategy = strategy;
        }
    }
}

class Programm
{
    Strateger strateger = new Strateger();

    void DoProgram()
    {
        strateger.DoStrategy();
    }
}