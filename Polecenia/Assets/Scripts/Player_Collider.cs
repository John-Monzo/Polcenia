using UnityEngine;
using System.Collections;

public class Player_Collider : MonoBehaviour {
    public float colourChangeDelay = 0.5f;//delay time for a color change
    float currentDelay = 0f;//delay it will take for the object to realize something is colliding with it

    public void OnTriggerStay2D(Collider2D  other)//if something collides with the mover
    {
        currentDelay = Time.time + colourChangeDelay;//time+color delay will make the object turn into a certain color when the following conditions are met
        if (other.gameObject.tag == "Player")//if the object colliding with the mover object has a player tag
        {
            HorizontalPlatformController.instance.Hplatspeed = 3;//Hplatform(i) speed is set to three. Think of it as putting key ignition to a car
            //ReverseHPLATcontroller.instance.Hplatspeedi = 3;
            Debug.Log("hello");//test to see if it is colliding
            transform.GetComponent<Renderer>().material.color = Color.yellow;//another color displays to show that the game player is colliding
        }
        
    }
    public void OnTriggerExit2D(Collider2D other)//when an object leaves the mover 
    {
        if (other.gameObject.tag == "Player")// and that object is the player
        {
            HorizontalPlatformController.instance.Hplatspeed = 0;//speed is set back to 0. the key is out of the ingition
            //ReverseHPLATcontroller.instance.Hplatspeedi = 0;
            Debug.Log("good");//test
            transform.GetComponent<Renderer>().material.color = Color.black;//shows that the player is no longer in the object mover space
        }
    }
 

}
