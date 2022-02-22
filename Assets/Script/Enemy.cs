using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform Spawnpoint;
    public UI board;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            
            Instantiate(gameObject,Spawnpoint.position,Spawnpoint.rotation);
            Destroy(gameObject);
            board.score= board.score+1;
        }
        print(other);
    }
}
