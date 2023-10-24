using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mission : MonoBehaviour
{
    private Inventory inventory;

    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player")
        {
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
            

        }
    }
}
