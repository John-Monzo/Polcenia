using UnityEngine;
using System.Collections;

public class PlayerCollider2b : MonoBehaviour {
    public float colourChangeDelay = 0.5f;
    float currentDelay = 0f;

    public void OnTriggerStay2D(Collider2D other)
    {

        currentDelay = Time.time + colourChangeDelay;
        if (other.gameObject.tag == "Player")
        {
         
            ReverseHPLATcontroller.instance.Hplatspeedi = 3;
            Debug.Log("hello");
            transform.GetComponent<Renderer>().material.color = Color.yellow;
        }

    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
          
            ReverseHPLATcontroller.instance.Hplatspeedi = 0;
            Debug.Log("good");
            transform.GetComponent<Renderer>().material.color = Color.black;
        }
    }


}
