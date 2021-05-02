using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator.Fighters
{
    public class Mage : FighterBase
    {
        Random random = new Random();

        public Mage(string name, string team)
        {
            this.Name = name;
            this.Team = team;
            this.Class = Core.FighterClass.Ranged;
            this.attackPoints = 60;
            this.healthPoints = 80;
        }

        protected override int GetCritModifier()
        {
            return random.Next(30, 101);  
        }

        protected override int GetBlockModifier()
        {
            return random.Next(10, 41);
        }
    }
}
