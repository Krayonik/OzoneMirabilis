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
    public GameObject[] Retro_False_Roof;

    [SerializeField]
    public Renderer Roof1;
    [SerializeField]
    public Renderer Roof2;
    [SerializeField]
    public Renderer Roof3;
    [SerializeField]
    public Renderer Roof4;

    [SerializeField]
    public Renderer Wall;
    [SerializeField]
    public Renderer Floor;
    [SerializeField]
    public Renderer Skirting;

    [SerializeField]
    public Renderer[] Door_Frames;
    [SerializeField]
    public Renderer[] Window_Frames;
    [SerializeField]
    public Renderer[] Bathroom_Window_Frames;


    //Retro
    [SerializeField]
    public Material[] Retro_Roof1;
    [SerializeField]
    public Material[] Retro_Roof2;
    [SerializeField]
    public Material[] Retro_Roof3;
    [SerializeField]
    public Material[] Retro_Roof4;
    [SerializeField]
    public Material[] Retro_Walls;
    [SerializeField]
    public Material[] Retro_Floors;
    [SerializeField]
    public Material[] Retro_Skirting;
    [SerializeField]
    public Material[] Retro_DoorFrames;
    [SerializeField]
    public Material[] Retro_WindowFrames;
    [SerializeField]
    public Material[] Retro_BathroomWindowFrames;

    //Danish
    [SerializeField]
    public Material[] Danish_Roof1;
    [SerializeField]
    public Material[] Danish_Roof2;
    [SerializeField]
    public Material[] Danish_Roof3;
    [SerializeField]
    public Material[] Danish_Roof4;
    [SerializeField]
    public Material[] Danish_Walls;
    [SerializeField]
    public Material[] Danish_Floors;
    [SerializeField]
    public Material[] Danish_Skirting;
    [SerializeField]
    public Material[] Danish_DoorFrames;
    [SerializeField]
    public Material[] Danish_WindowFrames;
    [SerializeField]
    public Material[] Danish_BathroomWindowFrames;

    //Contemp
    [SerializeField]
    public Material[] Contemp_Roof1;
    [SerializeField]
    public Material[] Contemp_Roof2;
    [SerializeField]
    public Material[] Contemp_Roof3;
    [SerializeField]
    public Material[] Contemp_Roof4;
    [SerializeField]
    public Material[] Contemp_Walls;
    [SerializeField]
    public Material[] Contemp_Floors;
    [SerializeField]
    public Material[] Contemp_Skirting;
    [SerializeField]
    public Material[] Contemp_DoorFrames;
    [SerializeField]
    public Material[] Contemp_WindowFrames;
    [SerializeField]
    public Material[] Contemp_BathroomWindowFrames;


	// Use this for initialization
	void Start () {

        string levelName = SceneManager.GetActiveScene().name;

        Debug.Log(levelName);
        switch(levelName)
        {
            case "Wing_A_Flat_No_01_Type01":
                Wing_A_FlatNo_01_Type01_Retro();
                break;
            case "Wing_A_Flat_No_01_Type02":
                Wing_A_FlatNo_01_Type02_Retro();
                break;
            case "Wing_A_Flat_No_01_Type03":
                Wing_A_FlatNo_01_Type03_Retro();
                break;
            case "Wing_A_Flat_No_02_Type01":
                Wing_A_FlatNo_02_Type01_Retro();
                break;
            case "Wing_A_Flat_No_02_Type02":
                Wing_A_FlatNo_02_Type02_Retro();
                break;
            case "Wing_A_Flat_No_03_Type01":
                Wing_A_FlatNo_03_Type01_Retro();
                break;
            case "Wing_A_Flat_No_03_Type02":
                Wing_A_FlatNo_03_Type02_Retro();
                break;
            case "Wing_A_Flat_No_03_Type03":
                Wing_A_FlatNo_03_Type03_Retro();
                break;
            case "Wing_A_Flat_No_04_Type01":
                Wing_A_FlatNo_04_Type01_Retro();
                break;
            case "Wing_A_Flat_No_04_Type02":
                Wing_A_FlatNo_04_Type01_Retro();
                break;
            case "Wing_A_Flat_No_04_Type03":
                Wing_A_FlatNo_04_Type03_Retro();
                break;
            case "Wing_B_Flat_No_01_Type01":
                Wing_B_FlatNo_01_Type01_Retro();
                break;
            case "Wing_B_Flat_No_01_Type02":
                Wing_B_FlatNo_01_Type02_Retro();
                break;
            case "Wing_B_Flat_No_01_Type03":
                Wing_B_FlatNo_01_Type03_Retro();
                break;
            case "Wing_B_Flat_No_02_Type01":
                Wing_B_FlatNo_02_Type01_Retro();
                break;
            case "Wing_B_Flat_No_02_Type02":
                Wing_B_FlatNo_02_Type02_Retro();
                break;
            case "Wing_B_Flat_No_03_Type01":
                Wing_B_FlatNo_03_Type01_Retro();
                break;
            case "Wing_B_Flat_No_03_Type02":
                Wing_B_FlatNo_03_Type02_Retro();
                break;
            case "Wing_B_Flat_No_03_Type03":
                Wing_B_FlatNo_03_Type03_Retro();
                break;
            case "Wing_B_Flat_No_04_Type01":
                Wing_B_FlatNo_04_Type01_Retro();
                break;
            case "Wing_B_Flat_No_04_Type02":
                Wing_B_FlatNo_04_Type01_Retro();
                break;
            case "Wing_B_Flat_No_04_Type03":
                Wing_B_FlatNo_04_Type03_Retro();
                break;
        }

	}
	
	// Update is called once per frame
	void Update () {
	
	}


    //*******************
    //***  WING A   *****
    //*******************

    //Wing_A_FlatNo_01_Type01

    public void Wing_A_FlatNo_01_Type01_Retro()
    {
        Props_Retro.SetActive(true);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(true);
        }


        Roof1.materials = Retro_Roof1;
        Roof2.materials = Retro_Roof2;
        Roof3.materials = Retro_Roof3;
        Roof4.materials = Retro_Roof4;
        Floor.materials = Retro_Floors;
        Wall.materials = Retro_Walls;
        Skirting.materials = Retro_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Retro_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Retro_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Retro_BathroomWindowFrames;
        }
        
    }
    public void Wing_A_FlatNo_01_Type01_Danish()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(true);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Danish_Roof1;
        Roof2.materials = Danish_Roof2;
        Roof3.materials = Danish_Roof3;
        Roof4.materials = Danish_Roof4;
        Floor.materials = Danish_Floors;
        Wall.materials = Danish_Walls;
        Skirting.materials = Danish_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Danish_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Danish_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Danish_BathroomWindowFrames;
        }
    }
    public void Wing_A_FlatNo_01_Type01_Contemp()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(true);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Contemp_Roof1;
        Roof2.materials = Contemp_Roof2;
        Roof3.materials = Contemp_Roof3;
        Roof4.materials = Contemp_Roof4;
        Floor.materials = Contemp_Floors;
        Wall.materials = Contemp_Walls;
        Skirting.materials = Contemp_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Contemp_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Contemp_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Contemp_BathroomWindowFrames;
        }
    }


    //Wing_A_FlatNo_01_Type02

    public void Wing_A_FlatNo_01_Type02_Retro()
    {
        Props_Retro.SetActive(true);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(true);
        }


        Roof1.materials = Retro_Roof1;
        Roof2.materials = Retro_Roof2;
        Roof3.materials = Retro_Roof3;
        Roof4.materials = Retro_Roof4;
        Floor.materials = Retro_Floors;
        Wall.materials = Retro_Walls;
        Skirting.materials = Retro_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Retro_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Retro_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Retro_BathroomWindowFrames;
        }

    }
    public void Wing_A_FlatNo_01_Type02_Danish()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(true);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Danish_Roof1;
        Roof2.materials = Danish_Roof2;
        Roof3.materials = Danish_Roof3;
        Roof4.materials = Danish_Roof4;
        Floor.materials = Danish_Floors;
        Wall.materials = Danish_Walls;
        Skirting.materials = Danish_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Danish_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Danish_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Danish_BathroomWindowFrames;
        }
    }
    public void Wing_A_FlatNo_01_Type02_Contemp()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(true);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Contemp_Roof1;
        Roof2.materials = Contemp_Roof2;
        Roof3.materials = Contemp_Roof3;
        Roof4.materials = Contemp_Roof4;
        Floor.materials = Contemp_Floors;
        Wall.materials = Contemp_Walls;
        Skirting.materials = Contemp_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Contemp_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Contemp_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Contemp_BathroomWindowFrames;
        }
    }


    //Wing_A_FlatNo_01_Type03

    public void Wing_A_FlatNo_01_Type03_Retro()
    {
        Props_Retro.SetActive(true);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(true);
        }


        Roof1.materials = Retro_Roof1;
        Roof2.materials = Retro_Roof2;
        Roof3.materials = Retro_Roof3;
        Roof4.materials = Retro_Roof4;
        Floor.materials = Retro_Floors;
        Wall.materials = Retro_Walls;
        Skirting.materials = Retro_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Retro_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Retro_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Retro_BathroomWindowFrames;
        }

    }
    public void Wing_A_FlatNo_01_Type03_Danish()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(true);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Danish_Roof1;
        Roof2.materials = Danish_Roof2;
        Roof3.materials = Danish_Roof3;
        Roof4.materials = Danish_Roof4;
        Floor.materials = Danish_Floors;
        Wall.materials = Danish_Walls;
        Skirting.materials = Danish_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Danish_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Danish_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Danish_BathroomWindowFrames;
        }
    }
    public void Wing_A_FlatNo_01_Type03_Contemp()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(true);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Contemp_Roof1;
        Roof2.materials = Contemp_Roof2;
        Roof3.materials = Contemp_Roof3;
        Roof4.materials = Contemp_Roof4;
        Floor.materials = Contemp_Floors;
        Wall.materials = Contemp_Walls;
        Skirting.materials = Contemp_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Contemp_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Contemp_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Contemp_BathroomWindowFrames;
        }
    }




    //Wing_A_FlatNo_02_Type01

    public void Wing_A_FlatNo_02_Type01_Retro()
    {
        Props_Retro.SetActive(true);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(true);
        }


        Roof1.materials = Retro_Roof1;
        Roof2.materials = Retro_Roof2;
        Roof3.materials = Retro_Roof3;
        //Roof4.materials = Retro_Roof4;
        Floor.materials = Retro_Floors;
        Wall.materials = Retro_Walls;
        Skirting.materials = Retro_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Retro_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Retro_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Retro_BathroomWindowFrames;
        }

    }
    public void Wing_A_FlatNo_02_Type01_Danish()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(true);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Danish_Roof1;
        Roof2.materials = Danish_Roof2;
        Roof3.materials = Danish_Roof3;
        //Roof4.materials = Danish_Roof4;
        Floor.materials = Danish_Floors;
        Wall.materials = Danish_Walls;
        Skirting.materials = Danish_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Danish_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Danish_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Danish_BathroomWindowFrames;
        }
    }
    public void Wing_A_FlatNo_02_Type01_Contemp()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(true);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Contemp_Roof1;
        Roof2.materials = Contemp_Roof2;
        Roof3.materials = Contemp_Roof3;
        //Roof4.materials = Contemp_Roof4;
        Floor.materials = Contemp_Floors;
        Wall.materials = Contemp_Walls;
        Skirting.materials = Contemp_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Contemp_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Contemp_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Contemp_BathroomWindowFrames;
        }
    }



    //Wing_A_FlatNo_02_Type02

    public void Wing_A_FlatNo_02_Type02_Retro()
    {
        Props_Retro.SetActive(true);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(true);
        }


        Roof1.materials = Retro_Roof1;
        Roof2.materials = Retro_Roof2;
        Roof3.materials = Retro_Roof3;
        //Roof4.materials = Retro_Roof4;
        Floor.materials = Retro_Floors;
        Wall.materials = Retro_Walls;
        Skirting.materials = Retro_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Retro_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Retro_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Retro_BathroomWindowFrames;
        }

    }
    public void Wing_A_FlatNo_02_Type02_Danish()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(true);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Danish_Roof1;
        Roof2.materials = Danish_Roof2;
        Roof3.materials = Danish_Roof3;
        //Roof4.materials = Danish_Roof4;
        Floor.materials = Danish_Floors;
        Wall.materials = Danish_Walls;
        Skirting.materials = Danish_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Danish_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Danish_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Danish_BathroomWindowFrames;
        }
    }
    public void Wing_A_FlatNo_02_Type02_Contemp()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(true);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Contemp_Roof1;
        Roof2.materials = Contemp_Roof2;
        Roof3.materials = Contemp_Roof3;
        //Roof4.materials = Contemp_Roof4;
        Floor.materials = Contemp_Floors;
        Wall.materials = Contemp_Walls;
        Skirting.materials = Contemp_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Contemp_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Contemp_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Contemp_BathroomWindowFrames;
        }
    }



    //Wing_A_FlatNo_03_Type01

    public void Wing_A_FlatNo_03_Type01_Retro()
    {
        Props_Retro.SetActive(true);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(true);
        }


        Roof1.materials = Retro_Roof1;
        Roof2.materials = Retro_Roof2;
        Roof3.materials = Retro_Roof3;
        Roof4.materials = Retro_Roof4;
        Floor.materials = Retro_Floors;
        Wall.materials = Retro_Walls;
        Skirting.materials = Retro_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Retro_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Retro_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Retro_BathroomWindowFrames;
        }

    }
    public void Wing_A_FlatNo_03_Type01_Danish()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(true);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Danish_Roof1;
        Roof2.materials = Danish_Roof2;
        Roof3.materials = Danish_Roof3;
        Roof4.materials = Danish_Roof4;
        Floor.materials = Danish_Floors;
        Wall.materials = Danish_Walls;
        Skirting.materials = Danish_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Danish_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Danish_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Danish_BathroomWindowFrames;
        }
    }
    public void Wing_A_FlatNo_03_Type01_Contemp()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(true);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Contemp_Roof1;
        Roof2.materials = Contemp_Roof2;
        Roof3.materials = Contemp_Roof3;
        Roof4.materials = Contemp_Roof4;
        Floor.materials = Contemp_Floors;
        Wall.materials = Contemp_Walls;
        Skirting.materials = Contemp_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Contemp_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Contemp_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Contemp_BathroomWindowFrames;
        }
    }



    //Wing_A_FlatNo_03_Type02

    public void Wing_A_FlatNo_03_Type02_Retro()
    {
        Props_Retro.SetActive(true);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(true);
        }


        Roof1.materials = Retro_Roof1;
        Roof2.materials = Retro_Roof2;
        Roof3.materials = Retro_Roof3;
        Roof4.materials = Retro_Roof4;
        Floor.materials = Retro_Floors;
        Wall.materials = Retro_Walls;
        Skirting.materials = Retro_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Retro_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Retro_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Retro_BathroomWindowFrames;
        }

    }
    public void Wing_A_FlatNo_03_Type02_Danish()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(true);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Danish_Roof1;
        Roof2.materials = Danish_Roof2;
        Roof3.materials = Danish_Roof3;
        Roof4.materials = Danish_Roof4;
        Floor.materials = Danish_Floors;
        Wall.materials = Danish_Walls;
        Skirting.materials = Danish_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Danish_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Danish_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Danish_BathroomWindowFrames;
        }
    }
    public void Wing_A_FlatNo_03_Type02_Contemp()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(true);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Contemp_Roof1;
        Roof2.materials = Contemp_Roof2;
        Roof3.materials = Contemp_Roof3;
        Roof4.materials = Contemp_Roof4;
        Floor.materials = Contemp_Floors;
        Wall.materials = Contemp_Walls;
        Skirting.materials = Contemp_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Contemp_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Contemp_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Contemp_BathroomWindowFrames;
        }
    }



    //Wing_A_FlatNo_03_Type03

    public void Wing_A_FlatNo_03_Type03_Retro()
    {
        Props_Retro.SetActive(true);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(true);
        }


        Roof1.materials = Retro_Roof1;
        Roof2.materials = Retro_Roof2;
        Roof3.materials = Retro_Roof3;
        Roof4.materials = Retro_Roof4;
        Floor.materials = Retro_Floors;
        Wall.materials = Retro_Walls;
        Skirting.materials = Retro_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Retro_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Retro_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Retro_BathroomWindowFrames;
        }

    }
    public void Wing_A_FlatNo_03_Type03_Danish()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(true);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Danish_Roof1;
        Roof2.materials = Danish_Roof2;
        Roof3.materials = Danish_Roof3;
        Roof4.materials = Danish_Roof4;
        Floor.materials = Danish_Floors;
        Wall.materials = Danish_Walls;
        Skirting.materials = Danish_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Danish_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Danish_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Danish_BathroomWindowFrames;
        }
    }
    public void Wing_A_FlatNo_03_Type03_Contemp()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(true);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Contemp_Roof1;
        Roof2.materials = Contemp_Roof2;
        Roof3.materials = Contemp_Roof3;
        Roof4.materials = Contemp_Roof4;
        Floor.materials = Contemp_Floors;
        Wall.materials = Contemp_Walls;
        Skirting.materials = Contemp_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Contemp_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Contemp_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Contemp_BathroomWindowFrames;
        }
    }



    //Wing_A_FlatNo_04_Type01

    public void Wing_A_FlatNo_04_Type01_Retro()
    {
        Props_Retro.SetActive(true);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(true);
        }


        Roof1.materials = Retro_Roof1;
        Roof2.materials = Retro_Roof2;
        Roof3.materials = Retro_Roof3;
        Roof4.materials = Retro_Roof4;
        Floor.materials = Retro_Floors;
        Wall.materials = Retro_Walls;
        Skirting.materials = Retro_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Retro_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Retro_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Retro_BathroomWindowFrames;
        }

    }
    public void Wing_A_FlatNo_04_Type01_Danish()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(true);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Danish_Roof1;
        Roof2.materials = Danish_Roof2;
        Roof3.materials = Danish_Roof3;
        Roof4.materials = Danish_Roof4;
        Floor.materials = Danish_Floors;
        Wall.materials = Danish_Walls;
        Skirting.materials = Danish_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Danish_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Danish_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Danish_BathroomWindowFrames;
        }
    }
    public void Wing_A_FlatNo_04_Type01_Contemp()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(true);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Contemp_Roof1;
        Roof2.materials = Contemp_Roof2;
        Roof3.materials = Contemp_Roof3;
        Roof4.materials = Contemp_Roof4;
        Floor.materials = Contemp_Floors;
        Wall.materials = Contemp_Walls;
        Skirting.materials = Contemp_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Contemp_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Contemp_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Contemp_BathroomWindowFrames;
        }
    }


    //Wing_A_FlatNo_04_Type02

    public void Wing_A_FlatNo_04_Type02_Retro()
    {
        Props_Retro.SetActive(true);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(true);
        }


        Roof1.materials = Retro_Roof1;
        Roof2.materials = Retro_Roof2;
        Roof3.materials = Retro_Roof3;
        Roof4.materials = Retro_Roof4;
        Floor.materials = Retro_Floors;
        Wall.materials = Retro_Walls;
        Skirting.materials = Retro_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Retro_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Retro_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Retro_BathroomWindowFrames;
        }

    }
    public void Wing_A_FlatNo_04_Type02_Danish()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(true);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Danish_Roof1;
        Roof2.materials = Danish_Roof2;
        Roof3.materials = Danish_Roof3;
        Roof4.materials = Danish_Roof4;
        Floor.materials = Danish_Floors;
        Wall.materials = Danish_Walls;
        Skirting.materials = Danish_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Danish_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Danish_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Danish_BathroomWindowFrames;
        }
    }
    public void Wing_A_FlatNo_04_Type02_Contemp()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(true);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Contemp_Roof1;
        Roof2.materials = Contemp_Roof2;
        Roof3.materials = Contemp_Roof3;
        Roof4.materials = Contemp_Roof4;
        Floor.materials = Contemp_Floors;
        Wall.materials = Contemp_Walls;
        Skirting.materials = Contemp_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Contemp_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Contemp_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Contemp_BathroomWindowFrames;
        }
    }



    //Wing_A_FlatNo_04_Type03

    public void Wing_A_FlatNo_04_Type03_Retro()
    {
        Props_Retro.SetActive(true);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(true);
        }


        Roof1.materials = Retro_Roof1;
        Roof2.materials = Retro_Roof2;
        Roof3.materials = Retro_Roof3;
        Roof4.materials = Retro_Roof4;
        Floor.materials = Retro_Floors;
        Wall.materials = Retro_Walls;
        Skirting.materials = Retro_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Retro_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Retro_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Retro_BathroomWindowFrames;
        }

    }
    public void Wing_A_FlatNo_04_Type03_Danish()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(true);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Danish_Roof1;
        Roof2.materials = Danish_Roof2;
        Roof3.materials = Danish_Roof3;
        Roof4.materials = Danish_Roof4;
        Floor.materials = Danish_Floors;
        Wall.materials = Danish_Walls;
        Skirting.materials = Danish_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Danish_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Danish_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Danish_BathroomWindowFrames;
        }
    }
    public void Wing_A_FlatNo_04_Type03_Contemp()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(true);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Contemp_Roof1;
        Roof2.materials = Contemp_Roof2;
        Roof3.materials = Contemp_Roof3;
        Roof4.materials = Contemp_Roof4;
        Floor.materials = Contemp_Floors;
        Wall.materials = Contemp_Walls;
        Skirting.materials = Contemp_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Contemp_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Contemp_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Contemp_BathroomWindowFrames;
        }
    }





    //*******************
    //***  WING B   *****
    //*******************

    //Wing_B_FlatNo_01_Type01

    public void Wing_B_FlatNo_01_Type01_Retro()
    {
        Props_Retro.SetActive(true);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(true);
        }


        Roof1.materials = Retro_Roof1;
        Roof2.materials = Retro_Roof2;
        Roof3.materials = Retro_Roof3;
        Roof4.materials = Retro_Roof4;
        Floor.materials = Retro_Floors;
        Wall.materials = Retro_Walls;
        Skirting.materials = Retro_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Retro_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Retro_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Retro_BathroomWindowFrames;
        }

    }
    public void Wing_B_FlatNo_01_Type01_Danish()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(true);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Danish_Roof1;
        Roof2.materials = Danish_Roof2;
        Roof3.materials = Danish_Roof3;
        Roof4.materials = Danish_Roof4;
        Floor.materials = Danish_Floors;
        Wall.materials = Danish_Walls;
        Skirting.materials = Danish_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Danish_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Danish_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Danish_BathroomWindowFrames;
        }
    }
    public void Wing_B_FlatNo_01_Type01_Contemp()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(true);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Contemp_Roof1;
        Roof2.materials = Contemp_Roof2;
        Roof3.materials = Contemp_Roof3;
        Roof4.materials = Contemp_Roof4;
        Floor.materials = Contemp_Floors;
        Wall.materials = Contemp_Walls;
        Skirting.materials = Contemp_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Contemp_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Contemp_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Contemp_BathroomWindowFrames;
        }
    }


    //Wing_B_FlatNo_01_Type02

    public void Wing_B_FlatNo_01_Type02_Retro()
    {
        Props_Retro.SetActive(true);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(true);
        }


        Roof1.materials = Retro_Roof1;
        Roof2.materials = Retro_Roof2;
        Roof3.materials = Retro_Roof3;
        Roof4.materials = Retro_Roof4;
        Floor.materials = Retro_Floors;
        Wall.materials = Retro_Walls;
        Skirting.materials = Retro_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Retro_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Retro_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Retro_BathroomWindowFrames;
        }

    }
    public void Wing_B_FlatNo_01_Type02_Danish()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(true);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Danish_Roof1;
        Roof2.materials = Danish_Roof2;
        Roof3.materials = Danish_Roof3;
        Roof4.materials = Danish_Roof4;
        Floor.materials = Danish_Floors;
        Wall.materials = Danish_Walls;
        Skirting.materials = Danish_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Danish_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Danish_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Danish_BathroomWindowFrames;
        }
    }
    public void Wing_B_FlatNo_01_Type02_Contemp()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(true);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Contemp_Roof1;
        Roof2.materials = Contemp_Roof2;
        Roof3.materials = Contemp_Roof3;
        Roof4.materials = Contemp_Roof4;
        Floor.materials = Contemp_Floors;
        Wall.materials = Contemp_Walls;
        Skirting.materials = Contemp_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Contemp_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Contemp_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Contemp_BathroomWindowFrames;
        }
    }


    //Wing_B_FlatNo_01_Type03

    public void Wing_B_FlatNo_01_Type03_Retro()
    {
        Props_Retro.SetActive(true);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(true);
        }


        Roof1.materials = Retro_Roof1;
        Roof2.materials = Retro_Roof2;
        Roof3.materials = Retro_Roof3;
        Roof4.materials = Retro_Roof4;
        Floor.materials = Retro_Floors;
        Wall.materials = Retro_Walls;
        Skirting.materials = Retro_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Retro_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Retro_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Retro_BathroomWindowFrames;
        }

    }
    public void Wing_B_FlatNo_01_Type03_Danish()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(true);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Danish_Roof1;
        Roof2.materials = Danish_Roof2;
        Roof3.materials = Danish_Roof3;
        Roof4.materials = Danish_Roof4;
        Floor.materials = Danish_Floors;
        Wall.materials = Danish_Walls;
        Skirting.materials = Danish_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Danish_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Danish_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Danish_BathroomWindowFrames;
        }
    }
    public void Wing_B_FlatNo_01_Type03_Contemp()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(true);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Contemp_Roof1;
        Roof2.materials = Contemp_Roof2;
        Roof3.materials = Contemp_Roof3;
        Roof4.materials = Contemp_Roof4;
        Floor.materials = Contemp_Floors;
        Wall.materials = Contemp_Walls;
        Skirting.materials = Contemp_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Contemp_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Contemp_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Contemp_BathroomWindowFrames;
        }
    }




    //Wing_B_FlatNo_02_Type01

    public void Wing_B_FlatNo_02_Type01_Retro()
    {
        Props_Retro.SetActive(true);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(true);
        }


        Roof1.materials = Retro_Roof1;
        Roof2.materials = Retro_Roof2;
        Roof3.materials = Retro_Roof3;
        //Roof4.materials = Retro_Roof4;
        Floor.materials = Retro_Floors;
        Wall.materials = Retro_Walls;
        Skirting.materials = Retro_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Retro_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Retro_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Retro_BathroomWindowFrames;
        }

    }
    public void Wing_B_FlatNo_02_Type01_Danish()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(true);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Danish_Roof1;
        Roof2.materials = Danish_Roof2;
        Roof3.materials = Danish_Roof3;
        //Roof4.materials = Danish_Roof4;
        Floor.materials = Danish_Floors;
        Wall.materials = Danish_Walls;
        Skirting.materials = Danish_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Danish_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Danish_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Danish_BathroomWindowFrames;
        }
    }
    public void Wing_B_FlatNo_02_Type01_Contemp()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(true);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Contemp_Roof1;
        Roof2.materials = Contemp_Roof2;
        Roof3.materials = Contemp_Roof3;
        //Roof4.materials = Contemp_Roof4;
        Floor.materials = Contemp_Floors;
        Wall.materials = Contemp_Walls;
        Skirting.materials = Contemp_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Contemp_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Contemp_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Contemp_BathroomWindowFrames;
        }
    }



    //Wing_B_FlatNo_02_Type02

    public void Wing_B_FlatNo_02_Type02_Retro()
    {
        Props_Retro.SetActive(true);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(true);
        }


        Roof1.materials = Retro_Roof1;
        Roof2.materials = Retro_Roof2;
        Roof3.materials = Retro_Roof3;
        //Roof4.materials = Retro_Roof4;
        Floor.materials = Retro_Floors;
        Wall.materials = Retro_Walls;
        Skirting.materials = Retro_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Retro_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Retro_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Retro_BathroomWindowFrames;
        }

    }
    public void Wing_B_FlatNo_02_Type02_Danish()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(true);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Danish_Roof1;
        Roof2.materials = Danish_Roof2;
        Roof3.materials = Danish_Roof3;
        //Roof4.materials = Danish_Roof4;
        Floor.materials = Danish_Floors;
        Wall.materials = Danish_Walls;
        Skirting.materials = Danish_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Danish_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Danish_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Danish_BathroomWindowFrames;
        }
    }
    public void Wing_B_FlatNo_02_Type02_Contemp()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(true);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Contemp_Roof1;
        Roof2.materials = Contemp_Roof2;
        Roof3.materials = Contemp_Roof3;
        //Roof4.materials = Contemp_Roof4;
        Floor.materials = Contemp_Floors;
        Wall.materials = Contemp_Walls;
        Skirting.materials = Contemp_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Contemp_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Contemp_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Contemp_BathroomWindowFrames;
        }
    }



    //Wing_B_FlatNo_03_Type01

    public void Wing_B_FlatNo_03_Type01_Retro()
    {
        Props_Retro.SetActive(true);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(true);
        }


        Roof1.materials = Retro_Roof1;
        Roof2.materials = Retro_Roof2;
        Roof3.materials = Retro_Roof3;
        Roof4.materials = Retro_Roof4;
        Floor.materials = Retro_Floors;
        Wall.materials = Retro_Walls;
        Skirting.materials = Retro_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Retro_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Retro_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Retro_BathroomWindowFrames;
        }

    }
    public void Wing_B_FlatNo_03_Type01_Danish()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(true);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Danish_Roof1;
        Roof2.materials = Danish_Roof2;
        Roof3.materials = Danish_Roof3;
        Roof4.materials = Danish_Roof4;
        Floor.materials = Danish_Floors;
        Wall.materials = Danish_Walls;
        Skirting.materials = Danish_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Danish_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Danish_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Danish_BathroomWindowFrames;
        }
    }
    public void Wing_B_FlatNo_03_Type01_Contemp()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(true);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Contemp_Roof1;
        Roof2.materials = Contemp_Roof2;
        Roof3.materials = Contemp_Roof3;
        Roof4.materials = Contemp_Roof4;
        Floor.materials = Contemp_Floors;
        Wall.materials = Contemp_Walls;
        Skirting.materials = Contemp_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Contemp_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Contemp_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Contemp_BathroomWindowFrames;
        }
    }



    //Wing_B_FlatNo_03_Type02

    public void Wing_B_FlatNo_03_Type02_Retro()
    {
        Props_Retro.SetActive(true);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(true);
        }


        Roof1.materials = Retro_Roof1;
        Roof2.materials = Retro_Roof2;
        Roof3.materials = Retro_Roof3;
        Roof4.materials = Retro_Roof4;
        Floor.materials = Retro_Floors;
        Wall.materials = Retro_Walls;
        Skirting.materials = Retro_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Retro_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Retro_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Retro_BathroomWindowFrames;
        }

    }
    public void Wing_B_FlatNo_03_Type02_Danish()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(true);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Danish_Roof1;
        Roof2.materials = Danish_Roof2;
        Roof3.materials = Danish_Roof3;
        Roof4.materials = Danish_Roof4;
        Floor.materials = Danish_Floors;
        Wall.materials = Danish_Walls;
        Skirting.materials = Danish_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Danish_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Danish_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Danish_BathroomWindowFrames;
        }
    }
    public void Wing_B_FlatNo_03_Type02_Contemp()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(true);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Contemp_Roof1;
        Roof2.materials = Contemp_Roof2;
        Roof3.materials = Contemp_Roof3;
        Roof4.materials = Contemp_Roof4;
        Floor.materials = Contemp_Floors;
        Wall.materials = Contemp_Walls;
        Skirting.materials = Contemp_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Contemp_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Contemp_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Contemp_BathroomWindowFrames;
        }
    }



    //Wing_B_FlatNo_03_Type03

    public void Wing_B_FlatNo_03_Type03_Retro()
    {
        Props_Retro.SetActive(true);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(true);
        }


        Roof1.materials = Retro_Roof1;
        Roof2.materials = Retro_Roof2;
        Roof3.materials = Retro_Roof3;
        Roof4.materials = Retro_Roof4;
        Floor.materials = Retro_Floors;
        Wall.materials = Retro_Walls;
        Skirting.materials = Retro_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Retro_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Retro_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Retro_BathroomWindowFrames;
        }

    }
    public void Wing_B_FlatNo_03_Type03_Danish()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(true);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Danish_Roof1;
        Roof2.materials = Danish_Roof2;
        Roof3.materials = Danish_Roof3;
        Roof4.materials = Danish_Roof4;
        Floor.materials = Danish_Floors;
        Wall.materials = Danish_Walls;
        Skirting.materials = Danish_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Danish_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Danish_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Danish_BathroomWindowFrames;
        }
    }
    public void Wing_B_FlatNo_03_Type03_Contemp()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(true);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Contemp_Roof1;
        Roof2.materials = Contemp_Roof2;
        Roof3.materials = Contemp_Roof3;
        Roof4.materials = Contemp_Roof4;
        Floor.materials = Contemp_Floors;
        Wall.materials = Contemp_Walls;
        Skirting.materials = Contemp_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Contemp_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Contemp_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Contemp_BathroomWindowFrames;
        }
    }



    //Wing_B_FlatNo_04_Type01

    public void Wing_B_FlatNo_04_Type01_Retro()
    {
        Props_Retro.SetActive(true);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(true);
        }


        Roof1.materials = Retro_Roof1;
        Roof2.materials = Retro_Roof2;
        Roof3.materials = Retro_Roof3;
        //Roof4.materials = Retro_Roof4;
        Floor.materials = Retro_Floors;
        Wall.materials = Retro_Walls;
        Skirting.materials = Retro_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Retro_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Retro_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Retro_BathroomWindowFrames;
        }

    }
    public void Wing_B_FlatNo_04_Type01_Danish()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(true);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Danish_Roof1;
        Roof2.materials = Danish_Roof2;
        Roof3.materials = Danish_Roof3;
       // Roof4.materials = Danish_Roof4;
        Floor.materials = Danish_Floors;
        Wall.materials = Danish_Walls;
        Skirting.materials = Danish_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Danish_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Danish_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Danish_BathroomWindowFrames;
        }
    }
    public void Wing_B_FlatNo_04_Type01_Contemp()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(true);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Contemp_Roof1;
        Roof2.materials = Contemp_Roof2;
        Roof3.materials = Contemp_Roof3;
       // Roof4.materials = Contemp_Roof4;
        Floor.materials = Contemp_Floors;
        Wall.materials = Contemp_Walls;
        Skirting.materials = Contemp_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Contemp_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Contemp_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Contemp_BathroomWindowFrames;
        }
    }


    //Wing_B_FlatNo_04_Type02

    public void Wing_B_FlatNo_04_Type02_Retro()
    {
        Props_Retro.SetActive(true);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(true);
        }


        Roof1.materials = Retro_Roof1;
        Roof2.materials = Retro_Roof2;
        Roof3.materials = Retro_Roof3;
        //Roof4.materials = Retro_Roof4;
        Floor.materials = Retro_Floors;
        Wall.materials = Retro_Walls;
        Skirting.materials = Retro_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Retro_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Retro_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Retro_BathroomWindowFrames;
        }

    }
    public void Wing_B_FlatNo_04_Type02_Danish()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(true);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Danish_Roof1;
        Roof2.materials = Danish_Roof2;
        Roof3.materials = Danish_Roof3;
        //Roof4.materials = Danish_Roof4;
        Floor.materials = Danish_Floors;
        Wall.materials = Danish_Walls;
        Skirting.materials = Danish_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Danish_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Danish_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Danish_BathroomWindowFrames;
        }
    }
    public void Wing_B_FlatNo_04_Type02_Contemp()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(true);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Contemp_Roof1;
        Roof2.materials = Contemp_Roof2;
        Roof3.materials = Contemp_Roof3;
       // Roof4.materials = Contemp_Roof4;
        Floor.materials = Contemp_Floors;
        Wall.materials = Contemp_Walls;
        Skirting.materials = Contemp_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Contemp_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Contemp_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Contemp_BathroomWindowFrames;
        }
    }



    //Wing_B_FlatNo_04_Type03

    public void Wing_B_FlatNo_04_Type03_Retro()
    {
        Props_Retro.SetActive(true);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(true);
        }


        Roof1.materials = Retro_Roof1;
        Roof2.materials = Retro_Roof2;
        Roof3.materials = Retro_Roof3;
       // Roof4.materials = Retro_Roof4;
        Floor.materials = Retro_Floors;
        Wall.materials = Retro_Walls;
        Skirting.materials = Retro_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Retro_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Retro_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Retro_BathroomWindowFrames;
        }

    }
    public void Wing_B_FlatNo_04_Type03_Danish()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(true);
        Props_Contemp.SetActive(false);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Danish_Roof1;
        Roof2.materials = Danish_Roof2;
        Roof3.materials = Danish_Roof3;
       // Roof4.materials = Danish_Roof4;
        Floor.materials = Danish_Floors;
        Wall.materials = Danish_Walls;
        Skirting.materials = Danish_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Danish_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Danish_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Danish_BathroomWindowFrames;
        }
    }
    public void Wing_B_FlatNo_04_Type03_Contemp()
    {
        Props_Retro.SetActive(false);
        Props_Danish.SetActive(false);
        Props_Contemp.SetActive(true);
        foreach (var item in Retro_False_Roof)
        {
            item.SetActive(false);
        }

        Roof1.materials = Contemp_Roof1;
        Roof2.materials = Contemp_Roof2;
        Roof3.materials = Contemp_Roof3;
        //Roof4.materials = Contemp_Roof4;
        Floor.materials = Contemp_Floors;
        Wall.materials = Contemp_Walls;
        Skirting.materials = Contemp_Skirting;

        foreach (var item in Door_Frames)
        {
            item.materials = Contemp_DoorFrames;
        }
        foreach (var item in Window_Frames)
        {
            item.materials = Contemp_WindowFrames;
        }
        foreach (var item in Bathroom_Window_Frames)
        {
            item.materials = Contemp_BathroomWindowFrames;
        }
    }




}