namespace AbstractFactory;

public class IPhone : ISmartPhone
{
    public void ShowInfo()
    {
        Console.WriteLine("Marca: Apple\n Modelo: IPhone 13 Pro Max");
    }
}