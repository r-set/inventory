using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Food object", menuName = "Inventory System/Items/Food")]

public class FoodObject : ItemsObject
{
    public void Awake()
    {
        type = ItemType.Food;
    }
}
