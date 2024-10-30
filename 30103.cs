// See https://aka.ms/new-console-template for more information
using System;
class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("животное издает звуууук");
    }
}
class Dog : Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("гав");
    }
}
class Cat : Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("мяу");
    }
}
class Program
{
    static void Main()
    {
        Animal dog = new Dog();
        Animal cat = new Cat();
        dog.Sound();
        cat.Sound();
    }
}
