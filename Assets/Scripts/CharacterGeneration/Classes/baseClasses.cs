using System.Collections;
using UnityEngine;

public class baseClasses {

    private string className;
    private string classDescrition;

    private int minHealthInc;
    private int maxHealthInc;

    private int minMagicInc;
    private int maxMagicInc;

    private int minStrengthInc;
    private int maxStrengthInc;

    private int minAgilityInc;
    private int maxAgilityInc;

    private int minIntelligenceInc;
    private int maxIntelligenceInc;

    private int minResistanceInc;
    private int maxResistanceInc;

    private int minReflexInc;
    private int maxReflexInc;

    private int minWillInc;
    private int maxWillInc;

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
