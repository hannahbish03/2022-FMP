using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
   public float jumpForce;
  
   public float knockBackForce;
   public float knockBackTime;
   private float knockBackCounter;
   private Vector3 moveDirection;
   

    // Start is called before the first frame update
    void Start()
    {



        //Update is called once per frame

        void Update()
        {
            if (knockBackCounter <= 0)
            {


                moveDirection.y = jumpForce;

            }


            else
            {

                knockBackCounter -= Time.deltaTime;

            }

        }
         
        
        void knockBack()
        {

            knockBackCounter = knockBackTime;

        }


    }


   // void TakeDamage(int damage)
   // {
     //   currentHealth -= damage;
    //    healthBar.SetHealth(currentHealth);
     //   if (currentHealth <= 0)
      //  {
    //        Respawn();
   //  //   }
   // }
   // void Respawn()
  //  {
 //       // reload scene
  //      // or other respawn mechanic
   // }






}