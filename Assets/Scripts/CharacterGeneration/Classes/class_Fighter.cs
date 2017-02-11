using UnityEngine;
using System.Collections;

/// <summary>
/// Insert description here
/// </summary>

public class class_Fighter : baseClasses
{
    public class_Fighter()
    {
        ClassName = "Fighter";
        ClassDescrition = "The fighter class.";

        HealthBonus = 10;
        MagicBonus = 0;
        StrengthBonus = 4;
        AgilityBonus = 3;
        IntelligenceBonus = 2;
        AttackBonus = new int[] { };
        ResistanceBonus = new int[] { };
        ReflexBonus = new int[] { };
        WillBonus = new int[] { };

        PassiveClassAbilities = new int[] { };
        ActiveClassAbilities = new int[] { };
    }
}
