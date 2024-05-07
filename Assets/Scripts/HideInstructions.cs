using UnityEngine;
using UnityEngine.UI;

public class HideInstructions : MonoBehaviour
{
    [SerializeField] private GameObject instrucciones;
    [SerializeField] private Button botonContinuar;

    void Start()
    {
        // Asegúrate de que el objeto de instrucciones esté activo al inicio de la escena
        instrucciones.SetActive(true);
        // Asigna el método OcultarInstrucciones al evento onClick del botón de continuar
        botonContinuar.onClick.AddListener(OcultarInstrucciones);
    }

    public void OcultarInstrucciones()
    {
        // Desactiva el objeto de instrucciones cuando se presione el botón de continuar
        instrucciones.SetActive(false);
    }
}

