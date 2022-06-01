using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    private bool clicked = true;
    [Tooltip("Agregar todo lo que se active en los créditos (Incluye a los textos)")]
    public GameObject[] creditBoxes; 
    [Tooltip("Solo agregar los elementos que aparezcan en la escena principal")]
    public GameObject[] mainButtons;

    // Start is called before the first frame update
    public void ExitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ShowCredits()
    {
        if (clicked)
        {
            Debug.Log("Creditos numeritos");
            for(int i = 0; i < creditBoxes.Length; i++)
            {
                creditBoxes[i].SetActive(true);
            }
            for(int j = 0; j< mainButtons.Length; j++)
            {
                mainButtons[j].SetActive(false);
            }
            clicked = false;
        }
        else
        {
            Debug.Log("Quito creditos muahahaha");
            for (int i = 0; i < creditBoxes.Length; i++)
            {
                creditBoxes[i].SetActive(false);
            }
            for (int j = 0; j < mainButtons.Length; j++)
            {
                mainButtons[j].SetActive(true);
            }
            clicked = true;
        }
    }
}
