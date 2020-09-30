using UnityEngine;
using System.Collections;

public class protect : MonoBehaviour {
    //NO_LONGER_IN_USE
	// Use this for initialization
	void Start () {
        GameObject protector = GameObject.Find("HPlat");//protector finds the object called HPLAT
        protector.transform.parent = transform;//will set itself to a cetain position
    }
    public Transform toFollow = null;//to follow will be set to a certain object
    
    void Update () {//every frame
        if (toFollow != null)//if toFollow is set to something
            transform.position = toFollow.position;//have the protector follow its position.
    }
}
