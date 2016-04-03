using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class MaterialManager : MonoBehaviour {

    [SerializeField]
    public GameObject Props_Retro;
    [SerializeField]
    public GameObject Props_Danish;
    [SerializeField]
    public GameObject Props_Contemp;

    [SerializeField]
    public Renderer Roof1;
    [SerializeField]
    public Renderer Roof2;
    [SerializeField]
    public Renderer Roof3;

    [SerializeField]
    public Renderer Wall;
    [SerializeField]
    public Renderer Floor;

    //Retro
    [SerializeField]
    public Material Retro_Roof1Mat;
    [SerializeField]
    public Material[] Retro_Walls;
    [SerializeField]
    public Material[] Retro_Floors;


    //Danish
    [SerializeField]
    public Material Danish_Roof1Mat;
    [SerializeField]
    public Material[] Danish_Walls;
    [SerializeField]
    public Material[] Danish_Floors;


    //Contemp
    [SerializeField]
    public Material Contemp_Roof1Mat;
    [SerializeField]
    public Material[] Contemp_Walls;
    [SerializeField]
    public Material[] Contemp_Floors;


	// Use this for initialization
	void Start () {

        string levelName = SceneManager.GetActiveScene().name;

        Debug.Log(levelName);
        switch(levelName)
        {
            case "Wing_B_Flat_No_02_Type01":
                Wing_B_FlatNo_02_Type01_Retro();
                break;
        }

	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public void Wing_B_FlatNo_02_Type01_Retro()
    {
        Props_Retro.SetActive(true);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(false);

        Floor.materials = Retro_Floors;
        Wall.materials = Retro_Walls;
    }
    public void Wing_B_FlatNo_02_Type01_Danish()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(true);
        Props_Contemp.SetActive(false);

        Floor.materials = Danish_Floors;
        Wall.materials = Danish_Walls;
    }
    public void Wing_B_FlatNo_02_Type01_Contemp()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(true);

        Floor.materials = Contemp_Floors;
        Wall.materials = Contemp_Walls;
    }


}