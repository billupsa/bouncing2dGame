using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletAction : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.name.ToUpper() != "Terrain")
        {
            Destroy(rb);
            statCounter.kills++;
            monsterGenerator.totalMonsters--;
        }

    }
}
