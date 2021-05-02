using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator.Fighters
{
    public class Warrior : FighterBase
    {
        Random random = new Random();
        
        public Warrior(string name, string team)
        {
            this.Name = name;
            this.Team = team;
            this.Class = Core.FighterClass.Melle;
            this.attackPoints = 40;
            this.healthPoints = 100;
        }

        protected override int GetCritModifier()
        {
            return random.Next(10, 51);
        }


        protected override int GetBlockModifier()
        {
            return random.Next(20, 81);
        }
    }

}
