namespace _03BarracksFactory.Core.Factories
{
    using Contracts;
    using System;

    public class UnitFactory : IUnitFactory
    {
        private string nameSpace = "_03BarracksFactory.Models.Units.";

        public IUnit CreateUnit(string unitType)
        {
            //Problem 3
            Type desirableUnitType = Type.GetType(this.nameSpace + unitType);
            return (IUnit)Activator.CreateInstance(desirableUnitType);
        }
    }
}
