using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;//gives acces to scenes in the build

public class nextlvl : MonoBehaviour
{//controlls how a player can manage their level

    void Update()
    {
        if (Input.GetKey(KeyCode.R))//if R is pressed
        {
            SceneManager.LoadScene("rot2");//reload the scene
        }
        else if (Input.GetKey(KeyCode.E))// if e  is pressed
        {
            SceneManager.LoadScene(0);//go to the main menu
        }
    }
 
}
