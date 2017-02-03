using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class d_Node : MonoBehaviour {

    Vector2 pos;
    bool canMove;
    int mCost;

    public Vector2 Pos
    {
        get
        {
            return pos;
        }

        set
        {
            pos = value;
        }
    }

    public bool CanMove
    {
        get
        {
            return canMove;
        }

        set
        {
            canMove = value;
        }
    }

    public int MCost
    {
        get
        {
            return mCost;
        }

        set
        {
            mCost = value;
        }
    }
}
