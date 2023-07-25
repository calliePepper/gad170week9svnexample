using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //This line lets you access the other object
        //collision.gameObject
        //

        if(collision.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);

            //Can also be used top access components on the other object
            //collision.gameObject.GetComponent<PlayerMovement>().
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        
    }
}
