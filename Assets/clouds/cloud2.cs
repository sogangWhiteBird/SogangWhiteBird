using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud2 : MonoBehaviour
{
    [SerializeField]
    GameObject foods;

    GameObject[] pool = new GameObject[5];
    int food_num = 0;

    Vector3 cloud_velocity = new Vector3(-2, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <5; i++)
        {
            pool[i] = (GameObject)Instantiate(foods, transform.position, Quaternion.identity);
            pool[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = cloud_velocity;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            pool[food_num].transform.position = transform.position;
            pool[food_num].SetActive(true);
            food_num = (food_num + 1) % 5;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "wall")
        {
            cloud_velocity.x = -cloud_velocity.x;
        }
    }

}
