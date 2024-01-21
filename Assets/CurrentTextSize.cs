using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CurrentTextSize : MonoBehaviour
{
    public TMP_Text textComponent;
    public RectTransform content;

    public ScrollRect rect;

    public void Kfktfjerrtjwjfwe() {
        var kekskfdskf = textComponent.preferredHeight;

        var fsjfsjfjsjfd = content.sizeDelta;
        fsjfsjfjsjfd.y = kekskfdskf;
        content.sizeDelta = fsjfsjfjsjfd;

        rect.normalizedPosition = new Vector2(0, 1);
    }
    
    void Start()
    {
        Kfktfjerrtjwjfwe();
    }


}
