using UnityEngine;
using System.Collections;

public class ReversePlatController : MonoBehaviour//controlls the platform under certain conditions
{//NOTICE!!!!!!!!!!:REVERSE VPLATFORM IS NEVER USED HOWEVER AN OBJECT IS STILL IN THE FILES
    public static ReversePlatController instance;//creates an instance of the class so it can be used in other scripts
    private Rigidbody2D rbplatr;//rigidbody
    void Start()//once the scene starts
    {
        instance = this;//an instance of PLATcontroller is made and can now be used in all other scripts
        rbplatr = GetComponent<Rigidbody2D>();//declares a rigidbody2d
    }

    public float platspeedr = 0;//speed(reverse)
    void OnCollisionEnter2D(Collision2D coll)//when something collides with the object 
    {
        if (coll.transform.tag == "Player")//and it has player tag
        {
            GetComponent<Rigidbody2D>().isKinematic = false;//the object is not kinematic
        }

    }
    void FixedUpdate()
    {
        float moveVerticalr = Input.GetAxis("inverse_Plat");//gets the input named inverse_Plat and applies it to the object of this script


        Vector2 platmovementr = new Vector2(0.0f, moveVerticalr);//vector movement in 2d  declared. no x axis
        rbplatr.velocity = platmovementr * platspeedr;//velocity = the movement direction times the declared speed



    }
}

