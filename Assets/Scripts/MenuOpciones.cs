using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class MenuOpciones : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    public void CambiarVolumen(float volumen){
        audioMixer.SetFloat("Volumen", volumen);
    }
    /*
    public void Reiniciar(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex)
        //Cuando esten las escenas se debe modificar una parte en Unity
    }
    */
}
