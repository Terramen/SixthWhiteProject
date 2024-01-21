using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Jrwersdfsfgererdg))]
public class PlayerInfoEditor : Editor {
    private Jrwersdfsfgererdg _itemBase;
    private void Awake()
    {
        _itemBase = (Jrwersdfsfgererdg)target;
    }
    public override void OnInspectorGUI()
    {

        if (GUILayout.Button("New Item"))
        {
            _itemBase.Jrioweorsdofsodf();
        }
        if (GUILayout.Button("Remove"))
        {
            _itemBase.Ieriwqqriifsidf();
        }
        if (GUILayout.Button("Save"))
        {
            if (_itemBase != null)
            {
                EditorUtility.SetDirty(_itemBase);
                AssetDatabase.SaveAssets();
            }
        }
        GUILayout.BeginHorizontal();
        if (GUILayout.Button("<"))
        {
            _itemBase.Jeqwesysdyfsd();
        }
        if (GUILayout.Button(">"))
        {
            _itemBase.Kkfskkxkvxkcv();
        }
        GUILayout.EndHorizontal();

        base.OnInspectorGUI();
    }
}
