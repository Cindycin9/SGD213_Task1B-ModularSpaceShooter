using UnityEngine;
using System.Collections;

public class DestroyedOnExit : MonoBehaviour
{

    // Called when the object leaves the viewport and will no longer be rendered.
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
