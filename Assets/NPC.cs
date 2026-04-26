using UnityEngine;

public class NPC : MonoBehaviour
{
    public GameObject dialoguePanel;
    private bool somethingNearby = false;

    void Update()
    {
        if (somethingNearby && Input.GetMouseButtonDown(0))
        {
            dialoguePanel.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer != LayerMask.NameToLayer("Default"))
        {
            somethingNearby = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer != LayerMask.NameToLayer("Default"))
        {
            somethingNearby = false;
            dialoguePanel.SetActive(false);
        }
    }
}
