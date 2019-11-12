using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foods : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0,-2*0.1f *Time.deltaTime, 0);

        //클릭시
       
    }


    void OnMouseDown()
    {
        gameObject.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "wall")
        {
            gameObject.SetActive(false);
        }
    }
}
