using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraY : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        //Mouse Y
        //CameraY
        transform.Rotate(Input.GetAxis("Mouse Y") * -1, 0, 0);
    }
}
