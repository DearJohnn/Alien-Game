using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MissionSubmit : MonoBehaviour
{
    private Inventory inventory;

    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }
    void Update()
    {
        string submitCard = ((Ink.Runtime.StringValue) DialogueManager
            .GetInstance()
            .GetVariableState("submitCard")).value;
        
        string rehabilitation = ((Ink.Runtime.StringValue)DialogueManager
            .GetInstance()
            .GetVariableState("rehabilitation")).value;

        switch (submitCard)
        {
            case "false":
                break;

            case "submit":
                for (int i = 0; i < inventory.slots.Length; i++)
                {
                    if (inventory.isFull[i] == true)
                    {
                        foreach (Transform child in inventory.slots[i].transform)
                        {
                            if (child.tag == "Card")
                                GameObject.Destroy(child.gameObject);

                        }
                    }
                }
                GameManager.coin = 500;
                break;
        }

        switch (rehabilitation)
        {
            case "false":
                break;

            case "health":
                GameManager.coin = 0;
                GameManager.Win();
                break;
        }
    }
}
