using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    private static bool paused = false;
    public GameObject[] buttons;
    public GameObject cameraLimiter;
    void Start()
    {
        paused = false;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PausingAction();
        }
    }

    public void PausingAction()
    {
        if (paused == false) //Pausado
        {
            cameraLimiter.GetComponent<CameraY>().enabled = false; //Evita que la cámara se pueda mover en pausa
            for (int i = 0; i < buttons.Length; i++) //Desactivamos los botones que están en pantalla
            {
                buttons[i].SetActive(true);
            }
            Debug.Log("Pausado");
            paused = true;
            Time.timeScale = 0;
        }
        else if (paused == true)
        {
            cameraLimiter.GetComponent<CameraY>().enabled = true;
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].SetActive(false);
            }
            Debug.Log("Continuar");
            paused = false;
            Time.timeScale = 1;
        }
    }

    public void CloseGame()
    {
        Application.Quit();
        Debug.Log("Jeje no puedes salir");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Debug.Log("No hay menu bro");
    }

}
