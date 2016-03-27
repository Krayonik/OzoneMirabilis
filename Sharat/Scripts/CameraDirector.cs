using UnityEngine;
using System.Collections;

public class CameraDirector : MonoBehaviour {


    public KGFOrbitCamSettings CityViewSettings;
    public KGFOrbitCamSettings ProjectViewSettings;

	// Use this for initialization
	void Start () {

        CityViewSettings.Apply();

	}


    public void OnClick_CityView()
    {
        CityViewSettings.Apply();
    }

    public void OnClick_ProjectView()
    {
        ProjectViewSettings.Apply();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
