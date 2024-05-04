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
    public Image image;

    void Awake()
    {
            Instance = this; 
    }

    public void ShowDialogue(string name, string dialogue, Sprite imageSprite)
    {
        nameText.text = name;
        dialogueText.text = dialogue;

        // Asignamos la imagen al componente Image si se proporciona
        if (imageSprite != null)
        {
            image.sprite = imageSprite;
            image.gameObject.SetActive(true); // Activamos el GameObject de la imagen
        }
        else
        {
            image.gameObject.SetActive(false); // Desactivamos el GameObject de la imagen si no se proporciona
        }

        dialogueCanvas.SetActive(true);
    }

    public void CloseDialogue()
    {
        dialogueCanvas.SetActive(false);
    }
}


