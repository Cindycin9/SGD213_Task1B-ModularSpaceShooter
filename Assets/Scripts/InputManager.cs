using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    //    private PlayerMovementScript playerMovementScript;
    private ShootingScript shootingScript;

    private Movement movement;


    void Start()
    {
        //        playerMovementScript = GetComponent<PlayerMovementScript>();
        shootingScript = GetComponent<ShootingScript>();

        movement = GetComponent<Movement>();

    }

    void Update()
    {
        /*
        float HorizontalInput = Input.GetAxis("Horizontal");

        if (HorizontalInput != 0.0f)
        {
            playerMovementScript.HorizontalMovement(HorizontalInput);
        }
        */
        float input = Input.GetAxis("Horizontal");

        movement.Move(Vector2.right * input);



        if (Input.GetButton("Fire1"))
        {
            if (shootingScript != null)
            {
                shootingScript.Shoot();
            }
            else
            {
                Debug.Log("Attach the shooting script!");
            }
        }

    }
}
