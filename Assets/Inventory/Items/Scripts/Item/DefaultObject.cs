using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Default object", menuName = "Inventory System/Items/Default")]
public class DefaultObject : ItemsObject
{
    public void Awake()
    {
        type = ItemType.Default;
    }
}
