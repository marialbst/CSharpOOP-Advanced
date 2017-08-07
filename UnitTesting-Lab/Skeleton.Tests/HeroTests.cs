namespace Skeleton.Tests
{
    using System;
    using NUnit.Framework;
    using Moq;

    [TestFixture]
    public class HeroTests
    {
        private const string HeroName = "Hero";
        private const int AxeAttack = 5;
        private const int AxeDurability = 5;
        private const int DummyHealth = 4;
        private const int DummyExp = 4;

        public IWeapon fakeAxe;
        public ITarget fakeDummy;
        public Hero testedObj;
        
        [Test]
        public void HeroGainsExpAfterKillingTarget()
        {
            this.fakeAxe = new Axe(AxeAttack, AxeDurability);
            this.fakeDummy = new Dummy(DummyHealth, DummyExp);
            this.testedObj = new Hero(HeroName, this.fakeAxe);
            int testObjInitExp = this.testedObj.Experience;

            this.testedObj.Attack(this.fakeDummy);

            Assert.AreEqual(testObjInitExp + this.fakeDummy.GiveExperience(), this.testedObj.Experience, "Hero doesn't get XP");
        }

        [Test]
        public void HeroDoesNotGetXpIfTargetIsStillAlive()
        {
            Mock<IWeapon> fakeWeapon = new Mock<IWeapon>();
            Mock<ITarget> fakeTarget = new Mock<ITarget>();

            fakeTarget.Setup(t => t.IsDead()).Returns(true);
            fakeTarget.Setup(t => t.GiveExperience()).Throws(new InvalidOperationException("Target is not dead."));

            this.testedObj = new Hero(HeroName, fakeWeapon.Object);

            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => this.testedObj.Attack(fakeTarget.Object));
            Assert.AreEqual("Target is not dead.", ex.Message, "Target is dead");
        }
    }
}
