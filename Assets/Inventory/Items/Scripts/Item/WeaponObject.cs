using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon object", menuName = "Inventory System/Items/Weapon")]

public class WeaponObject : ItemsObject
{
    public void Awake()
    {
        type = ItemType.Weapon;
    }
}