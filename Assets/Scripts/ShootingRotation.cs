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
        float angle = Mathf.Atan2(direction.y, direction.x) *
            Mathf.Rad2Deg;

        Quaternion rotation = Quaternion.AngleAxis(angle - 90,
            Vector3.forward);
        m_transform.rotation = rotation;

    }

    void Update()
    {
        LAMouse();

    }


    /*
    
    private Camera mainCam;
    private Vector3 mousePos;


    // Start is called before the first frame update
    void Start()
    {

        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();

    }

    // Update is called once per frame
    void Update()
    {
         mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);

        Vector3 rotation = mousePos - transform.position;

        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, rotZ);
    }*/
}
