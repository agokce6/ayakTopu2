using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void OnMoveLeft ();
    public static event OnMoveLeft onMoveLeft;
    public static void RaiseOnMoveLeft ()
    {
        if (onMoveLeft != null)
            onMoveLeft ();
    }

    public delegate void OnMoveRight ();
    public static event OnMoveRight onMoveRight;
    public static void RaiseOnMoveRight ()
    {
        if (onMoveRight != null)
            onMoveRight ();
    }
}