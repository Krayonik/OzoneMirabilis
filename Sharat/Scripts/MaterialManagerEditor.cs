using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;

[CustomEditor(typeof(MaterialManager))]
public class MaterialManagerEditor : Editor {


    bool MainMat_bool = true;
    bool RetroGroup_bool = true;

    private bool listVisibility = true;
    private string entry;
    MaterialManager myTarget;


    SerializedObject serializedObj;

    SerializedProperty Retro_Walls;
    SerializedProperty Retro_Floors;

    SerializedProperty Danish_Walls;
    SerializedProperty Danish_Floors;

    SerializedProperty Contemp_Walls;
    SerializedProperty Contemp_Floors;

    void OnEnable()
    {
        serializedObj = new SerializedObject(target);
        myTarget = (MaterialManager)target;

        Retro_Walls = serializedObj.FindProperty("Retro_Walls");
        Retro_Floors = serializedObj.FindProperty("Retro_Floors");

        Danish_Walls = serializedObj.FindProperty("Danish_Walls");
        Danish_Floors = serializedObj.FindProperty("Danish_Floors");

        Contemp_Walls = serializedObj.FindProperty("Contemp_Walls");
        Contemp_Floors = serializedObj.FindProperty("Contemp_Floors");
    }

    public override void OnInspectorGUI()
    {


        serializedObj.Update();

        EditorGUILayout.BeginToggleGroup("Props Link ", true);

        myTarget.Props_Retro = (GameObject) EditorGUILayout.ObjectField("Retro Ref :", myTarget.Props_Retro, typeof(GameObject), true);
        myTarget.Props_Danish = (GameObject) EditorGUILayout.ObjectField("Danish Ref :", myTarget.Props_Danish, typeof(GameObject), true);
        myTarget.Props_Contemp = (GameObject) EditorGUILayout.ObjectField("Contemp Ref :", myTarget.Props_Contemp, typeof(GameObject), true);
        

        EditorGUILayout.EndToggleGroup();


        //myTarget.experience = EditorGUILayout.IntField("Experience", myTarget.experience);
        //EditorGUILayout.LabelField("Level", myTarget.Level.ToString());

        //MainMat_bool = EditorGUILayout.BeginToggleGroup("Main Materials", MainMat_bool);
        EditorGUILayout.BeginToggleGroup("Main Materials", true);

        myTarget.Roof1 = (Renderer) EditorGUILayout.ObjectField("Roof 1 :",myTarget.Roof1, typeof(Renderer), true);
        myTarget.Roof2 = (Renderer) EditorGUILayout.ObjectField("Roof 2 :", myTarget.Roof2, typeof(Renderer), true);
        myTarget.Roof3 = (Renderer) EditorGUILayout.ObjectField("Roof 3 :", myTarget.Roof3, typeof(Renderer), true);
        myTarget.Wall = (Renderer)EditorGUILayout.ObjectField("Wall :", myTarget.Wall, typeof(Renderer), true);
        myTarget.Floor = (Renderer)EditorGUILayout.ObjectField("Floor :", myTarget.Floor, typeof(Renderer), true);

        EditorGUILayout.EndToggleGroup();

        //Retro

        //RetroGroup_bool = EditorGUILayout.BeginToggleGroup("Retro Materials", RetroGroup_bool);
        EditorGUILayout.BeginToggleGroup("Retro Materials", true);
        
        myTarget.Retro_Roof1Mat = (Material)EditorGUILayout.ObjectField("Roof Mat :", myTarget.Retro_Roof1Mat, typeof(Renderer), true);

        
        EditorGUILayout.PropertyField(Retro_Walls, new GUIContent("Retro Walls : "), true);
        
        EditorGUILayout.PropertyField(Retro_Floors, new GUIContent("Retro Floors : "), true);
        

        EditorGUILayout.EndToggleGroup();


        //Danish

        EditorGUILayout.BeginToggleGroup("Danish Materials", true);

        //myTarget.Retro_Roof1Mat = (Material)EditorGUILayout.ObjectField("Roof Mat :", myTarget.Retro_Roof1Mat, typeof(Renderer), true);


        EditorGUILayout.PropertyField(Danish_Walls, new GUIContent("Danish Walls : "), true);

        EditorGUILayout.PropertyField(Danish_Floors, new GUIContent("Danish Floors : "), true);


        EditorGUILayout.EndToggleGroup();


        //Contemp


        EditorGUILayout.BeginToggleGroup("Contemp Materials", true);

        //myTarget.Retro_Roof1Mat = (Material)EditorGUILayout.ObjectField("Roof Mat :", myTarget.Retro_Roof1Mat, typeof(Renderer), true);


        EditorGUILayout.PropertyField(Contemp_Walls, new GUIContent("Contemp Walls : "), true);

        EditorGUILayout.PropertyField(Contemp_Floors, new GUIContent("Contemp Floors : "), true);


        EditorGUILayout.EndToggleGroup();


        //End Params

        serializedObj.ApplyModifiedProperties();
    }


    


}

