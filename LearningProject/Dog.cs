using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProject
{
    class Dog
    {
        public string Name;
        private int age;
        private Dog friend;

        public Dog(string name, int age)
        {
            Name = name;
            this.age = age;
        }

        public virtual void Voice()
        {
            Console.WriteLine("Gav!");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Dog: {Name}");
            Console.WriteLine($"Age: {age} years");

            if (friend != null)
            {
                Console.WriteLine($"Friend: {friend.Name}");

            }

            Console.WriteLine("Voice:");
            Voice();
        }

        public void MakeFriend(Dog otherDog)
        {
            this.friend = otherDog;
            otherDog.friend = this;

        }
    }

    class BigDog: Dog
    {
        private int weight;

        public BigDog(string name, int age, int weight)
            :base(name, age)
        {
            this.weight = weight;
        }

        public override void Voice()
        {
            Console.WriteLine("Woof!");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Weight: {weight}");
        }
    }
}
