using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(CoordCalculator))]
public class CoordCalculatorInspector : Editor
{
    
    public override void OnInspectorGUI()
    {
        EditorGUILayout.BeginVertical();
        var tr = (CoordCalculator)target;
        var flag = EditorGUILayout.Toggle("Track Pos", tr.savePos);
        if (flag)
        {
            EditorGUILayout.Vector3Field("Delta Pos", tr.gameObject.transform.localPosition - (tr.gameObject.transform.position - tr.pos));
        }
        if (flag != tr.savePos && !tr.savePos && flag)
        {
            tr.pos = tr.gameObject.transform.position;
        }
        tr.savePos = flag;
        EditorGUILayout.EndVertical();

    }
}

