using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    private bool playerInRange;
    public GameObject Instruction;

    private void Awake()
    {
        playerInRange = false;
        visualCue.SetActive(false);
        Instruction.SetActive(false);
    }

    private void Update()
    {
        if (playerInRange && !DialogueManager.GetInstance().dialogueIsPlaying)
        {
            visualCue.SetActive(true);
            Instruction.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                Instruction.SetActive(false);
                //Debug.Log(inkJSON.text);
                DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
                
            }
        }
        else
        {
            visualCue.SetActive(false);
            Instruction.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            playerInRange = true;
            Instruction.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange= false;
            Instruction.SetActive(false);
        }
    }
}
