using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using UnityEngine;
using TMPro;

public class NPC : MonoBehaviour
{
    public GameObject dialoguePanel;
    public TextMeshProUGUI dialogueText; // Cambiado a TextMeshProUGUI
    public string[] dialogue;
    private int index;

    public GameObject contButton;
    public GameObject contButton2;
    public GameObject contButton3;
    public float wordSpeed;
    public bool playerIsClose;
    public bool dialogueStarted;

    private void Start()
    {
        dialogueText.text = "";
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose && dialogueStarted == false)
        {
            if (dialoguePanel.activeInHierarchy)
            {
                zeroText();
            }
            else
            {

                dialoguePanel.SetActive(true);
                contButton.SetActive(false);
                contButton2.SetActive(false);
                contButton3.SetActive(false);
                StartCoroutine(Typing());

            }
        }

        if (dialogueText.text == dialogue[index] && dialogueStarted == true)
        {
            contButton.SetActive(true);
            contButton2.SetActive(true);
            contButton3.SetActive(true);
        }
    }

    public void zeroText()
    {
        dialogueText.text = "";
        index = 0;
        dialoguePanel.SetActive(false);
    }

    IEnumerator Typing()
    {
        dialogueStarted = true;
        foreach (char letter in dialogue[index].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
        dialogueStarted = false;
    }

    public void NextLine()
    {

        contButton.SetActive(false);
        contButton2.SetActive(false);
        contButton3.SetActive(false);

        if (index < dialogue.Length - 1 && dialogueStarted == false)
        {
            index++;
            dialogueText.text = "";
            StartCoroutine(Typing());
        }
        else
        {
            zeroText();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = false;
            zeroText();
        }
    }
}





