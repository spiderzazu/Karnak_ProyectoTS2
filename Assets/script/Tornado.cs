using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tornado : MonoBehaviour
{
    public Transform center;
    public float pullForce;
    public float refreshRate;
    public bool detenerse = true;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            detenerse = false;
            StartCoroutine(pullObject(other, true));

        }
    }
    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("Salió?");
        if (other.tag == "Player")
        {
            detenerse = true;
            other.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
        //StartCoroutine(pullObject(other, false));
    }

    IEnumerator pullObject(Collider x, bool pullable)
    {
        if (pullable && !detenerse)
        {
            Vector3 ForceDir = center.position - x.transform.position;
            x.GetComponent<Rigidbody>().AddForce(ForceDir.normalized * pullForce * Time.deltaTime);
            yield return refreshRate;
            StartCoroutine(pullObject(x, pullable));
        }
    }
}
