using UnityEngine;
using System.Collections;

public class TriggerEvents : MonoBehaviour 
{


	DoorScript _door;
	public bool outSide,forSetting;
	void Start()
	{
		_door = transform.GetComponentInParent<DoorScript> ();
	}
	void OnTriggerEnter()
	{
		if (forSetting)
			_door.inSide = outSide;
		else
			_door.DoorEnter (_door.inSide);
	}
	void OnTriggerExit()
	{
		if (forSetting)
			_door.inSide = outSide;
		else
			_door.DoorExit (_door.inSide);
	}

}
