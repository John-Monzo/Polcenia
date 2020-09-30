using UnityEngine;
using System.Collections;

public class Rot : MonoBehaviour {//rotates platforms
    public float rotationspeed = 10;//default rotation speed. can be modified
    void Update()
    {
        transform.Rotate(0, Time.deltaTime, rotationspeed);//rotates in vector3 terms. set the first to 0 so it doesn't leave 2d. everysecond rotates a little bit.
    }
    void OnTriggerEnter(Collider VPlat)//if it collides with VPlat
    {
        transform.Rotate(0,0,0);//stop rotation   **never really used
    }
  
}
