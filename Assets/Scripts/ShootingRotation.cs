using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingRotation : MonoBehaviour
{

    private Transform m_transform;

    private void Start()
    {
        m_transform = this.transform;

    }

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

    void Update()
    {
        LAMouse();

    }
}
