using UnityEngine;
using UnityEngine.SceneManagement;

public class FinPartida : MonoBehaviour
{
    public GameOverManager gameOverManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
                Debug.Log("tas chocao");
            SceneManager.LoadScene("gameOverScene");
        }
    }
}
