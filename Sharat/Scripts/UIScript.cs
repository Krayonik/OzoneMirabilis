using UnityEngine;
using System.Collections;

public class UIScript : MonoBehaviour {
    //Ameneities
    public Animator Amen_Animator;
    public GameObject Amen_Object;
    bool Amen_State;


    //Landmarks
    public Animator Land_Animator;
    public GameObject Land_Object;
    bool Land_State;

    //Landmarks
    public Animator Apart_Animator;
    public GameObject Apart_Object;
    bool Apart_State;




	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void CloseAndHideApartPanel()
    {
        Apart_Animator.SetBool("Open", false);
        Apart_Object.SetActive(false);
        Apart_State = false;
    }
    public void CloseAndHideLandPanel()
    {
        Land_Animator.SetBool("Open", false);
        Land_Object.SetActive(false);
        Land_State = false;
    }
    public void CloseAndHideAmenPanel()
    {
        Amen_Animator.SetBool("Open", false);
        Amen_Object.SetActive(false);
        Amen_State = false;
    }
    public void ShowApartPanel()
    {
        Apart_Object.SetActive(true);
    }
    public void ShowLandPanel()
    {
        Land_Object.SetActive(true);
    }
    public void ShowAmenPanel()
    {
        Amen_Object.SetActive(true);
    }

    public void ToggleApartPanel()
    {
        if (Apart_State)
        {
            Apart_Animator.SetBool("Open", false);
        }
        else
        {
            Apart_Animator.SetBool("Open", true);
        }
        Apart_State = !Apart_State;
    }
    public void ToggleLandPanel()
    {
        if (Land_State)
        {
            Land_Animator.SetBool("Open", false);
        }
        else
        {
            Land_Animator.SetBool("Open", true);
        }
        Land_State = !Land_State;
    }

    public void ToggleAmenPanel()
    {
        if(Amen_State)
        {
            Amen_Animator.SetBool("Open", false);
        }
        else
        {
            Amen_Animator.SetBool("Open", true);
        }
        Amen_State = !Amen_State;
    }


}
