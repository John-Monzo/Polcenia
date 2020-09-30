using UnityEngine;
using System.Collections;

public class Sticker : MonoBehaviour

{
    void Start () {
    GameObject Player = GameObject.Find("HPlat");
    Player.transform.parent = transform;
    }
public Transform toFollow = null;
// Update is called once per frame
void Update()
{
    if (toFollow != null)
        transform.position = toFollow.position;
}
}
