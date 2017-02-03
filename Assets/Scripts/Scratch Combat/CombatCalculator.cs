using UnityEngine;
using System.Collections;

/// <summary>
/// Insert description here
/// </summary>

public class CombatCalculator : MonoBehaviour
{

    public CC_Unit unit1;
    public CC_Unit unit2;


    public void Check()
    {
        unit1.ConfigureNumbers();
        unit2.ConfigureNumbers();
    }

}
