using UnityEngine;
using System.Collections;

/// <summary>
/// Insert description here
/// </summary>

public class baseFootwear : MonoBehaviour
{
    enum armorType { light, medium, heavy }
    armorType a_Type;

    private string armorName;
    private string armorDescription;

    private int armorBonus;
    private int strengthRequirement;
    private int reflexMod;
    private int willMod;
    private int passiveAbility;
    private int activeAbility;
}
