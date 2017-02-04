using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class d_Node {

    Vector2 pos;
    bool canMove = true;
    int mCost = 0;

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
