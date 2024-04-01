using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager Instance;

    public GameObject dialogueCanvas;
    public Text nameText;
    public Text dialogueText;

    void Awake()
    {
        Instance = this;
    }

    public void ShowDialogue(string name, string dialogue)
    {
        nameText.text = name;
        dialogueText.text = dialogue;

        dialogueCanvas.SetActive(true);
    }

    public void CloseDialogue()
    {
        dialogueCanvas.SetActive(false);
    }
}
