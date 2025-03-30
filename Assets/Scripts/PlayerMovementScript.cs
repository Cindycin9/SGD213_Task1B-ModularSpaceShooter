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
}
