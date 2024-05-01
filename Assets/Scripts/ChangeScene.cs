using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public float waitTime = 36.5f;
    public string introSceneName = "Intro";

    void Start()
    {
        StartCoroutine(PlayIntro());
    }

    IEnumerator PlayIntro()
    {
        yield return new WaitForSeconds(waitTime);

        // Load the intro scene
        SceneManager.LoadScene(introSceneName);
    }
}

