using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baseClasses {

    private string className;
    private string classDescrition;

    private int healthBonus;
    private int magicBonus;
    private int strengthBonus;
    private int agilityBonus;
    private int intelligenceBonus;
    private int[] attackBonus;
    private int[] resistanceBonus;
    private int[] reflexBonus;
    private int[] willBonus;

    private int[] passiveClassAbilities;
    private int[] activeClassAbilities;

    #region Encapsulation
    public string ClassName
    {
        get
        {
            return className;
        }

        set
        {
            className = value;
        }
    }

    public string ClassDescrition
    {
        get
        {
            return classDescrition;
        }

        set
        {
            classDescrition = value;
        }
    }

    public int HealthBonus
    {
        get
        {
            return healthBonus;
        }

        set
        {
            healthBonus = value;
        }
    }

    public int MagicBonus
    {
        get
        {
            return magicBonus;
        }

        set
        {
            magicBonus = value;
        }
    }

    public int StrengthBonus
    {
        get
        {
            return strengthBonus;
        }

        set
        {
            strengthBonus = value;
        }
    }

    public int AgilityBonus
    {
        get
        {
            return agilityBonus;
        }

        set
        {
            agilityBonus = value;
        }
    }

    public int IntelligenceBonus
    {
        get
        {
            return intelligenceBonus;
        }

        set
        {
            intelligenceBonus = value;
        }
    }

    public int[] AttackBonus
    {
        get
        {
            return attackBonus;
        }

        set
        {
            attackBonus = value;
        }
    }

    public int[] ResistanceBonus
    {
        get
        {
            return resistanceBonus;
        }

        set
        {
            resistanceBonus = value;
        }
    }

    public int[] ReflexBonus
    {
        get
        {
            return reflexBonus;
        }

        set
        {
            reflexBonus = value;
        }
    }

    public int[] WillBonus
    {
        get
        {
            return willBonus;
        }

        set
        {
            willBonus = value;
        }
    }

    public int[] PassiveClassAbilities
    {
        get
        {
            return passiveClassAbilities;
        }

        set
        {
            passiveClassAbilities = value;
        }
    }

    public int[] ActiveClassAbilities
    {
        get
        {
            return activeClassAbilities;
        }

        set
        {
            activeClassAbilities = value;
        }
    }
    #endregion
}
