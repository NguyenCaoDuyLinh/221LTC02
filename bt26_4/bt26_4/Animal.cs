using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt26_4
{
    public abstract class Animal
    {
        protected abstract void makeSound();
        public virtual void Eat()
        {
            Console.WriteLine("Động vật ăn cỏ");
        }
        public void Run()
        {
            Console.WriteLine("Chạy bằng 4 chân");
        }
    }
    public class Cat : Animal
    {
        
        public override void makeSound()
        {
            Console.WriteLine("Mèo meow meow.");
        }
        
        public override void Eat()
        {
            Console.WriteLine("Mèo ăn cá.");
        }
        
    }
    
    public class Bird : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Bò ummuu bò.");
        }
    }
    static void main(string[] args)
    {
        
        Animal cat = new Cat();

        // hoặc:
        Cat cat1 = new Cat();

        Cow cow = new Cow();
        
        cat.Eat();
        cow.Eat();

        cat.AnimalSound();
        cow.AnimalSound();

        cat.Run();
        cat.Run();

        Console.ReadKey();
    }
}
