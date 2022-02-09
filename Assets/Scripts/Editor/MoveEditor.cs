using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Move))]
public class MoveEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        /*if(GUILayout.Button("Vector Motion"))
        {
            var castedTarget = target as Move;
            castedTarget.Moving();
        }*/
    }
}
