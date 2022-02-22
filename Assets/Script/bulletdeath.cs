using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletdeath : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       Destroy(gameObject,3.5f); 
    }

    void OnTriggerEnter(Collider hitinfo)
    {
        //Debug.Log(hitinfo.name);
        Destroy(gameObject);
    }
    
}
