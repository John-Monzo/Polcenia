using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
[System.Serializable]


public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private float speed=3;


    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.transform.tag == "HPlat")
        {
            /**/
            GetComponent<Rigidbody2D>().isKinematic = true;
            transform.parent = coll.transform;

        }
        else
        {
            GetComponent<Rigidbody2D>().isKinematic = false;
            if (coll.gameObject.tag == "RPlat")
            {
                SceneManager.LoadScene("rot2");
            }
        }

    }

        /**/
        void OnCollisionExit2D(Collision2D coll)
        {
            if (coll.transform.tag == "HPlat" || coll.transform.tag != "Mover")
            {

                /* if (Input.GetKey(KeyCode.RightArrow))
                 {
                  GetComponent<Rigidbody2D>().isKinematic = true;
                  transform.parent = null;
                    }
                  else if (Input.GetKey(KeyCode.LeftArrow))
            {
                     GetComponent<Rigidbody2D>().isKinematic = true;
                     transform.parent = null;
            }
                  else
            {
                         GetComponent<Rigidbody2D>().isKinematic = false;
            }*/
            GetComponent<Rigidbody2D>().isKinematic = false;
                transform.parent = null;
            }

        }
    void Update()
    {
  
    }


    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
      

        Vector2 movement = new Vector2(moveHorizontal, 0.0f);
        rb.velocity = movement * speed;

    }
   

}
