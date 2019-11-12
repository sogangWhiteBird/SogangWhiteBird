using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud : MonoBehaviour
{


    Vector3 cloud_velocity = new Vector3(2, 0, 0);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = cloud_velocity;
     }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "wall")
        {
            cloud_velocity.x = -cloud_velocity.x;
        }
    }

}
