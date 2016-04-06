using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CameraDirector : MonoBehaviour {


    public KGFOrbitCamSettings CityViewSettings;
    public KGFOrbitCamSettings ProjectViewSettings;
    public KGFOrbitCamSettings ProjectViewSettings2;
    public KGFOrbitCamSettings ApartmentViewSettings;


    public GameObject VR_Button;
    public GameObject Back_Button;

    public GameObject Terrain_Mumbai;


    public CanvasGroup LocationsUI;
    public CanvasGroup WorldspaceUI;

    public Image City_Button;
    public Image Project_Button;
    public Image Apartment_Button;

    public Color Inactive_Color;
    public Color Active_Color;

    private UIScript UIS;

    public GameObject[] Outter_Amenities;
    public GameObject[] Inner_Amenities;
    public GameObject[] ToHideGOs;



    public ScrollRect ApartmentView_Rect;
    public RectTransform[] Content_Panels;
    public GameObject[] FloorObjects;

    public enum MenuState
    {
        City,
        Project,
        Apartment,
        Unit
    };

    public void FloorSelection(int num)
    {
        foreach (var item in Content_Panels)
        {
            item.gameObject.SetActive(false);
        }
        Content_Panels[num - 1].gameObject.SetActive(true);
        ApartmentView_Rect.content = Content_Panels[num - 1];
    }

    private MenuState currState;

    public MenuState CurrState
    {
        get { return currState; }
        set
        {
            currState = value;
            switch(currState)
            {
                case MenuState.City:
                    Event_CityView();
                    break;
                case MenuState.Project:
                    Event_ProjectView();
                    break;
                case MenuState.Apartment:
                    Event_ApartmentView();
                    break;
                case MenuState.Unit:
                    Event_UnitView();
                    break;
            }
        }
    }


    IEnumerator LocationUIChange(bool direction)
    {
        float SeedValue = 1;

        if(direction)
        {
            for (int i = 0; i < 10; i++)
            {
                LocationsUI.alpha += 0.1f;
                WorldspaceUI.alpha += 0.1f;
                yield return new WaitForSeconds(Time.deltaTime * SeedValue);
            }
        }
        else
        {
            for (int i = 0; i < 10; i++)
            {
                LocationsUI.alpha -= 0.1f;
                WorldspaceUI.alpha -= 0.1f;
                yield return new WaitForSeconds(Time.deltaTime * SeedValue);
            }
        }
        
    }

    void Event_UnitView()
    {

    }

    void Event_CityView()
    {
        StartCoroutine("LocationUIChange", true);
        foreach (var item in ToHideGOs)
        {
            item.SetActive(true);
        }
        foreach (var item in FloorObjects)
        {
            item.SetActive(false);
        }
        foreach (var item in Outter_Amenities)
        {
            item.SetActive(false);
        }
        foreach (var item in Inner_Amenities)
        {
            item.SetActive(false);
        }

        City_Button.color = Active_Color;
        Project_Button.color = Inactive_Color;
        Apartment_Button.color = Inactive_Color;
        UIS.CloseAndHideAmenPanel();
        UIS.CloseAndHideApartPanel();
        UIS.ShowLandPanel();

    }

    void Show_InnerAmen()
    {
        foreach (var item in Inner_Amenities)
        {
            item.SetActive(true);
        }
    }
    void Show_OutterAmen()
    {
        foreach (var item in Outter_Amenities)
        {
            item.SetActive(true);
        }
    }
    void Hide_InnerAmen()
    {
        foreach (var item in Inner_Amenities)
        {
            item.SetActive(false);
        }
    }
    void Hide_OutterAmen()
    {
        foreach (var item in Outter_Amenities)
        {
            item.SetActive(false);
        }
    }

    public void Select_Amen(int num)
    {
        

        if(num == 1 || num == 9)
        {
            ProjectViewSettings.Apply();
            Show_OutterAmen();
            Hide_InnerAmen();
            foreach (var item in ToHideGOs)
            {
                item.SetActive(true);
            }
        }
        else
        {
            ProjectViewSettings2.Apply();
            Show_InnerAmen();
            Hide_OutterAmen();
            foreach (var item in ToHideGOs)
            {
                item.SetActive(false);
            }
        }
    }


    void Event_ProjectView()
    {
        foreach (var item in ToHideGOs)
        {
            item.SetActive(true);
        }
        foreach (var item in FloorObjects)
        {
            item.SetActive(false);
        }
        foreach (var item in Outter_Amenities)
        {
            item.SetActive(true);
        }
        
        foreach (var item in Inner_Amenities)
        {
            item.SetActive(false);
        }
        StartCoroutine("LocationUIChange", false);

        City_Button.color = Inactive_Color;
        Project_Button.color = Active_Color;
        Apartment_Button.color = Inactive_Color;
        UIS.CloseAndHideLandPanel();
        UIS.CloseAndHideApartPanel();
        UIS.ShowAmenPanel();

    }

    void Event_ApartmentView()
    {
        foreach (var item in ToHideGOs)
        {
            item.SetActive(true);
        }
        foreach (var item in FloorObjects)
        {
            item.SetActive(true);
        }
        foreach (var item in Outter_Amenities)
        {
            item.SetActive(false);
        }
        foreach (var item in Inner_Amenities)
        {
            item.SetActive(false);
        }
        City_Button.color = Inactive_Color;
        Project_Button.color = Inactive_Color;
        Apartment_Button.color = Active_Color;
        UIS.CloseAndHideAmenPanel();
        UIS.CloseAndHideLandPanel();
        UIS.ShowApartPanel();

    }

	// Use this for initialization
	void Start () {

        Active_Color = new Color(0.2f, 0.388f, 0.47f, 1);
        Inactive_Color = City_Button.color;

        LocationsUI.alpha = 0;
        WorldspaceUI.alpha = 0;

        CityViewSettings.Apply();
        VR_Button.SetActive(false);
        Back_Button.SetActive(false);

        UIS = this.GetComponent<UIScript>();

        CurrState = MenuState.City;

	}


    public void OnClick_CityView()
    {
        CityViewSettings.Apply();
        Terrain_Mumbai.SetActive(true);
        VR_Button.SetActive(false);
        Back_Button.SetActive(false);
        CurrState = MenuState.City;
    }

    public void OnClick_ProjectView()
    {
        ProjectViewSettings.Apply();
        Terrain_Mumbai.SetActive(false);
        VR_Button.SetActive(true);
        Back_Button.SetActive(true);
        CurrState = MenuState.Project;
    }

    public void OnClick_ApartmentView()
    {
        ApartmentViewSettings.Apply();
        Terrain_Mumbai.SetActive(false);
        VR_Button.SetActive(false);
        Back_Button.SetActive(true);
        CurrState = MenuState.Apartment;
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
