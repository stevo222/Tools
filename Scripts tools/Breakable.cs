using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour
{

    public GameObject destroyedVersion;
    // Start is called before the first frame update
    void OnMouseDown ()

    {
        Instantiate(destroyedVersion, transform.position, transform.rotation);
            Destroy(gameObject);
    }

 
}
