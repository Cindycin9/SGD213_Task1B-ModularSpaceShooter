using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantSpeedController : MonoBehaviour
{
    // Showing private Variable value on Inspector for Movement
    [SerializeField]
    private Vector2 direction;
    private Movement movement;


    // Movement's movement
    void Start()
    {
        movement = GetComponent<Movement>();
    }


    // Movement's direction
    void Update()
    {
        movement.Move(direction);
    }
}