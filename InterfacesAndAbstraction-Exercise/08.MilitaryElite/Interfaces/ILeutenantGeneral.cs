﻿namespace _08.MilitaryElite.Interfaces
{
    using System.Collections.Generic;

    public interface ILeutenantGeneral : IPrivate
    {
        ICollection<IPrivate> Privates { get; }
    }
}
