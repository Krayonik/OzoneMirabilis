using UnityEngine;
using UnityEditor;
using System.Collections;

public class MatManagerWindow : EditorWindow {


    static GameObject ScriptObject;
    static MaterialManager myTarget;

    SerializedObject serializedObj;

    SerializedProperty Door_Frames;
    SerializedProperty Window_Frames;
    SerializedProperty Bathroom_Window_Frames;
    SerializedProperty Retro_False_Roof;

    SerializedProperty Retro_Roof1;
    SerializedProperty Retro_Roof2;
    SerializedProperty Retro_Roof3;
    SerializedProperty Retro_Roof4;
    SerializedProperty Retro_Walls;
    SerializedProperty Retro_Floors;
    SerializedProperty Retro_Skirting;
    SerializedProperty Retro_DoorFrames;
    SerializedProperty Retro_WindowFrames;
    SerializedProperty Retro_BathroomWindowFrames;

    SerializedProperty Danish_Roof1;
    SerializedProperty Danish_Roof2;
    SerializedProperty Danish_Roof3;
    SerializedProperty Danish_Roof4;
    SerializedProperty Danish_Walls;
    SerializedProperty Danish_Floors;
    SerializedProperty Danish_Skirting;
    SerializedProperty Danish_DoorFrames;
    SerializedProperty Danish_WindowFrames;
    SerializedProperty Danish_BathroomWindowFrames;

    SerializedProperty Contemp_Roof1;
    SerializedProperty Contemp_Roof2;
    SerializedProperty Contemp_Roof3;
    SerializedProperty Contemp_Roof4;
    SerializedProperty Contemp_Walls;
    SerializedProperty Contemp_Floors;
    SerializedProperty Contemp_Skirting;
    SerializedProperty Contemp_DoorFrames;
    SerializedProperty Contemp_WindowFrames;
    SerializedProperty Contemp_BathroomWindowFrames;

    Vector2 scrollPos;

