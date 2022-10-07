using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject groundChecker;
    public LayerMask whatIsGround;

    float maxSpeed = 5.0f;
    bool isOnGround = false;
    float movementValueX;

    //create a reference to the Rigidbody2D so we can manipulate it
    Rigidbody2D playerObject;
    // Start is called before the first frame update
    void Start()
    {
        //Find the Rigidbody2D component that is attached to the same object as this script
        playerObject = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {

        //Create a 'float' that will be equal to the players horizontal input
        //movementValueX = 1.0f;

        //change the X velocity of the Rigidbody2D to be equalk to the movement value
        //playerObject.velocity = new Vector2(movementValueX, playerObject.velocity.y);

        //Check to see if the ground check object is touching the ground
        isOnGround = Physics2D.OverlapCircle(groundChecker.transform.position, 1.01f, whatIsGround);

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround == true)
        {
            playerObject.AddForce(new Vector2(0.0f, 1.0f));
        }


        if (Input.GetKey(KeyCode.LeftShift))
        {
            maxSpeed = 10.0f;
        }
        else
        {
            maxSpeed = 5.0f;
        }
        //Create a 'float' that will be equal to the players horizontal input
        float movementValueX = 1f;
        float movementValueY = Input.GetAxis("Vertical");

        playerObject.velocity = new Vector2(movementValueX * maxSpeed, movementValueY * maxSpeed);

        //Set movementValueX to 1.0f, so that we always run forward and no longer care about player input



        /*if (Input.GetKey(KeyCode.UpArrow))
        {
            playerObject.AddForce(new Vector2(0.0f, 30.0f));
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            playerObject.AddForce(new Vector2(30.0f, 0.0f));
        }

        if (Input.GetKey(KeyCode.UpArrow) && isOnGround == true)
        {
            playerObject.AddForce(new Vector2(0.0f, 30.0f));
        }

        if (Input.GetKey(KeyCode.DownArrow) && isOnGround == true)
        {
            playerObject.AddForce(new Vector2(30.0f, 0.0f));
        }*/
    }    }
