using UnityEngine;
using System.Collections;

/// <summary>
/// Insert description here
/// </summary>

public class classRanger : baseClasses
{
    public classRanger()
    {
        ClassName = "Ranger";
        ClassDescrition = "The ranger class.";

        HealthBonus = 8;
        MagicBonus = 2;
        StrengthBonus = 3;
        AgilityBonus = 4;
        IntelligenceBonus = 3;
        AttackBonus = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        ResistanceBonus = new int[] { 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 11, 11, 12 };
        ReflexBonus = new int[] { 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 11, 11, 12 };
        WillBonus = new int[] { 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 5, 5, 6, 6, 6 };

        PassiveClassAbilities = new int[] { };
        ActiveClassAbilities = new int[] { };
    }

}
