using UnityEngine;
using System.Collections;

public class PlatformController : MonoBehaviour {//controlls the platform under certain conditions
    public static PlatformController instance;//creates an instance of the class so it can be used in other scripts
    private Rigidbody2D rbplat;//rigidbody
    void Start()//once the scene starts
    {
        instance = this;//an instance of PLATcontroller is made and can now be used in all other scripts
        rbplat = GetComponent<Rigidbody2D>();//declares a rigidbody2d
    }

    public float platspeed =  0;//speed
    void FixedUpdate()
    {
        float moveVertical = Input.GetAxis("Vertical");//gets the input named Vertical and applies it to the object of this script


        Vector2 platmovement = new Vector2(0.0f, moveVertical);//vector movement in 2d  declared. no x axis
        rbplat.velocity = platmovement * platspeed;//velocity = the movement direction times the declared speed

    }
 

}
