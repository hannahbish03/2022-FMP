using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;
    
    
    
    // Start is called before the first frame update
    void Start()
    {    
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Enenmy damage code
    public void HurtPlayer(int damage) {

        currentHealth -= damage;

        Debug.Log("load Game: " + currentHealth);

        if (currentHealth <= 0)
        {
            Respawn();
        }
    }

    public void HealPlayer(int healAmount) {
       
        
        currentHealth += healAmount;

        if (currentHealth > maxHealth) {

            currentHealth = maxHealth;

        }
    
    
    }

 
    void Respawn()
    {
       
        SceneManager.LoadScene("Game");
    }
}
