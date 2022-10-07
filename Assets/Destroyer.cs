using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Much like the start() and Update() methods, OntriggerEnter2D is a special Unity method that is called
        //by Unity automatically at a specific point - in this case, when something enters the trigger attached
        //to this GameObject
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //If the GameObject that has collided with our trigger is tagged with Cleanup...
        if (collision.gameObject.tag == "CleanUp")
            {
                //Then we use this method to destroy it
                Destroy(collision.gameObject);
            }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
