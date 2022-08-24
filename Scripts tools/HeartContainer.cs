using UnityEngine;

public class HeartContainer : MonoBehaviour
{
    public Player playerScript;
    
    void OnTriggerEnter2D (Collider2D col)
    {
        playerScript.lives += 1;
    }
}
