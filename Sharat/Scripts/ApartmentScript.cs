using UnityEngine;
using System.Collections;

public class ApartmentScript : MonoBehaviour {

    public GameObject FlyCam;
    public GameObject WalkCam;

    public GameObject Roof;
    public GameObject _target;

    public GameObject _FloorPlan;
    public GameObject _FlatNumber;
    public GameObject _Lights;

	// Use this for initialization
	void Start () {

        _target = this.gameObject;

        //FlyMode();
        _FloorPlan = _target.transform.parent.FindChild("WorldCanvas").transform.FindChild("FloorPlan").gameObject;
        _FlatNumber = _target.transform.parent.FindChild("WorldCanvas").transform.FindChild("FlatNumber").gameObject;
        _Lights = _target.transform.parent.FindChild("Lights").gameObject;
        ActivateFloorPlan();
	}

    public void ActivateFloorPlan()
    {
        _FloorPlan.SetActive(false);
        _FlatNumber.SetActive(true);
        _Lights.SetActive(false);
    }
    public void ActivateFlatNumber()
    {
        _FloorPlan.SetActive(true);
        _FlatNumber.SetActive(false);
        _Lights.SetActive(true);
    }

	
    public void WalkMode()
    {
        _target.SendMessage("Fly_Mode", false);

        Roof.SetActive(true);

        WalkCam.SetActive(true);
        FlyCam.SetActive(false);
    }

    public void FlyMode()
    {
        _target.SendMessage("Fly_Mode", true);

        Roof.SetActive(false);

        WalkCam.SetActive(false);
        FlyCam.SetActive(true);
    }

	// Update is called once per frame
	void Update () {
	
	}
}

