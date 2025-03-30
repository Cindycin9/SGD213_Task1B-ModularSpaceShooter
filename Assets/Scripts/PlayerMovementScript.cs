using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour 
{
    [SerializeField]
    private float f_horPlayAccel = 5000f;

    private Rigidbody2D OURRigidbody;

    void Start()
    {
        OURRigidbody = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");

        if (HorizontalInput != 0.0f)
        {
            Vector2 ForceToAdd = Vector2.right * HorizontalInput * f_horPlayAccel * Time.deltaTime;
            OURRigidbody.AddForce(ForceToAdd);
        }
    }

    /*

    public float speed = 5000f;

            private Rigidbody2D rb;

    void Start() 
    {
        //Calls GetComponent once, increasing the game speed
        rb = GetComponent<Rigidbody2D>(); 
    
    }

    //HorizontalMovement using the Rigidbody to add force
    public void HorizontalMovement(float HorizontalInput)
    {
        Vector2 ForceToAdd = Vector2.right * HorizontalInput * speed * Time.deltaTime;
        rb.AddForce(ForceToAdd);
    }

    // If player collides with Enemy, isGameOver is true
    private void OnTriggerEnter2D(Collider2D collider)
    {
        GameManagerScript.isGameOver = true;
        Debug.Log("END SCREEN");
    }

    */

}
