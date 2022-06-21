namespace AbstractFactory;

public class IPad : ITablet
{
    public void ShowInfo()
    {
        Console.WriteLine("Marca: Apple\n Modelo: IPad 12 Max");
    }
}