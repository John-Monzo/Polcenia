using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;//gives acces to scenes in the build
public class lvlController2 : MonoBehaviour
{ //controlls how a player can manage their level
    void Update()//every frame
    {
        if (Input.GetKey(KeyCode.R))//if R is pressed
        {
            SceneManager.LoadScene("test2");//The scene will reload itself
        }
        else if (Input.GetKey(KeyCode.E))//if e is pressed
        {
            SceneManager.LoadScene(0);//go to scene 0 which is the main menu
        }
    }

}
