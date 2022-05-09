using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaMusicStart : MonoBehaviour
{
    public AudioSource areaInfo;

    //// Update is called once per frame
    //void Update()
    //{
        
    //}
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("Player"))
        {
            if (!areaInfo.isPlaying)
            {
                areaInfo.Play();
                Debug.Log("Inicia audio...");
            }
            //else
            //    Debug.Log("Ya reproduciendo");
            
            
        }
    }
}
