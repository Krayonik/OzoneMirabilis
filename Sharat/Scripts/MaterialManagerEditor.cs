using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;

[CustomEditor(typeof(MaterialManager))]
public class MaterialManagerEditor : Editor {


    bool MainMat_bool;
    bool RetroGroup_bool;

    private bool listVisibility = true;
    private string entry;
    

    public override void OnInspectorGUI()
    {
        
        MaterialManager myTarget = (MaterialManager)target;

        SerializedObject serOBJ;

        

        serOBJ = new SerializedObject(target);
        serOBJ.Update();

        //myTarget.experience = EditorGUILayout.IntField("Experience", myTarget.experience);
        //EditorGUILayout.LabelField("Level", myTarget.Level.ToString());

        MainMat_bool = EditorGUILayout.BeginToggleGroup("Main Materials", MainMat_bool);

        myTarget.Roof1 = (Renderer) EditorGUILayout.ObjectField("Roof 1 :",myTarget.Roof1, typeof(Renderer), true);
        myTarget.Roof2 = (Renderer) EditorGUILayout.ObjectField("Roof 2 :", myTarget.Roof2, typeof(Renderer), true);
        myTarget.Roof3 = (Renderer) EditorGUILayout.ObjectField("Roof 3 :", myTarget.Roof3, typeof(Renderer), true);

        EditorGUILayout.EndToggleGroup();

        RetroGroup_bool = EditorGUILayout.BeginToggleGroup("Retro Materials", RetroGroup_bool);
        myTarget.Retro_Roof1Mat = (Material)EditorGUILayout.ObjectField("Roof Mat :", myTarget.Retro_Roof1Mat, typeof(Renderer), true);
        

        EditorGUILayout.EndToggleGroup();
    }


    


}

