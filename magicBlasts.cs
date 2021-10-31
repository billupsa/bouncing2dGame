using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magicBlasts : MonoBehaviour
{
    public Transform startingPoint;
    public GameObject bullet;
    public float bulletSpeed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GameObject shot = Instantiate(bullet, startingPoint.position, startingPoint.rotation);
            Rigidbody2D rb = shot.GetComponent<Rigidbody2D>();
            rb.AddForce(startingPoint.up*bulletSpeed,ForceMode2D.Impulse);
        }
    }
}
