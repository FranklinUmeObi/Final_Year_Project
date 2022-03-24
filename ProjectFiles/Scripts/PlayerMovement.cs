using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    public Rigidbody body;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) body.AddForce(body.transform.forward * speed);
        if (Input.GetKey(KeyCode.S)) body.AddForce(body.transform.forward * -speed);
        if (Input.GetKey(KeyCode.D)) body.AddForce(Vector3.right * speed);
        if (Input.GetKey(KeyCode.A)) body.AddForce(Vector3.left * speed);
    }
}
