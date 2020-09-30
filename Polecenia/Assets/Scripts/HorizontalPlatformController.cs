using UnityEngine;
using System.Collections;
using System;

public class HorizontalPlatformController : MonoBehaviour {
    public static HorizontalPlatformController instance;//creates an instance of the class so it can be used in other scripts
    private Rigidbody2D rbHplat;//rigidbody
  
    void Start()//once the scene starts
    {
        instance = this;//an instance of ReverseHPLATcontroller is made and can now be used in all other scripts
        rbHplat = GetComponent<Rigidbody2D>();//declares a rigidbody2d
    }

    public float Hplatspeed=0;//speed
    void OnCollisionEnter2D(Collision2D coll)//when the object collides with something
    {
        if (coll.transform.tag == "Player")//specifically the player tagged object
        {
            GetComponent<Rigidbody2D>().isKinematic = false;//the object is no longer kinematic
        }
        
    }
   
    void FixedUpdate()
    {
        
        float movePlatHorizontal = Input.GetAxis("PlatHorizontal");//gets the input named PlatHorizontal and applies it to the object of this script


        Vector2 Hplatmovement = new Vector2(movePlatHorizontal, 0.0f);//vector movement in 2d  declared. no y axis
        rbHplat.velocity = Hplatmovement * Hplatspeed;//velocity = the movement direction times the declared speed
    }

    }


   

    




