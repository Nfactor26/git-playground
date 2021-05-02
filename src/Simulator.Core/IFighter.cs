using System;

namespace Simulator.Core
{
    public interface IFighter
    {
        string Name { get; set; }

        string Team { get; set; }

        FighterClass Class { get; }

        int AttackPoints { get; }

        int HealthPoints { get; }

        bool IsAlive { get; }

        void TakeDamage(int damage);

        void Attack(IFighter another);

    }
}
