using UnityEngine;
using System.Collections;

public class UIScript : MonoBehaviour {
    //Ameneities
    public Animator Amen_Animator;

    bool Amen_State;


    //Landmarks
    public Animator Land_Animator;

    bool Land_State;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
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
