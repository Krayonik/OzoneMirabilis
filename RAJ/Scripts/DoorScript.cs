using UnityEngine;
using System.Collections;

public class DoorScript : MonoBehaviour 
{

	public Animator door;
	public bool inSide;
 	public void DoorEnter(bool fromOut)
	{
		door.SetBool ("FromOutSide", fromOut);
		door.SetTrigger ("Open");
	}
	public void DoorExit(bool fromOut)
	{
		door.SetBool ("FromOutSide", fromOut);
		door.SetTrigger ("Close");
	}
 	 

}
