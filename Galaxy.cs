namespace AbstractFactory;

public class Galaxy : ISmartPhone
{
    public void ShowInfo()
    {
        Console.WriteLine("Marca: Samsung\n Modelo: Galaxy 22 Max");
    }
}