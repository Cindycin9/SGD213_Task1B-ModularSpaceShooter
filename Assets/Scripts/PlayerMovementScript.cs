using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour 
{
    [SerializeField]

    public float speed = 5000f;

            private Rigidbody2D OURRigidbody;

    void Start() 
    {
        //Calls GetComponent once, increasing the game speed
        OURRigidbody = GetComponent<Rigidbody2D>(); 
    
    }


    // If player collides with Enemy, isGameOver is true
    private void OnTriggerEnter2D(Collider2D collider)
    {
        GameManagerScript.isGameOver = true;
        Debug.Log("END SCREEN");
    }





    public void HorizontalMovement(float HorizontalInput)
    {
        Vector2 ForceToAdd = Vector2.right * HorizontalInput * speed * Time.deltaTime;
        OURRigidbody.AddForce(ForceToAdd);
    }
}
