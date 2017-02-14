using UnityEngine;
using System.Collections;

/// <summary>
/// Insert description here
/// </summary>

public class baseRace
{
    private string raceName;
    private string raceDescription;

    private int baseHealth;
    private int minHealthInc;
    private int maxHealthInc;

    private int baseMagic;
    private int minMagicInc;
    private int maxMagicInc;

    private int baseStrength;
    private int minStrengthInc;
    private int maxStrengthInc;

    private int baseAgility;
    private int minAgilityInc;
    private int maxAgilityInc;

    private int baseIntelligence;
    private int minIntelligenceInc;
    private int maxIntelligenceInc;

    private int baseResistance;
    private int minResistanceInc;
    private int maxResistanceInc;

    private int baseReflex;
    private int minReflexInc;
    private int maxReflexInc;

    private int baseWill;
    private int minWillInc;
    private int maxWillInc;

    private int[] passiveRaceAbilities;
    private int[] activeRaceAbilities;

    #region Encapsulation
    public string RaceName
    {
        get
        {
            return raceName;
        }

        set
        {
            raceName = value;
        }
    }

    public string RaceDescription
    {
        get
        {
            return raceDescription;
        }

        set
        {
            raceDescription = value;
        }
    }

    public int BaseHealth
    {
        get
        {
            return baseHealth;
        }

        set
        {
            baseHealth = value;
        }
    }

    public int MinHealthInc
    {
        get
        {
            return minHealthInc;
        }

        set
        {
            minHealthInc = value;
        }
    }

    public int MaxHealthInc
    {
        get
        {
            return maxHealthInc;
        }

        set
        {
            maxHealthInc = value;
        }
    }

    public int BaseMagic
    {
        get
        {
            return baseMagic;
        }

        set
        {
            baseMagic = value;
        }
    }

    public int MinMagicInc
    {
        get
        {
            return minMagicInc;
        }

        set
        {
            minMagicInc = value;
        }
    }

    public int MaxMagicInc
    {
        get
        {
            return maxMagicInc;
        }

        set
        {
            maxMagicInc = value;
        }
    }

    public int BaseStrength
    {
        get
        {
            return baseStrength;
        }

        set
        {
            baseStrength = value;
        }
    }

    public int MinStrengthInc
    {
        get
        {
            return minStrengthInc;
        }

        set
        {
            minStrengthInc = value;
        }
    }

    public int MaxStrengthInc
    {
        get
        {
            return maxStrengthInc;
        }

        set
        {
            maxStrengthInc = value;
        }
    }

    public int BaseAgility
    {
        get
        {
            return baseAgility;
        }

        set
        {
            baseAgility = value;
        }
    }

    public int MinAgilityInc
    {
        get
        {
            return minAgilityInc;
        }

        set
        {
            minAgilityInc = value;
        }
    }

    public int MaxAgilityInc
    {
        get
        {
            return maxAgilityInc;
        }

        set
        {
            maxAgilityInc = value;
        }
    }

    public int BaseIntelligence
    {
        get
        {
            return baseIntelligence;
        }

        set
        {
            baseIntelligence = value;
        }
    }

    public int MinIntelligenceInc
    {
        get
        {
            return minIntelligenceInc;
        }

        set
        {
            minIntelligenceInc = value;
        }
    }

    public int MaxIntelligenceInc
    {
        get
        {
            return maxIntelligenceInc;
        }

        set
        {
            maxIntelligenceInc = value;
        }
    }

    public int BaseResistance
    {
        get
        {
            return baseResistance;
        }

        set
        {
            baseResistance = value;
        }
    }

    public int MinResistanceInc
    {
        get
        {
            return minResistanceInc;
        }

        set
        {
            minResistanceInc = value;
        }
    }

    public int MaxResistanceInc
    {
        get
        {
            return maxResistanceInc;
        }

        set
        {
            maxResistanceInc = value;
        }
    }

    public int BaseReflex
    {
        get
        {
            return baseReflex;
        }

        set
        {
            baseReflex = value;
        }
    }

    public int MinReflexInc
    {
        get
        {
            return minReflexInc;
        }

        set
        {
            minReflexInc = value;
        }
    }

    public int MaxReflexInc
    {
        get
        {
            return maxReflexInc;
        }

        set
        {
            maxReflexInc = value;
        }
    }

    public int BaseWill
    {
        get
        {
            return baseWill;
        }

        set
        {
            baseWill = value;
        }
    }

    public int MinWillInc
    {
        get
        {
            return minWillInc;
        }

        set
        {
            minWillInc = value;
        }
    }

    public int MaxWillInc
    {
        get
        {
            return maxWillInc;
        }

        set
        {
            maxWillInc = value;
        }
    }

    public int[] PassiveRaceAbilities
    {
        get
        {
            return passiveRaceAbilities;
        }

        set
        {
            passiveRaceAbilities = value;
        }
    }

    public int[] ActiveRaceAbilities
    {
        get
        {
            return activeRaceAbilities;
        }

        set
        {
            activeRaceAbilities = value;
        }
    }
    #endregion
}