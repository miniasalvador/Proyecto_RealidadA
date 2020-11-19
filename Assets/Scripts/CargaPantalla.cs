using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CargaPantalla : MonoBehaviour
{
    float tiempo = 4f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempo -= Time.deltaTime;

        if (tiempo <= 0)
        {
            MenúInicio();
        }
    }

    public void MenúInicio()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene("MenúPrincipal");
    }
}
