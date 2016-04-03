using UnityEngine;
using UnityEditor;
using System.Collections;

public class MatManagerWindow : EditorWindow {


    [MenuItem("EyE-RiS/MaterialManager")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(MatManagerWindow));
    }

    void OnGUI () {
            // The actual window code goes here
           }




}



