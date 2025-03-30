using UnityEngine;
using System.Collections;

public class BulletMoveForward : MonoBehaviour
{
    // Variables for Bullet position and Rigidbody
    private Camera mainCam;
    private Vector3 mousePos;
    private Rigidbody2D rb;
    public float force;

    // Bullet Variables
    private float acceleration = 50f;
    private float initialVelocity = 5f;
    private Rigidbody2D ourRigidbody;

    // Score Variable
    private ScoreScript scoreScript;



    //Bullet rotation + Bullet following camera
    void Start()
    {
        ourRigidbody = GetComponent<Rigidbody2D>();
        ourRigidbody.velocity = Vector2.up * initialVelocity;

        // Setting the camera position + Cursor direction
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        rb = GetComponent<Rigidbody2D>();

        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);

        //Direction for the bullet to go to (position of the mouse for the bullet to follow)
        Vector3 direction = mousePos - transform.position;
        Vector3 rotation = transform.position - mousePos;

        //Normalise so the bullet does not change speed
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;

        //Corrects the angle of the bullet
        float rot = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot + 90);
    }


    // Bullet Acceleration and RigidBody force
    void Update()
    {
        Vector2 ForceToAdd = Vector2.up * acceleration * Time.deltaTime;
        ourRigidbody.AddForce(ForceToAdd);
    }


    // If bullet hits an enemy, Score increases by +1
    private void OnTriggerEnter2D(Collider2D collider)
    {
        ScoreScript.score += 1;
        Debug.Log("ENEMY HIT");
    }
}
