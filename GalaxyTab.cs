namespace AbstractFactory;

public class GalaxyTab : ITablet
{
    public void ShowInfo()
    {
        Console.WriteLine("Marca: Samsung\n Modelo: GalaxyTab 22");
    }
}