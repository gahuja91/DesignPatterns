using HandsOn_DP.Implementations;
using System;

namespace HandsOn_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            //MALLARD DUCK
            var mallardFlyBehavior = new SimpleFly();
            var mallardDisplayBehavior = new SimpleDisplay();
            var mallardQuackBehavior = new SimpleQuack();
            Duck mallardDuck = new Duck(mallardDisplayBehavior, mallardQuackBehavior, mallardFlyBehavior);
            mallardDuck.Display();
            mallardDuck.Quack();
            mallardDuck.Fly();
            
            Console.WriteLine();
            
            //RUBBER DUCK
            var rubberFlyBehavior = new NoFly();
            var rubberDisplayBehavior = new RubberDisplay();
            var rubberQuackBehavior = new FastQuack();
            Duck rubberDuck = new Duck(rubberDisplayBehavior, rubberQuackBehavior, rubberFlyBehavior);
            rubberDuck.Display();
            rubberDuck.Quack();
            rubberDuck.Fly();
        }
    }
}
