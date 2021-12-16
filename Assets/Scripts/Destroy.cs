using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{

    public Vector3 startingPos;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        startingPos = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name=="Ball(Clone)")
        {
        Destroy(gameObject);
        Destroy(other.gameObject);
        }

        else
        {
            other.transform.position = startingPos;
        }
    }
    }
