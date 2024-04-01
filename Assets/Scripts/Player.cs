using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float interactionRange = 2f;
    private NPC currentNPC;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && currentNPC != null)
        {
            float distance = Vector3.Distance(transform.position, currentNPC.transform.position);
            if (distance <= interactionRange)
            {
                currentNPC.Interact();
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("NPC"))
        {
            currentNPC = other.GetComponent<NPC>();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("NPC"))
        {
            currentNPC = null;
        }
    }
}
