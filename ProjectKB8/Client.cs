namespace ProjectKB8;

public class Client
{
    public string Name { get; set; }
    public string Company { get; set; }

    public Client(string name, string company)
    {
        Name = name;
        Company = company;
    }

    public void EnterHall()
    {
        Console.WriteLine($"Client {Name} entered the hall.");
    }
    public void ShowInfo()
    {
        Console.WriteLine($"Клиент {Name} из {Company}");
    }
}