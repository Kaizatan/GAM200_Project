using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    //HideInspector prevents this var from being access in unity's inspector *Pls don't inspect me UwU*
    [HideInInspector]
    public ItemGrid selectedItemGrid;

    private void Update()
    {
        if (selectedItemGrid == null) { return; }

        if (Input.GetMouseButtonDown(0))
        {

            Debug.Log(selectedItemGrid.GetTileGridPosition(Input.mousePosition));

        }
        
    }
}
