using System.Runtime.InteropServices.Marshalling;

namespace NoiseMaker;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, NoiseMaker World!");

        Animal myAnimal = new Animal;
        Olca myOlca = new Olca  ("Willie");
    }
}