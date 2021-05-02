using Simulator.Core;
using System;

namespace Simulator.Fighters
{
    public class FighterBase : IFighter
    {
        public string Name { get; set; }

        public string Team { get; set; }

        public FighterClass Class { get; protected set; }

        protected int attackPoints;
        public int AttackPoints => attackPoints;

        protected int healthPoints;
        public int HealthPoints => healthPoints;

        public bool IsAlive => healthPoints > 0;

        public void Attack(IFighter another)
        {
            int critModifier = GetCritModifier();
            attackPoints += (int)((critModifier / 100.0) * attackPoints);
            Console.WriteLine($"{Team}->{Name} attacks for {attackPoints} with critModifier {critModifier}");
            another.TakeDamage(attackPoints);

        }

        public void TakeDamage(int damage)
        {
            int blockModifier = GetBlockModifier();
            damage -= (int)((blockModifier / 100.0) * damage);
            Console.WriteLine($"{Team}->{Name} damaged for {damage} with blockModifer {blockModifier}");
            healthPoints = healthPoints - damage;
        }

        protected virtual int GetBlockModifier()
        {
            return 0;
        }

        protected virtual int GetCritModifier()
        {
            return 0;
        }
    }
}
