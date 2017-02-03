using UnityEngine;
using System.Collections;

/// <summary>
/// Insert description here
/// </summary>

public class raceGoblin : baseRace
{
    public raceGoblin()
    {
        RaceName = "Goblin";
        RaceDescription = "Add description.";

        BaseHealth = 2;
        BaseMagic = 2;
        BaseStrength = 2;
        BaseAgility = 6;
        BaseIntelligence = 2;

        BaseResistance = 2;
        BaseReflexes = 4;
        BaseWill = 2;
    }


}
