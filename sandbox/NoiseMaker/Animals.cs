// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
class Animal
{
    private string _nam;

    public Animal(string n)
    {
        _name = n;
    }
    virtual public void MakeNoise()
    {
        Console.WriteLine("I am a generic animals,I don't know what sound I make");
    }
}