using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    // back button
    public void BackButtonGame()
    {

        SceneManager.LoadScene("Menu");

    }
}


