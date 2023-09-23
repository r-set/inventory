using UnityEngine;

[CreateAssetMenu(fileName = "New Inventory", menuName = "Inventory System/Inventory")]

public class InventoryObject : ScriptableObject
{
    public ItemDatabaseObject database;
    public Inventory Container;

    public void AddItem(Item item, int ammount)
    {
        for(int i = 0; i < Container.Items.Length;  i++)
        {
            if (Container.Items[i].ID == item.Id)
            {
                Container.Items[i].AddAmmount(ammount);
                return;
            }
        }

        SetEmptySlot(item, ammount);
    }

    public void RemoveItem(Item item)
    {
        for (int i = 0; i < Container.Items.Length; i++)
        {
            if (Container.Items[i].item == item)
            {
                Container.Items[i].UpdateSlot(-1, null, 0);            }
        }
    }

    public void MoveItem(InventorySlot item1, InventorySlot item2)
    {
        InventorySlot temp = new InventorySlot(item2.ID, item2.item, item2.ammount);
        item2.UpdateSlot(item1.ID, item1.item, item1.ammount);
        item1.UpdateSlot(temp.ID, temp.item, temp.ammount);
    }

    public InventorySlot SetEmptySlot(Item item, int ammount)
    { 
        for(int i = 0; i < Container.Items.Length; i++)
        {
            if (Container.Items[i].ID <= -1)
            {
                Container.Items[i].UpdateSlot(item.Id, item, ammount);
                return Container.Items[i];
            }
        }

        return null;
    }
}

[System.Serializable]
public class Inventory
{
    public InventorySlot[] Items = new InventorySlot[30];
}

[System.Serializable]
public class InventorySlot
{
    public int ID = -1;
    public Item item;
    public int ammount;

    public InventorySlot()
    {
        ID = -1;
        item = null;
        ammount = 0;
    }
    public InventorySlot(int _id, Item _item, int _ammount)
    {
        ID = _id;
        item = _item;
        ammount = _ammount;
    }

    public void UpdateSlot(int _id, Item _item, int _ammount)
    {
        ID = _id;
        item = _item;
        ammount = _ammount;
    }

    public void AddAmmount(int value)
    {
        ammount += value;
    }
}