    [MenuItem("EyE-RiS/MaterialManager")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(MatManagerWindow));
    }

    void OnEnable()
    {
        ScriptObject = GameObject.Find("ScriptObject");
        if(ScriptObject!=null)
        {
            Debug.Log("ScriptObject found!");
        }
        else
        {
            Debug.Log("ScriptObject not found!");
        }
        if(ScriptObject.GetComponent<MaterialManager>())
        {
            Debug.Log("Material Manager found!");
        }
        else
        {
            Debug.Log("Material Manager not found! Adding the component");
            ScriptObject.AddComponent<MaterialManager>();
            EditorApplication.SaveScene();
        }
        myTarget = ScriptObject.GetComponent<MaterialManager>();

        serializedObj = new SerializedObject(myTarget);
        //myTarget = (MaterialManager)ScriptObject;

        Door_Frames = serializedObj.FindProperty("Door_Frames");
        Window_Frames = serializedObj.FindProperty("Window_Frames");
        Bathroom_Window_Frames = serializedObj.FindProperty("Bathroom_Window_Frames");
        Retro_False_Roof = serializedObj.FindProperty("Retro_False_Roof");

        Retro_Roof1 = serializedObj.FindProperty("Retro_Roof1");
        Retro_Roof2 = serializedObj.FindProperty("Retro_Roof2");
        Retro_Roof3 = serializedObj.FindProperty("Retro_Roof3");
        Retro_Roof4 = serializedObj.FindProperty("Retro_Roof4");
        Retro_Walls = serializedObj.FindProperty("Retro_Walls");
        Retro_Floors = serializedObj.FindProperty("Retro_Floors");
        Retro_Skirting = serializedObj.FindProperty("Retro_Skirting");
        Retro_DoorFrames = serializedObj.FindProperty("Retro_DoorFrames");
        Retro_WindowFrames = serializedObj.FindProperty("Retro_WindowFrames");
        Retro_BathroomWindowFrames = serializedObj.FindProperty("Retro_BathroomWindowFrames");

        Danish_Roof1 = serializedObj.FindProperty("Danish_Roof1");
        Danish_Roof2 = serializedObj.FindProperty("Danish_Roof2");
        Danish_Roof3 = serializedObj.FindProperty("Danish_Roof3");
        Danish_Roof4 = serializedObj.FindProperty("Danish_Roof4");
        Danish_Walls = serializedObj.FindProperty("Danish_Walls");
        Danish_Floors = serializedObj.FindProperty("Danish_Floors");
        Danish_Skirting = serializedObj.FindProperty("Danish_Skirting");
        Danish_DoorFrames = serializedObj.FindProperty("Danish_DoorFrames");
        Danish_WindowFrames = serializedObj.FindProperty("Danish_WindowFrames");
        Danish_BathroomWindowFrames = serializedObj.FindProperty("Danish_BathroomWindowFrames");


        Contemp_Roof1 = serializedObj.FindProperty("Contemp_Roof1");
        Contemp_Roof2 = serializedObj.FindProperty("Contemp_Roof2");
        Contemp_Roof3 = serializedObj.FindProperty("Contemp_Roof3");
        Contemp_Roof4 = serializedObj.FindProperty("Contemp_Roof4");
        Contemp_Walls = serializedObj.FindProperty("Contemp_Walls");
        Contemp_Floors = serializedObj.FindProperty("Contemp_Floors");
        Contemp_Skirting = serializedObj.FindProperty("Contemp_Skirting");
        Contemp_DoorFrames = serializedObj.FindProperty("Contemp_DoorFrames");
        Contemp_WindowFrames = serializedObj.FindProperty("Contemp_WindowFrames");
        Contemp_BathroomWindowFrames = serializedObj.FindProperty("Contemp_BathroomWindowFrames");

    }

    void OnGUI () 
    {
        serializedObj.Update();

        scrollPos = EditorGUILayout.BeginScrollView(scrollPos);

        EditorGUILayout.BeginToggleGroup("Props Link ", true);

        myTarget.Props_Retro = (GameObject) EditorGUILayout.ObjectField("Retro Ref :", myTarget.Props_Retro, typeof(GameObject), true);
        myTarget.Props_Danish = (GameObject) EditorGUILayout.ObjectField("Danish Ref :", myTarget.Props_Danish, typeof(GameObject), true);
        myTarget.Props_Contemp = (GameObject) EditorGUILayout.ObjectField("Contemp Ref :", myTarget.Props_Contemp, typeof(GameObject), true);
        EditorGUILayout.PropertyField(Retro_False_Roof, new GUIContent("Retro False Roof Refs : "), true);
        

        EditorGUILayout.EndToggleGroup();


        //myTarget.experience = EditorGUILayout.IntField("Experience", myTarget.experience);
        //EditorGUILayout.LabelField("Level", myTarget.Level.ToString());

        //MainMat_bool = EditorGUILayout.BeginToggleGroup("Main Materials", MainMat_bool);
        EditorGUILayout.BeginToggleGroup("Main Materials", true);

        myTarget.Roof1 = (Renderer) EditorGUILayout.ObjectField("Roof 1 :",myTarget.Roof1, typeof(Renderer), true);
        myTarget.Roof2 = (Renderer) EditorGUILayout.ObjectField("Roof 2 :", myTarget.Roof2, typeof(Renderer), true);
        myTarget.Roof3 = (Renderer) EditorGUILayout.ObjectField("Roof 3 :", myTarget.Roof3, typeof(Renderer), true);
        myTarget.Roof4 = (Renderer)EditorGUILayout.ObjectField("Roof 4 :", myTarget.Roof4, typeof(Renderer), true);
        myTarget.Wall = (Renderer)EditorGUILayout.ObjectField("Wall :", myTarget.Wall, typeof(Renderer), true);
        myTarget.Floor = (Renderer)EditorGUILayout.ObjectField("Floor :", myTarget.Floor, typeof(Renderer), true);
        myTarget.Skirting = (Renderer)EditorGUILayout.ObjectField("Skirting :", myTarget.Skirting, typeof(Renderer), true);
        EditorGUILayout.PropertyField(Door_Frames, new GUIContent("Door Frames : "), true);
        EditorGUILayout.PropertyField(Window_Frames, new GUIContent("Window Frames : "), true);
        EditorGUILayout.PropertyField(Bathroom_Window_Frames, new GUIContent("Bathroom Window Frames : "), true);

        EditorGUILayout.EndToggleGroup();

        //Retro

        //RetroGroup_bool = EditorGUILayout.BeginToggleGroup("Retro Materials", RetroGroup_bool);
        EditorGUILayout.BeginToggleGroup("Retro Materials", true);

        EditorGUILayout.PropertyField(Retro_Roof1, new GUIContent("Retro Roof1 : "), true);

        EditorGUILayout.PropertyField(Retro_Roof2, new GUIContent("Retro Roof2 : "), true);

        EditorGUILayout.PropertyField(Retro_Roof3, new GUIContent("Retro Roof3 : "), true);

        EditorGUILayout.PropertyField(Retro_Roof4, new GUIContent("Retro Roof4 : "), true);
        
        EditorGUILayout.PropertyField(Retro_Walls, new GUIContent("Retro Walls : "), true);
        
        EditorGUILayout.PropertyField(Retro_Floors, new GUIContent("Retro Floors : "), true);

        EditorGUILayout.PropertyField(Retro_Skirting, new GUIContent("Retro Skirting : "), true);

        EditorGUILayout.PropertyField(Retro_DoorFrames, new GUIContent("Retro Door Frames : "), true);

        EditorGUILayout.PropertyField(Retro_WindowFrames, new GUIContent("Retro Window Frames : "), true);

        EditorGUILayout.PropertyField(Retro_BathroomWindowFrames, new GUIContent("Retro Bathroom Window Frames : "), true);
        

        EditorGUILayout.EndToggleGroup();


        //Danish

        EditorGUILayout.BeginToggleGroup("Danish Materials", true);

        //myTarget.Retro_Roof1Mat = (Material)EditorGUILayout.ObjectField("Roof Mat :", myTarget.Retro_Roof1Mat, typeof(Renderer), true);

        EditorGUILayout.PropertyField(Danish_Roof1, new GUIContent("Danish Roof1 : "), true);

        EditorGUILayout.PropertyField(Danish_Roof2, new GUIContent("Danish Roof2 : "), true);

        EditorGUILayout.PropertyField(Danish_Roof3, new GUIContent("Danish Roof3 : "), true);

        EditorGUILayout.PropertyField(Danish_Roof4, new GUIContent("Danish Roof4 : "), true);

        EditorGUILayout.PropertyField(Danish_Walls, new GUIContent("Danish Walls : "), true);

        EditorGUILayout.PropertyField(Danish_Floors, new GUIContent("Danish Floors : "), true);

        EditorGUILayout.PropertyField(Danish_Skirting, new GUIContent("Danish Skirting : "), true);

        EditorGUILayout.PropertyField(Danish_DoorFrames, new GUIContent("Danish Door Frames : "), true);

        EditorGUILayout.PropertyField(Danish_WindowFrames, new GUIContent("Danish Window Frames : "), true);

        EditorGUILayout.PropertyField(Danish_BathroomWindowFrames, new GUIContent("Danish Bathroom Window Frames : "), true);

        EditorGUILayout.EndToggleGroup();


        //Contemp


        EditorGUILayout.BeginToggleGroup("Contemp Materials", true);

        //myTarget.Retro_Roof1Mat = (Material)EditorGUILayout.ObjectField("Roof Mat :", myTarget.Retro_Roof1Mat, typeof(Renderer), true);

        EditorGUILayout.PropertyField(Contemp_Roof1, new GUIContent("Contemp Roof1 : "), true);

        EditorGUILayout.PropertyField(Contemp_Roof2, new GUIContent("Contemp Roof2 : "), true);

        EditorGUILayout.PropertyField(Contemp_Roof3, new GUIContent("Contemp Roof3 : "), true);

        EditorGUILayout.PropertyField(Contemp_Roof4, new GUIContent("Contemp Roof4 : "), true);

        EditorGUILayout.PropertyField(Contemp_Walls, new GUIContent("Contemp Walls : "), true);

        EditorGUILayout.PropertyField(Contemp_Floors, new GUIContent("Contemp Floors : "), true);

        EditorGUILayout.PropertyField(Contemp_Skirting, new GUIContent("Contemp Skirting : "), true);

        EditorGUILayout.PropertyField(Contemp_DoorFrames, new GUIContent("Contemp Door Frames : "), true);

        EditorGUILayout.PropertyField(Contemp_WindowFrames, new GUIContent("Contemp Window Frames : "), true);

        EditorGUILayout.PropertyField(Contemp_BathroomWindowFrames, new GUIContent("Contemp Bathroom Window Frames : "), true);


        EditorGUILayout.EndToggleGroup();


        EditorGUILayout.EndScrollView();
        //End Params

        serializedObj.ApplyModifiedProperties();
    }




}



