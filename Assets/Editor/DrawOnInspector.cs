using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


[CustomEditor(typeof(TestClass))]
public class DrawOnInspector : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("直接访问修改"))
        {
            TestClass test = (TestClass)target;
            test.TestName = "名字被修改";
            //不会直接保存 必须赋予脏标记后Unity才会确认修改
            EditorUtility.SetDirty(test);
        }

        if (GUILayout.Button("通过Editor修改"))
        {
            serializedObject.FindProperty("TestName").stringValue = "Editor修改名字";
            serializedObject.ApplyModifiedProperties();
        }
    }

}
