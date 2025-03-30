using UnityEngine;
using System.Collections;

public class EnemyMoveForward : MonoBehaviour 
{
    // Showing private Variable value on Inspector for Enemy acceleration, velocity and Rigidbody
    [SerializeField]
    private float acceleration = 75f;
    private float initialVelocity = 2f;
    private Rigidbody2D ourRigidbody;


    void Start()
    {
        ourRigidbody = GetComponent<Rigidbody2D>();

        ourRigidbody.velocity = Vector2.down * initialVelocity;
    }

    // Acceleration and delay for the Enemy
    void Update()
    {
        Vector2 ForceToAdd = Vector2.down * acceleration * Time.deltaTime;

        ourRigidbody.AddForce(ForceToAdd);
    }
}
