using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneLoader2 : MonoBehaviour
{
    public float videoDuration = 36f; // Set the duration of your video here

    IEnumerator Start()
    {
        // Play your video here

        // Wait for the specified duration
        yield return new WaitForSeconds(videoDuration);

        // Load the main menu scene
        SceneManager.LoadScene("Salon");
    }
}
