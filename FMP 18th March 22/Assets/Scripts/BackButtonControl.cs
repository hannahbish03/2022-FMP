using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonControl: MonoBehaviour
{
    public void BackButtonControls()
    {
        // Back button code
        SceneManager.LoadScene("Menu");

    }
}

