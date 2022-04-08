using UnityEngine;
using UnityEditor;

public class MouseCursorExample : EditorWindow
{
    [MenuItem("Examples/MouseCursorRect Example")]
    static void AddCursorRectExample()
    {
        MouseCursorExample window =
            EditorWindow.GetWindowWithRect<MouseCursorExample>(new Rect(0, 0, 180, 80));
        window.Show();
    }

    void OnGUI()
    {
        EditorGUI.DrawRect(new Rect(10, 10, 160, 60), new Color(0.5f, 0.5f, 0.85f));
        EditorGUI.DrawRect(new Rect(20, 20, 140, 40), new Color(0.9f, 0.9f, 0.9f));
        EditorGUIUtility.AddCursorRect(new Rect(20, 20, 140, 40), MouseCursor.FPS);
    }
}