using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public GameObject Canvas;

    Animator anim;
   


    void Start()
    {
        Canvas.SetActive(false);
        anim = GetComponent<Animator>();
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        

        if (Input.GetKeyDown(KeyCode.F))
        {
            if (Canvas.activeSelf)
            {
                Canvas.SetActive(false);
                anim.SetBool("boxer", false);
            }

            else
            {
                Canvas.SetActive(true);
                anim.SetBool("boxer", true);
            }

        }  
    }

}
