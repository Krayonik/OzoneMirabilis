using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MaterialManager : MonoBehaviour {

    [SerializeField]
    public Renderer Roof1;
    [SerializeField]
    public Renderer Roof2;
    [SerializeField]
    public Renderer Roof3;

    [SerializeField]
    public Renderer Wall;


    //Retro
    [SerializeField]
    public Material Retro_Roof1Mat;
    [SerializeField]
    public string[] Retro_Walls;

	// Use this for initialization
	void Start () {

        Roof1.material = Retro_Roof1Mat;
        Roof2.material = Retro_Roof1Mat;
        Roof3.material = Retro_Roof1Mat;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
