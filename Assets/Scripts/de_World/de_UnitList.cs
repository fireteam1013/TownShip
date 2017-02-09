using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class de_UnitList : MonoBehaviour {


    List<GameObject> PlayerList = new List<GameObject>();
    List<GameObject> EnemyList = new List<GameObject>();
    List<GameObject> NeutralList = new List<GameObject>();


    public void SetUnitLists(GameObject X, string tag)
    {
        if(tag == "PlayerUnit")
        {
            PlayerList.Add(X);
        }
        if(tag == "EnemyUnit")
        {
            EnemyList.Add(X);
        }
        if(tag == "NeutralUnit")
        {
            NeutralList.Add(X);
        }
    }

}
