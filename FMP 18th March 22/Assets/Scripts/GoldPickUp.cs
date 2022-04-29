using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldPickUp : MonoBehaviour
{
    public SoundManager sm;

    public int value;
    
    // Start is called before the first frame update
    void Start()
    {
        sm = FindObjectOfType<SoundManager>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {

            FindObjectOfType<GameManager>().AddGold(value);
          
            sm.Playcoin();
            Destroy(gameObject); 
        }



    }


}