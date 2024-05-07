using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrin : MonoBehaviour
{
    public void Jugar(){
        SceneManager.LoadScene("instrucciones");

    }
    public void Salir(){
        Debug.Log("Salir...");//ELIMINAR CUANDO CONFIRME QUE FUNCIONA
        Application.Quit();
    }
}
