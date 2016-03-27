using UnityEngine;
using System.Collections;

public class RenderVisiblity : MonoBehaviour {


    Renderer _this;

    public GameObject UILink;
	// Use this for initialization
	void Start () {
        _this = this.GetComponent<Renderer>();

        UILink.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
        
	}

    void  OnBecameVisible()
    {
        UILink.SetActive(true);
    }

    void OnBecameInvisible()
    {
        UILink.SetActive(false);
    }
}
