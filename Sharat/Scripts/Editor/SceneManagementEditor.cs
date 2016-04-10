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

        EditorGUILayout.LabelField("Scenes : ");

        char[] delimiters = {'/'};
        for (int i = 0; i < Scenes.Length; i++)
        {
            string[] StringToBeFed = Scenes[i].Split(delimiters);
            if (GUILayout.Button(StringToBeFed[5]))
            {
                EditorSceneManager.OpenScene(Scenes[i]);
            }
        }

        EditorGUILayout.LabelField("Patches : ");
        if (GUILayout.Button("Heirarchy Patch"))
        {
            GameObject DebugObject = new GameObject("DebugObject");
            DebugObject.layer = 8;
            DebugObject.tag = "DebugObject";
            Transform DebugObjectTranform = DebugObject.transform;
            GameObject DLight = GameObject.Find("Directional Light");
            GameObject ESystem = GameObject.Find("EventSystem");
            GameObject Cam = GameObject.Find("KGFOrbitCam");
            GameObject Canvas = GameObject.Find("Canvas");
            GameObject FPS = GameObject.Find("FPSController");

            DLight.transform.SetParent(DebugObjectTranform);
            ESystem.transform.SetParent(DebugObjectTranform);
            Cam.transform.SetParent(DebugObjectTranform);
            Canvas.transform.SetParent(DebugObjectTranform);
            FPS.transform.SetParent(DebugObjectTranform);

            GameObject LevelObject = new GameObject(SceneManager.GetActiveScene().name);
            LevelObject.tag = "LevelObject";
            GameObject[] RootObjects = SceneManager.GetActiveScene().GetRootGameObjects();
            for (int i = 0; i < RootObjects.Length; i++)
            {
                if (RootObjects[i].tag == "LevelObject" || RootObjects[i].tag == "DebugObject")
                {
                    
                }
                else
                {
                    RootObjects[i].transform.SetParent(LevelObject.transform);
                }
            }

        }


    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
