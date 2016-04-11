using UnityEngine;
using System.Collections;

public class ApartmentScript : MonoBehaviour {

    public GameObject FlyCam;
    public GameObject WalkCam;

    public GameObject Roof;
    public GameObject _target;

	// Use this for initialization
	void Start () {

        _target = this.gameObject;

        FlyMode();

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
