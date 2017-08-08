namespace Database.Tests
{
    using System;
    using System.Linq;
    using Databasepr.Models;
    using NUnit.Framework;

    [TestFixture]
    public class IntegerDatabaseTests
    {
        private int[] sampleDataValidCapacity = new int[14];
        private int[] sampleDataInvalidCapacity = new int[17];
        private int[] sampleData = new int[] {1,2,3,4};
        
        private Database<int> db;

        [SetUp]
        public void InitDb()
        {
            this.db = new Database<int>(this.sampleData);
        }

        [Test]
        public void InitializeDbWithEmptyThrowsException()
        {
            var ex = Assert.Throws<InvalidOperationException>(() => new Database<int>());

            Assert.AreEqual("Invalid input", ex.Message);
        }

        [Test]
        public void InitializeDbWithNullThrowsException()
        {
            var ex = Assert.Throws<InvalidOperationException>(() => new Database<int>(null));

            Assert.AreEqual("Invalid input", ex.Message);
        }

        [Test]
        public void InitializeDbWithMoreThanCapacityThrowsExeption()
        {
            var ex = Assert.Throws<InvalidOperationException>(() => new Database<int>(this.sampleDataInvalidCapacity));

            Assert.AreEqual("Invalid input", ex.Message);
        }

        [Test]
        public void InitializeDbWithValidCapacity()
        {
            Assert.AreEqual(this.sampleData.Length, this.db.Count, "Capacity is different");
        }

        [Test]
        public void DbElementsCheckParameterEquality()
        {
            Assert.AreEqual(this.sampleData, this.db.Items.Take(this.sampleData.Length), "They are not the same");
        }

        [Test]
        public void DbAddElement()
        {
            this.db.Add(6);

            Assert.AreEqual(this.sampleData.Length+1, this.db.Count, "Not equal");
        }

        [Test]
        public void DbAddMultipleElements()
        {
            this.db.Add(6);
            this.db.Add(6);
            this.db.Add(6);
            this.db.Add(6);

            Assert.AreEqual(this.sampleData.Length + 4, this.db.Count, "Not equal");
        }

        [Test]
        [TestCase(16)]
        public void DbAddElementsMoreThanMaxCapacity(int capacity)
        {
            for (int i = 0; i < capacity - this.sampleData.Length; i++)
            {
                this.db.Add(6);
            }

            var ex = Assert.Throws<InvalidOperationException>(() => this.db.Add(1), "Trying to add more elements than the capacity");

            Assert.AreEqual("Items already reached max capacity", ex.Message, "Messages doesn't match");
        }
    }
}
