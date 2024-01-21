using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Keersdfsdf", menuName = "ScriptableObject", order = 1)]
public class Jrwersdfsfgererdg : ScriptableObject
{
    [HideInInspector] [SerializeField] private List<ItemModel> _jkerjjsdfjdjf;
    [SerializeField] private ItemModel currentItem;

    private int currentIndex;

    public List<ItemModel> Iriwrisdfsdgdfg(Oorworosdofsdf type) {

        var ghdfhgdhghfdg = new List<ItemModel>();

        foreach (var item in _jkerjjsdfjdjf)
        {
            if (item.oorworosdofsdf == type)
            {
                ghdfhgdhghfdg.Add(item);
            }
        }

        return ghdfhgdhghfdg;
    }

    #region SoInit
    public void Jrioweorsdofsodf()
    {
        _jkerjjsdfjdjf ??= new List<ItemModel>();

        var sdfjsdjfsjdf = new ItemModel();
        
        _jkerjjsdfjdjf.Add(sdfjsdjfsjdf);
        currentItem = sdfjsdjfsjdf;
        currentIndex = _jkerjjsdfjdjf.Count - 1;
    }

    public void Ieriwqqriifsidf()
    {
        _jkerjjsdfjdjf.Remove(currentItem);
        if (_jkerjjsdfjdjf.Count > 0)
            currentItem = _jkerjjsdfjdjf[0];
        else Jrioweorsdofsodf();
        currentIndex = 0;
    }

    public void Kkfskkxkvxkcv()
    {
        if (currentIndex + 1 < _jkerjjsdfjdjf.Count)
        {
            currentIndex++;
            currentItem = _jkerjjsdfjdjf[currentIndex];
        }
    }
    public void Jeqwesysdyfsd()
    {
        if (currentIndex <= 0) return;
        currentIndex--;
        currentItem = _jkerjjsdfjdjf[currentIndex];
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
    public string fsdfksdfsdkf;
    public string rkwekksdfkskdf;
    public Sprite eqwjjjwjejfjds;
}
