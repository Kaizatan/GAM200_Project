using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(ItemGrid))]
public class GridInteract : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    InventoryController inventoryController;
    ItemGrid itemGrid;

    private void Awake()
    {
        inventoryController = FindObjectOfType(typeof(InventoryController)) as InventoryController;
        itemGrid = GetComponent<ItemGrid>();
    }

    //checks if pointer is has entered into the obj
    public void OnPointerEnter(PointerEventData eventData)
    {
        //if point is on obj, set inventoryController's selectedItemGrid to be the itemGrid
        inventoryController.selectedItemGrid = itemGrid;
    }

    //checks if pointer is has exited out of the obj
    public void OnPointerExit(PointerEventData eventData)
    {
        //if point is not on obj, set inventoryController's selectedItemGrid to be nothing like me :)
        inventoryController.selectedItemGrid = null;
    }

}
