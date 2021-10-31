using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainTeleporter : MonoBehaviour
{
    public Transform starter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Once the player passes the plane for this onTriggerEnter, then the player is teleported to the starting position of the main map
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ManMovement.man.transform.position = starter.transform.position;
    }
}
