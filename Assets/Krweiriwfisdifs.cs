using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Krweiriwfisdifs : MonoBehaviour
{
    [SerializeField] private TMP_Text _rwerwsjfjsdjf;
    [SerializeField] private TMP_Text _sdkjfskdfkskdf;
    [SerializeField] private Image _erqwyrydfysdf;

    [SerializeField] private Jrwersdfsfgererdg _rewqrywyfsdyfs;

    [SerializeField] private GameObject _jeqwjejqjsasd;
    [SerializeField] private GameObject _sdkfskewkrwekwef;

    [SerializeField] private Image _background;
    [SerializeField] private Sprite _newSprite;

    private List<ItemModel> _currentList;
    private int _currentId;


    public void Yrwersfjsdfsgdf(int fsdjfsjd) {
        _currentId = 0;

        var eddfwerwer = (Oorworosdofsdf)fsdjfsjd;
        _currentList = _rewqrywyfsdyfs.Iriwrisdfsdgdfg(eddfwerwer);
    }
    
    public void Ghrfhwehrwhfsdf() {
        Application.Quit();
    }
    
    public void Lorweorosdfsodf() {
        _rwerwsjfjsdjf.text = _currentList[_currentId].fsdfksdfsdkf;
        _erqwyrydfysdf.sprite = _currentList[_currentId].eqwjjjwjejfjds;
        _sdkjfskdfkskdf.text = _currentList[_currentId].rkwekksdfkskdf;
    }

    public void Orweorosdofsgsdgdfg() {
        if (_currentId == _currentList.Count - 1) {
            _currentId = 0;
            _jeqwjejqjsasd.SetActive(false);
            _sdkfskewkrwekwef.SetActive(true);
            _background.sprite = _newSprite;
            return;
        }
        _currentId++;
        Lorweorosdfsodf();
    }


}
