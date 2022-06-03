using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    public float rotationSpeed = 1;
    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, 0, rotationSpeed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            this.GetComponent<MeshRenderer>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;
            this.GetComponent<AudioSource>().Play();
            Destroy(this.gameObject, 2.0f);
        }
    }
}
