using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAndShoot : MonoBehaviour
{
    public Camera Cam;

    public Camera cam1;

    public RaycastHit RayHit;

    public Ray ray;

    public GameObject ObjectHit;

    public Vector3 Hitpoint = Vector3.zero;



    private void Update()
    {

        if (cam1 != null)

        {

            //Cast Ray from Camera through Mouse

            ray = cam1.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RayHit))

            {

                ObjectHit = RayHit.transform.gameObject;
                Hitpoint = RayHit.point;

                if (ObjectHit != null)

                    Debug.DrawLine(cam1.transform.position, Hitpoint, Color.blue, 0.5f);

            }

            //Cast Ray from Camera through Mouse Ends

        }
    }

    private static Vector3 cursorWorldPosOnNCP
    {
        get
        {
            return Camera.main.ScreenToWorldPoint(
                new Vector3(Input.mousePosition.x,
                Input.mousePosition.y,
                Camera.main.nearClipPlane));
        }
    }

    private static Vector3 cameraToCursor
    {
        get
        {
            return cursorWorldPosOnNCP - Camera.main.transform.position;
        }
    }

    private Vector3 cursorOnTransform
    {
        get
        {
            Vector3 camToTrans = transform.position - Camera.main.transform.position;
            return Camera.main.transform.position +
                cameraToCursor *
                (Vector3.Dot(Camera.main.transform.forward, camToTrans) / Vector3.Dot(Camera.main.transform.forward, cameraToCursor));
        }
    }

}
