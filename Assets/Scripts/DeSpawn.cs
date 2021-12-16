using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeSpawn : MonoBehaviour
{
    [SerializeField] private GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(ball, 0.6f);
    }

   
}
