using UnityEngine;
using System.Collections;

public class BulletMoveForward : MonoBehaviour {

    private float acceleration = 50f;
    private float initialVelocity = 5f;
    private Rigidbody2D ourRigidbody;

    private ScoreScript scoreScript;

    void Start()
    {
        ourRigidbody = GetComponent<Rigidbody2D>();
        ourRigidbody.velocity = Vector2.up * initialVelocity;
    }

    void Update()
    {
        Vector2 ForceToAdd = Vector2.up * acceleration * Time.deltaTime;
        ourRigidbody.AddForce(ForceToAdd);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        ScoreScript.score += 1;
        Debug.Log("ENEMY HIT");
    }
}
