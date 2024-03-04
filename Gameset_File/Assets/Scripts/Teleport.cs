using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    public string Field;

    void Start()
    {

    }
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                SceneManager.LoadScene(Field);
            }
        }
    }
}