using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class printwin : MonoBehaviour {//will print a win statement
  
    void OnTriggerEnter2D(Collider2D coll)//when something collides with the object(door)...
    {
        if (coll.gameObject.CompareTag ("Player"))//specifically if the player collides with the door...
        {
            SceneManager.LoadScene(0);// the game moves to scene 0
            Debug.Log("test");//testing to see if the collision was being picked up
        }


}
}
