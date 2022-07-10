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

        if (GUILayout.Button("ֱ�ӷ����޸�"))
        {
            TestClass test = (TestClass)target;
            test.TestName = "���ֱ��޸�";
            //����ֱ�ӱ��� ���븳�����Ǻ�Unity�Ż�ȷ���޸�
            EditorUtility.SetDirty(test);
        }

        if (GUILayout.Button("ͨ��Editor�޸�"))
        {
            serializedObject.FindProperty("TestName").stringValue = "Editor�޸�����";
            serializedObject.ApplyModifiedProperties();
        }
    }

}
