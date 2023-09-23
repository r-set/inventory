using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Equipment object", menuName = "Inventory System/Items/Equipment")]

public class EquipmentObject : ItemsObject
{
    public void Awake()
    {
        type = ItemType.Equipment;
    }
}
