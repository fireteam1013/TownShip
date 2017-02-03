using System.Collections;
using UnityEngine;

/// <summary>==================================================
/// Description Here
/// </summary>=================================================

public class Node : MonoBehaviour
{
    Vector2 position;
    int movementCost;
    bool canMove;

    public Vector2 Position
    {
        get
        {
            return position;
        }

        set
        {
            position = value;
        }
    }

    public int MovementCost
    {
        get
        {
            return movementCost;
        }

        set
        {
            movementCost = value;
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
}