using UnityEngine;
using System.Collections;

/// <summary>
/// Insert description here
/// </summary>

public class raceOrc : baseRace
{
    public raceOrc()
    {
        RaceName = "Orc";
        RaceDescription = "A savage race in the land.  Orcs are a tribal race who has no central government.";

        BaseHealth = 8;
        BaseMagic = 2;
        BaseStrength = 8;
        BaseAgility = 0;
        BaseIntelligence = 0;

        BaseResistance = 4;
        BaseReflexes = 0;
        BaseWill = 0;
    }

}
