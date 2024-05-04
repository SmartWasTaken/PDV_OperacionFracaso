using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPillado : MonoBehaviour
{
    public void Reiniciar(){
        Time.timeScale =1f;
        SceneManager.LoadScene(1);
    }

    public void Salir(){
        Application.Quit();

    }
}
