namespace AbstractFactory;

public class SamsungFactory : IGadgetsFactory
{
    public ISmartPhone MakeSmartPhone()
    {
        return new Galaxy();
    }

    public ITablet MakeTablet()
    {
        return new GalaxyTab();
    }
}