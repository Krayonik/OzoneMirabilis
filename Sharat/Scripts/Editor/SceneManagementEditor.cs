using UnityEngine;
using UnityEditor;
using System.Collections;
using System.IO;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;

public class SceneManagementEditor : EditorWindow {


    public static string[] Scenes;

    [MenuItem("EyE-RiS/SceneManager")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(SceneManagementEditor));
        Start();
    }

	// Use this for initialization
	public static void Start () {

        

        

        

	}

    void OnEnable()
    {
        Scenes = Directory.GetFiles(Application.dataPath + "/OzoneMirabilis/Scenes", "*.unity");
    }

    void OnGUI()
    {

        char[] delimiters = {'/'};
        for (int i = 0; i < Scenes.Length; i++)
        {
            string[] StringToBeFed = Scenes[i].Split(delimiters);
            if (GUILayout.Button(StringToBeFed[5]))
            {
                EditorSceneManager.OpenScene(Scenes[i]);
            }
        }



    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
