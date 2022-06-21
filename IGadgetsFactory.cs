namespace AbstractFactory;

public interface IGadgetsFactory
{
    ISmartPhone MakeSmartPhone();
    ITablet MakeTablet();
}