using NUnit.Framework;
using Simulator.Core;

namespace Simulator.Fighters.Test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void ValidateThatWarriorCanBeInitialized()
        {
            Warrior warrior = new Warrior("Kaido", "Pirates");
            Assert.AreEqual("Kaido", warrior.Name);
            Assert.AreEqual("Pirates", warrior.Team);
            Assert.AreEqual(FighterClass.Melle, warrior.Class);
            Assert.AreEqual(40, warrior.AttackPoints);
            Assert.AreEqual(100, warrior.HealthPoints);
        }
    }
}