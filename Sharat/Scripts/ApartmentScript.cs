using UnityEngine;
using System.Collections;

public class ApartmentScript : MonoBehaviour {

    public GameObject FlyCam;
    public GameObject WalkCam;

    public GameObject Roof;

	// Use this for initialization
	void Start () {


        FlyMode();

	}
	
    public void WalkMode()
    {
        Roof.SetActive(true);

        WalkCam.SetActive(true);
        FlyCam.SetActive(false);
    }

    public void FlyMode()
    {
        Roof.SetActive(false);

        WalkCam.SetActive(false);
        FlyCam.SetActive(true);
    }

	// Update is called once per frame
	void Update () {
	
	}
}
