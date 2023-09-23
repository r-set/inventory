using UnityEngine;

public enum ItemType
{
    Food,
    Weapon,
    Equipment,
    Default
}

public enum Attributes
{
    Health,
    Stamina,
    Strength
}

public class ItemsObject : ScriptableObject
{
    public int Id;
    public Sprite uiDisplay;
    public ItemType type;
    [TextArea(20, 20)] public string Description;
    public ItemBuff[] buff;

    public Item CreateItem()
    {
        Item newItem = new Item(this);
        return newItem;
    }
}

[System.Serializable]

public class Item
{
    public string Name;
    public int Id;
    public ItemBuff[] buff;

    public Item(ItemsObject item)
    {
        Name = item.name;
        Id = item.Id;
        buff = new ItemBuff[item.buff.Length];
        for (int i = 0; i < buff.Length; i++)
        {
            buff[i] = new ItemBuff(item.buff[i].Min, item.buff[i].Max)
            {
                attributes = item.buff[i].attributes
            };
        }
    }
}


[System.Serializable]

public class ItemBuff
{
    public Attributes attributes;
    public int Value;
    public int Min;
    public int Max;

    public ItemBuff(int min, int max)
    {
        Min = min;
        Max = max;
        GenerateValue();
    }

    private void GenerateValue()
    {
        Value = Random.Range(Min, Max);
    }

}