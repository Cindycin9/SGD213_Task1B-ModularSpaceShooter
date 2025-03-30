using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingRotation : MonoBehaviour
{
    // Variables for Bullet position and time between firing

    private Camera mainCam;
    private Vector3 mousePos;
    public GameObject bullet;
    public Transform bulletTransform;
    private Transform m_transform;

    // Locating the Camera through its Tag
    private void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        m_transform = this.transform;
    }

    // Bullet position and time between firing
    void Update()
    {
        // Sets the Vector 3 to Input.mousePosition
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 rotation = mousePos - transform.position;


        // Assigning Angle on radius 
        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotZ);

        // Rotation Point
        LAMouse();
    }

    // Rotate Point using the Cursor location
    private void LAMouse()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint
            (Input.mousePosition) - m_transform.position;
        // Angle that the Player Character must rotate around to face the cursor
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Vector3. forward is z axis
        Quaternion rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
        m_transform.rotation = rotation;
    }
}