using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class lvlsct : MonoBehaviour {//script for the level select screen

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {//every fram
        if (Input.GetKey(KeyCode.Alpha1))//if 1 is pressed 
        {
            SceneManager.LoadScene(1);// the game moves to scene 1
        }
       else if (Input.GetKey(KeyCode.Alpha2))//if 2 is pressed
        {
            SceneManager.LoadScene(2);// the game moves to scene 2
        }
       else if (Input.GetKey(KeyCode.Alpha3))//if 3 is pressed
        {
            SceneManager.LoadScene(3);// the game moves to scene 3
        }
       else if (Input.GetKey(KeyCode.Alpha4))//if 4 is pressed
        {
            SceneManager.LoadScene(4);// the game moves to scene 4
        }
    }
}
