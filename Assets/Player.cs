using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody RB;

    public GameObject Camera;

    public int moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        // 1. Addforce

        //if(Input.GetKey(KeyCode.A))
        //{
        //    RB.AddForce(Vector3.left, ForceMode.Impulse);
        //}
        //if(Input.GetKey(KeyCode.D))
        //{
        //    RB.AddForce(Vector3.right, ForceMode.Impulse);
        //}
        //if(Input.GetKey(KeyCode.W))
        //{
        //    RB.AddForce(Vector3.forward, ForceMode.Impulse);
        //}
        //if(Input.GetKey(KeyCode.S))
        //{
        //    RB.AddForce(Vector3.back, ForceMode.Impulse);
        //}

        // 2. velocity, getKey

        //if(Input.GetKey(KeyCode.A))
        //{
        //    RB.velocity = new Vector3(-1, 0, 0) * moveSpeed;
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    RB.velocity = new Vector3(1, 0, 0) * moveSpeed;
        //}
        //if (Input.GetKey(KeyCode.W))
        //{
        //    RB.velocity = new Vector3(0, 0, 1) * moveSpeed;
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    RB.velocity = new Vector3(0, 0, -1) * moveSpeed;
        //}

        // 3. GetAxis

        //float inputX = Input.GetAxisRaw("Horizontal");
        //float inputZ = Input.GetAxisRaw("Vertical");
        //// -1 ~ 1

        //Vector3 new_Velocity = new Vector3(inputX, 0, inputZ) * moveSpeed;

        //RB.velocity = new_Velocity;
    }
}
