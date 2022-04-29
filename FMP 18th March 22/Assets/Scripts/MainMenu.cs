using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
     //Play button code 
    public void PlayButton()
    {

        SceneManager.LoadScene("Game");
    }
}
