using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UiCompass : MonoBehaviour {

    public GameObject Target;

    public RectTransform _Self;

    public float Smootness = 0.001f;

	// Use this for initialization
	void Start () {

        _Self = this.GetComponent<RectTransform>();

	}
	
	// Update is called once per frame
	void Update () {

        

        var v = Target.transform.forward;
        v.y = 0;
        v.Normalize();

        
        //_Self.rotation.SetEulerAngles(new Vector3(0, 0, Vector3.Angle(v, Vector3.forward)));

        //_Self.localRotation.SetEulerAngles(new Vector3(0, 0, Vector3.Angle(v, Vector3.forward)));

        //_Self.localEulerAngles.Set(0,0,Vector3.Angle(v, Vector3.forward));

        _Self.rotation = Quaternion.EulerAngles(0, 0, Vector3.Angle(v, Vector3.forward) * Smootness);
	}
}
