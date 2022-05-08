using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public GameObject inventoryPanel;
    bool anctiveInventory = false;
    private void Start()
    {
        inventoryPanel.SetActive(anctiveInventory);
    }

    
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            anctiveInventory = !anctiveInventory;
            inventoryPanel.SetActive(anctiveInventory);
        }
    }
}
