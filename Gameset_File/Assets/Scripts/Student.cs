using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Student : MonoBehaviour
{
    Rigidbody2D myrigidbody;

    [SerializeField]
    private float power;
    [SerializeField]
    Transform pos;
    [SerializeField]
    float checkRadius;
    [SerializeField]
    LayerMask islayer;

    Animator anim;

    public int jumpCount;


    public GameObject Canvas;


    int jumpCnt;

    bool isGround;
    private void Start() // Setting
    {
        myrigidbody = GetComponent<Rigidbody2D>();
        jumpCnt = jumpCount;
        anim = GetComponent<Animator>();


        Canvas.SetActive(false);
    }

    private void Update() // Jump
    {
        isGround = Physics2D.OverlapCircle(pos.position, checkRadius, islayer);

        if (isGround == true && Input.GetKeyDown(KeyCode.Space) && jumpCnt > 0)
        {
            myrigidbody.velocity = Vector2.up * power;
        }
        if (isGround == false && Input.GetKeyDown(KeyCode.Space) && jumpCnt > 0)
        {
            myrigidbody.velocity = Vector2.up * power;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            jumpCnt--;
        }
        if (isGround)
        {
            jumpCnt = jumpCount;
        }


        if (myrigidbody.velocity.normalized.x == 0)
        {
            anim.SetBool("Walking", false);
        }
        else
        {
            anim.SetBool("Walking", true);
        }


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Canvas.activeSelf)
            {
                Canvas.SetActive(false);
            }
            else
            {
                Canvas.SetActive(true);
            }
        }

    }

    private void FixedUpdate() // Move
    {
        float hor = Input.GetAxis("Horizontal");
        myrigidbody.velocity = new Vector2(hor * 7, myrigidbody.velocity.y);

        if (hor > 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else if (hor < 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }

}