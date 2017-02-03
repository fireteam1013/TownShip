using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/// <summary>
/// Insert description here
/// </summary>

public class CC_Unit : MonoBehaviour
{
    [Header("Stats")]
    public float health;
    public float magic;
    public float strength;
    public float agility;
    public float intelligence;
    public float attack;
    public float resistance;
    public float reflex;
    public float will;


    
    float toHit;
    float damage;
    float defense;
    float dodge;
    float perception;
    float turnOrder;

    [Header("Equipment")]
    public float weaponBonus;
    public float armorBonus;

    public Text t_Health;
    public Text t_Magic;
    public Text t_Strength;
    public Text t_Agility;
    public Text t_Intelligence;
    public Text t_Attack;
    public Text t_Resistance;
    public Text t_Reflex;
    public Text t_Will;

    public Text t_ToHit;
    public Text t_Damage;
    public Text t_Defense;
    public Text t_Dodge;
    public Text t_Perception;
    public Text t_TurnOrder;

    public Text t_WeaponBonus;
    public Text t_ArmorBonus;

    public void ConfigureNumbers()
    {
        toHit = Random.Range(0, 20) + reflex + agility;
        damage = weaponBonus + strength + reflex;
        defense = armorBonus + resistance;
        dodge = agility + reflex;
        perception = 0;
        turnOrder = reflex;

        t_Health.text = "Health: " + health;

        t_Magic.text = "Magic: " + magic;
        t_Strength.text = "Strength: " + strength;
        t_Agility.text = "Agility: " + agility;
        t_Intelligence.text = "Intelligence: " + intelligence;
        t_Attack.text = "Attack: " + attack;
        t_Resistance.text = "Resistance: " + resistance;
        t_Reflex.text = "Reflex: " + reflex;
        t_Will.text = "Will: " + will;

        t_ToHit.text = "ToHit: " + toHit;
        t_Damage.text = "Damage: " + damage;
        t_Defense.text = "Defense: " + defense;
        t_Dodge.text = "Dodge: " + dodge;
        t_Perception.text = "Perception: " + perception;
        t_TurnOrder.text = "Turn Order: " + turnOrder;

        t_WeaponBonus.text = "Weapon Bonus: " + weaponBonus;
        t_ArmorBonus.text = "Armor Bonus: " + armorBonus;
    }
}
