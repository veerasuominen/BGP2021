using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : PlayerController
{
    public GameObject prefab;
    private Vector3 shootOffset = new Vector3(0.5f, 0.5f, 0);

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && rig.transform.rotation == Quaternion.Euler(0, 90, 0))
        {
                Instantiate(prefab, transform.position + shootOffset, prefab.transform.rotation);
        }
    }
}
