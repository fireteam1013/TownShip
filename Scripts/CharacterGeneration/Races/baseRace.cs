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
    private int baseMagic;
    private int baseStrength;
    private int baseAgility;
    private int baseIntelligence;

    private int baseResistance;
    private int baseReflexes;
    private int baseWill;

    private int[] passiveRaceAbilities;
    private int[] activeRaceAbilities;

    #region Encapulation
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

    public int BaseReflexes
    {
        get
        {
            return baseReflexes;
        }

        set
        {
            baseReflexes = value;
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
