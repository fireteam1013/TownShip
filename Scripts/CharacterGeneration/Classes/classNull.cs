using UnityEngine;
using System.Collections;

/// <summary>
/// Insert description here
/// </summary>

public class classNull : baseClasses
{
    public classNull()
    {
        ClassName = "";
        ClassDescrition = "";

        HealthBonus = 0;
        MagicBonus = 0;
        StrengthBonus = 0;
        AgilityBonus = 0;
        IntelligenceBonus = 0;
        AttackBonus = new int[] { };
        ResistanceBonus = new int[] { };
        ReflexBonus = new int[] { };
        WillBonus = new int[] { };

        PassiveClassAbilities = new int[] { };
        ActiveClassAbilities = new int[] { };
    }
}
