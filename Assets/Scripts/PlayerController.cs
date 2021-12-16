using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float walkSpeed = 5.0f;
    public float horizontalIput;
    /*public float jumpInput;
    public float jumpHeight = 7.0f;*/
    public float sprintSpeed = 8.0f;

    public Rigidbody rig;
    public float jumpSpeed = 5;
    public bool jumping;
    public bool isGrounded;
    public List<GameObject> ground = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        PlayerMovement();

        PlayerRotation();

        {
            if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
            {
                jumping = true;

            }

        }

    }

    private void FixedUpdate()
    {
        if (jumping)
        {
            rig.AddForce(transform.up * jumpSpeed, ForceMode.VelocityChange);
            isGrounded = false;
            jumping = false;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {

        if (ground.Contains(collision.gameObject))
        {
            isGrounded = true;
        }
    }

    void PlayerMovement()
    {


        //jumping using built-in input manager
        /*jumpInput = Input.GetAxis("Jump");
        transform.Translate(Vector3.up * jumpInput * Time.deltaTime * jumpHeight);*/

        horizontalIput = Input.GetAxis("Horizontal");

        if (horizontalIput > 0)
        {
            transform.Translate(Vector3.forward * horizontalIput * Time.deltaTime * walkSpeed);
        }

        if (horizontalIput < 0)
        {
            transform.Translate(Vector3.back * horizontalIput * Time.deltaTime * walkSpeed);
        }





        //sprinting while left shift is being pressed
        if (Input.GetKey(KeyCode.LeftShift))
        {
            walkSpeed = sprintSpeed;
        }

        //return to normal walkSpeed unless left shift is down
        else
        {
            walkSpeed = 5.0f;
        }

    }

    void PlayerRotation()
    {

        Quaternion pos = Quaternion.Euler(0, 90, 0);
        Quaternion pos2 = Quaternion.Euler(0, -90, 0);

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.rotation = pos;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.rotation = pos2;
        }

    }



}

