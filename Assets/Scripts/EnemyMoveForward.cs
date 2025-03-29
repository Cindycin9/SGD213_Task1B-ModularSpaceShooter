using UnityEngine;
using System.Collections;

public class EnemyMoveForward : MonoBehaviour 
{
    [SerializeField]

    private float acceleration = 75f;

    private float initialVelocity = 2f;

    private Rigidbody2D ourRigidbody;

    void Start()
    {
        ourRigidbody = GetComponent<Rigidbody2D>();

        ourRigidbody.velocity = Vector2.down * initialVelocity;
    }

    void Update()
    {
        Vector2 ForceToAdd = Vector2.down * acceleration * Time.deltaTime;

        ourRigidbody.AddForce(ForceToAdd);
    }
}
