using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantSpeedController : MonoBehaviour
{
    [SerializeField]
    private Vector2 direction;

    [SerializeField]
    private Movement movement;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.Move(direction);
    }
}
