using UnityEngine;
using System.Collections;

/// <summary>
/// Insert description here
/// </summary>

public class ironSword : baseWeapon
{
    public ironSword()
    {
        weaponType w_type = weaponType.shortsword;
        attackTypes[] a_Type = new attackTypes[] { attackTypes.piercing, attackTypes.slashing};

        WeaponName = "Iron Sword";
        WeaponDescription = "A simple sword of iron.  A basic weapon of footsoldiers, and sellswords.";

        RangeMin = 1;
        RangeMax = 1;

        DamageMin = 6;
        DamageMax = 10;

        LevelRequirement = 1;
        StrengthRequirement = 3;
        AgilityRequirement = 2;

        //PassiveAbility;
        //ActiveAbility;
        
    }

}
