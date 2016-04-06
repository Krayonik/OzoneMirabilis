using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RectUtil : MonoBehaviour
{

    public Camera MainCam;

    private Vector3 result;

    RectTransform CanvasRect;

    public RectTransform[] UIObjects;
    public GameObject[] Targets;

    public RectTransform[] UIObjects_2;
    public GameObject[] Targets_2;

    public RectTransform[] UIObjects_3;
    public GameObject[] Targets_3;

    public CameraDirector CD; 

    void Awake()
    {


        //for (int i = 0; i < Targets.Length; i++)
        //{
        //    ObjectList[i] = Targets[i].GetComponent<MeshRenderer>();
        //}

        //for (int i = 0; i < Targets.Length; i++)
        //{
        //   UIGameObjects[i] = UIObjects[i].gameObject;
        //}


    }

    void Start()
    {

        CanvasRect = this.GetComponent<RectTransform>();



    }


    private Vector2 WorldToCanvasPosition(RectTransform canvas, Camera camera, Vector3 position)
    {

        Vector2 temp = camera.WorldToViewportPoint(position);


        temp.x *= canvas.sizeDelta.x;
        temp.y *= canvas.sizeDelta.y;



        temp.x -= canvas.sizeDelta.x * canvas.pivot.x;
        temp.y -= canvas.sizeDelta.y * canvas.pivot.y;

        return temp;
    }





    void Update()
    {

        //RenderCheck();

        if (CD.CurrState == CameraDirector.MenuState.City)
        {
            for (int i = 0; i < Targets.Length; i++)
            {


                Vector2 ViewportPosition = MainCam.WorldToViewportPoint(Targets[i].transform.position);
                Vector2 WorldObject_ScreenPosition = new Vector2(
                ((ViewportPosition.x * CanvasRect.sizeDelta.x) - (CanvasRect.sizeDelta.x * 0.5f)),
                ((ViewportPosition.y * CanvasRect.sizeDelta.y) - (CanvasRect.sizeDelta.y * 0.5f)));


                UIObjects[i].anchoredPosition = WorldObject_ScreenPosition;




            }

        }
        if (CD.CurrState == CameraDirector.MenuState.Project)
        { 
            for (int i = 0; i < Targets_2.Length; i++)
            {


                Vector2 ViewportPosition = MainCam.WorldToViewportPoint(Targets_2[i].transform.position);
                Vector2 WorldObject_ScreenPosition = new Vector2(
                ((ViewportPosition.x * CanvasRect.sizeDelta.x) - (CanvasRect.sizeDelta.x * 0.5f)),
                ((ViewportPosition.y * CanvasRect.sizeDelta.y) - (CanvasRect.sizeDelta.y * 0.5f)));


                UIObjects_2[i].anchoredPosition = WorldObject_ScreenPosition;

            }

        }

        if (CD.CurrState == CameraDirector.MenuState.Apartment)
        {
            for (int i = 0; i < Targets_3.Length; i++)
            {


                Vector2 ViewportPosition = MainCam.WorldToViewportPoint(Targets_3[i].transform.position);
                Vector2 WorldObject_ScreenPosition = new Vector2(
                ((ViewportPosition.x * CanvasRect.sizeDelta.x) - (CanvasRect.sizeDelta.x * 0.5f)),
                ((ViewportPosition.y * CanvasRect.sizeDelta.y) - (CanvasRect.sizeDelta.y * 0.5f)));


                UIObjects_3[i].anchoredPosition = WorldObject_ScreenPosition;

            }

        }


    }
}