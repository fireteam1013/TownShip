using UnityEngine;
using System.Collections;

/// <summary>
/// Insert description here
/// </summary>

public class baseWeapon : MonoBehaviour
{
    public enum weaponType { shortsword, longsword, club, axe, spear, warhammer, shortbow, longbow};
    weaponType w_Type;
    public enum attackTypes { blunt, slashing, piercing, magic};
    attackTypes[] a_Type;

    private string weaponName;
    private string weaponDescription;

    private int rangeMin;
    private int rangeMax;

    private int damageMin;
    private int damageMax;

    private int levelRequirement;
    private int strengthRequirement;
    private int agilityRequirement;

    private int[] passiveAbility;
    private int[] activeAbility;


    #region Encapsulation
    public string WeaponName
    {
        get
        {
            return weaponName;
        }

        set
        {
            weaponName = value;
        }
    }

    public string WeaponDescription
    {
        get
        {
            return weaponDescription;
        }

        set
        {
            weaponDescription = value;
        }
    }

    public int RangeMin
    {
        get
        {
            return rangeMin;
        }

        set
        {
            rangeMin = value;
        }
    }

    public int RangeMax
    {
        get
        {
            return rangeMax;
        }

        set
        {
            rangeMax = value;
        }
    }

    public int DamageMin
    {
        get
        {
            return damageMin;
        }

        set
        {
            damageMin = value;
        }
    }

    public int DamageMax
    {
        get
        {
            return damageMax;
        }

        set
        {
            damageMax = value;
        }
    }

    public int LevelRequirement
    {
        get
        {
            return levelRequirement;
        }

        set
        {
            levelRequirement = value;
        }
    }

    public int StrengthRequirement
    {
        get
        {
            return strengthRequirement;
        }

        set
        {
            strengthRequirement = value;
        }
    }

    public int AgilityRequirement
    {
        get
        {
            return agilityRequirement;
        }

        set
        {
            agilityRequirement = value;
        }
    }

    public int[] PassiveAbility
    {
        get
        {
            return passiveAbility;
        }

        set
        {
            passiveAbility = value;
        }
    }

    public int[] ActiveAbility
    {
        get
        {
            return activeAbility;
        }

        set
        {
            activeAbility = value;
        }
    }
    #endregion
}
