using UnityEngine;
using System.Collections;

public class ReverseHPLATcontroller : MonoBehaviour {//does the same thing HPlat does but in reverse
    public static ReverseHPLATcontroller instance;//creates an instance of the class so it can be used in other scripts
    private Rigidbody2D rbHplati;//rigidbody
    void Start()//once the scene starts
    {
        instance = this;//an instance of ReverseHPLATcontroller is made and can now be used in all other scripts
        rbHplati = GetComponent<Rigidbody2D>();//declares a rigidbody2d
    }

    public float Hplatspeedi;//speed(for inverse)
    void FixedUpdate()
    {
        float movePlatHorizontali = Input.GetAxis("inverse_PlatHorizontal");//gets the input named inverse_PlatHorizontal and applies it to the object of this script


        Vector2 Hplatmovementi = new Vector2(movePlatHorizontali, 0.0f);//vector movement in 2d  declared. no y axis
        rbHplati.velocity = Hplatmovementi * Hplatspeedi;//velocity = the movement direction times the declared speed

    }
    void OnCollisionEnter2D(Collision2D coll)//when the object collides with something
    {
        if (coll.transform.tag == "Player")//specifically the player tagged object
        {
            GetComponent<Rigidbody2D>().isKinematic = false;//the object is no longer kinematic
        }

    }

    
    

}
