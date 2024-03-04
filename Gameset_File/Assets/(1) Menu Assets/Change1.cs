using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change1 : MonoBehaviour
{
    void start()
    {

    }

    void Update()
    {

    }

    public void ChangeGameScene()
    {
        SceneManager.LoadScene("Game2");
    }
}
