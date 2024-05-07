using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueTrigger : MonoBehaviour
{
    [SerializeField] private GameObject visualCue;
    [SerializeField] private GameObject visualCue2;
    [SerializeField] private TextAsset inkJSON;

    private bool playerInRange;
    private int interactionsCount;

    private void Awake()
    {
        playerInRange = false;
        visualCue.SetActive(false);
        visualCue2.SetActive(false);

        interactionsCount = 0;

        PlayerPrefs.DeleteKey(gameObject.name + "_InteractionsCount");

        interactionsCount = PlayerPrefs.GetInt(gameObject.name + "_InteractionsCount", 0);
    }

    private void Update()
    {
        if (playerInRange && !DialogoManager.GetInstance().dialogueIsPlaying)
        {
            visualCue.SetActive(true);
            visualCue2.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                interactionsCount++;

                if (interactionsCount >= 3)
                {
                    WinGame();
                }

                PlayerPrefs.SetInt(gameObject.name + "_InteractionsCount", interactionsCount);
                PlayerPrefs.Save();
            }
        }
        else
        {
            visualCue.SetActive(false);
            visualCue2.SetActive(false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }

    private void WinGame()
    {
        interactionsCount = 0;
        PlayerPrefs.DeleteKey(gameObject.name + "_InteractionsCount");
        PlayerPrefs.Save();

        SceneManager.LoadScene("creditos");
    }
}





