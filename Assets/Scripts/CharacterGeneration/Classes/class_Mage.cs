using System.Collections;
using UnityEngine;

/// <summary>==================================================
/// Description Here
/// </summary>=================================================

public class class_Mage : baseClasses
{
    public class_Mage()
    {
        ClassName = "Mage";
        ClassDescrition = "The mage class.";

        MinHealthInc = 0;
        MaxHealthInc = 0;

        MinMagicInc = 0;
        MaxMagicInc = 0;

        MinStrengthInc = 0;
        MaxStrengthInc = 0;

        MinAgilityInc = 0;
        MaxAgilityInc = 0;

        MinIntelligenceInc = 0;
        MaxIntelligenceInc = 0;

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