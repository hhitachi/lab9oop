using System;
using System.Collections.Generic;
class Animal{
    public string Name{get;set;}
    public int Age{get;set;}
    public void Info(){
        Console.WriteLine($"It's {Name}, Its age = {Age}");
    }
    public virtual void MakeSound(){
        Console.WriteLine("This animal made a sound");
    }
}
class Cat : Animal{
    public override void MakeSound()
    {
        Console.WriteLine("MurMiav");
    }
}
class Hamster : Animal{
    
    public override void MakeSound()
    {
        Console.WriteLine("Squeak-squeak");
    }
}
class Perrot : Animal{
    public override void MakeSound()
    {
        Console.WriteLine("Kesha is a good boy!");
    }
}
class Program
{
    static void Main(){

        List<Animal> animals = new List<Animal>{
            new Cat{Name = "Richard", Age = 2},
            new Hamster{Name = "Pillow", Age = 6},
            new Perrot{Name = "Afton", Age = 5}
        };
        
        foreach(var animal in animals){
            animal.MakeSound();
            animal.Info();
            Console.WriteLine("");
        }

        Console.ReadKey();
    }
}