using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghoster : MonoBehaviour
{
    public GameObject Ghost;

    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "pos")
        {
            Destroy(Ghost);
        }
    }


}
