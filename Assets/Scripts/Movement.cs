using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{


    [SerializeField]
    private float acceleration = 75f;
    private Rigidbody2D rb;

    private ScoreScript scoreScript;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    public void Move(Vector2 direction)
    {
        //        rb.AddForce(direction * acceleration * Time.deltaTime);
        rb.velocity = direction * acceleration;
    }

    // If player collides with Enemy, isGameOver is true
    private void OnTriggerEnter2D(Collider2D collider)
    {
        GameManagerScript.isGameOver = true;
        Debug.Log("END SCREEN");
    }

}
