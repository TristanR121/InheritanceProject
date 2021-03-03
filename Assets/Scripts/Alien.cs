using UnityEngine;

public class Alien : MonoBehaviour
{
    public string Name;
    public int Points;
    public bool Destroyable;

    private void OnMouseDown()
    {
        
    }

    public virtual void DestroyAlien()
    {
        Debug.Log("You Destroyed " + Name);
        if (Destroyable)
        {
            Destroy(this.gameObject);
        }
    }

}
