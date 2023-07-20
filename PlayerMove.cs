using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
{
    float horizontalInput = Input.GetAxis("Horizontal"); // A, D, Left, Right
    float verticalInput = Input.GetAxis("Vertical"); // W, S, Up, Down
    rb.AddForce(new Vector3(horizontalInput, 0, verticalInput));
}
}
