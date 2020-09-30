using UnityEngine;
using System.Collections;

public class PlayercolliderA : MonoBehaviour {

    public float colourChangeDelay = 0.5f;
    float currentDelay = 0f;

    public void OnTriggerStay2D(Collider2D other)
    {

        currentDelay = Time.time + colourChangeDelay;
        if (other.gameObject.tag == "Player")
        {
           
            ReversePlatController.instance.platspeedr = 3;
            Debug.Log("hello");
            transform.GetComponent<Renderer>().material.color = Color.red;
        }

    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            
            ReversePlatController.instance.platspeedr = 0;
            Debug.Log("good");
            transform.GetComponent<Renderer>().material.color = Color.black;
        }
    }
}
