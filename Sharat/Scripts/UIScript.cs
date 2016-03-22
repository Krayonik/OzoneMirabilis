using UnityEngine;
using System.Collections;

public class UIScript : MonoBehaviour {

    public Animator Amen_Animator;

    bool Amen_State;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
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
