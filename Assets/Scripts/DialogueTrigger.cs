using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset[] inkJSON;

    private bool playerInRange;
    public GameObject Instruction;
    public static int i = 0;
    private Inventory inventory;

    private void Awake()
    {
        playerInRange = false;
        visualCue.SetActive(false);
        Instruction.SetActive(false);
    }

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
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
                if(gameObject.transform.parent.gameObject.tag == "NPC3" && GameManager.creditCard)
                {
                    i = 1;
                }
                if(gameObject.transform.parent.gameObject.tag == "NPC2" && GameManager.coin>= 500)
                {
                    i = 1;
                }
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
