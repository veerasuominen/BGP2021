using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    [SerializeField] private float speed;
    private Vector3 direction = new Vector3(0, 1, 0);


    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * Time.deltaTime * speed);


        if (transform.position.y < 0)
        {
            direction = -direction;
        }

        if (transform.position.y > -7)
        {
            direction = -direction;
        }
    }

}
