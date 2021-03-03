using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenAlien : Alien
{
    public override void DestroyAlien()
    {
        base.DestroyAlien();
        Debug.Log("You gained 5 points!");
    }
}
