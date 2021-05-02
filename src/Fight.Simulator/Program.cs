using Ninject;
using Simulator.Core;
using Simulator.Fighters;
using System;

namespace git_playground
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Bind<IFightSimulator>().To<FightSimulator>();
            kernel.Bind<IFighterFactory>().To<FighterFactory>();

            var simulator = kernel.Get<IFightSimulator>();

            Console.WriteLine("Enter the size of team");
            if(int.TryParse(Console.ReadLine(), out int teamSize))
            {
                simulator.PrepareTeam("TeamOne", "TeamTwo", teamSize);
                simulator.BeginSimulation();
                Console.WriteLine("-------------Completed--------------------");
                Console.WriteLine("Press any key to exit");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Size of team should be an integer");
            Console.WriteLine("Press anykey to exit");
            Console.ReadLine();
        }
    }
}
