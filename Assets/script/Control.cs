using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
   public float velocidad;
   Rigidbody rb;
   public GameObject referencia;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update(){
        float hor= Input.GetAxis("Horizontal");
        float ver= Input.GetAxis("Vertical");
        rb.AddForce(ver*referencia.transform.forward*velocidad);
        rb.AddForce(hor*referencia.transform.right*velocidad);

        //rb.transform.Translate(hor*referencia.transform.right*velocidad* Time.deltaTime,0,ver*velocidad* Time.deltaTime);

    }
}
