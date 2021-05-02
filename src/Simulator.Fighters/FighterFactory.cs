using Simulator.Core;
using System;

namespace Simulator.Fighters
{
    public class FighterFactory : IFighterFactory
    {
        public IFighter CreateFighter(int fighterClass, string team)
        {
            switch(fighterClass)
            {
                case 1:
                    return new Warrior("Warrior", team);
                case 2:
                    return new Mage("Mage", team);
                default:
                    throw new ArgumentException();
            }
        }
    }
}
