namespace Skeleton.Tests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class AxeTests
    {
        private const int AxeAttack = 1;
        private const int AxeDurability = 1;
        private const int DummyHealth = 10;
        private const int DummyExp = 10;

        private Axe axe;
        private Dummy dummy;

        [SetUp]
        public void TestInit()
        {
            //Arrange
            this.axe = new Axe(AxeAttack, AxeDurability);
            this.dummy = new Dummy(DummyHealth,DummyExp);
        }
        [Test]
        public void AxeLosesDurabilityAfterAttack()
        {
            //Act
            this.axe.Attack(this.dummy);

            //Assert
            Assert.AreEqual(0, this.axe.DurabilityPoints, "Axe Durability doesn't change after attack");
        }

        [Test]
        public void AttackWithBrokenWeapon()
        {
            //Act
            this.axe.Attack(this.dummy);

            //Assert
            var ex = Assert.Throws<InvalidOperationException>(() => this.axe.Attack(this.dummy));
            Assert.AreEqual("Axe is broken.", ex.Message, "Messages are not the same.");
        }
    }
}
