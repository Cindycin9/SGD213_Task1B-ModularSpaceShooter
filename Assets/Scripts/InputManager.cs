using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    // Variables for ShootingScript and MovementScript
    private ShootingScript shootingScript;
    private Movement movement;

    // Reference to the Shooting and Movement Scripts
    void Start()
    {
        movement = GetComponent<Movement>();
        shootingScript = GetComponent<ShootingScript>();
    }

    // If Shooting Script is not assigned and activated with Fire1, Debug.Log will activate
    void Update()
    {
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
