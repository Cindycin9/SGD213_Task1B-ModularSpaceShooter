using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour
{
    // Showing private Variable value on Inspector for Enemy rotation
    [SerializeField]
    private float maximumSpinSpeed = 200;

    // Rotates the Gameobject at a random angle
    void Start()
    {
        GetComponent<Rigidbody2D>().angularVelocity = Random.Range(-maximumSpinSpeed, maximumSpinSpeed);
    }
}
