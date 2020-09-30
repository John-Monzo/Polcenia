using UnityEngine;
using System.Collections;

public class killer : MonoBehaviour {//delets player from the field of play

    void OnCollisionEnter(Collision other)//when an object collides with something
    {
        if (other.gameObject.tag == "Player")//and that something is with a player tag
        {
            Destroy(other.gameObject);//destroy the game object from play. the player will need to hit r to restart.
        }
    }
}
