using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamara : MonoBehaviour
{
    [Range(0, 100)]
    public float speed = 1;
    private Rigidbody rb;
    private Transform pos;
    [Range(0, 10)]
    public float sensibilidadX = 1;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Rotate(0, Input.GetAxis("Mouse X") * sensibilidadX, 0);
        rb.velocity = (transform.forward * Input.GetAxis("Vertical")*speed) + (transform.right * Input.GetAxis("Horizontal")*speed);
        pos = this.transform;

    }

}
