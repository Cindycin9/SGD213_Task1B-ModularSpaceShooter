using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour 
{
            // SerializeField exposes this value to the Editor, but not to other Scripts!
            // It is "pseudo public"
            [SerializeField]
            private float HorizontalPlayerAcceleration = 5000f;
            private Rigidbody2D OURRigidbody;

    void Start() 
    {
        // Get OurRigidbodyComponent once at the start of the game and store a reference to it
        //Calls GetComponent once, increasing the game speed.
        OURRigidbody = GetComponent<Rigidbody2D>(); 
    
    }

    void Update() 
    {
        float HorizontalInput = Input.GetAxis("Horizontal");

        if (HorizontalInput != 0.0f) 
        {
            Vector2 ForceToAdd=Vector2.right*HorizontalInput*HorizontalPlayerAcceleration*Time.deltaTime;
            OURRigidbody.AddForce(ForceToAdd);
            //print(HorizontalInput);
        } 
    } 
}
