using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator.Core
{
    public interface IFightSimulator
    {
        void BeginSimulation();
        void PrepareTeam(string teamOne, string teamTwo, int teamSize);
    }
}
