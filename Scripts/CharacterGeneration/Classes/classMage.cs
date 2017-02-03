using System.Collections;
using UnityEngine;

/// <summary>==================================================
/// Description Here
/// </summary>=================================================

public class classMage : baseClasses
{
    public classMage()
    {
        ClassName = "Mage";
        ClassDescrition = "The mage class.";

        HealthBonus = 4;
        MagicBonus = 10;
        StrengthBonus = 2;
        AgilityBonus = 2;
        IntelligenceBonus = 5;
        AttackBonus = new int[] { };
        ResistanceBonus = new int[] { };
        ReflexBonus = new int[] { };
        WillBonus = new int[] { };

        PassiveClassAbilities = new int[] { };
        ActiveClassAbilities = new int[] { };
    }
}