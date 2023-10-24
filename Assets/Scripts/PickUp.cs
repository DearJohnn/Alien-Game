using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemButton;
    public GameObject Instruction1;
    public GameObject Instruction2;
    public bool Action = false;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        Instruction1.SetActive(false);
        Instruction2.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Instruction1.SetActive(true);
            Instruction2.SetActive(true);
            Action = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        Instruction1.SetActive(false);
        Instruction2.SetActive(false);
        Action = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Action == true)
            {
                Pick();
                Instruction1.SetActive(false);
                Instruction2.SetActive(false);
                Action = false;
            }
        }

    }

    void Pick()
    {
        for (int i = 0; i < inventory.slots.Length; i++)
        {

            if (inventory.isFull[i] == false)
            {
                //ITEM CAN BE ADDED TO INVENTORY
                inventory.isFull[i] = true;
                Instantiate(itemButton, inventory.slots[i].transform);
                Destroy(gameObject);
                if(gameObject.tag == "CreditCard")
                {
                    GameManager.creditCard = true;
                }
                break;
            }
        }
    }
}
