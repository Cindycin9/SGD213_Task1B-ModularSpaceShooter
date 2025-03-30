using UnityEngine;
using System.Collections;

public class ShootingScript : MonoBehaviour
{
    // Showing private Variable value on Inspector for GameObject Bullets Offset and Delay
    [SerializeField]
    private GameObject bullet;
    private float lastFiredTime = 0f;

    [SerializeField]
    private float fireDelay = 1f;
    private float bulletOffset = 2f;

    void Start()
    {
        // Calculations that spawn the bullet from the PlayerCharacter -Plus half of the bullet size
        bulletOffset = GetComponent<Renderer>().bounds.size.y / 2 + bullet.GetComponent<Renderer>().bounds.size.y / 2;
    }
    
    // Bullet delay when shooting
    public void Shoot()

    {
        float CurrentTime = Time.time;

        // Have a delay so we don't shoot too many bullets
        if (CurrentTime - lastFiredTime > fireDelay)
        {
            Vector2 spawnPosition = new Vector2(transform.position.x, transform.position.y + bulletOffset);

            Instantiate(bullet, spawnPosition, transform.rotation);

            lastFiredTime = CurrentTime;
        }
    }

    public float SampleMethod(int number) 
    {
        return number;
    }

}
