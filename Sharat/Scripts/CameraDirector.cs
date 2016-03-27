using UnityEngine;
using System.Collections;

public class CameraDirector : MonoBehaviour {


    public KGFOrbitCamSettings CityViewSettings;
    public KGFOrbitCamSettings ProjectViewSettings;


    public GameObject VR_Button;
    public GameObject Back_Button;

    public enum MenuState
    {
        City,
        Project,
        Apartment
    };

    public MenuState CurrState;

	// Use this for initialization
	void Start () {

        CityViewSettings.Apply();
        VR_Button.SetActive(false);
        Back_Button.SetActive(false);

        CurrState = MenuState.City;

	}


    public void OnClick_CityView()
    {
        CityViewSettings.Apply();
        VR_Button.SetActive(false);
        Back_Button.SetActive(false);
        CurrState = MenuState.City;
    }

    public void OnClick_ProjectView()
    {
        ProjectViewSettings.Apply();
        VR_Button.SetActive(true);
        Back_Button.SetActive(true);
        CurrState = MenuState.Project;
    }
	
    public void OnClick_Back()
    {
        switch(CurrState)
        {
            case MenuState.Project:
                OnClick_CityView();
                break;
        }
    }

	// Update is called once per frame
	void Update () {
	
	}
}
