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
        RaceDescription = "Goblin Description";

        BaseHealth = 6;
        MinHealthInc = 1;
        MaxHealthInc = 4;

        BaseMagic = 2;
        MinMagicInc = 0;
        MaxMagicInc = 2;

        BaseStrength = 6;
        MinStrengthInc = 2;
        MaxStrengthInc = 4;

        BaseAgility = 2;
        MinAgilityInc = 0;
        MaxAgilityInc = 3;

        BaseIntelligence = 2;
        MinIntelligenceInc = 0;
        MaxIntelligenceInc = 2;

        BaseResistance = 6;
        MinResistanceInc = 2;
        MaxResistanceInc = 4;

        BaseReflex = 2;
        MinReflexInc = 0;
        MaxReflexInc = 2;

        BaseWill = 6;
        MinWillInc = 2;
        MaxWillInc = 4;
    }


}
