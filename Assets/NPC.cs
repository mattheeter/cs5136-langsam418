using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class NPC : MonoBehaviour
{
    public GameObject dialoguePanel;
    public TextMeshProUGUI dialogueText; // Reference to the TMP UI text
    public string customText;
    private bool playerNearby = false;

    void Update()
    {
        if (playerNearby)
        {
            dialoguePanel.SetActive(true);
            dialogueText.text = customText;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNearby = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNearby = false;
            dialoguePanel.SetActive(false);
        }
    }
}
