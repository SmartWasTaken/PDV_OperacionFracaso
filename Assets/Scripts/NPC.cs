    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public string name;
    public string dialogue;

    public void Interact()
    {
        DialogueManager.Instance.ShowDialogue(name, dialogue);
    }
}
