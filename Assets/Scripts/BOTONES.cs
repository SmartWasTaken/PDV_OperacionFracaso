using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void ReiniciarJuego()
    {
        // Carga la escena "Salon" para reiniciar el juego
        SceneManager.LoadScene("Salon");
    }

    public void SalirDelJuego()
    {
        if (Application.isEditor)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
        else
        {
            Application.Quit();
        }
    }
}
