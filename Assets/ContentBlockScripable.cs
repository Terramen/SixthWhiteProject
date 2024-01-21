using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ContentBlock", menuName = "ScriptableObject", order = 1)]
public class ContentBlockScripable : ScriptableObject
{
    [HideInInspector] [SerializeField] private List<ItemModel> _items;
    [SerializeField] private ItemModel currentItem;

    private int currentIndex;

    public List<ItemModel> Iriwrisdfsdgdfg(Oorworosdofsdf type) {

        var ghdfhgdhghfdg = new List<ItemModel>();

        foreach (var item in _items)
        {
            if (item.oorworosdofsdf == type)
            {
                ghdfhgdhghfdg.Add(item);
            }
        }

        return ghdfhgdhghfdg;
    }

    #region SoInit
    public void CreateItem()
    {
        _items ??= new List<ItemModel>();

        var sdfjsdjfsjdf = new ItemModel();
        
        _items.Add(sdfjsdjfsjdf);
        currentItem = sdfjsdjfsjdf;
        currentIndex = _items.Count - 1;
    }

    public void RemoveItem()
    {
        _items.Remove(currentItem);
        if (_items.Count > 0)
            currentItem = _items[0];
        else CreateItem();
        currentIndex = 0;
    }

    public void NextItem()
    {
        if (currentIndex + 1 < _items.Count)
        {
            currentIndex++;
            currentItem = _items[currentIndex];
        }
    }
    public void PrevItem()
    {
        if (currentIndex <= 0) return;
        currentIndex--;
        currentItem = _items[currentIndex];
    }
    #endregion
}

public enum Oorworosdofsdf {
    GERMAN_SOCCERS
}

[System.Serializable]
public class ItemModel {
    public Oorworosdofsdf oorworosdofsdf;
    public int id;
    public string playerName;
    public string playerInfo;
    public Sprite playerPhoto;
}
