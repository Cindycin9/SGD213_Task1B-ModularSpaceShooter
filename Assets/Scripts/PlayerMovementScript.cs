using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour 
{
    // Showing private Variable value on Inspector for Player Acceleration and player Rigidbody2D
    [SerializeField]
    private float HorizontalPlayerAcceleration = 5000f;
    private Rigidbody2D OURRigidbody;



    // Activates Player Rigidbody2D
    void Start()
    {
        OURRigidbody = GetComponent<Rigidbody2D>();
    }

    // Horizontal Axis of the player
    void Update()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");

        if (HorizontalInput != 0.0f)
        {
            Vector2 ForceToAdd = Vector2.right * HorizontalInput * HorizontalPlayerAcceleration * Time.deltaTime;
            OURRigidbody.AddForce(ForceToAdd);
        }
    }
}
