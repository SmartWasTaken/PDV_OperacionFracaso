using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class MenuOpciones : MonoBehaviour
{

    public void PantallaCompleta(bool pantallaCompleta){
        Screen.fullScreen = pantallaCompleta;
    }

    [SerializeField] private AudioMixer audioMixer;
    public void CambiarVolumen(float volumen){
        audioMixer.SetFloat("Volumen", volumen);
    }
   
}
