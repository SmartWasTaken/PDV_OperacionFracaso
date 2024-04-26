using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public string gameOverScene = "GameOverScene";

    // Método para cargar la escena de Game Over
    public void GameOver()
    {
        SceneManager.LoadScene(gameOverScene);
    }
}
