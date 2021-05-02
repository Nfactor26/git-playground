using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator.Core
{   

    public class FightSimulator : IFightSimulator
    {
        public string TeamOne { get; private set; }

        private List<IFighter> teamOneFighters = new List<IFighter>();

        public string TeamTwo { get; private set; }

        private List<IFighter> teamTwoFighters = new List<IFighter>();

        public int TeamSize { get; private set; }

        private readonly IFighterFactory fighterFactory;

        public FightSimulator(IFighterFactory fighterFactory)
        {
            this.fighterFactory = fighterFactory;
        }

        public void PrepareTeam(string teamOne, string teamTwo, int teamSize)
        {
            this.TeamOne = teamOne;
            this.TeamTwo = teamTwo;
            this.TeamSize = teamSize;

            Random rnd = new Random();
            while (teamSize > 0)
            {
                int next = rnd.Next(1, 3);
                teamOneFighters.Add(fighterFactory.CreateFighter(next, teamOne));
                next = rnd.Next(1, 3);
                teamTwoFighters.Add(fighterFactory.CreateFighter(next, teamTwo));
                teamSize--;
            }

            Console.WriteLine("Team Details :");
            Console.WriteLine(TeamOne);
            Console.WriteLine(string.Join(',', teamOneFighters.Select(f => f.Name)));
            Console.WriteLine(TeamTwo);
            Console.WriteLine(string.Join(',', teamTwoFighters.Select(f => f.Name)));
        }

        /// <summary>
        /// A really poor simulation 
        /// </summary>
        public void BeginSimulation()
        {
            while (teamOneFighters.Any() && teamTwoFighters.Any())
            {
                IFighter teamOneFighter = teamOneFighters.First();
                IFighter teamTwoFighter = teamTwoFighters.First();
                teamOneFighter.Attack(teamTwoFighter);
                if (teamTwoFighter.IsAlive)
                {
                    Console.WriteLine($"{teamTwoFighter.Class} from {TeamTwo} lives with {teamTwoFighter.HealthPoints}.");
                }
                else
                {
                    Console.WriteLine($"{teamTwoFighter.Class} from {TeamTwo} dies.");
                    teamTwoFighters.Remove(teamTwoFighter);
                }

                teamTwoFighter.Attack(teamOneFighter);
                if (teamOneFighter.IsAlive)
                {
                    Console.WriteLine($"{teamOneFighter.Class} from {TeamOne} lives with {teamOneFighter.HealthPoints}.");
                }
                else
                {
                    Console.WriteLine($"{teamOneFighter.Class} from {TeamOne} dies.");
                    teamOneFighters.Remove(teamOneFighter);
                }
            }

            if(teamOneFighters.Any())
            {
                Console.WriteLine($"{TeamOne} wins !!");
            }
            if(teamTwoFighters.Any())
            {
                Console.WriteLine($"{TeamTwo} wins !!");
            }
        }
    }
}
