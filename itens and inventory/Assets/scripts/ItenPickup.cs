using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItenPickup : Interactable
{
    public Itens item;
    public override void Interact()
    {
        base.Interact();
        PickUp();
    }
    void PickUp()
    {
        Debug.Log("Pegou o " +item.name);
        Destroy(gameObject);
    }
}



