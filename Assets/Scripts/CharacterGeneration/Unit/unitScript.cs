using UnityEngine;
using System.Collections;

/// <summary>
/// Insert description here
/// </summary>

public class unitScript : MonoBehaviour
{
    baseRace unitRace;
    baseClasses unitClass;

    int u_Level;
    int u_Experience;

    string u_GivenName;
    string u_SurName;
    string u_NickName;

    int u_CurrentHealth;
    int u_MaxHealth;

    int u_CurrentMagic;
    int u_MaxMagic;

    int u_Strength;
    int u_Agility;
    int u_Intelligence;

    int u_Resistance;
    int u_Reflex;
    int u_Will;

    int u_Attack;
    int u_MAttack;

    int u_Defense;
    int u_Dodge;
    int u_MDefense;

    int u_Movement;

    baseWeapon u_RightHand;
    baseWeapon u_LeftHand;


    void ConfigureStats()
    {

    }



    void LevelUp()
    {
        u_Level++;

        StatIncrease(u_MaxHealth, unitRace.MinHealthInc, unitRace.MaxHealthInc, unitClass.MinHealthInc, unitClass.MaxHealthInc);
        StatIncrease(u_MaxMagic, unitRace.MinMagicInc, unitRace.MaxMagicInc, unitClass.MinMagicInc, unitClass.MaxMagicInc);
        StatIncrease(u_Strength, unitRace.MinStrengthInc, unitRace.MaxStrengthInc, unitClass.MinStrengthInc, unitClass.MaxStrengthInc);
        StatIncrease(u_Agility, unitRace.MinAgilityInc, unitRace.MaxAgilityInc, unitClass.MinAgilityInc, unitClass.MaxAgilityInc);
        StatIncrease(u_Intelligence, unitRace.MinIntelligenceInc, unitRace.MaxIntelligenceInc, unitClass.MinIntelligenceInc, unitClass.MaxIntelligenceInc);
        StatIncrease(u_Resistance, unitRace.MinResistanceInc, unitRace.MaxResistanceInc, unitClass.MinResistanceInc, unitClass.MaxResistanceInc);
        StatIncrease(u_Reflex, unitRace.MinReflexInc, unitRace.MaxReflexInc, unitClass.MinReflexInc, unitClass.MaxReflexInc);
        StatIncrease(u_Will, unitRace.MinWillInc, unitRace.MaxWillInc, unitClass.MinWillInc, unitClass.MaxWillInc);
    }



    void StatIncrease(int stat, int minIncrease, int maxIncrease, int cMinIncrease, int cMaxIncrease)
    {
        int _raceAmount = 0;

        if (u_Level <= 5)
        {
            int _randomAmount1 = Random.Range(minIncrease, maxIncrease);
            int _randomAmount2 = Random.Range(minIncrease, maxIncrease);
            int _randomAmount3 = Random.Range(minIncrease, maxIncrease);
            _raceAmount = Mathf.FloorToInt((_randomAmount1 + _randomAmount2 + _randomAmount3) / 3);
        }

        int _randomClass1 = Random.Range(cMinIncrease, cMaxIncrease);
        int _randomClass2 = Random.Range(cMinIncrease, cMaxIncrease);
        int _randomClass3 = Random.Range(cMinIncrease, cMaxIncrease);
        int _classAmount = Mathf.FloorToInt((_randomClass1 + _randomClass2 + _randomClass3) / 3);

        stat += _raceAmount + _classAmount;
    }
}
