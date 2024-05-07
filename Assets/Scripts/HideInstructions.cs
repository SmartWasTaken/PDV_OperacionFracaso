using UnityEngine;
using UnityEngine.UI;

public class HideInstructions : MonoBehaviour
{
    [SerializeField] private GameObject instrucciones;
    [SerializeField] private Button botonContinuar;

    void Start()
    {
        // Aseg�rate de que el objeto de instrucciones est� activo al inicio de la escena
        instrucciones.SetActive(true);
        // Asigna el m�todo OcultarInstrucciones al evento onClick del bot�n de continuar
        botonContinuar.onClick.AddListener(OcultarInstrucciones);
    }

    public void OcultarInstrucciones()
    {
        // Desactiva el objeto de instrucciones cuando se presione el bot�n de continuar
        instrucciones.SetActive(false);
    }
}

