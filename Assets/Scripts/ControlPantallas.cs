using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlPantallas : MonoBehaviour
{


    public void Función1()
    {
        SceneManager.LoadScene("Catalogo");
    }

    public void Función2()
    {
        SceneManager.LoadScene("CortaYReparte");
    }



    public void Salir()
    {
        Debug.Log("");
        Application.Quit(); //Salir del Juego
    }
}