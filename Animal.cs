using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt26_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Cat cat134 = new Cat();

            Bird bird134 = new Bird();

            cat134.Run();
            bird134.Fly();

            Console.ReadKey();
        }
    }
    public abstract class Animal
    {
        public abstract void makeSound();

        public virtual void Run()
        {
            
        }
        public virtual void Fly() { }

        
    }
    public class Cat : Animal
    {
        
        public override void makeSound()
        {
            Console.WriteLine("Mèo meow meow.");
        }
        public override void Run()
        {
            Console.WriteLine("Chạy bằng 4 chân");
        }
    }
    
    public class Bird : Animal
    {     
        public override void makeSound()
        {
            Console.WriteLine("ec' ec'");
        }
        public override void Fly()
        {
            Console.WriteLine("Bay nhu chim");
        }
    }
    
    
}
