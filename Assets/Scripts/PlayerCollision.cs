using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    private void OnCollisionEntereD(Collision2D collision)
    {
        if(collision.transform.tag == "Enemy")
        {
            GameManagerScript.isGameOver = true;
        }
    }
}
