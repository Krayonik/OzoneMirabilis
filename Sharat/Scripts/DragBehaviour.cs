using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class DragBehaviour : MonoBehaviour, IBeginDragHandler, IEndDragHandler
{


    public KGFOrbitCam Cam;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnBeginDrag()
    {

    }

    public void OnEndDrag()
    {

    }

    public void OnBeginDrag(PointerEventData eventData)
    {

        Cam.isMoveable = false;
    }

    public void OnEndDrag(PointerEventData eventData)
    {

        Cam.isMoveable = true;
    }
}
