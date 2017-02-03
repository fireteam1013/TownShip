using UnityEngine;
using System.Collections;

/// <summary>
/// Insert description here
/// </summary>

public class raceElf : baseRace
{
    public raceElf()
    {
        RaceName = "Elf";
        RaceDescription = "Race Elf";

        BaseHealth = 2;
        BaseMagic = 4;
        BaseStrength = 2;
        BaseAgility = 6;
        BaseIntelligence = 6;

        BaseResistance = 6;
        BaseReflexes = 6;
        BaseWill = 6;
    }

}
