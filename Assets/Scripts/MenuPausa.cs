using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPausa : MonoBehaviour
{

    
    public void Pausa(){
        Time.timeScale = 0f;
        
    }

    public void Reanudar(){
        Time.timeScale = 1f;
    }

    public void Salir(){
        Application.Quit();
    }

}
