using HandsOn_DP.Behaviors;
using System;

namespace HandsOn_DP.Implementations
{
    public class NoFly : IFly
    {
        public void Fly()
        {
            Console.WriteLine("I CANNOT FLY :(");
        }
    }
}
