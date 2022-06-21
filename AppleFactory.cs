namespace AbstractFactory;

public class AppleFactory : IGadgetsFactory
{
    public ISmartPhone MakeSmartPhone()
    {
        return new IPhone();
    }

    public ITablet MakeTablet()
    {
        return new IPad();
    }
}