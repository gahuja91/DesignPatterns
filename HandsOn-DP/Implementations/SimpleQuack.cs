using HandsOn_DP.Behaviors;
using System;

namespace HandsOn_DP.Implementations
{
    public class SimpleQuack : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("Quack Quack");
        }
    }
}
