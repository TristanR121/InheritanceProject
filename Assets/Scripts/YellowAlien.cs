using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowAlien : Alien
{
    public override void DestroyAlien()
    {
        base.DestroyAlien();
        Debug.Log("You gained 10 points!");
    }
}
    