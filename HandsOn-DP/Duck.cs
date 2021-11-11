using HandsOn_DP.Behaviors;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOn_DP
{
    public class Duck
    {
        public IFly FlyBehavior { get; private set; }
        public IDisplay DisplayBehavior { get; private set; }
        public IQuack QuackBehavior { get; private set; }
        public Duck(IDisplay displayStrategy, IQuack quackStrategy, IFly flyStrategy)
        {
            FlyBehavior = flyStrategy;
            DisplayBehavior = displayStrategy;
            QuackBehavior = quackStrategy;
        }

        public void Quack()
        {
            QuackBehavior.Quack();
        }

        public void Display()
        {
            DisplayBehavior.Display();
        }

        public void Fly()
        {
            FlyBehavior.Fly();
        }
    }
}
