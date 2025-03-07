//. Abstract Class and Polymorphism
//Time: 15 mins
//Create an abstract class `Animal` with an abstract method `MakeSound()`. Derive two classes `Dog` and `Cat` that override `MakeSound()`. Instantiate objects of both classes and call the method.

using System;

abstract class Animal
{
    public abstract void MakeSound();
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal myDog = new Dog();
        Animal myCat = new Cat();

        myDog.MakeSound();
        myCat.MakeSound();
    }
}
