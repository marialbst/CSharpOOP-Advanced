namespace Skeleton.Tests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class DummyTests
    {
        private const int AliveDummyHealth = 10;
        private const int MustDieDummyHealth = 4;
        private const int DeadDummyHealth = 0;
        private const int DummyExp = 10;
        private const int AttackPower = 5;
        
        private Dummy dummy;

        [SetUp]
        public void TestInit()
        {
            //Arrange
            this.dummy = new Dummy(AliveDummyHealth, DummyExp);
        }

        [Test]
        public void DummyLosesHealthAfterAttack()
        {
            //Act
            this.dummy.TakeAttack(AttackPower);

            //Assert
            Assert.AreEqual(AliveDummyHealth-AttackPower, this.dummy.Health, "Dummy doesn't lose health after attack.");
        }

        [Test]
        public void DeadDummyThrowsExceptionAfterAttack()
        {
            //Arrange
            this.dummy = new Dummy(MustDieDummyHealth, DummyExp);

            //Act
            this.dummy.TakeAttack(AttackPower);

            //Assert
            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => this.dummy.TakeAttack(AttackPower));
            Assert.AreEqual("Dummy is dead.", ex.Message, "Outputs are not the same.");
        }

        [Test]
        public void DeadDummyGivesExp()
        {
            //Arrange
            this.dummy = new Dummy(DeadDummyHealth, DummyExp);

            //Act
            this.dummy.IsDead();

            //Assert
            Assert.AreEqual(DummyExp, this.dummy.GiveExperience(), "Dummy does not give XP after his dead.");
        }

        [Test]
        public void AliveDummyNotGiveExp()
        {
            //Act
            this.dummy.IsDead();

            //Assert
            Assert.Throws<InvalidOperationException>(() => this.dummy.GiveExperience(), "Dummy gives XP even if he's alive.");
        }
    }
}
