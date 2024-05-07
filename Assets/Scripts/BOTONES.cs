using UnityEngine;
using UnityEngine.SceneManagement;

public class BOTONES : MonoBehaviour
{
    public void ReiniciarJuego()
    {
        // Carga la escena "Salon" para reiniciar el juego
        SceneManager.LoadScene("Salon");
    }

    public void SalirDelJuego()
    {
        Application.Quit();
    }
}
