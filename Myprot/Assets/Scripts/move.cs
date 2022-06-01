using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Rigidbody rigid;
    private Animator anim;

    private float speed = 3;
    public float turnSpeed = 10;

    Vector3 movement;
    float forwardAmount;
    float turnAmount;

    float x
    float z


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        Vector3 movement = transform.forward * z * speed * Time.deltaTime;
        rigid.MovePosition(rigid.position + movement);
    }
}
