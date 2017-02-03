using UnityEngine;
using System.Collections;

/// <summary>
/// Insert description hereW
/// </summary>

public class raceHuman : baseRace
{
    public raceHuman()
    {
        RaceName = "Human";
        RaceDescription = "The most prolific race of the Alliance, humanity has spread to all corners of the world, inhabiting the plains, forest, and mountains of the land.  They are relatively short lived compared to the other races, but their short lives and adaptability have proven to be a major boon of the race.";

        BaseHealth = 4;
        BaseMagic = 0;
        BaseStrength = 4;
        BaseAgility = 4;
        BaseIntelligence = 4;

        BaseResistance = 2;
        BaseReflexes = 2;
        BaseWill = 2;
    }


}
