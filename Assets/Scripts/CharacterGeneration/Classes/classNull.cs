using UnityEngine;
using System.Collections;

/// <summary>
/// Insert description here
/// </summary>

public class classNull : baseClasses
{
    public classNull()
    {
        ClassName = "Null";
        ClassDescrition = "Null Class.";

        MinHealthInc = 2;
        MaxHealthInc = 6;

        MinMagicInc = 0;
        MaxMagicInc = 0;

        MinStrengthInc = 2;
        MaxStrengthInc = 4;

        MinAgilityInc = 0;
        MaxAgilityInc = 4;

        MinIntelligenceInc = 0;
        MaxIntelligenceInc = 3;

        MinResistanceInc = 0;
        MaxResistanceInc = 0;

        MinReflexInc = 0;
        MaxReflexInc = 0;

        MinWillInc = 0;
        MaxWillInc = 0;

        PassiveClassAbilities = new int[] { };
        ActiveClassAbilities = new int[] { };
    }
}
