using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotherShip : Alien
{
    public int Uses;

    public override void DestroyAlien()
    {
        Uses--;
        if (Uses >= 0)
        {
            Debug.Log("The Mothership's defenses weaken.");
        }
        else
        {
            Debug.Log("The Mothership has been destroyed!");
            Destroy(this.gameObject);
        }
    }
}
