using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public string key;
    [SerializeField] private GameObject ActualCheckpoint;
    [SerializeField] private GameObject NextCheckpoint;
    [SerializeField] private DialogueScript dialogue;
    [SerializeField] private DialogueScriptMulti dialogueMulti;
    public AudioSource audioLlegada;
    private void OnTriggerEnter(Collider obj)
    {
        if (obj.tag == "PlayerController")
        {
            audioLlegada.Play();
            ActualCheckpoint.SetActive(false);
            NextCheckpoint.SetActive(true);
            if (dialogue)
            {
                dialogue.StartDialogueMovementCheckPoint(key);
            }
            else
            {
                dialogueMulti.StartDialogueMovementCheckPoint(key);
            }
            
        }
    }
}
