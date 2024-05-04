using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public string gameOverScene = "GameOverScene";

    // M�todo para cargar la escena de Game Over
    public void GameOver()
    {
        SceneManager.LoadScene(gameOverScene);
    }
}
