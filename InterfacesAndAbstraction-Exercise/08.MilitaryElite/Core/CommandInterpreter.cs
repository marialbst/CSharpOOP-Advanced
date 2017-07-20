namespace _08.MilitaryElite.Core
{
    using Interfaces;
    using System.Collections.Generic;
    using System.Text;
    using Models;
    using System.Linq;
    using Enumerables;
    using System;

    public class CommandInterpreter
    {
        private ICollection<ISoldier> soldiers;
        private ICollection<IPrivate> privates;

        public CommandInterpreter()
        {
            this.soldiers = new List<ISoldier>();
            this.privates = new List<IPrivate>();
    }

        internal void AddPrivate(IList<string> parameters)
        {
            int id = int.Parse(parameters[0]);
            string firstName = parameters[1];
            string lastName = parameters[2];
            double salary = double.Parse(parameters[3]);
            IPrivate priv = new Private(id, firstName, lastName, salary);
            this.soldiers.Add(priv);
            this.privates.Add(priv);
        }

        internal void AddLeutenant(IList<string> parameters)
        {
            int id = int.Parse(parameters[0]);
            string firstName = parameters[1];
            string lastName = parameters[2];
            double salary = double.Parse(parameters[3]);
            ILeutenantGeneral ltGn = new LeutenantGeneral(id, firstName, lastName, salary);

            if (parameters.Count > 4)
            {
                AddPrivates(parameters.Skip(4).Select(int.Parse), ltGn);
            }
            this.soldiers.Add(ltGn);
        }

        internal void AddEngineer(IList<string> parameters)
        {
            int id = int.Parse(parameters[0]);
            string firstName = parameters[1];
            string lastName = parameters[2];
            double salary = double.Parse(parameters[3]);

            Corps corps;

            if (Enum.TryParse(parameters[4], false, out corps))
            {
                IEngineer eng = new Engineer(id, firstName, lastName, salary, corps);
                if (parameters.Count > 5)
                {
                    AddRepairs(eng, parameters.Skip(5).ToList());
                }
                soldiers.Add(eng);
            }
        }

        internal void AddCommando(IList<string> parameters)
        {
            int id = int.Parse(parameters[0]);
            string firstName = parameters[1];
            string lastName = parameters[2];
            double salary = double.Parse(parameters[3]);

            Corps corps;

            if (Enum.TryParse(parameters[4], false, out corps))
            {
                ICommando commando = new Commando(id, firstName, lastName, salary, corps);
                if (parameters.Count > 5)
                {
                    AddMissions(commando, parameters.Skip(5).ToList());
                }
                soldiers.Add(commando);
            }
        }

        private void AddMissions(ICommando commando, List<string> list)
        {
            for (int i = 0; i < list.Count; i+=2)
            {
                MissionState state;
                if(Enum.TryParse(list[i+1], false, out state))
                {
                    commando.Missions.Add(new Mission(list[i], state));
                }
            }
        }

        internal void AddSpy(IList<string> parameters)
        {
            int id = int.Parse(parameters[0]);
            string firstName = parameters[1];
            string lastName = parameters[2];
            int code = int.Parse(parameters[3]);

            soldiers.Add(new Spy(id, firstName, lastName, code));
        }

        internal string PrintSoldiers()
        {
            var sb = new StringBuilder();

            foreach (var soldier in this.soldiers)
            {
                sb.AppendLine(soldier.ToString());
            }

            return sb.ToString().Trim();
        }

        private void AddPrivates(IEnumerable<int> soldierIds, ILeutenantGeneral ltGn)
        {
            foreach (var sid in soldierIds)
            {
                ltGn.Privates.Add(privates.First(s => s.Id == sid));
            }
        }

        
        private void AddRepairs(IEngineer eng, List<string> paramas)
        {
            for (int i = 0; i < paramas.Count; i += 2)
            {
                eng.Repairs.Add(new Repair(paramas[i], int.Parse(paramas[i + 1])));
            }
        }
    }
}
