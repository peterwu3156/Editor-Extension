using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class DrawEditorWindow : EditorWindow
{
    [MenuItem("NewMenu/OpenWindow")]
    protected static void OpenWindow()
    {
        var window = GetWindow<DrawEditorWindow>();
        window.Show();
    }
}
