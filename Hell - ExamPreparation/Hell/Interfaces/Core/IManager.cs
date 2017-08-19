﻿using System.Collections.Generic;

public interface IManager
{
    string AddHero(IList<string> arguments);
    string AddItemToHero(IList<string> arguments);
    string Inspect(IList<string> arguments);
    string Quit();
    string AddRecipeToHero(IList<string> argsList);
}