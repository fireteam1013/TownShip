using UnityEngine;
using System.Collections;

/// <summary>
/// Insert description here
/// </summary>

public class unitCreation : MonoBehaviour
{
    public baseRace[] race =
        new baseRace[] {
        new raceNull(),
        new raceDwarf(),
        new raceElf(),
        new raceHalfling(),
        new raceHuman()
        };


    public baseClasses[] playerClass = new baseClasses[] {
        new classNull(),
        new class_Fighter(),
        new class_Mage(),
        new class_Ranger()
    };


    public baseRace selectedRace;
    public baseClasses selectedClass;

    public string givenName;
    public string surName;
    public string nickName;

    int level = 1;
    int health;
    int magic;
    int strength;
    int agility;
    int intelligence;

    int attack;
    int resistance;
    int reflex;
    int will;


    void Start()
    {
        selectedRace = race[0];
        selectedClass = playerClass[0];
    }

    public void SetRace(int r)
    {
        selectedRace = race[r];
    }

    public void SetClass(int c)
    {
        selectedClass = playerClass[c];
    }

    public void SetGivenName(string gn)
    {
        givenName = gn;
    }
    public void SetSurName(string sn)
    {
        surName = sn;
    }
    public void SetNickName(string nn)
    {
        nickName = nn;
    }

    void ConfigureStats()
    {
        health = selectedRace.BaseHealth + (selectedClass.HealthBonus * level);
        magic = selectedRace.BaseMagic + (selectedClass.MagicBonus * level);
        strength = selectedRace.BaseStrength + (selectedClass.StrengthBonus * level);
        agility = selectedRace.BaseAgility + (selectedClass.AgilityBonus * level);
        intelligence = selectedRace.BaseIntelligence + (selectedClass.IntelligenceBonus * level);

        attack = selectedClass.AttackBonus[level - 1];
        resistance = selectedRace.BaseResistance + selectedClass.ResistanceBonus[level - 1];
        reflex = selectedRace.BaseReflex + selectedClass.ReflexBonus[level - 1];
        will = selectedRace.BaseWill + selectedClass.WillBonus[level - 1];
    }

}
